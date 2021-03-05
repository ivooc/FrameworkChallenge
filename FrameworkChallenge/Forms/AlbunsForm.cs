using System.Data;
using System.Windows.Forms;

namespace FrameworkChallenge.Forms
{
    public partial class AlbunsForm : Form
    {
        public AlbunsForm(DataTable albumsTable)
        {
            InitializeComponent();
            albunsView.DataSource = albumsTable;
            albunsView.Columns[0].HeaderText = "ID do Usuário";
            albunsView.Columns[1].HeaderText = "ID";
            albunsView.Columns[2].HeaderText = "Título";
        }

        private void VoltarButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
