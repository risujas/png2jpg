using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace png2jpg
{
	public partial class MainForm : Form
	{
		private const string OldOptionsFile = "options.txt";
		private const char OptionsDelimiter = '?';
		private const string RootDirectoryOption = "root_directory";
		private const string SourceExtensionOption = "source_extension";
		private const string TargetExtensionOption = "target_extension";
		private const string IncludeSubdirectoriesOption = "include_subdirectories";
		private const string RemoveOriginalsOption = "remove_originals";

		public MainForm()
		{
			InitializeComponent();
			LoadOptions();
		}

		bool LoadOptions()
		{
			if (File.Exists(OldOptionsFile))
			{
				string[] lines = File.ReadAllLines(OldOptionsFile);

				foreach (var l in lines)
				{
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

		private void SourceExtensionComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ValidateOptions();
		}

		private void TargetExtensionComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ValidateOptions();
		}

		private void ChooseDirectoryButton_Click(object sender, EventArgs e)
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
			// TODO
		}
	}
}
