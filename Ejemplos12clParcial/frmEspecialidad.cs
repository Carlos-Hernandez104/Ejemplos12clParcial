using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplos12clParcial
{
    public partial class frmEspecialidad : Form
    {
        public frmEspecialidad()
        {
            InitializeComponent();
        }

        private void especialidadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.especialidadBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospital_medykalsystemDataSet);

        }

        private void frmEspecialidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hospital_medykalsystemDataSet.Especialidad' Puede moverla o quitarla según sea necesario.
            this.especialidadTableAdapter.Fill(this.hospital_medykalsystemDataSet.Especialidad);

        }
    }
}
