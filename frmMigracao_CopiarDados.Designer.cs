namespace Gerenciador
{
  partial class frmMigracao_CopiarDados
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
      this.clbTabelas = new System.Windows.Forms.CheckedListBox();
      this.cmdCopiar = new System.Windows.Forms.Button();
      this.cmdFechar = new System.Windows.Forms.Button();
      this.cmdMarcarTodos = new System.Windows.Forms.Button();
      this.cmdDesmarcarTodos = new System.Windows.Forms.Button();
      this.oConexao_Destino = new Gerenciador.uscConexao();
      this.oConexao_Origem = new Gerenciador.uscConexao();
      this.lstMigradas = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // clbTabelas
      // 
      this.clbTabelas.FormattingEnabled = true;
      this.clbTabelas.Location = new System.Drawing.Point(545, 9);
      this.clbTabelas.Name = "clbTabelas";
      this.clbTabelas.Size = new System.Drawing.Size(477, 259);
      this.clbTabelas.TabIndex = 3;
      // 
      // cmdCopiar
      // 
      this.cmdCopiar.Location = new System.Drawing.Point(1032, 240);
      this.cmdCopiar.Name = "cmdCopiar";
      this.cmdCopiar.Size = new System.Drawing.Size(110, 28);
      this.cmdCopiar.TabIndex = 4;
      this.cmdCopiar.Text = "Copiar";
      this.cmdCopiar.UseVisualStyleBackColor = true;
      this.cmdCopiar.Click += new System.EventHandler(this.cmdCopiar_Click);
      // 
      // cmdFechar
      // 
      this.cmdFechar.Location = new System.Drawing.Point(1032, 423);
      this.cmdFechar.Name = "cmdFechar";
      this.cmdFechar.Size = new System.Drawing.Size(110, 28);
      this.cmdFechar.TabIndex = 5;
      this.cmdFechar.Text = "Fechar";
      this.cmdFechar.UseVisualStyleBackColor = true;
      this.cmdFechar.Click += new System.EventHandler(this.cmdFechar_Click);
      // 
      // cmdMarcarTodos
      // 
      this.cmdMarcarTodos.Location = new System.Drawing.Point(1032, 9);
      this.cmdMarcarTodos.Name = "cmdMarcarTodos";
      this.cmdMarcarTodos.Size = new System.Drawing.Size(110, 28);
      this.cmdMarcarTodos.TabIndex = 6;
      this.cmdMarcarTodos.Text = "Marcar todos";
      this.cmdMarcarTodos.UseVisualStyleBackColor = true;
      this.cmdMarcarTodos.Click += new System.EventHandler(this.cmdMarcarTodos_Click);
      // 
      // cmdDesmarcarTodos
      // 
      this.cmdDesmarcarTodos.Location = new System.Drawing.Point(1032, 43);
      this.cmdDesmarcarTodos.Name = "cmdDesmarcarTodos";
      this.cmdDesmarcarTodos.Size = new System.Drawing.Size(110, 28);
      this.cmdDesmarcarTodos.TabIndex = 7;
      this.cmdDesmarcarTodos.Text = "Desmarcar todos";
      this.cmdDesmarcarTodos.UseVisualStyleBackColor = true;
      this.cmdDesmarcarTodos.Click += new System.EventHandler(this.cmdDesmarcarTodos_Click);
      // 
      // oConexao_Destino
      // 
      this.oConexao_Destino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.oConexao_Destino.Legenda = "";
      this.oConexao_Destino.Location = new System.Drawing.Point(275, 5);
      this.oConexao_Destino.Name = "oConexao_Destino";
      this.oConexao_Destino.Size = new System.Drawing.Size(260, 263);
      this.oConexao_Destino.TabIndex = 1;
      // 
      // oConexao_Origem
      // 
      this.oConexao_Origem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.oConexao_Origem.Legenda = "";
      this.oConexao_Origem.Location = new System.Drawing.Point(5, 5);
      this.oConexao_Origem.Name = "oConexao_Origem";
      this.oConexao_Origem.Size = new System.Drawing.Size(260, 263);
      this.oConexao_Origem.TabIndex = 0;
      this.oConexao_Origem.Conectado += new Gerenciador.uscConexao.evento(this.oConexao_Origem_Conectado);
      // 
      // lstMigradas
      // 
      this.lstMigradas.FormattingEnabled = true;
      this.lstMigradas.Location = new System.Drawing.Point(545, 278);
      this.lstMigradas.Name = "lstMigradas";
      this.lstMigradas.Size = new System.Drawing.Size(477, 173);
      this.lstMigradas.TabIndex = 9;
      // 
      // frmMigracao_CopiarDados
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1148, 456);
      this.Controls.Add(this.lstMigradas);
      this.Controls.Add(this.cmdDesmarcarTodos);
      this.Controls.Add(this.cmdMarcarTodos);
      this.Controls.Add(this.cmdFechar);
      this.Controls.Add(this.cmdCopiar);
      this.Controls.Add(this.clbTabelas);
      this.Controls.Add(this.oConexao_Destino);
      this.Controls.Add(this.oConexao_Origem);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MinimizeBox = false;
      this.Name = "frmMigracao_CopiarDados";
      this.Text = "Migração - Copiar Dados";
      this.ResumeLayout(false);

    }

    #endregion

    private uscConexao oConexao_Origem;
    private uscConexao oConexao_Destino;
    private System.Windows.Forms.CheckedListBox clbTabelas;
    private System.Windows.Forms.Button cmdCopiar;
    private System.Windows.Forms.Button cmdFechar;
    private System.Windows.Forms.Button cmdMarcarTodos;
    private System.Windows.Forms.Button cmdDesmarcarTodos;
    private System.Windows.Forms.ListBox lstMigradas;
  }
}