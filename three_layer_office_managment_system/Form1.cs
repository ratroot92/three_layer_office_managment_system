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
using BuisnessLayer;
namespace three_layer_office_managment_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {

            try
            {

           
            EmpProps p = new EmpProps();
           
           
            p.Emp_code    =   txt_1.Text;           
            p.Emp_name    =   txt_2.Text; 
            p.Emp_cell    =   txt_3.Text;
            p.Emp_address =   txt_4.Text;
            Console.WriteLine(p.Emp_code);
            Console.WriteLine(p.Emp_name);
            Console.WriteLine(p.Emp_cell);
            Console.WriteLine(p.Emp_address);
            EmpBLL a =new EmpBLL();
           if(a.empInsert(p))
            {
                MessageBox.Show("inserted ");
            }
           
            else{
                MessageBox.Show("failed  ");
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show("error"+ex);
            }



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
