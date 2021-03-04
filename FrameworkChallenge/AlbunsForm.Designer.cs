
namespace FrameworkChallenge
{
    partial class AlbunsForm
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
            this.albunsPanel = new System.Windows.Forms.Panel();
            this.albunsView = new System.Windows.Forms.DataGridView();
            this.albunsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albunsView)).BeginInit();
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
            // albunsPanel
            // 
            this.albunsPanel.Controls.Add(this.albunsView);
            this.albunsPanel.Location = new System.Drawing.Point(12, 123);
            this.albunsPanel.Name = "albunsPanel";
            this.albunsPanel.Size = new System.Drawing.Size(553, 315);
            this.albunsPanel.TabIndex = 2;
            // 
            // albunsView
            // 
            this.albunsView.AllowUserToAddRows = false;
            this.albunsView.AllowUserToDeleteRows = false;
            this.albunsView.AllowUserToOrderColumns = true;
            this.albunsView.AllowUserToResizeColumns = false;
            this.albunsView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.albunsView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.albunsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.albunsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.albunsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.albunsView.Location = new System.Drawing.Point(0, 0);
            this.albunsView.Name = "albunsView";
            this.albunsView.ReadOnly = true;
            this.albunsView.RowHeadersVisible = false;
            this.albunsView.RowHeadersWidth = 51;
            this.albunsView.RowTemplate.Height = 24;
            this.albunsView.Size = new System.Drawing.Size(553, 315);
            this.albunsView.TabIndex = 0;
            // 
            // AlbunsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.albunsPanel);
            this.Controls.Add(this.voltarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AlbunsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Álbuns";
            this.albunsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.albunsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button voltarButton;
        private System.Windows.Forms.Panel albunsPanel;
        private System.Windows.Forms.DataGridView albunsView;
    }
}
