
namespace FrameworkChallenge
{
    partial class Menu
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
            this.postagens = new System.Windows.Forms.Button();
            this.albuns = new System.Windows.Forms.Button();
            this.todos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // postagens
            // 
            this.postagens.Location = new System.Drawing.Point(45, 41);
            this.postagens.Name = "postagens";
            this.postagens.Size = new System.Drawing.Size(107, 38);
            this.postagens.TabIndex = 0;
            this.postagens.Text = "Postagens";
            this.postagens.UseVisualStyleBackColor = true;
            // 
            // albuns
            // 
            this.albuns.Location = new System.Drawing.Point(45, 85);
            this.albuns.Name = "albuns";
            this.albuns.Size = new System.Drawing.Size(107, 38);
            this.albuns.TabIndex = 1;
            this.albuns.Text = "Álbuns";
            this.albuns.UseVisualStyleBackColor = true;
            // 
            // todos
            // 
            this.todos.Location = new System.Drawing.Point(45, 129);
            this.todos.Name = "todos";
            this.todos.Size = new System.Drawing.Size(107, 38);
            this.todos.TabIndex = 2;
            this.todos.Text = "To-Dos";
            this.todos.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(198, 215);
            this.Controls.Add(this.todos);
            this.Controls.Add(this.albuns);
            this.Controls.Add(this.postagens);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button postagens;
        private System.Windows.Forms.Button albuns;
        private System.Windows.Forms.Button todos;
    }
}

