using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32.TaskScheduler;

namespace Temped
{
    public partial class Temped : Form
    {
        static readonly String TASK_NAME = "Temp folder (DO NOT CHANGE TASK'S NAME)";
        static readonly String TASK_DESCRIPTION = "Created by Temped (https://github.com/Piarre/Temped)";
        static readonly String FOLDER_PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\Temp\\*");


        public Temped()
        {
            InitializeComponent();
        }
        private void Temped_Load(object sender, EventArgs e)
        {
            
        }

        private void enableTempFolder_Click(object sender, EventArgs e)
        {
            if (!CreateTempFolder()) return;
            CreateAndScheduleTask();
        }

        private Boolean CreateTempFolder()
        {

            if (!Directory.Exists(FOLDER_PATH))
            {
                try
                {
                    Directory.CreateDirectory(FOLDER_PATH);
                    Console.WriteLine("Folder created");
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while created the temp folder : {ex.Message}");
                    return false;
                }
            }
            else
            {
                var boxResult = MessageBox.Show("A folder with this name already exists, overwrite it ?", "Temped", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (boxResult == DialogResult.OK)
                {
                    Directory.Delete(FOLDER_PATH, true);
                    Directory.CreateDirectory(FOLDER_PATH);

                    return true;
                } else if (boxResult == DialogResult.Cancel)
                {
                    return false;
                }
               
                return false;
            }
        }

        private void CreateAndScheduleTask()
        {

            if (TaskExists(TASK_NAME))
            {
                var boxResult = MessageBox.Show("The task is already exists, overwrite it ?", "Temped", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (boxResult == DialogResult.Cancel) return;
            }

            using (TaskService ts = new TaskService())
            {
                TaskDefinition td = ts.NewTask();
                td.Actions.Add(new ExecAction("powershell.exe", $"-NoProfile -ExecutionPolicy Bypass -File Remove-Item -Path \"{FOLDER_PATH}\" -Recurse", null));

                td.RegistrationInfo.Author = "Piarre";
                td.RegistrationInfo.Date = DateTime.Parse("02/09/2023");
                td.RegistrationInfo.Description = TASK_DESCRIPTION;
                td.Settings.Hidden = false;
                td.Settings.AllowDemandStart = false;

                td.Triggers.Add(new LogonTrigger());

                ts.RootFolder.RegisterTaskDefinition(TASK_NAME, td);

                MessageBox.Show("Task created !", "Temped", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkTask_Click(object sender, EventArgs e)
        {
            if (TaskExists(TASK_NAME))
            {
                MessageBox.Show("The task already exists", "Temped", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The task do not exists", "Temped", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool TaskExists(string taskName)
        {
            using (TaskService ts = new TaskService())
            {
                Task task = ts.GetTask(taskName);
                return task != null;
            }
        }

        private void githubProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Piarre/Temped");
        }
    }
}
