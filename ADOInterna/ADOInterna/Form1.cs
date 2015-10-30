using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;


namespace ADOInterna
{
    public partial class Form1 : MetroForm
    {
        DataTable dt = new DataTable("estudiantes");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Nombre", typeof(System.Int32));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr["Nombre"] = txtNombre.Text;
            dt.Rows.Add(dr);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {


            dataGridView1.DataSource = dt;
        }
    }
}
