using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo_de_reglas
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'catalogoDataSet.catalogoCompleto' Puede moverla o quitarla según sea necesario.
            this.catalogoCompletoTableAdapter.Fill(this.catalogoDataSet.catalogoCompleto);
            // TODO: esta línea de código carga datos en la tabla 'reglasDataSet.REGLA' Puede moverla o quitarla según sea necesario.

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
