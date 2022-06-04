namespace Gerenciador
{
  partial class frmEsquema_RestaurarBancoDados
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
      this.oConexao = new Gerenciador.uscConexao();
      this.txtBancoDados = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.cmdRestaurar = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.txtArquivoBackup = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // oConexao
      // 
      this.oConexao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.oConexao.Legenda = "";
      this.oConexao.Location = new System.Drawing.Point(5, 5);
      this.oConexao.Name = "oConexao";
      this.oConexao.Size = new System.Drawing.Size(260, 263);
      this.oConexao.TabIndex = 1;
      // 
      // txtBancoDados
      // 
      this.txtBancoDados.Location = new System.Drawing.Point(271, 20);
      this.txtBancoDados.Name = "txtBancoDados";
      this.txtBancoDados.Size = new System.Drawing.Size(500, 20);
      this.txtBancoDados.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(271, 5);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(133, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Nome de Banco de Dados";
      // 
      // cmdRestaurar
      // 
      this.cmdRestaurar.Location = new System.Drawing.Point(691, 91);
      this.cmdRestaurar.Name = "cmdRestaurar";
      this.cmdRestaurar.Size = new System.Drawing.Size(75, 23);
      this.cmdRestaurar.TabIndex = 4;
      this.cmdRestaurar.Text = "Restaurar";
      this.cmdRestaurar.UseVisualStyleBackColor = true;
      this.cmdRestaurar.Click += new System.EventHandler(this.cmdRestaurar_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(271, 46);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(97, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Arquivo de backup";
      // 
      // txtArquivoBackup
      // 
      this.txtArquivoBackup.Location = new System.Drawing.Point(274, 61);
      this.txtArquivoBackup.Name = "txtArquivoBackup";
      this.txtArquivoBackup.Size = new System.Drawing.Size(500, 20);
      this.txtArquivoBackup.TabIndex = 5;
      // 
      // frmEsquema_RestaurarBancoDados
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(778, 275);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtArquivoBackup);
      this.Controls.Add(this.cmdRestaurar);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtBancoDados);
      this.Controls.Add(this.oConexao);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "frmEsquema_RestaurarBancoDados";
      this.Text = "Esquema - Restaurar Banco de Dados";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private uscConexao oConexao;
    private System.Windows.Forms.TextBox txtBancoDados;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button cmdRestaurar;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtArquivoBackup;
  }
}