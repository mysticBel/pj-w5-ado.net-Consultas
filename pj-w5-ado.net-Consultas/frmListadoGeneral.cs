using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pj_w5_ado.net_Consultas
{
    public partial class frmListadoGeneral : Form
    {
        DAOVendedor objDAO = new DAOVendedor();
        public frmListadoGeneral()
        {
            InitializeComponent();
        }

        private void frmListadoGeneral_Load(object sender, EventArgs e)
        {
            dgVendedores.DataSource = objDAO.listadoGeneral();
        }
    }
}
