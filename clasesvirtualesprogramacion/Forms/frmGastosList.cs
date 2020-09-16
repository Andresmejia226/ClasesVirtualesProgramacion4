using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clasesvirtualesprogramacion.Forms
{
    public partial class frmGastosList : Form
    {
        admConexion oConexion = new admConexion();
        public frmGastosList()
        {
            InitializeComponent();
        }

        private void frmGastosList_Load(object sender, EventArgs e)
        {
            dsclasesvirtuales.Gastos.Clear();
            string SelectSQL = "Select * from gastos";
            if (oConexion.SelectData(SelectSQL, dsclasesvirtuales.Gastos) != true)
                MessageBox.Show("No se ha podido cargar ningun dato de Gastos, contacte el departamento de desarrollo tecnico", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Dialogs.GastosDialog frmNuevo = new Dialogs.GastosDialog();
            frmNuevo.categoriaComboBox.Focus();
            frmNuevo.ShowDialog();
            if (frmNuevo.DialogResult == DialogResult.OK)
            {
                string sqlInsert = string.Format("insert into gastos (fecha, categoria, subcategoria, descripcion, valor, formapago) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", frmNuevo.fechaDateTimePicker.Value.ToString("yyyy-MM-dd"), frmNuevo.categoriaComboBox.Text, frmNuevo.subcategoriaComboBox.Text, frmNuevo.descripcionTextBox.Text.Trim(), frmNuevo.nudValor.Value.ToString(), frmNuevo.formapagoComboBox.Text);
                if (oConexion.AccionSQL(sqlInsert) == true)
                {
                    this.frmGastosList_Load(null, null);
                    MessageBox.Show("La información de gastos ha sido almacenada correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gastosDataGridView.Focus();
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (gastosBindingSource.Count > 0)
            {
                Dialogs.GastosDialog frmEditar = new Dialogs.GastosDialog();
                DataGridViewRow Fila = gastosDataGridView.CurrentRow;
                Int16 ID = Int16.Parse(Fila.Cells[0].Value.ToString());
                frmEditar.fechaDateTimePicker.Value = Convert.ToDateTime(Fila.Cells[1].Value);
                frmEditar.categoriaComboBox.Text = Fila.Cells[2].Value.ToString();
                frmEditar.subcategoriaComboBox.Text = Fila.Cells[3].Value.ToString();
                frmEditar.descripcionTextBox.Text = Fila.Cells[4].Value.ToString();
                frmEditar.nudValor.Value = Convert.ToDecimal(Fila.Cells[5].Value);
                frmEditar.formapagoComboBox.Text = Fila.Cells[6].Value.ToString();
                frmEditar.fechaDateTimePicker.Focus();
                frmEditar.ShowDialog();
                if (frmEditar.DialogResult == DialogResult.OK)
                {
                    string sqlUpdate = string.Format("update gastos set fecha='{0}', categoria='{1}', subcategoria='{2}', descripcion='{3}', valor='{4}', formapago='{5}' where id = {6}", frmEditar.fechaDateTimePicker.Value.ToString("yyyy-MM-dd"), frmEditar.categoriaComboBox.Text, frmEditar.subcategoriaComboBox.Text, frmEditar.descripcionTextBox.Text.Trim(), frmEditar.nudValor.Value.ToString(), frmEditar.formapagoComboBox.Text, ID);
                    if (oConexion.AccionSQL(sqlUpdate) == true)
                    {
                        this.frmGastosList_Load(null, null);
                        MessageBox.Show("La información de gastos ha sido actualizada correctamente.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gastosDataGridView.Focus();
                    }

                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(gastosBindingSource.Count > 0)
            {
                if (MessageBox.Show("Asegurese de querer eliminar la información de gastos. Desea eliminar permanentemente este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    DataGridViewRow Fila = gastosDataGridView.CurrentRow;
                    Int16 ID = Int16.Parse(Fila.Cells[0].Value.ToString());
                    string sqlDelete = string.Format("delete from gastos where id = {0}", ID);
                    if(oConexion.AccionSQL(sqlDelete) == true)
                    {
                        this.frmGastosList_Load(null, null);
                        MessageBox.Show("La información de gastos ha sido borrada permanentemente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gastosDataGridView.Focus();
                    }
                }

            }
            else
            {
                MessageBox.Show("No hay información para eliminar un registro.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         
            }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cmbBuscarPor.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una de las opciones para buscar un gasto, ya sea por categoria o subcategoria", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbBuscarPor.Focus();
                return;
            }
            else
            {
                if(txtCriterio.Text.Trim()== string.Empty)
                {
                    MessageBox.Show("Por favor escriba un criterio para realizar la busqueda de un gasto.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCriterio.Focus();
                    return;
                }
                else
                {
                    String sqlSelect = string.Empty;
                    switch (cmbBuscarPor.SelectedIndex)
                    {
                        case 0: //categoria
                            sqlSelect = string.Format("Select * from gastos where categoria = '{0}'", txtCriterio.Text.Trim());
                            break;
                        case 1: //subcategoria
                            sqlSelect = string.Format("Select * from gastos where subcategoria like '{0}'", txtCriterio.Text.Trim());
                            break;
                    }
                    dsclasesvirtuales.Gastos.Clear();
                    if (oConexion.SelectData(sqlSelect, dsclasesvirtuales.Gastos) == true)
                        gastosDataGridView.Focus();
                }
            }
        }
    }
       
        

    }
    


