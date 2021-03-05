
namespace FrameworkChallenge.Forms
{
    partial class TabelaForm
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
            this.dataGridPanel = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.filtrosGroupBox = new System.Windows.Forms.GroupBox();
            this.concluidoComboBox = new System.Windows.Forms.ComboBox();
            this.concluidoLabel = new System.Windows.Forms.Label();
            this.corpoTextBox = new System.Windows.Forms.TextBox();
            this.corpoLabel = new System.Windows.Forms.Label();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.idUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.idUsuarioLabel = new System.Windows.Forms.Label();
            this.dataGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.filtrosGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // voltarButton
            // 
            this.voltarButton.Location = new System.Drawing.Point(484, 61);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(81, 60);
            this.voltarButton.TabIndex = 1;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.VoltarButton_Click);
            // 
            // dataGridPanel
            // 
            this.dataGridPanel.Controls.Add(this.dataGridView);
            this.dataGridPanel.Location = new System.Drawing.Point(12, 178);
            this.dataGridPanel.Name = "dataGridPanel";
            this.dataGridPanel.Size = new System.Drawing.Size(553, 375);
            this.dataGridPanel.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(553, 375);
            this.dataGridView.TabIndex = 0;
            // 
            // filtrosGroupBox
            // 
            this.filtrosGroupBox.Controls.Add(this.concluidoComboBox);
            this.filtrosGroupBox.Controls.Add(this.concluidoLabel);
            this.filtrosGroupBox.Controls.Add(this.corpoTextBox);
            this.filtrosGroupBox.Controls.Add(this.corpoLabel);
            this.filtrosGroupBox.Controls.Add(this.tituloTextBox);
            this.filtrosGroupBox.Controls.Add(this.tituloLabel);
            this.filtrosGroupBox.Controls.Add(this.idTextBox);
            this.filtrosGroupBox.Controls.Add(this.idLabel);
            this.filtrosGroupBox.Controls.Add(this.idUsuarioTextBox);
            this.filtrosGroupBox.Controls.Add(this.idUsuarioLabel);
            this.filtrosGroupBox.Location = new System.Drawing.Point(12, 12);
            this.filtrosGroupBox.Name = "filtrosGroupBox";
            this.filtrosGroupBox.Size = new System.Drawing.Size(460, 160);
            this.filtrosGroupBox.TabIndex = 3;
            this.filtrosGroupBox.TabStop = false;
            this.filtrosGroupBox.Text = "Filtrar";
            // 
            // concluidoComboBox
            // 
            this.concluidoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.concluidoComboBox.FormattingEnabled = true;
            this.concluidoComboBox.Items.AddRange(new object[] {
            "Não filtrar",
            "Verdadeiro",
            "Falso"});
            this.concluidoComboBox.Location = new System.Drawing.Point(359, 19);
            this.concluidoComboBox.Name = "concluidoComboBox";
            this.concluidoComboBox.Size = new System.Drawing.Size(95, 24);
            this.concluidoComboBox.TabIndex = 9;
            this.concluidoComboBox.SelectedIndexChanged += new System.EventHandler(this.TextBoxComboBox_TextChangedSelectedIndexChanged);
            // 
            // concluidoLabel
            // 
            this.concluidoLabel.AutoSize = true;
            this.concluidoLabel.Location = new System.Drawing.Point(279, 24);
            this.concluidoLabel.Name = "concluidoLabel";
            this.concluidoLabel.Size = new System.Drawing.Size(74, 17);
            this.concluidoLabel.TabIndex = 8;
            this.concluidoLabel.Text = "Concluído:";
            // 
            // corpoTextBox
            // 
            this.corpoTextBox.Location = new System.Drawing.Point(52, 80);
            this.corpoTextBox.Multiline = true;
            this.corpoTextBox.Name = "corpoTextBox";
            this.corpoTextBox.Size = new System.Drawing.Size(402, 74);
            this.corpoTextBox.TabIndex = 7;
            this.corpoTextBox.TextChanged += new System.EventHandler(this.TextBoxComboBox_TextChangedSelectedIndexChanged);
            // 
            // corpoLabel
            // 
            this.corpoLabel.AutoSize = true;
            this.corpoLabel.Location = new System.Drawing.Point(0, 83);
            this.corpoLabel.Name = "corpoLabel";
            this.corpoLabel.Size = new System.Drawing.Size(50, 17);
            this.corpoLabel.TabIndex = 6;
            this.corpoLabel.Text = "Corpo:";
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.Location = new System.Drawing.Point(52, 49);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(402, 22);
            this.tituloTextBox.TabIndex = 5;
            this.tituloTextBox.TextChanged += new System.EventHandler(this.TextBoxComboBox_TextChangedSelectedIndexChanged);
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Location = new System.Drawing.Point(3, 52);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(47, 17);
            this.tituloLabel.TabIndex = 4;
            this.tituloLabel.Text = "Título:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(204, 21);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(55, 22);
            this.idTextBox.TabIndex = 3;
            this.idTextBox.TextChanged += new System.EventHandler(this.TextBoxComboBox_TextChangedSelectedIndexChanged);
            this.idTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumeric_KeyPress);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(177, 24);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(25, 17);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "ID:";
            // 
            // idUsuarioTextBox
            // 
            this.idUsuarioTextBox.Location = new System.Drawing.Point(103, 21);
            this.idUsuarioTextBox.Name = "idUsuarioTextBox";
            this.idUsuarioTextBox.Size = new System.Drawing.Size(55, 22);
            this.idUsuarioTextBox.TabIndex = 1;
            this.idUsuarioTextBox.TextChanged += new System.EventHandler(this.TextBoxComboBox_TextChangedSelectedIndexChanged);
            this.idUsuarioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumeric_KeyPress);
            // 
            // idUsuarioLabel
            // 
            this.idUsuarioLabel.AutoSize = true;
            this.idUsuarioLabel.Location = new System.Drawing.Point(3, 24);
            this.idUsuarioLabel.Name = "idUsuarioLabel";
            this.idUsuarioLabel.Size = new System.Drawing.Size(98, 17);
            this.idUsuarioLabel.TabIndex = 0;
            this.idUsuarioLabel.Text = "ID do Usuário:";
            // 
            // TabelaForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(577, 565);
            this.Controls.Add(this.filtrosGroupBox);
            this.Controls.Add(this.dataGridPanel);
            this.Controls.Add(this.voltarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TabelaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela";
            this.dataGridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.filtrosGroupBox.ResumeLayout(false);
            this.filtrosGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button voltarButton;
        private System.Windows.Forms.Panel dataGridPanel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox filtrosGroupBox;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idUsuarioTextBox;
        private System.Windows.Forms.Label idUsuarioLabel;
        private System.Windows.Forms.Label concluidoLabel;
        private System.Windows.Forms.TextBox corpoTextBox;
        private System.Windows.Forms.Label corpoLabel;
        private System.Windows.Forms.ComboBox concluidoComboBox;
    }
}
