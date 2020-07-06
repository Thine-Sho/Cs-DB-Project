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
    public partial class About_us : Form
    {
        public About_us()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Label lab = new Label();
            lab.Text = "JAMES FRANCO";
            lab.Size = new Size(120, 25);
        }
    }
}
