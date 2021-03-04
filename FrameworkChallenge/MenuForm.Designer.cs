
namespace FrameworkChallenge
{
    partial class MenuForm
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.postagensButton = new System.Windows.Forms.Button();
            this.albunsButton = new System.Windows.Forms.Button();
            this.todosButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // postagensButton
            // 
            this.postagensButton.Location = new System.Drawing.Point(45, 41);
            this.postagensButton.Name = "postagensButton";
            this.postagensButton.Size = new System.Drawing.Size(107, 38);
            this.postagensButton.TabIndex = 0;
            this.postagensButton.Text = "Postagens";
            this.postagensButton.UseVisualStyleBackColor = true;
            this.postagensButton.Click += new System.EventHandler(this.PostagensButton_Click);
            // 
            // albunsButton
            // 
            this.albunsButton.Location = new System.Drawing.Point(45, 85);
            this.albunsButton.Name = "albunsButton";
            this.albunsButton.Size = new System.Drawing.Size(107, 38);
            this.albunsButton.TabIndex = 1;
            this.albunsButton.Text = "Álbuns";
            this.albunsButton.UseVisualStyleBackColor = true;
            this.albunsButton.Click += new System.EventHandler(this.AlbunsButton_Click);
            // 
            // todosButton
            // 
            this.todosButton.Location = new System.Drawing.Point(45, 129);
            this.todosButton.Name = "todosButton";
            this.todosButton.Size = new System.Drawing.Size(107, 38);
            this.todosButton.TabIndex = 2;
            this.todosButton.Text = "To-Dos";
            this.todosButton.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(198, 215);
            this.Controls.Add(this.todosButton);
            this.Controls.Add(this.albunsButton);
            this.Controls.Add(this.postagensButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button postagensButton;
        private System.Windows.Forms.Button albunsButton;
        private System.Windows.Forms.Button todosButton;
    }
}

