using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Search_Form : Form
    {
        public Search_Form()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox9_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void info_group_box_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.maskedTextBox9.Text == "")
            {
                MessageBox.Show("You must enter the ID");
                return;
            }
            string fn;
            string p;
            string r;
            fn = "C:\\tuts\\";
            p = fn + this.maskedTextBox9.Text + "_fn.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.maskedTextBox7.Text = r;
            }
            //-----------------------------------------------------------------------
            p = fn + this.maskedTextBox9.Text + "_ln.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.maskedTextBox6.Text = r;
            }
            //-----------------------------------------------------------------------
            fn = "C:\\tuts\\";
            p = fn + this.maskedTextBox9.Text + "_tele.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.maskedTextBox5.Text = r;
            }
            //-----------------------------------------------------------------------
            p = fn + this.maskedTextBox9.Text + "_cnum.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.maskedTextBox4.Text = r;
            }
            //-----------------------------------------------------------------------
            fn = "C:\\tuts\\";
            p = fn + this.maskedTextBox9.Text + "_email.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.maskedTextBox3.Text = r;
            }
            //-----------------------------------------------------------------------
            p = fn + this.maskedTextBox9.Text + "_addr.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.maskedTextBox2.Text = r;
            }
            //-----------------------------------------------------------------------
            fn = "C:\\tuts\\";
            p = fn + this.maskedTextBox9.Text + "_cmnt.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.maskedTextBox8.Text = r;
            }
            //-----------------------------------------------------------------------
        }

        private void maskedTextBox7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
