﻿using System.Data;
using System.Windows.Forms;

namespace FrameworkChallenge.Forms
{
    public partial class PostagensForm : Form
    {
        public PostagensForm(DataTable postsTable)
        {
            InitializeComponent();
            postsTable.Columns["Body"].SetOrdinal(3);
            postagensView.DataSource = postsTable;
            postagensView.Columns[0].HeaderText = "ID do Usuário";
            postagensView.Columns[1].HeaderText = "ID";
            postagensView.Columns[2].HeaderText = "Título";
            postagensView.Columns[3].HeaderText = "Corpo";
        }

        private void VoltarButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}