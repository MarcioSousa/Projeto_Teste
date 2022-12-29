using System;
using System.Windows.Forms;
using ProjetoTeste.Code.BLL;
using ProjetoTeste.Code.DTO;

namespace ProjetoTeste
{
    public partial class frmPrincipal : Form
    {
        PrincipalBLL bll = new PrincipalBLL();
        PrincipalDTO dto = new PrincipalDTO();
        

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            
        }

        private void CarregarGrid()
            {
                dgvPrincipal.DataSource = bll.SelecionaTodos();
                
             }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
