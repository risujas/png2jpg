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
			this.RootDirectoryTextBox = new System.Windows.Forms.TextBox();
			this.ProgressBar = new System.Windows.Forms.ProgressBar();
			this.ConfirmConversionButton = new System.Windows.Forms.Button();
			this.SubdirectoriesCheckbox = new System.Windows.Forms.CheckBox();
			this.SourceExtensionComboBox = new System.Windows.Forms.ComboBox();
			this.TargetExtensionComboBox = new System.Windows.Forms.ComboBox();
			this.RemoveOriginalFilesCheckBox = new System.Windows.Forms.CheckBox();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.SourceDirectoryButton = new System.Windows.Forms.Button();
			this.CopyFilesCheckBox = new System.Windows.Forms.CheckBox();
			this.TargetDirectoryTextBox = new System.Windows.Forms.TextBox();
			this.TargetDirectoryButton = new System.Windows.Forms.Button();
			this.ExtensionsGroupBox = new System.Windows.Forms.GroupBox();
			this.SourceDirectoryGroupBox = new System.Windows.Forms.GroupBox();
			this.TargetDirectoryGroupBox = new System.Windows.Forms.GroupBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
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
			// RootDirectoryTextBox
			// 
			this.RootDirectoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RootDirectoryTextBox.Location = new System.Drawing.Point(116, 22);
			this.RootDirectoryTextBox.Name = "RootDirectoryTextBox";
			this.RootDirectoryTextBox.Size = new System.Drawing.Size(256, 20);
			this.RootDirectoryTextBox.TabIndex = 5;
			this.RootDirectoryTextBox.TextChanged += new System.EventHandler(this.RootDirectoryTextBox_TextChanged);
			// 
			// ProgressBar
			// 
			this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ProgressBar.Location = new System.Drawing.Point(12, 335);
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.Size = new System.Drawing.Size(378, 23);
			this.ProgressBar.TabIndex = 6;
			// 
			// ConfirmConversionButton
			// 
			this.ConfirmConversionButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ConfirmConversionButton.Enabled = false;
			this.ConfirmConversionButton.Location = new System.Drawing.Point(12, 306);
			this.ConfirmConversionButton.Name = "ConfirmConversionButton";
			this.ConfirmConversionButton.Size = new System.Drawing.Size(378, 23);
			this.ConfirmConversionButton.TabIndex = 7;
			this.ConfirmConversionButton.Text = "Confirm conversion";
			this.ConfirmConversionButton.UseVisualStyleBackColor = true;
			this.ConfirmConversionButton.Click += new System.EventHandler(this.StartConversionButton_Click);
			// 
			// SubdirectoriesCheckbox
			// 
			this.SubdirectoriesCheckbox.AutoSize = true;
			this.SubdirectoriesCheckbox.Location = new System.Drawing.Point(6, 48);
			this.SubdirectoriesCheckbox.Name = "SubdirectoriesCheckbox";
			this.SubdirectoriesCheckbox.Size = new System.Drawing.Size(132, 17);
			this.SubdirectoriesCheckbox.TabIndex = 8;
			this.SubdirectoriesCheckbox.Text = " Include subdirectories";
			this.SubdirectoriesCheckbox.UseVisualStyleBackColor = true;
			this.SubdirectoriesCheckbox.CheckedChanged += new System.EventHandler(this.SubdirectoriesCheckbox_CheckedChanged);
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
            ".bmp"});
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
            ".bmp"});
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
			// CopyFilesCheckBox
			// 
			this.CopyFilesCheckBox.AutoSize = true;
			this.CopyFilesCheckBox.Location = new System.Drawing.Point(6, 19);
			this.CopyFilesCheckBox.Name = "CopyFilesCheckBox";
			this.CopyFilesCheckBox.Size = new System.Drawing.Size(224, 17);
			this.CopyFilesCheckBox.TabIndex = 13;
			this.CopyFilesCheckBox.Text = "(Optional) Copy files to a different directory";
			this.CopyFilesCheckBox.UseVisualStyleBackColor = true;
			this.CopyFilesCheckBox.CheckedChanged += new System.EventHandler(this.CopyFilesCheckBox_CheckedChanged);
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
			this.SourceDirectoryGroupBox.Controls.Add(this.RootDirectoryTextBox);
			this.SourceDirectoryGroupBox.Controls.Add(this.SubdirectoriesCheckbox);
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
			this.TargetDirectoryGroupBox.Controls.Add(this.CopyFilesCheckBox);
			this.TargetDirectoryGroupBox.Controls.Add(this.TargetDirectoryButton);
			this.TargetDirectoryGroupBox.Controls.Add(this.TargetDirectoryTextBox);
			this.TargetDirectoryGroupBox.Location = new System.Drawing.Point(12, 222);
			this.TargetDirectoryGroupBox.Name = "TargetDirectoryGroupBox";
			this.TargetDirectoryGroupBox.Size = new System.Drawing.Size(378, 72);
			this.TargetDirectoryGroupBox.TabIndex = 18;
			this.TargetDirectoryGroupBox.TabStop = false;
			this.TargetDirectoryGroupBox.Text = "Target directory";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(402, 370);
			this.Controls.Add(this.TargetDirectoryGroupBox);
			this.Controls.Add(this.SourceDirectoryGroupBox);
			this.Controls.Add(this.ExtensionsGroupBox);
			this.Controls.Add(this.ConfirmConversionButton);
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

		}

		#endregion

		private System.Windows.Forms.Label SourceExtensionLabel;
		private System.Windows.Forms.Label TargetExtensionLabel;
		private System.Windows.Forms.TextBox RootDirectoryTextBox;
		private System.Windows.Forms.ProgressBar ProgressBar;
		private System.Windows.Forms.Button ConfirmConversionButton;
		private System.Windows.Forms.CheckBox SubdirectoriesCheckbox;
		private System.Windows.Forms.ComboBox SourceExtensionComboBox;
		private System.Windows.Forms.ComboBox TargetExtensionComboBox;
		private System.Windows.Forms.CheckBox RemoveOriginalFilesCheckBox;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Button SourceDirectoryButton;
		private System.Windows.Forms.CheckBox CopyFilesCheckBox;
		private System.Windows.Forms.TextBox TargetDirectoryTextBox;
		private System.Windows.Forms.Button TargetDirectoryButton;
		private System.Windows.Forms.GroupBox ExtensionsGroupBox;
		private System.Windows.Forms.GroupBox SourceDirectoryGroupBox;
		private System.Windows.Forms.GroupBox TargetDirectoryGroupBox;
		private System.Windows.Forms.Timer timer1;
	}
}

