using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace png2jpg
{
	public partial class MainForm : Form
	{
		public bool HasProperDirectorySelected { get; private set; }

		public MainForm()
		{
			InitializeComponent();
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

			if (!HasProperDirectorySelected)
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
	}
}
