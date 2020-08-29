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
					if (l.StartsWith("directory:"))
					{
						string[] parts = l.Split(':');
						if (parts.Length > 1)
						{
							RootDirectoryTextBox.Text = parts[1];
						}
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

			// TODO

			return true;
		}

		bool ValidateOptions()
		{
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

		private void StartConversionButton_Click(object sender, EventArgs e)
		{

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
	}
}
