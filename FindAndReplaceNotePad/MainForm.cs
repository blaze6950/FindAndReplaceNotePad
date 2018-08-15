using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindAndReplaceNotePad
{
    public partial class MainForm : Form
    {
        private FindForm _findForm = null;
        private FindAndReplaceForm _findAndReplaceForm = null;
        public MainForm()
        {
            InitializeComponent();
        }

        public string Data
        {
            set { textBox.Text = value; }
            get { return textBox.Text; }
        }

        public TextBox DataTextBox
        {
            set { textBox = value; }
            get { return textBox; }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (_findAndReplaceForm == null)
            {
                _findAndReplaceForm = new FindAndReplaceForm(this, true);
                _findAndReplaceForm.FormClosed += (s, a) => _findAndReplaceForm = null;
                _findAndReplaceForm.Show();
            }
            else
            {
                _findAndReplaceForm.Activate();
            }
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            if (_findAndReplaceForm == null)
            {
                _findAndReplaceForm = new FindAndReplaceForm(this, false);
                _findAndReplaceForm.FormClosed += (s, a) => _findAndReplaceForm = null;
                _findAndReplaceForm.Show();
            }
            else
            {
                _findAndReplaceForm.Activate();
            }
        }
    }
}
