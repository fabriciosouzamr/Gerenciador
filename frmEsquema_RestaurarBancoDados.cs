﻿using System;
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
  public partial class frmEsquema_RestaurarBancoDados : Form
  {
    public frmEsquema_RestaurarBancoDados()
    {
      InitializeComponent();
    }

    private void cmdRestaurar_Click(object sender, EventArgs e)
    {
      oConexao.oBancoDados.DBRestaurarBancoDados(txtBancoDados.Text, txtBancoDados.Text);
    }
  }
}
