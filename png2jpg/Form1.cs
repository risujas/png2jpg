using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace png2jpg
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			InvalidColor = Color.FromArgb(255, 230, 230);
			DefaultTextBoxColor = RootDirectoryTextBox.BackColor;
			DefaultGroupBoxColor = ExtensionsGroupBox.BackColor;

			LoadOptions();
			SetDestinationGroupBoxInternalStates();
			ValidateOptions();
		}

		// vars /////////////////////////////////////////////////////////////////////////////////////

		private Logger logger = new Logger("log.txt");

		private readonly Color InvalidColor;
		private readonly Color DefaultTextBoxColor;
		private readonly Color DefaultGroupBoxColor;

		private const string OldOptionsFile = "options.txt";
		private const char OptionsDelimiter = '=';
		private const string RootDirectoryOption = "root_directory";
		private const string SourceExtensionOption = "source_extension";
		private const string TargetExtensionOption = "target_extension";
		private const string IncludeSubdirectoriesOption = "include_subdirectories";
		private const string RemoveOriginalsOption = "remove_originals";
		private const string CopyFilesOption = "copy_files";
		private const string TargetDirectoryOption = "target_directory";

		private List<Process> spawnedProcesses = new List<Process>();
		private bool processingFiles = false;
		private List<string> AffectedFilesList = new List<string>();
		private int currentFileIndex = 0;
		private int maximumFileIndex = 0;

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
			WriteOptions();

			bool good = true;

			ExtensionsGroupBox.BackColor = DefaultGroupBoxColor;
			if (SourceExtensionComboBox.SelectedIndex == TargetExtensionComboBox.SelectedIndex)
			{
				good = false;
				ExtensionsGroupBox.BackColor = InvalidColor;
			}
			else if (SourceExtensionComboBox.SelectedIndex == -1)
			{
				good = false;
				ExtensionsGroupBox.BackColor = InvalidColor;
			}
			else if (TargetExtensionComboBox.SelectedIndex == -1)
			{
				good = false;
				ExtensionsGroupBox.BackColor = InvalidColor;
			}

			RootDirectoryTextBox.BackColor = DefaultTextBoxColor;
			if (!Directory.Exists(RootDirectoryTextBox.Text))
			{
				good = false;
				RootDirectoryTextBox.BackColor = InvalidColor;
			}
			if (CopyFilesCheckBox.Checked)
			{
				TargetDirectoryTextBox.BackColor = DefaultTextBoxColor;
				if (!Directory.Exists(TargetDirectoryTextBox.Text))
				{
					good = false;
					TargetDirectoryTextBox.BackColor = InvalidColor;
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

		void SetDestinationGroupBoxInternalStates()
		{
			TargetDirectoryButton.Enabled = CopyFilesCheckBox.Checked;
			TargetDirectoryTextBox.Enabled = CopyFilesCheckBox.Checked;

			if (!TargetDirectoryTextBox.Enabled)
			{
				TargetDirectoryTextBox.BackColor = DefaultTextBoxColor;
			}
		}

		void SetGroupBoxStates(bool state)
		{
			ExtensionsGroupBox.Enabled = state;
			SourceDirectoryGroupBox.Enabled = state;
			TargetDirectoryGroupBox.Enabled = state;
			ConfirmConversionButton.Enabled = state;
		}

		int CountFinishedProcesses()
		{
			int finished = 0;
			foreach (var sp in spawnedProcesses)
			{
				if (sp.HasExited)
				{
					finished++;
				}
			}
			return finished;
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
			SetDestinationGroupBoxInternalStates();

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
			var affectedFiles = FindAffectedFiles();

			if (affectedFiles.Count == 0)
			{
				MessageBox.Show("0 matching files were found.", "Confirm conversion");
				return;
			}

			else
			{
				string message = "";

				if (!SubdirectoriesCheckbox.Checked)
				{
					message += FindAffectedFiles().Count.ToString() + " matching files were found in the source directory." + "\n";
				}
				else
				{
					message += FindAffectedFiles().Count.ToString() + " matching files were found in the source directory and its subdirectories." + "\n";
				}
				message += "\n";

				if (!CopyFilesCheckBox.Checked)
				{
					message += "The converted files will be saved next to the original files." + "\n";
				}
				else
				{
					message += "The converted files will be moved to a different directory." + "\n";
				}
				message += "\n";

				if (!RemoveOriginalFilesCheckBox.Checked)
				{
					message += "The original files will not be removed." + "\n";
				}
				else
				{
					message += "THE ORIGINAL FILES WILL BE REMOVED." + "\n";
				}

				var result = MessageBox.Show(message, "Confirm conversion", MessageBoxButtons.OKCancel);
				if (result == DialogResult.OK)
				{
					AffectedFilesList = affectedFiles;
					currentFileIndex = 0;
					maximumFileIndex = AffectedFilesList.Count;
					processingFiles = true;
				}
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (processingFiles)
			{
				if (currentFileIndex < maximumFileIndex)
				{
					SetGroupBoxStates(false);

					string filePathWithoutExtension = AffectedFilesList[currentFileIndex];

					if (!filePathWithoutExtension.Contains('.'))
					{
						return;
					}

					while (filePathWithoutExtension.Last() != '.')
					{
						filePathWithoutExtension = filePathWithoutExtension.Remove(filePathWithoutExtension.Count() - 1, 1);
					}
					filePathWithoutExtension = filePathWithoutExtension.Remove(filePathWithoutExtension.Count() - 1, 1);

					string[] possibleExtensions = TargetExtensionComboBox.SelectedItem.ToString().Split(' ');
					string newFilePath = filePathWithoutExtension + possibleExtensions[0];

					if (CopyFilesCheckBox.Checked)
					{
						newFilePath = newFilePath.Replace(RootDirectoryTextBox.Text, TargetDirectoryTextBox.Text);
					}

					ProcessStartInfo psi = new ProcessStartInfo();
					psi.FileName = Environment.CurrentDirectory + @"/ffmpeg/bin/ffmpeg.exe";
					psi.Arguments = "-y -i \"" + AffectedFilesList[currentFileIndex] + "\" \"" + newFilePath + "\"";
					spawnedProcesses.Add(Process.Start(psi));

					logger.Write(psi.FileName + " " + psi.Arguments);

					currentFileIndex++;
				}

				if (CountFinishedProcesses() == maximumFileIndex)
				{
					AffectedFilesList.Clear();
					currentFileIndex = 0;
					processingFiles = false;
					spawnedProcesses.Clear();

					ProgressBar.Value = maximumFileIndex;

					SetGroupBoxStates(true);
				}

				else
				{
					ProgressBar.Value = CountFinishedProcesses();
					ProgressBar.Maximum = maximumFileIndex;
				}
			}
		}
	}
}
