using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador
{
  public partial class uscConexao : UserControl
  {
    public delegate void evento();

    public event evento Conectado;

    public clsBancoDados oBancoDados;

    string sLegenda = "";

    public uscConexao()
    {
      InitializeComponent();
    }

    private void uscConexao_Load(object sender, EventArgs e)
    {
      lblConexaoBancoDados_Status.Text = "";
    }

    //PROPRIEDADES - INÍCIO
    public string Legenda
    {
      get { return sLegenda; }   
      set 
      { 
        sLegenda = value;
        grpTipoBancoDados.Text = grpTipoBancoDados.Text.Replace("LEGENDA", sLegenda);
        grpConexaoBancoDados.Text = grpConexaoBancoDados.Text.Replace("LEGENDA", sLegenda);
      }  
    }

    private void cmdConexaoBancoDados_Conectar_Click(object sender, EventArgs e)
    {
      try
      {
        if (txtConexaoBancoDados_Servidor.Text.Trim() == "")
        {
          MessageBox.Show("Informa o servidor");
          return;
        }
        if (txtConexaoBancoDados_BancoDados.Text.Trim() == "")
        {
          MessageBox.Show("Informa o banco de dados");
          return;
        }
        if (txtConexaoBancoDados_Usuario.Text.Trim() == "")
        {
          MessageBox.Show("Informa o usuário");
          return;
        }
        if (txtConexaoBancoDados_Senha.Text.Trim() == "")
        {
          MessageBox.Show("Informa a senha");
          return;
        }

        oBancoDados = new clsBancoDados
        {
          Conecao_Servidor = txtConexaoBancoDados_Servidor.Text,
          Conecao_BancoDados = txtConexaoBancoDados_BancoDados.Text,
          Conecao_Usuario = txtConexaoBancoDados_Usuario.Text,
          Conecao_Senha = txtConexaoBancoDados_Senha.Text
        };

        if (oBancoDados.DBConectar(BancoDados_Constantes.const_TipoBancoDados_SqlServer))
        {
          lblConexaoBancoDados_Status.Text = "Conectado";
          Conectado.Invoke();
        }
        else
        { lblConexaoBancoDados_Status.Text = "Não conectado"; }
      }
      catch (Exception Ex)
      {
        lblConexaoBancoDados_Status.Text = "Não conectado";

        MessageBox.Show(Ex.Message);
      }
    }

    //PROPRIEDADES - FIM
  }
}
