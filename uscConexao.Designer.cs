namespace Gerenciador
{
  partial class uscConexao
  {
    /// <summary> 
    /// Variável de designer necessária.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Limpar os recursos que estão sendo usados.
    /// </summary>
    /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código gerado pelo Designer de Componentes

    /// <summary> 
    /// Método necessário para suporte ao Designer - não modifique 
    /// o conteúdo deste método com o editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.grpConexaoBancoDados = new System.Windows.Forms.GroupBox();
      this.lblConexaoBancoDados_Status = new System.Windows.Forms.Label();
      this.txtConexaoBancoDados_BancoDados = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.cmdConexaoBancoDados_Conectar = new System.Windows.Forms.Button();
      this.txtConexaoBancoDados_Senha = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtConexaoBancoDados_Usuario = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtConexaoBancoDados_Servidor = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.grpTipoBancoDados = new System.Windows.Forms.GroupBox();
      this.cboTipoBancoDados = new System.Windows.Forms.ComboBox();
      this.grpConexaoBancoDados.SuspendLayout();
      this.grpTipoBancoDados.SuspendLayout();
      this.SuspendLayout();
      // 
      // grpConexaoBancoDados
      // 
      this.grpConexaoBancoDados.Controls.Add(this.lblConexaoBancoDados_Status);
      this.grpConexaoBancoDados.Controls.Add(this.txtConexaoBancoDados_BancoDados);
      this.grpConexaoBancoDados.Controls.Add(this.label7);
      this.grpConexaoBancoDados.Controls.Add(this.cmdConexaoBancoDados_Conectar);
      this.grpConexaoBancoDados.Controls.Add(this.txtConexaoBancoDados_Senha);
      this.grpConexaoBancoDados.Controls.Add(this.label3);
      this.grpConexaoBancoDados.Controls.Add(this.txtConexaoBancoDados_Usuario);
      this.grpConexaoBancoDados.Controls.Add(this.label2);
      this.grpConexaoBancoDados.Controls.Add(this.txtConexaoBancoDados_Servidor);
      this.grpConexaoBancoDados.Controls.Add(this.label1);
      this.grpConexaoBancoDados.Location = new System.Drawing.Point(1, 47);
      this.grpConexaoBancoDados.Name = "grpConexaoBancoDados";
      this.grpConexaoBancoDados.Size = new System.Drawing.Size(260, 214);
      this.grpConexaoBancoDados.TabIndex = 3;
      this.grpConexaoBancoDados.TabStop = false;
      this.grpConexaoBancoDados.Text = "Conexão do Banco de Dados [LEGENDA]";
      // 
      // lblConexaoBancoDados_Status
      // 
      this.lblConexaoBancoDados_Status.AutoSize = true;
      this.lblConexaoBancoDados_Status.Location = new System.Drawing.Point(5, 189);
      this.lblConexaoBancoDados_Status.Name = "lblConexaoBancoDados_Status";
      this.lblConexaoBancoDados_Status.Size = new System.Drawing.Size(37, 13);
      this.lblConexaoBancoDados_Status.TabIndex = 9;
      this.lblConexaoBancoDados_Status.Text = "Status";
      // 
      // txtConexaoBancoDados_BancoDados
      // 
      this.txtConexaoBancoDados_BancoDados.Location = new System.Drawing.Point(5, 72);
      this.txtConexaoBancoDados_BancoDados.Name = "txtConexaoBancoDados_BancoDados";
      this.txtConexaoBancoDados_BancoDados.Size = new System.Drawing.Size(250, 20);
      this.txtConexaoBancoDados_BancoDados.TabIndex = 2;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(5, 57);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(87, 13);
      this.label7.TabIndex = 7;
      this.label7.Text = "Banco de Dados";
      // 
      // cmdConexaoBancoDados_Conectar
      // 
      this.cmdConexaoBancoDados_Conectar.Location = new System.Drawing.Point(180, 184);
      this.cmdConexaoBancoDados_Conectar.Name = "cmdConexaoBancoDados_Conectar";
      this.cmdConexaoBancoDados_Conectar.Size = new System.Drawing.Size(75, 23);
      this.cmdConexaoBancoDados_Conectar.TabIndex = 5;
      this.cmdConexaoBancoDados_Conectar.Text = "Conectar";
      this.cmdConexaoBancoDados_Conectar.UseVisualStyleBackColor = true;
      this.cmdConexaoBancoDados_Conectar.Click += new System.EventHandler(this.cmdConexaoBancoDados_Conectar_Click);
      // 
      // txtConexaoBancoDados_Senha
      // 
      this.txtConexaoBancoDados_Senha.Location = new System.Drawing.Point(5, 154);
      this.txtConexaoBancoDados_Senha.Name = "txtConexaoBancoDados_Senha";
      this.txtConexaoBancoDados_Senha.Size = new System.Drawing.Size(250, 20);
      this.txtConexaoBancoDados_Senha.TabIndex = 4;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(5, 139);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(38, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Senha";
      // 
      // txtConexaoBancoDados_Usuario
      // 
      this.txtConexaoBancoDados_Usuario.Location = new System.Drawing.Point(5, 113);
      this.txtConexaoBancoDados_Usuario.Name = "txtConexaoBancoDados_Usuario";
      this.txtConexaoBancoDados_Usuario.Size = new System.Drawing.Size(250, 20);
      this.txtConexaoBancoDados_Usuario.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(5, 98);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(43, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Usuário";
      // 
      // txtConexaoBancoDados_Servidor
      // 
      this.txtConexaoBancoDados_Servidor.Location = new System.Drawing.Point(5, 31);
      this.txtConexaoBancoDados_Servidor.Name = "txtConexaoBancoDados_Servidor";
      this.txtConexaoBancoDados_Servidor.Size = new System.Drawing.Size(250, 20);
      this.txtConexaoBancoDados_Servidor.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(5, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(46, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Servidor";
      // 
      // grpTipoBancoDados
      // 
      this.grpTipoBancoDados.Controls.Add(this.cboTipoBancoDados);
      this.grpTipoBancoDados.Location = new System.Drawing.Point(1, 1);
      this.grpTipoBancoDados.Name = "grpTipoBancoDados";
      this.grpTipoBancoDados.Size = new System.Drawing.Size(260, 44);
      this.grpTipoBancoDados.TabIndex = 2;
      this.grpTipoBancoDados.TabStop = false;
      this.grpTipoBancoDados.Text = "Tipo de Banco de Dados [LEGENDA]";
      // 
      // cboTipoBancoDados
      // 
      this.cboTipoBancoDados.FormattingEnabled = true;
      this.cboTipoBancoDados.Location = new System.Drawing.Point(5, 16);
      this.cboTipoBancoDados.Name = "cboTipoBancoDados";
      this.cboTipoBancoDados.Size = new System.Drawing.Size(250, 21);
      this.cboTipoBancoDados.TabIndex = 0;
      // 
      // uscConexao
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.grpConexaoBancoDados);
      this.Controls.Add(this.grpTipoBancoDados);
      this.Name = "uscConexao";
      this.Size = new System.Drawing.Size(260, 263);
      this.Load += new System.EventHandler(this.uscConexao_Load);
      this.grpConexaoBancoDados.ResumeLayout(false);
      this.grpConexaoBancoDados.PerformLayout();
      this.grpTipoBancoDados.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox grpConexaoBancoDados;
    private System.Windows.Forms.Label lblConexaoBancoDados_Status;
    private System.Windows.Forms.TextBox txtConexaoBancoDados_BancoDados;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button cmdConexaoBancoDados_Conectar;
    private System.Windows.Forms.TextBox txtConexaoBancoDados_Senha;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtConexaoBancoDados_Usuario;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtConexaoBancoDados_Servidor;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox grpTipoBancoDados;
    private System.Windows.Forms.ComboBox cboTipoBancoDados;
  }
}
