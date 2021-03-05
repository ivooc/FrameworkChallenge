
namespace FrameworkChallenge.Forms
{
    partial class TodosForm
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
            this.todosPanel = new System.Windows.Forms.Panel();
            this.todosView = new System.Windows.Forms.DataGridView();
            this.todosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todosView)).BeginInit();
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
            // todosPanel
            // 
            this.todosPanel.Controls.Add(this.todosView);
            this.todosPanel.Location = new System.Drawing.Point(12, 123);
            this.todosPanel.Name = "todosPanel";
            this.todosPanel.Size = new System.Drawing.Size(553, 315);
            this.todosPanel.TabIndex = 2;
            // 
            // todosView
            // 
            this.todosView.AllowUserToAddRows = false;
            this.todosView.AllowUserToDeleteRows = false;
            this.todosView.AllowUserToOrderColumns = true;
            this.todosView.AllowUserToResizeColumns = false;
            this.todosView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.todosView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.todosView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.todosView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.todosView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.todosView.Location = new System.Drawing.Point(0, 0);
            this.todosView.Name = "todosView";
            this.todosView.ReadOnly = true;
            this.todosView.RowHeadersVisible = false;
            this.todosView.RowHeadersWidth = 51;
            this.todosView.RowTemplate.Height = 24;
            this.todosView.Size = new System.Drawing.Size(553, 315);
            this.todosView.TabIndex = 0;
            // 
            // TodosForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.todosPanel);
            this.Controls.Add(this.voltarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TodosForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TO-DOs";
            this.todosPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.todosView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button voltarButton;
        private System.Windows.Forms.Panel todosPanel;
        private System.Windows.Forms.DataGridView todosView;
    }
}
