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
    public partial class Reg_data : Form
    {
        public Reg_data()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            this.info_group_box.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void new_data_Click(object sender, EventArgs e)
        {

            this.new_data.Enabled = false;
            this.Save_btn.Enabled = true;
            this.info_group_box.Enabled = true;

            this.maskedTextBox1.ResetText();
            this.maskedTextBox2.ResetText();
            this.maskedTextBox3.ResetText();
            this.maskedTextBox4.ResetText();
            this.maskedTextBox5.ResetText();
            this.maskedTextBox6.ResetText();
            this.maskedTextBox7.ResetText();
            this.maskedTextBox8.ResetText();

        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            this.Save_btn.Enabled = false;
            this.new_data.Enabled = true;
            this.info_group_box.Enabled = false;

            if (this.maskedTextBox1.Text == "") 
            {
                MessageBox.Show("You must enter the ID");
                this.Save_btn.Enabled = true;
                this.info_group_box.Enabled = true;
                this.new_data.Enabled = false;
                return;
            }

            string fn;
            string p;
            fn = "C:\\tuts\\";
            p = fn + this.maskedTextBox1.Text + "_addr.txt";
            System.IO.File.WriteAllText(p, this.maskedTextBox2.Text, Encoding.UTF8);
            p = fn + this.maskedTextBox1.Text + "_email.txt";
            System.IO.File.WriteAllText(p, this.maskedTextBox3.Text, Encoding.UTF8);
            p = fn + this.maskedTextBox1.Text + "_cnum.txt";
            System.IO.File.WriteAllText(p, this.maskedTextBox4.Text, Encoding.UTF8);
            p = fn + this.maskedTextBox1.Text + "_tele.txt";
            System.IO.File.WriteAllText(p, this.maskedTextBox5.Text, Encoding.UTF8);
            p = fn + this.maskedTextBox1.Text + "_ln.txt";
            System.IO.File.WriteAllText(p, this.maskedTextBox6.Text, Encoding.UTF8);
            p = fn + this.maskedTextBox1.Text + "_fn.txt";
            System.IO.File.WriteAllText(p, this.maskedTextBox7.Text, Encoding.UTF8);
            p = fn + this.maskedTextBox1.Text + "_cmnt.txt";
            System.IO.File.WriteAllText(p, this.maskedTextBox8.Text, Encoding.UTF8);

            MessageBox.Show("Saved");
        }

        private void maskedTextBox7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
