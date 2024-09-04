﻿// COPYRIGHT 2009, 2010, 2011, 2012, 2013, 2014, 2015 by the Open Rails project.
// 
// This file is part of Open Rails.
// 
// Open Rails is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// Open Rails is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with Open Rails.  If not, see <http://www.gnu.org/licenses/>.

using System.Windows.Forms;

namespace ORTS
{
    partial class DownloadContentForm : Form
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
            this.dataGridViewDownloadContent = new System.Windows.Forms.DataGridView();
            this.Route = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Installed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstallPathLabel = new System.Windows.Forms.Label();
            this.InstallPathTextBox = new System.Windows.Forms.TextBox();
            this.InstallPathBrowseButton = new System.Windows.Forms.Button();
            this.InstallPathDirectoryEntry = new System.DirectoryServices.DirectoryEntry();
            this.buttonInstall = new System.Windows.Forms.Button();
            this.pictureBoxRoute = new System.Windows.Forms.PictureBox();
            this.textBoxRoute = new System.Windows.Forms.RichTextBox();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.tabContent = new System.Windows.Forms.TabControl();
            this.tabPageAutoInstalled = new System.Windows.Forms.TabPage();
            this.tabPageManuallyInstalled = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDownloadContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoute)).BeginInit();
            this.tabContent.SuspendLayout();
            this.tabPageAutoInstalled.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDownloadContent
            // 
            this.dataGridViewDownloadContent.AllowUserToAddRows = false;
            this.dataGridViewDownloadContent.AllowUserToDeleteRows = false;
            this.dataGridViewDownloadContent.AllowUserToResizeColumns = false;
            this.dataGridViewDownloadContent.AllowUserToResizeRows = false;
            this.dataGridViewDownloadContent.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewDownloadContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDownloadContent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Route,
            this.Installed,
            this.Url});
            this.dataGridViewDownloadContent.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewDownloadContent.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewDownloadContent.MultiSelect = false;
            this.dataGridViewDownloadContent.Name = "dataGridViewDownloadContent";
            this.dataGridViewDownloadContent.ReadOnly = true;
            this.dataGridViewDownloadContent.RowHeadersVisible = false;
            this.dataGridViewDownloadContent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewDownloadContent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDownloadContent.Size = new System.Drawing.Size(588, 222);
            this.dataGridViewDownloadContent.TabIndex = 0;
            this.dataGridViewDownloadContent.SelectionChanged += new System.EventHandler(this.dataGridViewDownloadContent_SelectionChanged);
            // 
            // Route
            // 
            this.Route.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Route.HeaderText = "Route";
            this.Route.Name = "Route";
            this.Route.ReadOnly = true;
            this.Route.Width = 61;
            // 
            // Installed
            // 
            this.Installed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Installed.HeaderText = "Installed";
            this.Installed.Name = "Installed";
            this.Installed.ReadOnly = true;
            this.Installed.Width = 71;
            // 
            // Url
            // 
            this.Url.HeaderText = "Url";
            this.Url.Name = "Url";
            this.Url.ReadOnly = true;
            this.Url.Width = 999;
            // 
            // InstallPathLabel
            // 
            this.InstallPathLabel.AutoSize = true;
            this.InstallPathLabel.Location = new System.Drawing.Point(6, 345);
            this.InstallPathLabel.Name = "InstallPathLabel";
            this.InstallPathLabel.Size = new System.Drawing.Size(62, 13);
            this.InstallPathLabel.TabIndex = 1;
            this.InstallPathLabel.Text = "Install Path:";
            // 
            // InstallPathTextBox
            // 
            this.InstallPathTextBox.Location = new System.Drawing.Point(74, 342);
            this.InstallPathTextBox.Name = "InstallPathTextBox";
            this.InstallPathTextBox.Size = new System.Drawing.Size(445, 20);
            this.InstallPathTextBox.TabIndex = 2;
            this.InstallPathTextBox.TextChanged += new System.EventHandler(this.InstallPathTextBox_TextChanged);
            // 
            // InstallPathBrowseButton
            // 
            this.InstallPathBrowseButton.Location = new System.Drawing.Point(521, 340);
            this.InstallPathBrowseButton.Name = "InstallPathBrowseButton";
            this.InstallPathBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.InstallPathBrowseButton.TabIndex = 3;
            this.InstallPathBrowseButton.Text = "Browse...";
            this.InstallPathBrowseButton.UseVisualStyleBackColor = true;
            this.InstallPathBrowseButton.Click += new System.EventHandler(this.InstallPathBrowseButton_Click);
            // 
            // buttonInstall
            // 
            this.buttonInstall.Enabled = false;
            this.buttonInstall.Location = new System.Drawing.Point(89, 371);
            this.buttonInstall.Name = "buttonInstall";
            this.buttonInstall.Size = new System.Drawing.Size(75, 23);
            this.buttonInstall.TabIndex = 5;
            this.buttonInstall.Text = "Install";
            this.buttonInstall.UseVisualStyleBackColor = true;
            this.buttonInstall.Click += new System.EventHandler(this.DownloadContentButton_Click);
            // 
            // pictureBoxRoute
            // 
            this.pictureBoxRoute.Location = new System.Drawing.Point(492, 234);
            this.pictureBoxRoute.Name = "pictureBoxRoute";
            this.pictureBoxRoute.Size = new System.Drawing.Size(102, 98);
            this.pictureBoxRoute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRoute.TabIndex = 5;
            this.pictureBoxRoute.TabStop = false;
            // 
            // textBoxRoute
            // 
            this.textBoxRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoute.Location = new System.Drawing.Point(6, 234);
            this.textBoxRoute.Name = "textBoxRoute";
            this.textBoxRoute.ReadOnly = true;
            this.textBoxRoute.Size = new System.Drawing.Size(480, 98);
            this.textBoxRoute.TabIndex = 9;
            this.textBoxRoute.Text = "";
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(8, 371);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonInfo.TabIndex = 4;
            this.buttonInfo.Text = "Info";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(251, 371);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(170, 371);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(544, 442);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.okButton_Click);
            // 
            // tabContent
            // 
            this.tabContent.Controls.Add(this.tabPageAutoInstalled);
            this.tabContent.Controls.Add(this.tabPageManuallyInstalled);
            this.tabContent.Location = new System.Drawing.Point(13, 12);
            this.tabContent.Name = "tabContent";
            this.tabContent.SelectedIndex = 0;
            this.tabContent.Size = new System.Drawing.Size(610, 428);
            this.tabContent.TabIndex = 10;
            // 
            // tabPageAutoInstalled
            // 
            this.tabPageAutoInstalled.Controls.Add(this.buttonInfo);
            this.tabPageAutoInstalled.Controls.Add(this.buttonInstall);
            this.tabPageAutoInstalled.Controls.Add(this.InstallPathBrowseButton);
            this.tabPageAutoInstalled.Controls.Add(this.pictureBoxRoute);
            this.tabPageAutoInstalled.Controls.Add(this.textBoxRoute);
            this.tabPageAutoInstalled.Controls.Add(this.buttonDelete);
            this.tabPageAutoInstalled.Controls.Add(this.InstallPathTextBox);
            this.tabPageAutoInstalled.Controls.Add(this.buttonUpdate);
            this.tabPageAutoInstalled.Controls.Add(this.InstallPathLabel);
            this.tabPageAutoInstalled.Controls.Add(this.dataGridViewDownloadContent);
            this.tabPageAutoInstalled.Location = new System.Drawing.Point(4, 22);
            this.tabPageAutoInstalled.Name = "tabPageAutoInstalled";
            this.tabPageAutoInstalled.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAutoInstalled.Size = new System.Drawing.Size(602, 402);
            this.tabPageAutoInstalled.TabIndex = 0;
            this.tabPageAutoInstalled.Text = "Auto Installed";
            this.tabPageAutoInstalled.UseVisualStyleBackColor = true;
            // 
            // tabPageManuallyInstalled
            // 
            this.tabPageManuallyInstalled.Location = new System.Drawing.Point(4, 22);
            this.tabPageManuallyInstalled.Name = "tabPageManuallyInstalled";
            this.tabPageManuallyInstalled.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManuallyInstalled.Size = new System.Drawing.Size(602, 402);
            this.tabPageManuallyInstalled.TabIndex = 1;
            this.tabPageManuallyInstalled.Text = "Manually Installed";
            this.tabPageManuallyInstalled.UseVisualStyleBackColor = true;
            // 
            // DownloadContentForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 481);
            this.Controls.Add(this.tabContent);
            this.Controls.Add(this.buttonOK);
            this.Location = new System.Drawing.Point(13, 12);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DownloadContentForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Download Content";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DownloadContentForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDownloadContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoute)).EndInit();
            this.tabContent.ResumeLayout(false);
            this.tabPageAutoInstalled.ResumeLayout(false);
            this.tabPageAutoInstalled.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewDownloadContent;
        private Label InstallPathLabel;
        private TextBox InstallPathTextBox;
        private Button InstallPathBrowseButton;
        private System.DirectoryServices.DirectoryEntry InstallPathDirectoryEntry;
        private Button buttonInstall;
        private DataGridViewTextBoxColumn Route;
        private DataGridViewTextBoxColumn Installed;
        private DataGridViewTextBoxColumn Url;
        private PictureBox pictureBoxRoute;
        private RichTextBox textBoxRoute;
        private Button buttonInfo;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonOK;
        private TabControl tabContent;
        private TabPage tabPageAutoInstalled;
        private TabPage tabPageManuallyInstalled;
    }
}
