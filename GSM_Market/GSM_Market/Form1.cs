using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GSM_Market
{
    public partial class MainForm : Form
    {
        int PricePerIndex;
        int totalIndexPrice;
        int DisCount;
        int Qantity;
        int totalAmount;

        string Phone;
        string Category; 
        int qty;


        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CombCategory.Items.Add("VIVO");
            CombCategory.Items.Add("GIONEE");
            CombCategory.Items.Add("HAWII");
            CombCategory.Items.Add("TECNO");
            CombCategory.Items.Add("IPHONE");

            
            

            //    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs); Handles ExitToolStripMenuItem.Click
            //        End
            //    End Sub
            //End Class
            // We creat procedure hare
        }
        public void Dark()
        {
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
            groupBox1.ForeColor = Color.White;
        }
        public void light()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            rtbList.BackColor = Color.White;
            rtbList.ForeColor = Color.Black;
            groupBox1.ForeColor = Color.Black;
        }
        public void reader()
        {
            this.BackColor = Color.LightGoldenrodYellow;
            this.ForeColor = Color.Black;
            rtbList.BackColor = Color.LightGoldenrodYellow;
            rtbList.ForeColor = Color.Black;
            groupBox1.ForeColor = Color.Black;
        }
        public void rtb()
        {
            rtbList.AppendText("Category     " + Category + Environment.NewLine +
                               "Type         " + Phone + Environment.NewLine +
                               "Qantity      " + Qantity + Environment.NewLine +
                               "total Price  " + totalIndexPrice + Environment.NewLine +
                               "discount     " + lblDiscount.Text + Environment.NewLine +
                                "........................" + Environment.NewLine);
        }
        public void Lissafi1()
        {
            totalIndexPrice = PricePerIndex * Qantity;
            //output
            lblPer1.Text = "₦" + PricePerIndex;
            lblTotalIndex.Text = "₦" + totalIndexPrice;
            lblDiscount.Text = "No Discount";
            if (Qantity > 0)
            {
                rtb();
            }
            lbl1.Text = "Total Price Of " + Qantity + " " + Phone;
            nudQuantity.Value = 0;
        }
        public void lissafi2()
        {
            totalIndexPrice = PricePerIndex * Qantity;
            DisCount = Convert.ToInt32((totalIndexPrice / 100) * 2.5);
            //output
            output();
        }
        public void output()
        {
            lblPer1.Text = "₦" + PricePerIndex;
            lblTotalIndex.Text = "₦" + (totalIndexPrice - DisCount);
            lblDiscount.Text = Convert.ToString(DisCount);
            rtb();
            lbl1.Text = "Total Price Of " + Qantity + " " + Phone;

        }

        public void lissafi3()
        {
            totalIndexPrice = PricePerIndex * Qantity;
            DisCount = (totalIndexPrice / 100) * 5;
            //output
            output();
        }
        public void lissafi4()
        {
            totalIndexPrice = PricePerIndex * Qantity;
            DisCount = Convert.ToInt32((totalIndexPrice / 100) * 7.5);
            //output
            output();
        }
        public void lissafi5()
        {
            totalIndexPrice = PricePerIndex * Qantity;
            DisCount = ((totalIndexPrice / 100) * 10);
            //output
            output();
        }

        public void final()
        {
            if (nudQuantity.Value < 10)
            {
                Lissafi1();
            }
            else if (nudQuantity.Value >= 10)
            {
                lissafi2();
            }
            else if (nudQuantity.Value >= 50)
            {
                lissafi3();
            }
            else if (nudQuantity.Value >= 100)
            {
                lissafi4();
            }
            else
            {
                lissafi5();
            }

            combPhone.Text = "Phones";
            totalAmount += totalIndexPrice;
            qty += Qantity;
        }



        private void lightMoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            light();
        }

        private void sKINToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Dark();
        }

        private void nightModeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           reader();
        }

        private void CombCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //VIVO
            if (CombCategory.SelectedIndex == 0)
            {
                combPhone.Items.Clear();
                combPhone.Items.Add("X7");
                combPhone.Items.Add("Y11");
                combPhone.Items.Add("Y13");
                combPhone.Items.Add("Y13 L");
                combPhone.Items.Add("Y20");
                combPhone.Items.Add("Y28");
                combPhone.Items.Add("Y32");
                combPhone.Items.Add("Y57");
            }
            //GIONEE
            else if (CombCategory.SelectedIndex == 1)
            {
                combPhone.Items.Clear();
                combPhone.Items.Add("H6");
                combPhone.Items.Add("F100 3G");
                combPhone.Items.Add("F100 4G");
                combPhone.Items.Add("GN5003");
                combPhone.Items.Add("GN5005");
                combPhone.Items.Add("GN5006");
                combPhone.Items.Add("S10");
                combPhone.Items.Add("S10 lite");
            }
            //HAWII
            else if (CombCategory.SelectedIndex == 2)
            {
                combPhone.Items.Clear();
                combPhone.Items.Add("HONOR 5");
                combPhone.Items.Add("HONOR 6");
                combPhone.Items.Add("HONOR 7");
            }
            //TECNO
            else if (CombCategory.SelectedIndex == 3)
            {
                combPhone.Items.Clear();
                combPhone.Items.Add("K7");
                combPhone.Items.Add("SPARK 4");
                combPhone.Items.Add("SPARK 5");
                combPhone.Items.Add("SPARK 6");
                combPhone.Items.Add("SPARK 7");
            }
            //IPHONE
            else
            {
                combPhone.Items.Clear();
                combPhone.Items.Add("Iphone 4");
                combPhone.Items.Add("Iphone 5");
                combPhone.Items.Add("Iphone 6");
                combPhone.Items.Add("Iphone 7");
                combPhone.Items.Add("Iphone 7 pro");
                combPhone.Items.Add("Iphone 7 pro max");
                combPhone.Items.Add("Iphone 10");
                combPhone.Items.Add("Iphone 11");
                combPhone.Items.Add("Iphone 11 pro");
                combPhone.Items.Add("Iphone 11 pro max");
                combPhone.Items.Add("Iphone 12");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //input
            Phone = combPhone.Text;
            Qantity = Convert.ToInt32(nudQuantity.Value);
            Category = CombCategory.Text;
            //vivo
            if (Phone == "X7")
            {
                PricePerIndex = 4000;
                final();
            }
            else if (Phone == "Y11")
            {
                PricePerIndex = 5000;
                final();
            }
            else if (Phone == "Y13")
            {
                PricePerIndex = 6000;
                final();
            }
            else if (Phone == "Y13 L")
            {
                PricePerIndex = 6000;
                final();
            }
            else if (Phone == "Y20  ")
            {
                PricePerIndex = 9000;
                final();
            }
            else if (Phone == "Y28")
            {
                PricePerIndex = 12000;
                final();
            }
            else if (Phone == "Y32")
            {
                PricePerIndex = 15000;
                final();
            }
            else if (Phone == "Y57")
            {
                PricePerIndex = 50000;
                final();
            }
            //            Gionee
            if (Phone == "h6")
            {
                PricePerIndex = 4000;
                final();
            }

            else if (Phone == "F100 3G")
            {
                PricePerIndex = 9500;
                final();
            }
            else if (Phone == "F100 4G")
            {
                PricePerIndex = 10000;
                final();
            }
            else if (Phone == "GN5003")
            {
                PricePerIndex = 11000;
                final();
            }
            else if (Phone == "GN5005")
            {
                PricePerIndex = 13000;
                final();
            }
            else if (Phone == "GN5006")
            {
                PricePerIndex = 15000;
                final();
            }
            else if (Phone == "S10")
            {
                PricePerIndex = 23000;
                final();
            }
            else if (Phone == "S10 lite")
            {
                PricePerIndex = 25000;
                final();
            }
            //HAWII
            if (Phone == "HONOR 5")
            {
                PricePerIndex = 13000;
                final();
            }
            else if (Phone == "HONOR 6")
            {
                PricePerIndex = 15000;
                final();
            }
            else if (Phone == "HONOR 7")
            {
                PricePerIndex = 17000;
                final();
            }
            if (Phone == "K7")
            {
                PricePerIndex = 21000;
                final();
            }
            else if (Phone == "SPARK 4")
            {
                PricePerIndex = 22000;
                final();
            }
            else if (Phone == "SPARK 5")
            {
                PricePerIndex = 35000;
                final();
            }
            else if (Phone == "SPARK 6")
            {
                PricePerIndex = 47000;
                final();
            }
            else if (Phone == "SPARK 7")
            {
                PricePerIndex = 53000;
                final();
            }
            //Iphone
            if (Phone == "Iphone 4")
            {
                PricePerIndex = 5000;
                final();
            }
            else if (Phone == "Iphone 5")
            {
                PricePerIndex = 12000;
                final();
            }
            else if (Phone == "Iphone 6")
            {
                PricePerIndex = 2500;
                final();
            }
            else if (Phone == "Iphone 7")
            {
                PricePerIndex = 30000;
                final();
            }
            else if (Phone == "Iphone 7 pro")
            {
                PricePerIndex = 50000;
                final();
            }
            else if (Phone == "Iphone 7 pro max")
            {
                PricePerIndex = 55000;
                final();
            }
            else if (Phone == "Iphone 10")
            {
                PricePerIndex = 80000;
                final();
            }
            else if (Phone == "Iphone 11")
            {
                PricePerIndex = 120000;
                final();
            }
            else if (Phone == "Iphone 11 pro")
            {
                PricePerIndex = 135000;
                final();
            }
            else if (Phone == "Iphone 11 pro max")
            {
                PricePerIndex = 200000;
                final();
            }
            else if (Phone == "Iphone 12")
            {
                PricePerIndex = 800000;
                final();
            }
        }


        private void btnCRecipt_Click(object sender, EventArgs e)
        {
            rtbRecipt.Clear();
            rtbRecipt.Text = "*************************************************--------------------Tk Smart Phone Shop-----------------*************************************************";
        }

        private void btnCList_Click(object sender, EventArgs e)
        {
            rtbList.Clear();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
                    if (rtbList.Text != null)
            {
                rtbRecipt.AppendText("Costomers Name  " + txtName.Text + Environment.NewLine + rtbList.Text + Environment.NewLine + Environment.NewLine + " You Paid " + totalAmount + " For " + qty + " Phones" + Environment.NewLine);
            }
                    BtnPrint.Enabled = false;
        }

        private void BtnFinish_Click(object sender, EventArgs e)
        {

            if (txtName.Text == null)
            {
                MessageBox.Show("Fill the costomer name Please", "Costomers name", MessageBoxButtons.OK);
            }
            else
            {
            BtnPrint.Enabled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void combPhone_SelectedIndexChanged(object sender, EventArgs e)
        {
                 lblTotalIndex.ResetText();
                    lblDiscount.ResetText();
                    lblPer1.ResetText();
                    lbl1.Text = "Total Price";
                    nudQuantity.Value = 0; 
        }

        private void developerModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            key_pass key = new key_pass();
            key.Show();
            this.Hide();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}