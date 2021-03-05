using System.Data;
using System.Windows.Forms;

namespace FrameworkChallenge.Forms
{
    public partial class TabelaForm : Form
    {
        public enum PostType { Post, Album, Todo }
        private readonly PostType _currentType;
        public TabelaForm(DataTable table, PostType currentType)
        {
            InitializeComponent();
            _currentType = currentType;
            if (_currentType == PostType.Album)
                Text = "Álbuns";
            else if (_currentType == PostType.Post)
            {
                Text = "Postagens";
                table.Columns[0].SetOrdinal(3);
            }
            else
            {
                Text = "TO-DOs";
                table.Columns[0].SetOrdinal(3);
            }
            dataGridView.DataSource = table;
            dataGridView.Columns[0].HeaderText = "ID do Usuário";
            dataGridView.Columns[1].HeaderText = "ID";
            dataGridView.Columns[2].HeaderText = "Título";
            if (_currentType != PostType.Album)
                dataGridView.Columns[3].HeaderText = _currentType == PostType.Post ? "Corpo" : "Concluído";
        }

        private void VoltarButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
