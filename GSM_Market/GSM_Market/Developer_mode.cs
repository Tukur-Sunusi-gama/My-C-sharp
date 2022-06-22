using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GSM_Market
{
    public partial class Developer_mode : Form
    {
        public Developer_mode()
        {
            InitializeComponent();
        }

        private void lightMoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            light();
        }
        public void Dark()
        {
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
            this.BackColor = Color.Black;
            this.ForeColor = Color.White; 
        }
        public void light()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black; 
        }
        public void reader()
        {
            this.BackColor = Color.LightGoldenrodYellow;
            this.ForeColor = Color.Black; 
        }

        private void nightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dark(); 
        }

        private void nightModeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reader();
        }

        private void cotomerModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mform = new MainForm();
            this.Hide();
            mform.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
