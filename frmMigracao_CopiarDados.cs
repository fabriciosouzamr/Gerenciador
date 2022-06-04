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
  public partial class frmMigracao_CopiarDados : Form
  {
    public frmMigracao_CopiarDados()
    {
      InitializeComponent();
    }

    private void cmdFechar_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void cmdCopiar_Click(object sender, EventArgs e)
    {
      if (!oConexao_Origem.oBancoDados.DBConectado())
      {
        MessageBox.Show("Banco de dados de origem não está conectado");

        return;
      }
      if (!oConexao_Destino.oBancoDados.DBConectado())
      {
        MessageBox.Show("Banco de dados de destino não está conectado");

        return;
      }
      if (clbTabelas.CheckedItems.Count == 0)
      {
        MessageBox.Show("Precisa selecionar pelo menos uma tabela para cópia");

        return;
      }
    }

    private void  cmdMarcarTodos_Click(object sender, EventArgs e)
    {
      for (int i = 0; i < clbTabelas.Items.Count; i++)
      {
        clbTabelas.SetItemChecked(i, true);
      }
    }

    private void cmdDesmarcarTodos_Click(object sender, EventArgs e)
    {
      for (int i = 0; i < clbTabelas.Items.Count; i++)
      {
        clbTabelas.SetItemChecked(i, false);
      }
    }

    private void oConexao_Origem_Conectado()
    {
      foreach (string sList in oConexao_Origem.oBancoDados.Objetos_ListarTabelas())
      {
        clbTabelas.Items.Add(sList);
      }
    }
  }
}
