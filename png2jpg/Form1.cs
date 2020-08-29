﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace png2jpg
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			LoadOptions();

			TargetDirectoryButton.Enabled = CopyFilesCheckBox.Checked;
			TargetDirectoryTextBox.Enabled = CopyFilesCheckBox.Checked;

			ValidateOptions();
		}

		// vars /////////////////////////////////////////////////////////////////////////////////////

		private const string OldOptionsFile = "options.txt";
		private const char OptionsDelimiter = '=';
		private const string RootDirectoryOption = "root_directory";
		private const string SourceExtensionOption = "source_extension";
		private const string TargetExtensionOption = "target_extension";
		private const string IncludeSubdirectoriesOption = "include_subdirectories";
		private const string RemoveOriginalsOption = "remove_originals";

		// methods /////////////////////////////////////////////////////////////////////////////////////

		bool LoadOptions()
		{
			if (File.Exists(OldOptionsFile))
			{
				string[] lines = File.ReadAllLines(OldOptionsFile);

				foreach (var l in lines)
				{
					if (!l.Contains(OptionsDelimiter))
					{
						continue;
					}

					string afterDelimiter = l.Substring(l.IndexOf(OptionsDelimiter) + 1);

					if (l.StartsWith(RootDirectoryOption))
					{
						RootDirectoryTextBox.Text = afterDelimiter;
					}

					if (l.StartsWith(SourceExtensionOption))
					{
						SourceExtensionComboBox.SelectedItem = afterDelimiter;
					}

					if (l.StartsWith(TargetExtensionOption))
					{
						TargetExtensionComboBox.SelectedItem = afterDelimiter;
					}

					if (l.StartsWith(IncludeSubdirectoriesOption))
					{
						SubdirectoriesCheckbox.Checked = bool.Parse(afterDelimiter);
					}

					if (l.StartsWith(RemoveOriginalsOption))
					{
						RemoveOriginalFilesCheckBox.Checked = bool.Parse(afterDelimiter);
					}
				}

				return true;
			}

			return false;
		}

		bool WriteOptions()
		{
			if (File.Exists(OldOptionsFile))
			{
				File.Delete(OldOptionsFile);
			}

			List<string> lines = new List<string>();
			lines.Add(RootDirectoryOption + OptionsDelimiter + RootDirectoryTextBox.Text);
			lines.Add(SourceExtensionOption + OptionsDelimiter + SourceExtensionComboBox.SelectedItem);
			lines.Add(TargetExtensionOption + OptionsDelimiter + TargetExtensionComboBox.SelectedItem);
			lines.Add(IncludeSubdirectoriesOption + OptionsDelimiter + SubdirectoriesCheckbox.Checked);
			lines.Add(RemoveOriginalsOption + OptionsDelimiter + RemoveOriginalFilesCheckBox.Checked);

			File.WriteAllLines(OldOptionsFile, lines);

			return true;
		}

		bool ValidateOptions()
		{
			WriteOptions();

			ConfirmConversionButton.Enabled = false;

			if (SourceExtensionComboBox.SelectedIndex == -1)
			{
				return false;
			}

			if (TargetExtensionComboBox.SelectedIndex == -1)
			{
				return false;
			}

			if (SourceExtensionComboBox.SelectedIndex == TargetExtensionComboBox.SelectedIndex)
			{
				return false;
			}

			if (RootDirectoryTextBox.Text == "")
			{
				return false;
			}

			if (!Directory.Exists(RootDirectoryTextBox.Text))
			{
				return false;
			}

			ConfirmConversionButton.Enabled = true;

			return true;
		}

		List<string> FindAffectedFiles()
		{
			List<string> affectedFiles = new List<string>();

			SearchOption so = SearchOption.TopDirectoryOnly;
			if (SubdirectoriesCheckbox.Checked)
			{
				so = SearchOption.AllDirectories;
			}

			string[] extensions = SourceExtensionComboBox.SelectedItem.ToString().Split(' ');
			foreach (var e in extensions)
			{
				affectedFiles.AddRange(Directory.GetFiles(RootDirectoryTextBox.Text, "*" + e, so).ToList());
			}

			return affectedFiles;
		}

		// form events /////////////////////////////////////////////////////////////////////////////////////

		private void SourceExtensionComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ValidateOptions();
		}

		private void TargetExtensionComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ValidateOptions();
		}

		private void SourceDirectoryButton_Click(object sender, EventArgs e)
		{
			DialogResult result = folderBrowserDialog1.ShowDialog();
			if (result == DialogResult.OK)
			{
				RootDirectoryTextBox.Text = folderBrowserDialog1.SelectedPath;
			}

			ValidateOptions();
		}

		private void RootDirectoryTextBox_TextChanged(object sender, EventArgs e)
		{
			ValidateOptions();
		}

		private void SubdirectoriesCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			ValidateOptions();
		}

		private void RemoveOriginalFilesCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			ValidateOptions();
		}

		private void StartConversionButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show(FindAffectedFiles().Count.ToString());
		}

		private void CopyFilesCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			TargetDirectoryButton.Enabled = CopyFilesCheckBox.Checked;
			TargetDirectoryTextBox.Enabled = CopyFilesCheckBox.Checked;

			ValidateOptions();
		}

		private void TargetDirectoryButton_Click(object sender, EventArgs e)
		{
			DialogResult result = folderBrowserDialog1.ShowDialog();
			if (result == DialogResult.OK)
			{
				TargetDirectoryTextBox.Text = folderBrowserDialog1.SelectedPath;
			}

			ValidateOptions();
		}

		private void TargetDirectoryTextBox_TextChanged(object sender, EventArgs e)
		{
			ValidateOptions();
		}
	}
}
