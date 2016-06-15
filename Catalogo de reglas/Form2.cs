using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo_de_reglas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'catalogoDataSet2.traerTablas' Puede moverla o quitarla según sea necesario.
            this.traerTablasTableAdapter1.Fill(this.catalogoDataSet2.traerTablas);
            // TODO: esta línea de código carga datos en la tabla 'catalogoDataSet1.traerTablas' Puede moverla o quitarla según sea necesario.
            this.traerTablasTableAdapter.Fill(this.catalogoDataSet1.traerTablas);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //crear
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //cancelar
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
            }
            else
            {
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            SqlConnection sqlConnection1 = new SqlConnection("Data Source=VINI\\SQLEXPRESS;Initial Catalog=catalogo;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT COLUMN_NAME FROM catalogo.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = " + comboBox6.SelectedValue + ";";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader = cmd.ExecuteReader();

            comboBox4.Items.Add(reader.GetString(0));
            // Data is accessible through the DataReader object here.

            sqlConnection1.Close();
        }
    }
}
