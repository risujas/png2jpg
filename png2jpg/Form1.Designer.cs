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
			this.RootDirectoryLabel = new System.Windows.Forms.Label();
			this.RootDirectoryTextBox = new System.Windows.Forms.TextBox();
			this.ProgressBar = new System.Windows.Forms.ProgressBar();
			this.StartConversionButton = new System.Windows.Forms.Button();
			this.SubdirectoriesCheckbox = new System.Windows.Forms.CheckBox();
			this.SourceExtensionComboBox = new System.Windows.Forms.ComboBox();
			this.TargetExtensionComboBox = new System.Windows.Forms.ComboBox();
			this.RemoveOriginalFilesCheckBox = new System.Windows.Forms.CheckBox();
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
			// RootDirectoryLabel
			// 
			this.RootDirectoryLabel.AutoSize = true;
			this.RootDirectoryLabel.Location = new System.Drawing.Point(9, 111);
			this.RootDirectoryLabel.Name = "RootDirectoryLabel";
			this.RootDirectoryLabel.Size = new System.Drawing.Size(76, 13);
			this.RootDirectoryLabel.TabIndex = 4;
			this.RootDirectoryLabel.Text = " Root directory";
			// 
			// RootDirectoryTextBox
			// 
			this.RootDirectoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RootDirectoryTextBox.Location = new System.Drawing.Point(12, 127);
			this.RootDirectoryTextBox.Name = "RootDirectoryTextBox";
			this.RootDirectoryTextBox.Size = new System.Drawing.Size(206, 20);
			this.RootDirectoryTextBox.TabIndex = 5;
			// 
			// ProgressBar
			// 
			this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ProgressBar.Location = new System.Drawing.Point(12, 252);
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.Size = new System.Drawing.Size(206, 23);
			this.ProgressBar.TabIndex = 6;
			// 
			// StartConversionButton
			// 
			this.StartConversionButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.StartConversionButton.Location = new System.Drawing.Point(12, 223);
			this.StartConversionButton.Name = "StartConversionButton";
			this.StartConversionButton.Size = new System.Drawing.Size(206, 23);
			this.StartConversionButton.TabIndex = 7;
			this.StartConversionButton.Text = "Confirm conversion";
			this.StartConversionButton.UseVisualStyleBackColor = true;
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
			// 
			// SourceExtensionComboBox
			// 
			this.SourceExtensionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SourceExtensionComboBox.FormattingEnabled = true;
			this.SourceExtensionComboBox.Location = new System.Drawing.Point(12, 29);
			this.SourceExtensionComboBox.Name = "SourceExtensionComboBox";
			this.SourceExtensionComboBox.Size = new System.Drawing.Size(206, 21);
			this.SourceExtensionComboBox.TabIndex = 9;
			// 
			// TargetExtensionComboBox
			// 
			this.TargetExtensionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TargetExtensionComboBox.FormattingEnabled = true;
			this.TargetExtensionComboBox.Location = new System.Drawing.Point(12, 69);
			this.TargetExtensionComboBox.Name = "TargetExtensionComboBox";
			this.TargetExtensionComboBox.Size = new System.Drawing.Size(206, 21);
			this.TargetExtensionComboBox.TabIndex = 10;
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
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(230, 287);
			this.Controls.Add(this.RemoveOriginalFilesCheckBox);
			this.Controls.Add(this.TargetExtensionComboBox);
			this.Controls.Add(this.SourceExtensionComboBox);
			this.Controls.Add(this.SubdirectoriesCheckbox);
			this.Controls.Add(this.StartConversionButton);
			this.Controls.Add(this.ProgressBar);
			this.Controls.Add(this.RootDirectoryTextBox);
			this.Controls.Add(this.RootDirectoryLabel);
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
		private System.Windows.Forms.Label RootDirectoryLabel;
		private System.Windows.Forms.TextBox RootDirectoryTextBox;
		private System.Windows.Forms.ProgressBar ProgressBar;
		private System.Windows.Forms.Button StartConversionButton;
		private System.Windows.Forms.CheckBox SubdirectoriesCheckbox;
		private System.Windows.Forms.ComboBox SourceExtensionComboBox;
		private System.Windows.Forms.ComboBox TargetExtensionComboBox;
		private System.Windows.Forms.CheckBox RemoveOriginalFilesCheckBox;
	}
}

