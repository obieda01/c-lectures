﻿using System;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Top : Form
    {
        public Top()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Password newPassword = new Password();
            string result = newPassword.getPassword(cbPronouncable.Checked);
            tbDisplay.AppendText(result + "\r\n");
            tbDisplay.ScrollToCaret();

            tbThis.Text = result;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(tbThis.Text);
        }

        private void Top_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAbout = new About();
            frmAbout.ShowDialog(); 
        }
    }
}

