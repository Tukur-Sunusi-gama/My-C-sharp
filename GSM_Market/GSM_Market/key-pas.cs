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
    public partial class key_pass : Form
    {
        int a;
        public key_pass()
        {
            InitializeComponent();
        }

        private void btnPass_Click(object sender, EventArgs e)
        {   
            
            Developer_mode developer = new Developer_mode();
            MainForm mform = new MainForm();
            txtPass.Focus();
             a++;
             if (a < 3)
             {
                 if (txtPass.Text == "Abba1234")
                 {
                     this.Hide();
                     mform.Hide();
                     developer.Show();
                     
                 }
                 else
                 {
                     MessageBox.Show("Wrong Password", "!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                     txtPass.Clear();
                 }
             }
             else
             {
                 this.Hide();
                 mform.Show();
             }
        }

        private void key_pass_Load(object sender, EventArgs e)
        {
            txtPass.Focus();
        }

    }
}
