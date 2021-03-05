using FrameworkChallenge.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace FrameworkChallenge.Forms
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void PostagensButton_Click(object sender, EventArgs e)
        {
            postagensButton.Cursor = Cursors.WaitCursor;
            DataTable postsTable = Utils.GetJsonToDataTable<Post>("https://jsonplaceholder.typicode.com/posts", out string mensagemErro);
            postagensButton.Cursor = Cursors.Default;
            if (mensagemErro != string.Empty)
            {
                MessageBox.Show($"Erro ao tentar conectar ao servidor. Verifique sua conexão com a internet.\n{mensagemErro}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PostagensForm postagensForm = new PostagensForm(postsTable);
            Hide();
            postagensForm.ShowDialog(this);
            Show();
        }

        private void AlbunsButton_Click(object sender, EventArgs e)
        {
            albunsButton.Cursor = Cursors.WaitCursor;
            DataTable albunsTable = Utils.GetJsonToDataTable<Album>("https://jsonplaceholder.typicode.com/albums", out string mensagemErro);
            albunsButton.Cursor = Cursors.Default;
            if (mensagemErro != string.Empty)
            {
                MessageBox.Show($"Erro ao tentar conectar ao servidor. Verifique sua conexão com a internet.\n{mensagemErro}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AlbunsForm albumsForm = new AlbunsForm(albunsTable);
            Hide();
            albumsForm.ShowDialog(this);
            Show();
        }

        private void TodosButton_Click(object sender, EventArgs e)
        {
            todosButton.Cursor = Cursors.WaitCursor;
            DataTable todosTable = Utils.GetJsonToDataTable<Todo>("https://jsonplaceholder.typicode.com/todos", out string mensagemErro);
            todosButton.Cursor = Cursors.Default;
            if (mensagemErro != string.Empty)
            {
                MessageBox.Show($"Erro ao tentar conectar ao servidor. Verifique sua conexão com a internet.\n{mensagemErro}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TodosForm todosForm = new TodosForm(todosTable);
            Hide();
            todosForm.ShowDialog(this);
            Show();
        }
    }
}
