namespace png2jpg
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			this.SourceExtensionLabel = new System.Windows.Forms.Label();
			this.TargetExtensionLabel = new System.Windows.Forms.Label();
			this.SourceDirectoryTextBox = new System.Windows.Forms.TextBox();
			this.ProgressBar = new System.Windows.Forms.ProgressBar();
			this.ConfirmationButton = new System.Windows.Forms.Button();
			this.IncludeSubdirectoriesCheckbox = new System.Windows.Forms.CheckBox();
			this.SourceExtensionComboBox = new System.Windows.Forms.ComboBox();
			this.TargetExtensionComboBox = new System.Windows.Forms.ComboBox();
			this.RemoveOriginalFilesCheckBox = new System.Windows.Forms.CheckBox();
			this.FolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.SourceDirectoryButton = new System.Windows.Forms.Button();
			this.UseDifferentDirectoryCheckBox = new System.Windows.Forms.CheckBox();
			this.TargetDirectoryTextBox = new System.Windows.Forms.TextBox();
			this.TargetDirectoryButton = new System.Windows.Forms.Button();
			this.ExtensionsGroupBox = new System.Windows.Forms.GroupBox();
			this.SourceDirectoryGroupBox = new System.Windows.Forms.GroupBox();
			this.TargetDirectoryGroupBox = new System.Windows.Forms.GroupBox();
			this.ProcessManagementTimer = new System.Windows.Forms.Timer(this.components);
			this.InfoLabel = new System.Windows.Forms.Label();
			this.FolderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
			this.ExtensionsGroupBox.SuspendLayout();
			this.SourceDirectoryGroupBox.SuspendLayout();
			this.TargetDirectoryGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// SourceExtensionLabel
			// 
			this.SourceExtensionLabel.AutoSize = true;
			this.SourceExtensionLabel.Location = new System.Drawing.Point(6, 16);
			this.SourceExtensionLabel.Name = "SourceExtensionLabel";
			this.SourceExtensionLabel.Size = new System.Drawing.Size(89, 13);
			this.SourceExtensionLabel.TabIndex = 0;
			this.SourceExtensionLabel.Text = "Source extension";
			// 
			// TargetExtensionLabel
			// 
			this.TargetExtensionLabel.AutoSize = true;
			this.TargetExtensionLabel.Location = new System.Drawing.Point(6, 57);
			this.TargetExtensionLabel.Name = "TargetExtensionLabel";
			this.TargetExtensionLabel.Size = new System.Drawing.Size(86, 13);
			this.TargetExtensionLabel.TabIndex = 2;
			this.TargetExtensionLabel.Text = "Target extension";
			// 
			// SourceDirectoryTextBox
			// 
			this.SourceDirectoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SourceDirectoryTextBox.Location = new System.Drawing.Point(116, 22);
			this.SourceDirectoryTextBox.Name = "SourceDirectoryTextBox";
			this.SourceDirectoryTextBox.Size = new System.Drawing.Size(256, 20);
			this.SourceDirectoryTextBox.TabIndex = 5;
			this.SourceDirectoryTextBox.TextChanged += new System.EventHandler(this.SourceDirectoryTextBox_TextChanged);
			// 
			// ProgressBar
			// 
			this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ProgressBar.Location = new System.Drawing.Point(12, 329);
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.Size = new System.Drawing.Size(378, 23);
			this.ProgressBar.TabIndex = 6;
			// 
			// ConfirmationButton
			// 
			this.ConfirmationButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ConfirmationButton.Enabled = false;
			this.ConfirmationButton.Location = new System.Drawing.Point(12, 300);
			this.ConfirmationButton.Name = "ConfirmationButton";
			this.ConfirmationButton.Size = new System.Drawing.Size(378, 23);
			this.ConfirmationButton.TabIndex = 7;
			this.ConfirmationButton.Text = "Confirm conversion";
			this.ConfirmationButton.UseVisualStyleBackColor = true;
			this.ConfirmationButton.Click += new System.EventHandler(this.ConfirmationButton_Click);
			// 
			// IncludeSubdirectoriesCheckbox
			// 
			this.IncludeSubdirectoriesCheckbox.AutoSize = true;
			this.IncludeSubdirectoriesCheckbox.Location = new System.Drawing.Point(6, 48);
			this.IncludeSubdirectoriesCheckbox.Name = "IncludeSubdirectoriesCheckbox";
			this.IncludeSubdirectoriesCheckbox.Size = new System.Drawing.Size(132, 17);
			this.IncludeSubdirectoriesCheckbox.TabIndex = 8;
			this.IncludeSubdirectoriesCheckbox.Text = " Include subdirectories";
			this.IncludeSubdirectoriesCheckbox.UseVisualStyleBackColor = true;
			this.IncludeSubdirectoriesCheckbox.CheckedChanged += new System.EventHandler(this.IncludeSubdirectories_CheckedChanged);
			// 
			// SourceExtensionComboBox
			// 
			this.SourceExtensionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SourceExtensionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SourceExtensionComboBox.FormattingEnabled = true;
			this.SourceExtensionComboBox.Items.AddRange(new object[] {
            ".jpg .jpeg",
            ".png",
            ".bmp",
            ".gif",
            ".webp",
            ".tiff"});
			this.SourceExtensionComboBox.Location = new System.Drawing.Point(6, 32);
			this.SourceExtensionComboBox.Name = "SourceExtensionComboBox";
			this.SourceExtensionComboBox.Size = new System.Drawing.Size(366, 21);
			this.SourceExtensionComboBox.TabIndex = 9;
			this.SourceExtensionComboBox.SelectedIndexChanged += new System.EventHandler(this.SourceExtensionComboBox_SelectedIndexChanged);
			// 
			// TargetExtensionComboBox
			// 
			this.TargetExtensionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TargetExtensionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TargetExtensionComboBox.FormattingEnabled = true;
			this.TargetExtensionComboBox.Items.AddRange(new object[] {
            ".jpg .jpeg",
            ".png",
            ".bmp",
            ".gif",
            ".webp",
            ".tiff"});
			this.TargetExtensionComboBox.Location = new System.Drawing.Point(6, 73);
			this.TargetExtensionComboBox.Name = "TargetExtensionComboBox";
			this.TargetExtensionComboBox.Size = new System.Drawing.Size(366, 21);
			this.TargetExtensionComboBox.TabIndex = 10;
			this.TargetExtensionComboBox.SelectedIndexChanged += new System.EventHandler(this.TargetExtensionComboBox_SelectedIndexChanged);
			// 
			// RemoveOriginalFilesCheckBox
			// 
			this.RemoveOriginalFilesCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RemoveOriginalFilesCheckBox.AutoSize = true;
			this.RemoveOriginalFilesCheckBox.Location = new System.Drawing.Point(6, 71);
			this.RemoveOriginalFilesCheckBox.Name = "RemoveOriginalFilesCheckBox";
			this.RemoveOriginalFilesCheckBox.Size = new System.Drawing.Size(202, 17);
			this.RemoveOriginalFilesCheckBox.TabIndex = 11;
			this.RemoveOriginalFilesCheckBox.Text = "Remove original files after conversion";
			this.RemoveOriginalFilesCheckBox.UseVisualStyleBackColor = true;
			this.RemoveOriginalFilesCheckBox.CheckedChanged += new System.EventHandler(this.RemoveOriginalFilesCheckBox_CheckedChanged);
			// 
			// SourceDirectoryButton
			// 
			this.SourceDirectoryButton.Location = new System.Drawing.Point(6, 19);
			this.SourceDirectoryButton.Name = "SourceDirectoryButton";
			this.SourceDirectoryButton.Size = new System.Drawing.Size(104, 23);
			this.SourceDirectoryButton.TabIndex = 12;
			this.SourceDirectoryButton.Text = "Choose directory";
			this.SourceDirectoryButton.UseVisualStyleBackColor = true;
			this.SourceDirectoryButton.Click += new System.EventHandler(this.SourceDirectoryButton_Click);
			// 
			// UseDifferentDirectoryCheckBox
			// 
			this.UseDifferentDirectoryCheckBox.AutoSize = true;
			this.UseDifferentDirectoryCheckBox.Location = new System.Drawing.Point(6, 19);
			this.UseDifferentDirectoryCheckBox.Name = "UseDifferentDirectoryCheckBox";
			this.UseDifferentDirectoryCheckBox.Size = new System.Drawing.Size(224, 17);
			this.UseDifferentDirectoryCheckBox.TabIndex = 13;
			this.UseDifferentDirectoryCheckBox.Text = "(Optional) Copy files to a different directory";
			this.UseDifferentDirectoryCheckBox.UseVisualStyleBackColor = true;
			this.UseDifferentDirectoryCheckBox.CheckedChanged += new System.EventHandler(this.UseDifferentDirectoryCheckBox_CheckedChanged);
			// 
			// TargetDirectoryTextBox
			// 
			this.TargetDirectoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TargetDirectoryTextBox.Location = new System.Drawing.Point(116, 45);
			this.TargetDirectoryTextBox.Name = "TargetDirectoryTextBox";
			this.TargetDirectoryTextBox.Size = new System.Drawing.Size(256, 20);
			this.TargetDirectoryTextBox.TabIndex = 14;
			this.TargetDirectoryTextBox.TextChanged += new System.EventHandler(this.TargetDirectoryTextBox_TextChanged);
			// 
			// TargetDirectoryButton
			// 
			this.TargetDirectoryButton.Location = new System.Drawing.Point(6, 42);
			this.TargetDirectoryButton.Name = "TargetDirectoryButton";
			this.TargetDirectoryButton.Size = new System.Drawing.Size(104, 23);
			this.TargetDirectoryButton.TabIndex = 15;
			this.TargetDirectoryButton.Text = "Choose directory";
			this.TargetDirectoryButton.UseVisualStyleBackColor = true;
			this.TargetDirectoryButton.Click += new System.EventHandler(this.TargetDirectoryButton_Click);
			// 
			// ExtensionsGroupBox
			// 
			this.ExtensionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ExtensionsGroupBox.Controls.Add(this.SourceExtensionLabel);
			this.ExtensionsGroupBox.Controls.Add(this.SourceExtensionComboBox);
			this.ExtensionsGroupBox.Controls.Add(this.TargetExtensionLabel);
			this.ExtensionsGroupBox.Controls.Add(this.TargetExtensionComboBox);
			this.ExtensionsGroupBox.Location = new System.Drawing.Point(12, 12);
			this.ExtensionsGroupBox.Name = "ExtensionsGroupBox";
			this.ExtensionsGroupBox.Size = new System.Drawing.Size(378, 103);
			this.ExtensionsGroupBox.TabIndex = 16;
			this.ExtensionsGroupBox.TabStop = false;
			this.ExtensionsGroupBox.Text = "File extensions";
			// 
			// SourceDirectoryGroupBox
			// 
			this.SourceDirectoryGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SourceDirectoryGroupBox.Controls.Add(this.SourceDirectoryButton);
			this.SourceDirectoryGroupBox.Controls.Add(this.SourceDirectoryTextBox);
			this.SourceDirectoryGroupBox.Controls.Add(this.IncludeSubdirectoriesCheckbox);
			this.SourceDirectoryGroupBox.Controls.Add(this.RemoveOriginalFilesCheckBox);
			this.SourceDirectoryGroupBox.Location = new System.Drawing.Point(12, 121);
			this.SourceDirectoryGroupBox.Name = "SourceDirectoryGroupBox";
			this.SourceDirectoryGroupBox.Size = new System.Drawing.Size(378, 95);
			this.SourceDirectoryGroupBox.TabIndex = 17;
			this.SourceDirectoryGroupBox.TabStop = false;
			this.SourceDirectoryGroupBox.Text = "Source directory";
			// 
			// TargetDirectoryGroupBox
			// 
			this.TargetDirectoryGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TargetDirectoryGroupBox.Controls.Add(this.UseDifferentDirectoryCheckBox);
			this.TargetDirectoryGroupBox.Controls.Add(this.TargetDirectoryButton);
			this.TargetDirectoryGroupBox.Controls.Add(this.TargetDirectoryTextBox);
			this.TargetDirectoryGroupBox.Location = new System.Drawing.Point(12, 222);
			this.TargetDirectoryGroupBox.Name = "TargetDirectoryGroupBox";
			this.TargetDirectoryGroupBox.Size = new System.Drawing.Size(378, 72);
			this.TargetDirectoryGroupBox.TabIndex = 18;
			this.TargetDirectoryGroupBox.TabStop = false;
			this.TargetDirectoryGroupBox.Text = "Target directory";
			// 
			// ProcessManagementTimer
			// 
			this.ProcessManagementTimer.Enabled = true;
			this.ProcessManagementTimer.Interval = 250;
			this.ProcessManagementTimer.Tick += new System.EventHandler(this.ProcessManagementTimer_Tick);
			// 
			// InfoLabel
			// 
			this.InfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.InfoLabel.AutoSize = true;
			this.InfoLabel.Location = new System.Drawing.Point(9, 355);
			this.InfoLabel.Name = "InfoLabel";
			this.InfoLabel.Size = new System.Drawing.Size(0, 13);
			this.InfoLabel.TabIndex = 19;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(402, 377);
			this.Controls.Add(this.InfoLabel);
			this.Controls.Add(this.TargetDirectoryGroupBox);
			this.Controls.Add(this.SourceDirectoryGroupBox);
			this.Controls.Add(this.ExtensionsGroupBox);
			this.Controls.Add(this.ConfirmationButton);
			this.Controls.Add(this.ProgressBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "MainForm";
			this.Text = "png2jpg";
			this.ExtensionsGroupBox.ResumeLayout(false);
			this.ExtensionsGroupBox.PerformLayout();
			this.SourceDirectoryGroupBox.ResumeLayout(false);
			this.SourceDirectoryGroupBox.PerformLayout();
			this.TargetDirectoryGroupBox.ResumeLayout(false);
			this.TargetDirectoryGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label SourceExtensionLabel;
		private System.Windows.Forms.Label TargetExtensionLabel;
		private System.Windows.Forms.TextBox SourceDirectoryTextBox;
		private System.Windows.Forms.ProgressBar ProgressBar;
		private System.Windows.Forms.Button ConfirmationButton;
		private System.Windows.Forms.CheckBox IncludeSubdirectoriesCheckbox;
		private System.Windows.Forms.ComboBox SourceExtensionComboBox;
		private System.Windows.Forms.ComboBox TargetExtensionComboBox;
		private System.Windows.Forms.CheckBox RemoveOriginalFilesCheckBox;
		private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog1;
		private System.Windows.Forms.Button SourceDirectoryButton;
		private System.Windows.Forms.CheckBox UseDifferentDirectoryCheckBox;
		private System.Windows.Forms.TextBox TargetDirectoryTextBox;
		private System.Windows.Forms.Button TargetDirectoryButton;
		private System.Windows.Forms.GroupBox ExtensionsGroupBox;
		private System.Windows.Forms.GroupBox SourceDirectoryGroupBox;
		private System.Windows.Forms.GroupBox TargetDirectoryGroupBox;
		private System.Windows.Forms.Timer ProcessManagementTimer;
		private System.Windows.Forms.Label InfoLabel;
		private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog2;
	}
}

