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
    public partial class FrmPaleta : Form
    {
        private Paleta _miPaleta;
        public FrmPaleta()
        {
            InitializeComponent();
            this._miPaleta = 5;
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            FrmTempera frm = new FrmTempera();
            frm.ShowDialog();
            if(frm.DialogResult == DialogResult.OK)
            {
                this._miPaleta += frm.MiTempera;
                this.lstLista.Items.Add(Tempera.Mostrar(frm.MiTempera));
            }
            
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            int index = this.lstLista.SelectedIndex;
            FrmTempera frm = new FrmTempera(this._miPaleta[index],true);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                //this._miPaleta -= this._miPaleta[index];
            }
        }

        private void lstLista_DoubleClick(object sender, EventArgs e)
        {
            int index = this.lstLista.SelectedIndex;
            FrmTempera frm = new FrmTempera(this._miPaleta[index], false);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {

            }
        }
    }
}
