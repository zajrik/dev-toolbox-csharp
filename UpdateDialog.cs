using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace dev_toolbox
{
    public partial class UpdateDialog : Form
    {
        public UpdateDialog(string label = "Enter new version:", string title = "Update Version")
        {
            InitializeComponent();

            label1.Text = label;
            this.Text = title;
        }

        public string updateResult;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"^\d+\.\d+\.\d+$"))
            {
                updateResult = textBox1.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Update string not properly formatted.");
            }
        }
    }
}
