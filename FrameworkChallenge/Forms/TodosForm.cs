using System.Data;
using System.Windows.Forms;

namespace FrameworkChallenge.Forms
{
    public partial class TodosForm : Form
    {
        public TodosForm(DataTable todosTable)
        {
            InitializeComponent();
            todosTable.Columns["Completed"].SetOrdinal(3);
            todosView.DataSource = todosTable;
            todosView.Columns[0].HeaderText = "ID do Usuário";
            todosView.Columns[1].HeaderText = "ID";
            todosView.Columns[2].HeaderText = "Título";
            todosView.Columns[3].HeaderText = "Concluído";
        }

        private void VoltarButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
