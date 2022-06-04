using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador
{
  public partial class frmPrincipal : Form
  {
    public frmPrincipal()
    {
      InitializeComponent();
    }

    private void mnuEsquema_CompararBancoDados_Click(object sender, EventArgs e)
    {
      frmEsquema_CompararBancoDados oForm = new frmEsquema_CompararBancoDados();
      oForm.Show();
    }

    private void mnuMigracao_CopiarDados_Click(object sender, EventArgs e)
    {
      frmMigracao_CopiarDados oForm = new frmMigracao_CopiarDados();
      oForm.MdiParent = this;
      oForm.Show();
    }

    private void mnuEsquema_RestaurarBancoDados_Click(object sender, EventArgs e)
    {
      frmEsquema_RestaurarBancoDados oForm = new frmEsquema_RestaurarBancoDados();
      oForm.MdiParent = this;
      oForm.Show();
    }
  }
}
