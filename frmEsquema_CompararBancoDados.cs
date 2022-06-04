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
  public partial class frmEsquema_CompararBancoDados : Form
  {
    clsBancoDados oBancoDados_Origem;
    clsBancoDados oBancoDados_Destino;

    public frmEsquema_CompararBancoDados()
    {
      InitializeComponent();
    }

    private void cmdSalvar_Click(object sender, EventArgs e)
    {
      txtResultado.SaveFile("Script.txt");
    }

    private void frmEsquema_CompararBancoDados_Load(object sender, EventArgs e)
    {
      lblConexaoBancoDadosOrigem_Status.Text = "";
      lblConexaoBancoDadosDestino_Status.Text = "";
    }

    private void cmdConexaoBancoDadosOrigem_Conectar_Click(object sender, EventArgs e)
    {
      oBancoDados_Origem = new clsBancoDados();

      oBancoDados_Origem.Conecao_Servidor = txtConexaoBancoDadosOrigem_Servidor.Text;
      oBancoDados_Origem.Conecao_BancoDados = txtConexaoBancoDadosOrigem_BancoDados.Text;
      oBancoDados_Origem.Conecao_Usuario = txtConexaoBancoDadosOrigem_Usuario.Text;
      oBancoDados_Origem.Conecao_Senha = txtConexaoBancoDadosOrigem_Senha.Text;
      if (oBancoDados_Origem.DBConectar(BancoDados_Constantes.const_TipoBancoDados_SqlServer))
      { lblConexaoBancoDadosOrigem_Status.Text = "Conectado"; }
      else
      { lblConexaoBancoDadosOrigem_Status.Text = "Não conectado"; }
    }

    private void cmdConexaoBancoDadosDestino_Conectar_Click(object sender, EventArgs e)
    {
      oBancoDados_Destino = new clsBancoDados();

      oBancoDados_Destino.Conecao_Servidor = txtConexaoBancoDadosDestino_Servidor.Text;
      oBancoDados_Destino.Conecao_BancoDados = txtConexaoBancoDadosDestino_BancoDados.Text;
      oBancoDados_Destino.Conecao_Usuario = txtConexaoBancoDadosDestino_Usuario.Text;
      oBancoDados_Destino.Conecao_Senha = txtConexaoBancoDadosDestino_Senha.Text;
      if (oBancoDados_Destino.DBConectar(BancoDados_Constantes.const_TipoBancoDados_SqlServer))
      { lblConexaoBancoDadosDestino_Status.Text = "Conectado"; }
      else
      { lblConexaoBancoDadosDestino_Status.Text = "Não conectado"; }
    }

    private void cmdComparar_Click(object sender, EventArgs e)
    {
      string sScript = "";

      oBancoDados_Origem.CompararBancoDados_GerarScript(oBancoDados_Destino, ref sScript);

      txtResultado.Text = sScript;
    }
  }
}
