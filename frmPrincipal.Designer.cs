namespace Gerenciador
{
  partial class frmPrincipal
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.mnuEsquema = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuEsquema_CompararBancoDados = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuEsquema_RestaurarBancoDados = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuMIgracao = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuMIgracao_CopiarDados = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEsquema,
            this.mnuMIgracao});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // mnuEsquema
      // 
      this.mnuEsquema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEsquema_CompararBancoDados,
            this.mnuEsquema_RestaurarBancoDados});
      this.mnuEsquema.Name = "mnuEsquema";
      this.mnuEsquema.Size = new System.Drawing.Size(67, 20);
      this.mnuEsquema.Text = "Esquema";
      // 
      // mnuEsquema_CompararBancoDados
      // 
      this.mnuEsquema_CompararBancoDados.Name = "mnuEsquema_CompararBancoDados";
      this.mnuEsquema_CompararBancoDados.Size = new System.Drawing.Size(215, 22);
      this.mnuEsquema_CompararBancoDados.Text = "Comparar Banco de Dados";
      this.mnuEsquema_CompararBancoDados.Click += new System.EventHandler(this.mnuEsquema_CompararBancoDados_Click);
      // 
      // mnuEsquema_RestaurarBancoDados
      // 
      this.mnuEsquema_RestaurarBancoDados.Name = "mnuEsquema_RestaurarBancoDados";
      this.mnuEsquema_RestaurarBancoDados.Size = new System.Drawing.Size(215, 22);
      this.mnuEsquema_RestaurarBancoDados.Text = "Restaurar Banco de Dados";
      this.mnuEsquema_RestaurarBancoDados.Click += new System.EventHandler(this.mnuEsquema_RestaurarBancoDados_Click);
      // 
      // mnuMIgracao
      // 
      this.mnuMIgracao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMIgracao_CopiarDados});
      this.mnuMIgracao.Name = "mnuMIgracao";
      this.mnuMIgracao.Size = new System.Drawing.Size(69, 20);
      this.mnuMIgracao.Text = "Migração";
      // 
      // mnuMIgracao_CopiarDados
      // 
      this.mnuMIgracao_CopiarDados.Name = "mnuMIgracao_CopiarDados";
      this.mnuMIgracao_CopiarDados.Size = new System.Drawing.Size(145, 22);
      this.mnuMIgracao_CopiarDados.Text = "Copiar Dados";
      this.mnuMIgracao_CopiarDados.Click += new System.EventHandler(this.mnuMigracao_CopiarDados_Click);
      // 
      // toolStrip1
      // 
      this.toolStrip1.Location = new System.Drawing.Point(0, 24);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(800, 25);
      this.toolStrip1.TabIndex = 2;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // frmPrincipal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.menuStrip1);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "frmPrincipal";
      this.Text = "Gerenciador Sql Server";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem mnuEsquema;
    private System.Windows.Forms.ToolStripMenuItem mnuEsquema_CompararBancoDados;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripMenuItem mnuMIgracao;
    private System.Windows.Forms.ToolStripMenuItem mnuMIgracao_CopiarDados;
    private System.Windows.Forms.ToolStripMenuItem mnuEsquema_RestaurarBancoDados;
  }
}