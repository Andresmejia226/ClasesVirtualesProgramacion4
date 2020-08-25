using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clasesvirtualesprogramacion.Dialogs
{
    public partial class baseDialog : Form
    {
        protected ErrorProvider erp = new ErrorProvider();
        public baseDialog()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected virtual bool ValidarEntrada()
        {
            return true;
        }
        public bool NotificacionDeValidacion(string mesage, Control objeto)
        {
            MessageBox.Show(mesage, "Información sin ingresar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (objeto != null)
                objeto.Focus();
            erp.SetError(objeto, mesage);
            return false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarEntrada() == false)
                return;

            DialogResult = DialogResult.OK;       
        }
    }
}
