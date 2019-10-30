using ShoesFactory.DAL.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ShoesContext db;
        BindingSource bs1;
        BindingSource bs2;
        BindingSource bs3;
        public Form1()
        {
            db = new ShoesContext("Default Connection1");
            InitializeComponent();
            //dataGridView1.DataSource = db.Materials.ToList();
            //dataGridView2.DataSource = db.Employers.ToList();
            //dataGridView3.DataSource = db.Suppliers.ToList();
            //bindingNavigator1.BindingSource.DataSource = db.Materials.ToList();
            bs1 = new BindingSource();
            bs1.DataSource = db.Materials.ToList();
            bindingNavigator1.BindingSource = bs1;
            dataGridView1.DataSource = bs1;

            bs2 = new BindingSource();
            bs2.DataSource = db.Suppliers.ToList();
            bindingNavigator2.BindingSource = bs2;
            dataGridView2.DataSource = bs2;

            bs3 = new BindingSource();
            bs3.DataSource = db.Employers.ToList();
            bindingNavigator3.BindingSource = bs3;
            dataGridView3.DataSource = bs3;
            
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bs1.EndEdit();
            
           // db.SaveChanges();

            this.Close();
        }
    }
}
