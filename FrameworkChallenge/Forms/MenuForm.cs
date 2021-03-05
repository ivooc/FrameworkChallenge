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

        private void AbrirTabelaButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            TabelaForm.PostType currentType;
            if (button.Text == "Postagens")
                currentType = TabelaForm.PostType.Post;
            else if (button.Text == "Álbuns")
                currentType = TabelaForm.PostType.Album;
            else
                currentType = TabelaForm.PostType.Todo;
            DataTable table;
            string mensagemErro;
            button.Cursor = Cursors.WaitCursor;
            if (currentType == TabelaForm.PostType.Post)
                table = Utils.GetJsonToDataTable<Post>("https://jsonplaceholder.typicode.com/posts", out mensagemErro);
            else if (currentType == TabelaForm.PostType.Album)
                table = Utils.GetJsonToDataTable<Album>("https://jsonplaceholder.typicode.com/albums", out mensagemErro);
            else
                table = Utils.GetJsonToDataTable<Todo>("https://jsonplaceholder.typicode.com/todos", out mensagemErro);
            button.Cursor = Cursors.Default;
            if (mensagemErro != string.Empty)
            {
                MessageBox.Show($"Erro ao tentar conectar ao servidor. Verifique sua conexão com a internet.\n{mensagemErro}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TabelaForm form = new TabelaForm(table, currentType);
            Hide();
            form.ShowDialog(this);
            Show();
        }
    }
}
