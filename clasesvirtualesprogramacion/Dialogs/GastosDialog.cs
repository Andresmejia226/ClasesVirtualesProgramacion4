using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clasesvirtualesprogramacion.Dialogs;

namespace clasesvirtualesprogramacion.Dialogs
{
    public partial class GastosDialog : baseDialog
    {
        public GastosDialog()
        {
            InitializeComponent();
        }

        protected override bool ValidarEntrada()
        {
            erp.Clear();
            if (categoriaComboBox.SelectedIndex < 0)
                return NotificacionDeValidacion("Por favor seleccione la categoria de gastos", categoriaComboBox);

            if (subcategoriaComboBox.SelectedIndex < 0)
                return NotificacionDeValidacion("Por favor seleccione la subcategoria de gastos", subcategoriaComboBox);

            if (descripcionTextBox.Text.Trim() == string.Empty)
                return NotificacionDeValidacion("Por favor escriba la descrición que se gasto", descripcionTextBox);

            if (formapagoComboBox.SelectedIndex < 0)
                return NotificacionDeValidacion("Por favor seleccione la forma de pago", formapagoComboBox);
            return true;
        }
    }
}
