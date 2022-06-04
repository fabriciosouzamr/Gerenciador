namespace Gerenciador
{
  partial class frmEsquema_CompararBancoDados
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.cboTipoBancoDadosOrigem = new System.Windows.Forms.ComboBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtConexaoBancoDadosOrigem_Servidor = new System.Windows.Forms.TextBox();
      this.txtConexaoBancoDadosOrigem_Usuario = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtConexaoBancoDadosOrigem_Senha = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.cmdConexaoBancoDadosOrigem_Conectar = new System.Windows.Forms.Button();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.cmdConexaoBancoDadosDestino_Conectar = new System.Windows.Forms.Button();
      this.txtConexaoBancoDadosDestino_Senha = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtConexaoBancoDadosDestino_Usuario = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtConexaoBancoDadosDestino_Servidor = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.cboTipoBancoDadosDestino = new System.Windows.Forms.ComboBox();
      this.cmdComparar = new System.Windows.Forms.Button();
      this.txtResultado = new System.Windows.Forms.RichTextBox();
      this.cmdSalvar = new System.Windows.Forms.Button();
      this.txtConexaoBancoDadosOrigem_BancoDados = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.txtConexaoBancoDadosDestino_BancoDados = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.lblConexaoBancoDadosOrigem_Status = new System.Windows.Forms.Label();
      this.lblConexaoBancoDadosDestino_Status = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.cboTipoBancoDadosOrigem);
      this.groupBox1.Location = new System.Drawing.Point(5, 5);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(260, 44);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Tipo de Banco de Dados de Origem";
      // 
      // cboTipoBancoDadosOrigem
      // 
      this.cboTipoBancoDadosOrigem.FormattingEnabled = true;
      this.cboTipoBancoDadosOrigem.Location = new System.Drawing.Point(5, 16);
      this.cboTipoBancoDadosOrigem.Name = "cboTipoBancoDadosOrigem";
      this.cboTipoBancoDadosOrigem.Size = new System.Drawing.Size(250, 21);
      this.cboTipoBancoDadosOrigem.TabIndex = 0;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.lblConexaoBancoDadosOrigem_Status);
      this.groupBox2.Controls.Add(this.txtConexaoBancoDadosOrigem_BancoDados);
      this.groupBox2.Controls.Add(this.label7);
      this.groupBox2.Controls.Add(this.cmdConexaoBancoDadosOrigem_Conectar);
      this.groupBox2.Controls.Add(this.txtConexaoBancoDadosOrigem_Senha);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Controls.Add(this.txtConexaoBancoDadosOrigem_Usuario);
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Controls.Add(this.txtConexaoBancoDadosOrigem_Servidor);
      this.groupBox2.Controls.Add(this.label1);
      this.groupBox2.Location = new System.Drawing.Point(5, 51);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(260, 214);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Conexão do Banco de Dados de Origem";
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
      // txtConexaoBancoDadosOrigem_Servidor
      // 
      this.txtConexaoBancoDadosOrigem_Servidor.Location = new System.Drawing.Point(5, 31);
      this.txtConexaoBancoDadosOrigem_Servidor.Name = "txtConexaoBancoDadosOrigem_Servidor";
      this.txtConexaoBancoDadosOrigem_Servidor.Size = new System.Drawing.Size(250, 20);
      this.txtConexaoBancoDadosOrigem_Servidor.TabIndex = 1;
      // 
      // txtConexaoBancoDadosOrigem_Usuario
      // 
      this.txtConexaoBancoDadosOrigem_Usuario.Location = new System.Drawing.Point(5, 113);
      this.txtConexaoBancoDadosOrigem_Usuario.Name = "txtConexaoBancoDadosOrigem_Usuario";
      this.txtConexaoBancoDadosOrigem_Usuario.Size = new System.Drawing.Size(250, 20);
      this.txtConexaoBancoDadosOrigem_Usuario.TabIndex = 3;
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
      // txtConexaoBancoDadosOrigem_Senha
      // 
      this.txtConexaoBancoDadosOrigem_Senha.Location = new System.Drawing.Point(5, 154);
      this.txtConexaoBancoDadosOrigem_Senha.Name = "txtConexaoBancoDadosOrigem_Senha";
      this.txtConexaoBancoDadosOrigem_Senha.Size = new System.Drawing.Size(250, 20);
      this.txtConexaoBancoDadosOrigem_Senha.TabIndex = 5;
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
      // cmdConexaoBancoDadosOrigem_Conectar
      // 
      this.cmdConexaoBancoDadosOrigem_Conectar.Location = new System.Drawing.Point(180, 184);
      this.cmdConexaoBancoDadosOrigem_Conectar.Name = "cmdConexaoBancoDadosOrigem_Conectar";
      this.cmdConexaoBancoDadosOrigem_Conectar.Size = new System.Drawing.Size(75, 23);
      this.cmdConexaoBancoDadosOrigem_Conectar.TabIndex = 6;
      this.cmdConexaoBancoDadosOrigem_Conectar.Text = "Conectar";
      this.cmdConexaoBancoDadosOrigem_Conectar.UseVisualStyleBackColor = true;
      this.cmdConexaoBancoDadosOrigem_Conectar.Click += new System.EventHandler(this.cmdConexaoBancoDadosOrigem_Conectar_Click);
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.lblConexaoBancoDadosDestino_Status);
      this.groupBox3.Controls.Add(this.txtConexaoBancoDadosDestino_BancoDados);
      this.groupBox3.Controls.Add(this.label8);
      this.groupBox3.Controls.Add(this.cmdConexaoBancoDadosDestino_Conectar);
      this.groupBox3.Controls.Add(this.txtConexaoBancoDadosDestino_Senha);
      this.groupBox3.Controls.Add(this.label4);
      this.groupBox3.Controls.Add(this.txtConexaoBancoDadosDestino_Usuario);
      this.groupBox3.Controls.Add(this.label5);
      this.groupBox3.Controls.Add(this.txtConexaoBancoDadosDestino_Servidor);
      this.groupBox3.Controls.Add(this.label6);
      this.groupBox3.Location = new System.Drawing.Point(270, 51);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(260, 214);
      this.groupBox3.TabIndex = 3;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Conexão do Banco de Dados de Destino";
      // 
      // cmdConexaoBancoDadosDestino_Conectar
      // 
      this.cmdConexaoBancoDadosDestino_Conectar.Location = new System.Drawing.Point(180, 184);
      this.cmdConexaoBancoDadosDestino_Conectar.Name = "cmdConexaoBancoDadosDestino_Conectar";
      this.cmdConexaoBancoDadosDestino_Conectar.Size = new System.Drawing.Size(75, 23);
      this.cmdConexaoBancoDadosDestino_Conectar.TabIndex = 6;
      this.cmdConexaoBancoDadosDestino_Conectar.Text = "Conectar";
      this.cmdConexaoBancoDadosDestino_Conectar.UseVisualStyleBackColor = true;
      this.cmdConexaoBancoDadosDestino_Conectar.Click += new System.EventHandler(this.cmdConexaoBancoDadosDestino_Conectar_Click);
      // 
      // txtConexaoBancoDadosDestino_Senha
      // 
      this.txtConexaoBancoDadosDestino_Senha.Location = new System.Drawing.Point(5, 154);
      this.txtConexaoBancoDadosDestino_Senha.Name = "txtConexaoBancoDadosDestino_Senha";
      this.txtConexaoBancoDadosDestino_Senha.Size = new System.Drawing.Size(250, 20);
      this.txtConexaoBancoDadosDestino_Senha.TabIndex = 5;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(5, 139);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(38, 13);
      this.label4.TabIndex = 4;
      this.label4.Text = "Senha";
      // 
      // txtConexaoBancoDadosDestino_Usuario
      // 
      this.txtConexaoBancoDadosDestino_Usuario.Location = new System.Drawing.Point(5, 113);
      this.txtConexaoBancoDadosDestino_Usuario.Name = "txtConexaoBancoDadosDestino_Usuario";
      this.txtConexaoBancoDadosDestino_Usuario.Size = new System.Drawing.Size(250, 20);
      this.txtConexaoBancoDadosDestino_Usuario.TabIndex = 3;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(5, 98);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(43, 13);
      this.label5.TabIndex = 2;
      this.label5.Text = "Usuário";
      // 
      // txtConexaoBancoDadosDestino_Servidor
      // 
      this.txtConexaoBancoDadosDestino_Servidor.Location = new System.Drawing.Point(5, 31);
      this.txtConexaoBancoDadosDestino_Servidor.Name = "txtConexaoBancoDadosDestino_Servidor";
      this.txtConexaoBancoDadosDestino_Servidor.Size = new System.Drawing.Size(250, 20);
      this.txtConexaoBancoDadosDestino_Servidor.TabIndex = 1;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(5, 16);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(46, 13);
      this.label6.TabIndex = 0;
      this.label6.Text = "Servidor";
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.cboTipoBancoDadosDestino);
      this.groupBox4.Location = new System.Drawing.Point(270, 5);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(260, 44);
      this.groupBox4.TabIndex = 2;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Tipo de Banco de Dados de Destino";
      // 
      // cboTipoBancoDadosDestino
      // 
      this.cboTipoBancoDadosDestino.FormattingEnabled = true;
      this.cboTipoBancoDadosDestino.Location = new System.Drawing.Point(5, 16);
      this.cboTipoBancoDadosDestino.Name = "cboTipoBancoDadosDestino";
      this.cboTipoBancoDadosDestino.Size = new System.Drawing.Size(250, 21);
      this.cboTipoBancoDadosDestino.TabIndex = 0;
      // 
      // cmdComparar
      // 
      this.cmdComparar.Location = new System.Drawing.Point(5, 275);
      this.cmdComparar.Name = "cmdComparar";
      this.cmdComparar.Size = new System.Drawing.Size(75, 23);
      this.cmdComparar.TabIndex = 7;
      this.cmdComparar.Text = "Comparar";
      this.cmdComparar.UseVisualStyleBackColor = true;
      this.cmdComparar.Click += new System.EventHandler(this.cmdComparar_Click);
      // 
      // txtResultado
      // 
      this.txtResultado.Location = new System.Drawing.Point(5, 304);
      this.txtResultado.Name = "txtResultado";
      this.txtResultado.Size = new System.Drawing.Size(789, 143);
      this.txtResultado.TabIndex = 8;
      this.txtResultado.Text = "";
      // 
      // cmdSalvar
      // 
      this.cmdSalvar.Location = new System.Drawing.Point(712, 453);
      this.cmdSalvar.Name = "cmdSalvar";
      this.cmdSalvar.Size = new System.Drawing.Size(75, 23);
      this.cmdSalvar.TabIndex = 9;
      this.cmdSalvar.Text = "Salvar";
      this.cmdSalvar.UseVisualStyleBackColor = true;
      this.cmdSalvar.Click += new System.EventHandler(this.cmdSalvar_Click);
      // 
      // txtConexaoBancoDadosOrigem_BancoDados
      // 
      this.txtConexaoBancoDadosOrigem_BancoDados.Location = new System.Drawing.Point(5, 72);
      this.txtConexaoBancoDadosOrigem_BancoDados.Name = "txtConexaoBancoDadosOrigem_BancoDados";
      this.txtConexaoBancoDadosOrigem_BancoDados.Size = new System.Drawing.Size(250, 20);
      this.txtConexaoBancoDadosOrigem_BancoDados.TabIndex = 8;
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
      // txtConexaoBancoDadosDestino_BancoDados
      // 
      this.txtConexaoBancoDadosDestino_BancoDados.Location = new System.Drawing.Point(5, 72);
      this.txtConexaoBancoDadosDestino_BancoDados.Name = "txtConexaoBancoDadosDestino_BancoDados";
      this.txtConexaoBancoDadosDestino_BancoDados.Size = new System.Drawing.Size(250, 20);
      this.txtConexaoBancoDadosDestino_BancoDados.TabIndex = 10;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(5, 57);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(87, 13);
      this.label8.TabIndex = 9;
      this.label8.Text = "Banco de Dados";
      // 
      // lblConexaoBancoDadosOrigem_Status
      // 
      this.lblConexaoBancoDadosOrigem_Status.AutoSize = true;
      this.lblConexaoBancoDadosOrigem_Status.Location = new System.Drawing.Point(5, 189);
      this.lblConexaoBancoDadosOrigem_Status.Name = "lblConexaoBancoDadosOrigem_Status";
      this.lblConexaoBancoDadosOrigem_Status.Size = new System.Drawing.Size(38, 13);
      this.lblConexaoBancoDadosOrigem_Status.TabIndex = 9;
      this.lblConexaoBancoDadosOrigem_Status.Text = "Senha";
      // 
      // lblConexaoBancoDadosDestino_Status
      // 
      this.lblConexaoBancoDadosDestino_Status.AutoSize = true;
      this.lblConexaoBancoDadosDestino_Status.Location = new System.Drawing.Point(5, 189);
      this.lblConexaoBancoDadosDestino_Status.Name = "lblConexaoBancoDadosDestino_Status";
      this.lblConexaoBancoDadosDestino_Status.Size = new System.Drawing.Size(38, 13);
      this.lblConexaoBancoDadosDestino_Status.TabIndex = 11;
      this.lblConexaoBancoDadosDestino_Status.Text = "Senha";
      // 
      // frmEsquema_CompararBancoDados
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(799, 488);
      this.Controls.Add(this.cmdSalvar);
      this.Controls.Add(this.txtResultado);
      this.Controls.Add(this.cmdComparar);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "frmEsquema_CompararBancoDados";
      this.Text = "Esquema - Comparar Banco de Dados";
      this.Load += new System.EventHandler(this.frmEsquema_CompararBancoDados_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ComboBox cboTipoBancoDadosOrigem;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtConexaoBancoDadosOrigem_Senha;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtConexaoBancoDadosOrigem_Usuario;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtConexaoBancoDadosOrigem_Servidor;
    private System.Windows.Forms.Button cmdConexaoBancoDadosOrigem_Conectar;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Button cmdConexaoBancoDadosDestino_Conectar;
    private System.Windows.Forms.TextBox txtConexaoBancoDadosDestino_Senha;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtConexaoBancoDadosDestino_Usuario;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtConexaoBancoDadosDestino_Servidor;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.ComboBox cboTipoBancoDadosDestino;
    private System.Windows.Forms.Button cmdComparar;
    private System.Windows.Forms.RichTextBox txtResultado;
    private System.Windows.Forms.Button cmdSalvar;
    private System.Windows.Forms.TextBox txtConexaoBancoDadosOrigem_BancoDados;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txtConexaoBancoDadosDestino_BancoDados;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label lblConexaoBancoDadosOrigem_Status;
    private System.Windows.Forms.Label lblConexaoBancoDadosDestino_Status;
  }
}