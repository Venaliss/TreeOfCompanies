using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeOfCompanies_home_Work_02._03._2024__
{
    public partial class TreeOfCompany_2 : Form
    {
        public TreeOfCompany_2()
        {
            InitializeComponent();
        }

        private void btnCompanies_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("companies.xml");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnHq_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("companies.xml");
            dataGridView1.DataSource = ds.Tables[1];
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("companies.xml");
            dataGridView1.DataSource = ds.Tables[3];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
