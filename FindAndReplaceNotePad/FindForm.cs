using System;
using System.Windows.Forms;

namespace FindAndReplaceNotePad
{
    public partial class FindForm : Form
    {
        private MainForm _mainForm;
        public FindForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            findTextBox.Text = _mainForm.DataTextBox.SelectedText;
        }

        private void findNextButton_Click(object sender, EventArgs e)
        {
            FindInTheText();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FindInTheText()
        {
            if (downRB.Checked)
            {
                FindDown();
            }
            else
            {
                FindUp();
            }
        }

        private void FindDown()
        {
            String text =
                _mainForm.Data.Substring(_mainForm.DataTextBox.SelectionStart +
                                         _mainForm.DataTextBox.SelectionLength);
            if (text.Length > 0)
            {
                int firstPos;

                if (caseSensitiveCB.Checked == false)
                {
                    firstPos = text.IndexOf(findTextBox.Text, StringComparison.OrdinalIgnoreCase);
                }
                else
                {
                    firstPos = text.IndexOf(findTextBox.Text, StringComparison.Ordinal);
                }

                if (firstPos != -1)
                {
                    _mainForm.DataTextBox.Select(firstPos + (_mainForm.Data.Length - text.Length), findTextBox.Text.Length);
                    _mainForm.Activate();
                }
                else
                {
                    MessageBox.Show(@"Find nothing!", @"Result", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show(@"Find nothing!", @"Result", MessageBoxButtons.OK);
            }
        }

        private void FindUp()
        {
            String text = _mainForm.Data.Substring(0, _mainForm.DataTextBox.SelectionStart);
            if (text.Length > 0)
            {
                int firstPos;

                if (caseSensitiveCB.Checked == false)
                {
                    firstPos = text.LastIndexOf(findTextBox.Text, StringComparison.OrdinalIgnoreCase);
                }
                else
                {
                    firstPos = text.LastIndexOf(findTextBox.Text, StringComparison.Ordinal);
                }

                if (firstPos != -1)
                {
                    _mainForm.DataTextBox.Select(firstPos, findTextBox.Text.Length);
                    _mainForm.Activate();
                }
                else
                {
                    MessageBox.Show(@"Find nothing!", @"Result", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show(@"Find nothing!", @"Result", MessageBoxButtons.OK);
            }
        }
    }
}
