using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Entidades;

namespace RegistroyMapeo
{
    public partial class FormularioPrincipal : MetroFramework.Forms.MetroForm
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void registosEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.RegistroEstudiantes rEstudiante = new UI.Registros.RegistroEstudiantes();
            rEstudiante.Show();
        }
    }
}
