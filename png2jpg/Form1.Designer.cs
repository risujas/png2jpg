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
			this.ChooseDirectoryButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// SourceExtensionLabel
			// 
			this.SourceExtensionLabel.AutoSize = true;
			this.SourceExtensionLabel.Location = new System.Drawing.Point(9, 13);
			this.SourceExtensionLabel.Name = "SourceExtensionLabel";
			this.SourceExtensionLabel.Size = new System.Drawing.Size(89, 13);
			this.SourceExtensionLabel.TabIndex = 0;
			this.SourceExtensionLabel.Text = "Source extension";
			// 
			// TargetExtensionLabel
			// 
			this.TargetExtensionLabel.AutoSize = true;
			this.TargetExtensionLabel.Location = new System.Drawing.Point(9, 52);
			this.TargetExtensionLabel.Name = "TargetExtensionLabel";
			this.TargetExtensionLabel.Size = new System.Drawing.Size(86, 13);
			this.TargetExtensionLabel.TabIndex = 2;
			this.TargetExtensionLabel.Text = "Target extension";
			// 
			// RootDirectoryTextBox
			// 
			this.RootDirectoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RootDirectoryTextBox.Location = new System.Drawing.Point(122, 126);
			this.RootDirectoryTextBox.Name = "RootDirectoryTextBox";
			this.RootDirectoryTextBox.Size = new System.Drawing.Size(177, 20);
			this.RootDirectoryTextBox.TabIndex = 5;
			this.RootDirectoryTextBox.TextChanged += new System.EventHandler(this.RootDirectoryTextBox_TextChanged);
			// 
			// ProgressBar
			// 
			this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ProgressBar.Location = new System.Drawing.Point(12, 252);
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.Size = new System.Drawing.Size(291, 23);
			this.ProgressBar.TabIndex = 6;
			// 
			// ConfirmConversionButton
			// 
			this.ConfirmConversionButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ConfirmConversionButton.Enabled = false;
			this.ConfirmConversionButton.Location = new System.Drawing.Point(12, 223);
			this.ConfirmConversionButton.Name = "ConfirmConversionButton";
			this.ConfirmConversionButton.Size = new System.Drawing.Size(291, 23);
			this.ConfirmConversionButton.TabIndex = 7;
			this.ConfirmConversionButton.Text = "Confirm conversion";
			this.ConfirmConversionButton.UseVisualStyleBackColor = true;
			this.ConfirmConversionButton.Click += new System.EventHandler(this.StartConversionButton_Click);
			// 
			// SubdirectoriesCheckbox
			// 
			this.SubdirectoriesCheckbox.AutoSize = true;
			this.SubdirectoriesCheckbox.Location = new System.Drawing.Point(12, 153);
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
			this.SourceExtensionComboBox.Location = new System.Drawing.Point(12, 29);
			this.SourceExtensionComboBox.Name = "SourceExtensionComboBox";
			this.SourceExtensionComboBox.Size = new System.Drawing.Size(291, 21);
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
			this.TargetExtensionComboBox.Location = new System.Drawing.Point(12, 69);
			this.TargetExtensionComboBox.Name = "TargetExtensionComboBox";
			this.TargetExtensionComboBox.Size = new System.Drawing.Size(291, 21);
			this.TargetExtensionComboBox.TabIndex = 10;
			this.TargetExtensionComboBox.SelectedIndexChanged += new System.EventHandler(this.TargetExtensionComboBox_SelectedIndexChanged);
			// 
			// RemoveOriginalFilesCheckBox
			// 
			this.RemoveOriginalFilesCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RemoveOriginalFilesCheckBox.AutoSize = true;
			this.RemoveOriginalFilesCheckBox.Location = new System.Drawing.Point(12, 176);
			this.RemoveOriginalFilesCheckBox.Name = "RemoveOriginalFilesCheckBox";
			this.RemoveOriginalFilesCheckBox.Size = new System.Drawing.Size(202, 17);
			this.RemoveOriginalFilesCheckBox.TabIndex = 11;
			this.RemoveOriginalFilesCheckBox.Text = "Remove original files after conversion";
			this.RemoveOriginalFilesCheckBox.UseVisualStyleBackColor = true;
			this.RemoveOriginalFilesCheckBox.CheckedChanged += new System.EventHandler(this.RemoveOriginalFilesCheckBox_CheckedChanged);
			// 
			// folderBrowserDialog1
			// 
			this.folderBrowserDialog1.ShowNewFolderButton = false;
			// 
			// ChooseDirectoryButton
			// 
			this.ChooseDirectoryButton.Location = new System.Drawing.Point(12, 124);
			this.ChooseDirectoryButton.Name = "ChooseDirectoryButton";
			this.ChooseDirectoryButton.Size = new System.Drawing.Size(104, 23);
			this.ChooseDirectoryButton.TabIndex = 12;
			this.ChooseDirectoryButton.Text = "Choose directory";
			this.ChooseDirectoryButton.UseVisualStyleBackColor = true;
			this.ChooseDirectoryButton.Click += new System.EventHandler(this.ChooseDirectoryButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(315, 287);
			this.Controls.Add(this.ChooseDirectoryButton);
			this.Controls.Add(this.RemoveOriginalFilesCheckBox);
			this.Controls.Add(this.TargetExtensionComboBox);
			this.Controls.Add(this.SourceExtensionComboBox);
			this.Controls.Add(this.SubdirectoriesCheckbox);
			this.Controls.Add(this.ConfirmConversionButton);
			this.Controls.Add(this.ProgressBar);
			this.Controls.Add(this.RootDirectoryTextBox);
			this.Controls.Add(this.TargetExtensionLabel);
			this.Controls.Add(this.SourceExtensionLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "MainForm";
			this.Text = "png2jpg";
			this.ResumeLayout(false);
			this.PerformLayout();

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
		private System.Windows.Forms.Button ChooseDirectoryButton;
	}
}

