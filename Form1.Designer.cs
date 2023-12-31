﻿namespace Temped
{
    partial class Temped
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enableTempFolder = new System.Windows.Forms.Button();
            this.githubProject = new System.Windows.Forms.LinkLabel();
            this.checkTask = new System.Windows.Forms.Button();
            this.forSpecificUser = new System.Windows.Forms.CheckBox();
            this.usersList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // enableTempFolder
            // 
            this.enableTempFolder.Location = new System.Drawing.Point(149, 106);
            this.enableTempFolder.Name = "enableTempFolder";
            this.enableTempFolder.Size = new System.Drawing.Size(117, 38);
            this.enableTempFolder.TabIndex = 0;
            this.enableTempFolder.Text = "Create task";
            this.enableTempFolder.UseVisualStyleBackColor = true;
            this.enableTempFolder.Click += new System.EventHandler(this.enableTempFolder_Click);
            // 
            // githubProject
            // 
            this.githubProject.AutoSize = true;
            this.githubProject.Location = new System.Drawing.Point(12, 170);
            this.githubProject.Name = "githubProject";
            this.githubProject.Size = new System.Drawing.Size(73, 13);
            this.githubProject.TabIndex = 3;
            this.githubProject.TabStop = true;
            this.githubProject.Text = "Github project";
            this.githubProject.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubProject_LinkClicked);
            // 
            // checkTask
            // 
            this.checkTask.Location = new System.Drawing.Point(17, 106);
            this.checkTask.Name = "checkTask";
            this.checkTask.Size = new System.Drawing.Size(117, 38);
            this.checkTask.TabIndex = 4;
            this.checkTask.Text = "Check for task";
            this.checkTask.UseVisualStyleBackColor = true;
            this.checkTask.Click += new System.EventHandler(this.checkTask_Click);
            // 
            // forSpecificUser
            // 
            this.forSpecificUser.AutoSize = true;
            this.forSpecificUser.Location = new System.Drawing.Point(12, 12);
            this.forSpecificUser.Name = "forSpecificUser";
            this.forSpecificUser.Size = new System.Drawing.Size(132, 17);
            this.forSpecificUser.TabIndex = 6;
            this.forSpecificUser.Text = "Run for a specific user";
            this.forSpecificUser.UseVisualStyleBackColor = true;
            this.forSpecificUser.CheckedChanged += new System.EventHandler(this.forSpecificUser_CheckedChanged);
            // 
            // usersList
            // 
            this.usersList.FormattingEnabled = true;
            this.usersList.Location = new System.Drawing.Point(150, 10);
            this.usersList.Name = "usersList";
            this.usersList.Size = new System.Drawing.Size(116, 21);
            this.usersList.TabIndex = 7;
            // 
            // Temped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 192);
            this.Controls.Add(this.usersList);
            this.Controls.Add(this.forSpecificUser);
            this.Controls.Add(this.checkTask);
            this.Controls.Add(this.githubProject);
            this.Controls.Add(this.enableTempFolder);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Temped";
            this.Text = "Temped";
            this.Load += new System.EventHandler(this.Temped_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enableTempFolder;
        private System.Windows.Forms.LinkLabel githubProject;
        private System.Windows.Forms.Button checkTask;
        private System.Windows.Forms.CheckBox forSpecificUser;
        private System.Windows.Forms.ComboBox usersList;
    }
}

