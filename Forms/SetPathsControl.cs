namespace MapPortingUtility
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class SetPathsForm : Form
    {
        public Paths ComputedPath => computedPath;

        public Paths computedPath;

        public SetPathsForm(Paths paths) : base()
        {
            computedPath = paths;

            InitializeComponent();

            okButton.Enabled = computedPath.IsValid;

            if (!computedPath.IsIW3PathGood(out _)) {
                computedPath.TryDetectIW3Path();
            }

            if (!computedPath.IsIW4PathGood(out _)) {
                computedPath.TryDetectIW4Path();
            }

            if (!computedPath.IsIW5PathGood(out _))
            {
                computedPath.TryDetectIW5Path();
            }

            iw3PathTextBox.Text = computedPath.IW3Path;
            iw4PathTextBox.Text = computedPath.IW4Path;
            iw5PathTextBox.Text = computedPath.IW5Path;

            iw3PathTextBox.TextChanged += Iw3PathTextBox_TextChanged;
            iw4PathTextBox.TextChanged += Iw4PathTextBox_TextChanged;
            iw5PathTextBox.TextChanged += Iw5PathTextBox_TextChanged;

        }

        private void Iw5PathTextBox_TextChanged(object sender, EventArgs e)
        {
            computedPath.IW5Path = iw5PathTextBox.Text.Trim();

            if (computedPath.IsIW5PathGood(out string error))
            {
                okButton.Enabled = computedPath.IsValid;
            }
            else
            {
                MessageBox.Show(error, "Invalid path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Iw4PathTextBox_TextChanged(object sender, EventArgs e)
        {
            computedPath.IW4Path = iw4PathTextBox.Text.Trim();
            
            if (computedPath.IsIW4PathGood(out string error)) {
                okButton.Enabled = computedPath.IsValid;
            }
            else {
                MessageBox.Show(error, "Invalid path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Iw3PathTextBox_TextChanged(object sender, EventArgs e)
        {
            computedPath.IW3Path = iw3PathTextBox.Text.Trim();

            if (computedPath.IsIW3PathGood(out string error)) {
                okButton.Enabled = computedPath.IsValid;
            }
            else {
                MessageBox.Show(error, "Invalid path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Program.WritePaths(computedPath);
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void browseIW3Button_Click(object sender, EventArgs e)
        {
            var openDialog = new FolderBrowserDialog();
            if (openDialog.ShowDialog() == DialogResult.OK) {
                iw3PathTextBox.Text = openDialog.SelectedPath;
            }
        }

        private void browseIW4Button_Click(object sender, EventArgs e)
        {
            var openDialog = new FolderBrowserDialog();
            if (openDialog.ShowDialog() == DialogResult.OK) {
                iw4PathTextBox.Text = openDialog.SelectedPath;
            }
        }

        private void browseIW5Button_Click(object sender, EventArgs e)
        {
            var openDialog = new FolderBrowserDialog();
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                iw5PathTextBox.Text = openDialog.SelectedPath;
            }
        }
    }
}
