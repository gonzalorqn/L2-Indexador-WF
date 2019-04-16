using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase06.Entidades;

namespace Clase07.WF
{
    public partial class FrmTempera : Form
    {
        private Tempera _miTempera;

        public Tempera MiTempera
        {
            get { return _miTempera; }
        }

        public FrmTempera()
        {
            InitializeComponent();
            foreach (ConsoleColor c in Enum.GetValues(typeof (ConsoleColor)))
            {
                this.cboColor.Items.Add(c);
            }
        }

        public FrmTempera(Tempera t,bool b) :this()
        {
            this._miTempera = t;
            sbyte aux = t;
            this.txtCantidad.Text = aux.ToString();
            this.txtMarca.Text = t.Marca;
            this.cboColor.SelectedItem = t.Color;
            if(b)
            {
                this.txtMarca.Enabled = false;
                this.txtCantidad.Enabled = false;
                this.cboColor.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string marca = this.txtMarca.Text;
            sbyte cantidad = sbyte.Parse(this.txtCantidad.Text);
            ConsoleColor color = (ConsoleColor)this.cboColor.SelectedItem;
            Tempera t1 = new Tempera(color, marca, cantidad);
            this._miTempera = t1;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
