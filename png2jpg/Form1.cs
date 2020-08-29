using System;
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
			SetDestinationGroupBoxState();
			ValidateOptions();
		}

		// vars /////////////////////////////////////////////////////////////////////////////////////

		Logger logger = new Logger("log.txt");
		private const string OldOptionsFile = "options.txt";
		private const char OptionsDelimiter = '=';
		private const string RootDirectoryOption = "root_directory";
		private const string SourceExtensionOption = "source_extension";
		private const string TargetExtensionOption = "target_extension";
		private const string IncludeSubdirectoriesOption = "include_subdirectories";
		private const string RemoveOriginalsOption = "remove_originals";
		private const string CopyFilesOption = "copy_files";
		private const string TargetDirectoryOption = "target_directory";

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

					if (l.StartsWith(CopyFilesOption))
					{
						CopyFilesCheckBox.Checked = bool.Parse(afterDelimiter);
					}

					if (l.StartsWith(TargetDirectoryOption))
					{
						TargetDirectoryTextBox.Text = afterDelimiter;
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
			lines.Add(CopyFilesOption + OptionsDelimiter + CopyFilesCheckBox.Checked);
			lines.Add(TargetDirectoryOption + OptionsDelimiter + TargetDirectoryTextBox.Text);

			File.WriteAllLines(OldOptionsFile, lines);

			return true;
		}

		bool ValidateOptions()
		{
			bool good = true;

			if (SourceExtensionComboBox.SelectedIndex == -1)
			{
				good = false;
			}

			if (TargetExtensionComboBox.SelectedIndex == -1)
			{
				good = false;
			}

			if (SourceExtensionComboBox.SelectedIndex == TargetExtensionComboBox.SelectedIndex)
			{
				good = false;
			}

			if (!Directory.Exists(RootDirectoryTextBox.Text))
			{
				good = false;
			}

			if (CopyFilesCheckBox.Checked)
			{
				if (!Directory.Exists(TargetDirectoryTextBox.Text))
				{
					good = false;
				}
			}

			ConfirmConversionButton.Enabled = good;

			return good;
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
			foreach (var ext in extensions)
			{
				try
				{
					affectedFiles.AddRange(Directory.GetFiles(RootDirectoryTextBox.Text, "*" + ext, so).ToList());
				}
				catch (System.UnauthorizedAccessException e)
				{
					logger.Write(e.Message);
				}
			}

			return affectedFiles;
		}

		void SetDestinationGroupBoxState()
		{
			TargetDirectoryButton.Enabled = CopyFilesCheckBox.Checked;
			TargetDirectoryTextBox.Enabled = CopyFilesCheckBox.Checked;
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

		private void CopyFilesCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			SetDestinationGroupBoxState();

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

		private void StartConversionButton_Click(object sender, EventArgs e)
		{
			WriteOptions();
			MessageBox.Show(FindAffectedFiles().Count.ToString());
		}
	}
}
