using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportSIO
{
    public partial class frmModifs : Form
    {
        public frmModifs()
        {
            InitializeComponent();
            txtId.Hide();
            txtCP.Hide();
            txtNom.Hide();
            txtPren.Hide();
            txtRue.Hide();
            txtVille.Hide();
            dtpDateNais.Hide();
            cbxNivExp.Hide();
            txtNomSport.Hide();
        }
    }
}
