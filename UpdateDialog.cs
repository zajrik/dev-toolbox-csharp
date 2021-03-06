﻿using System;
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
        public UpdateDialog
            (
                string label = "Enter new version:",
                string title = "Update Version",
                string regex = @"^\d+\.\d+\.\d+$"
            )
        {
            InitializeComponent();

            label1.Text = label;
            this.Text = title;
            format = regex;
        }

        public string updateResult;
        string format;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, format))
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
