
namespace FrameworkChallenge.Forms
{
    partial class PostagensForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.voltarButton = new System.Windows.Forms.Button();
            this.postagensPanel = new System.Windows.Forms.Panel();
            this.postagensView = new System.Windows.Forms.DataGridView();
            this.postagensPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postagensView)).BeginInit();
            this.SuspendLayout();
            // 
            // voltarButton
            // 
            this.voltarButton.Location = new System.Drawing.Point(485, 12);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(81, 36);
            this.voltarButton.TabIndex = 1;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.VoltarButton_Click);
            // 
            // postagensPanel
            // 
            this.postagensPanel.Controls.Add(this.postagensView);
            this.postagensPanel.Location = new System.Drawing.Point(12, 123);
            this.postagensPanel.Name = "postagensPanel";
            this.postagensPanel.Size = new System.Drawing.Size(553, 315);
            this.postagensPanel.TabIndex = 2;
            // 
            // postagensView
            // 
            this.postagensView.AllowUserToAddRows = false;
            this.postagensView.AllowUserToDeleteRows = false;
            this.postagensView.AllowUserToOrderColumns = true;
            this.postagensView.AllowUserToResizeColumns = false;
            this.postagensView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.postagensView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.postagensView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.postagensView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.postagensView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postagensView.Location = new System.Drawing.Point(0, 0);
            this.postagensView.Name = "postagensView";
            this.postagensView.ReadOnly = true;
            this.postagensView.RowHeadersVisible = false;
            this.postagensView.RowHeadersWidth = 51;
            this.postagensView.RowTemplate.Height = 24;
            this.postagensView.Size = new System.Drawing.Size(553, 315);
            this.postagensView.TabIndex = 0;
            // 
            // PostagensForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.postagensPanel);
            this.Controls.Add(this.voltarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PostagensForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Postagens";
            this.postagensPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.postagensView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button voltarButton;
        private System.Windows.Forms.Panel postagensPanel;
        private System.Windows.Forms.DataGridView postagensView;
    }
}
