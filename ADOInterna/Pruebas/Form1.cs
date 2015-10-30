using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebas
{
    public partial class Form1 : Form
    {
        private DataTable dt = new DataTable("usuarios");
        DataRow dr = null;
        DataRow drB = null;
        int codigo;
        


        public Form1()
        {
            InitializeComponent();
            DataColumn dc = dt.Columns.Add("Id", typeof(Int32));
            dc.AutoIncrement = true;
            dc.AutoIncrementSeed = 100;
            dc.AutoIncrementStep = 1;
            dt.Columns.Add("Nombre",typeof(string));
            dt.Columns.Add("Apellido", typeof(string));
            DataColumn[] pk = new DataColumn[1];
            pk[0] = dt.Columns[0];
            dt.PrimaryKey = pk;

            dataGridView1.Columns.Add("Id", "Codigo");
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns.Add("Apellido", "Apellido");
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;

            dataGridView1.Columns["Id"].DataPropertyName = "Id";
            dataGridView1.Columns["Nombre"].DataPropertyName = "Nombre";
            dataGridView1.Columns["Apellido"].DataPropertyName = "Apellido";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Insert(string nombre, string apellido)
        {
            dr = dt.NewRow();
            dr[1] = nombre;
            dr[2] = apellido;
            dt.Rows.Add(dr);
            Actualizar();
            Limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insert(textBox1.Text, textBox2.Text);
        }

        private void Limpiar()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
            }
        }

        private void Actualizar()
        {
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            drB = dt.Rows.Find(codigo);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            drB["Nombre"] = textBox1.Text;
            drB["Apellido"] = textBox2.Text;
            drB.EndEdit();
            Actualizar();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(drB != null)
            {
                drB.Delete();
                drB = null;
            }
            Actualizar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("Nombre = '{0}'",textBox3.Text);
                if (dv == null)
                {
                    MessageBox.Show("No se encontro ningun registro");
                }
                else
                {
                    dataGridView2.DataSource = dv;
                }
            }
        }
    }
}
