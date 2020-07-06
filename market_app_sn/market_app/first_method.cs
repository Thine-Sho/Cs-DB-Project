using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market_app
{
    public partial class first_method : Form
    {
        public first_method()
        {
            InitializeComponent();
        }

        private void goods_listBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.goods_listBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.goods_ds);

        }

        private void first_method_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'goods_ds.goods_list' table. You can move, or remove it, as needed.
            this.goods_listTableAdapter.Fill(this.goods_ds.goods_list);

        }

        private void goods_listDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void idLabel2_Click(object sender, EventArgs e)
        {

        }

        private void priceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
