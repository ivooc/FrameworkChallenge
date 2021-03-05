using System.Data;
using System.Windows.Forms;

namespace FrameworkChallenge.Forms
{
    public partial class TabelaForm : Form
    {
        public enum PostType { Post, Album, Todo }
        private readonly PostType _currentType;
        private readonly DataTable _table;
        public TabelaForm(DataTable table, PostType currentType)
        {
            InitializeComponent();
            _currentType = currentType;
            _table = table;
            if (_currentType == PostType.Album)
            {
                Text = "Álbuns";
                corpoLabel.Visible = corpoTextBox.Visible = concluidoLabel.Visible = concluidoComboBox.Visible = false;
                idUsuarioLabel.Top += 28;
                idUsuarioTextBox.Top += 28;
                idLabel.Top += 28;
                idTextBox.Top += 28;
                tituloLabel.Top += 28;
                tituloTextBox.Top += 28;
            }
            else if (_currentType == PostType.Post)
            {
                Text = "Postagens";
                concluidoLabel.Visible = concluidoComboBox.Visible = false;
                _table.Columns[0].SetOrdinal(3);
            }
            else
            {
                Text = "TO-DOs";
                corpoLabel.Visible = corpoTextBox.Visible = false;
                _table.Columns[0].SetOrdinal(3);
                idUsuarioLabel.Top += 28;
                idUsuarioTextBox.Top += 28;
                idLabel.Top += 28;
                idTextBox.Top += 28;
                tituloLabel.Top += 28;
                tituloTextBox.Top += 28;
                concluidoLabel.Top += 28;
                concluidoComboBox.Top += 28;
            }
            dataGridView.DataSource = _table;
            dataGridView.Columns[0].HeaderText = "ID do Usuário";
            dataGridView.Columns[1].HeaderText = "ID";
            dataGridView.Columns[2].HeaderText = "Título";
            if (_currentType != PostType.Album)
                dataGridView.Columns[3].HeaderText = _currentType == PostType.Post ? "Corpo" : "Concluído";
            concluidoComboBox.SelectedIndex = 0;
        }

        private void VoltarButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void OnlyNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBoxComboBox_TextChangedSelectedIndexChanged(object sender, System.EventArgs e)
        {
            bool filterCompleted = concluidoComboBox.SelectedIndex > 0;
            bool completed = concluidoComboBox.SelectedIndex == 1;
            _table.DefaultView.RowFilter = Utils.GetFilter(idUsuarioTextBox.Text, idTextBox.Text,
                tituloTextBox.Text, corpoTextBox.Text, filterCompleted, completed);
        }
    }
}
