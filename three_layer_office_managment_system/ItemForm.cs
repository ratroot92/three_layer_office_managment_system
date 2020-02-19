using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjProps;
namespace three_layer_office_managment_system
{
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ItemProps new_item_object = new ItemProps();
            new_item_object.Id = Int32.Parse(txt_id.Text);
            new_item_object.Name = txt_name.Text;
            new_item_object.Saleprice = Double.Parse(txt_saleprice.Text);
            new_item_object.Purcahseprice = Double.Parse(txt_purchase_price.Text);
            new_item_object.Manufacturer = txt_manufacturer.Text;

        }
    }
}
