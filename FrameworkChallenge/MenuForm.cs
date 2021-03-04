using System;
using System.Windows.Forms;

namespace FrameworkChallenge
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void PostagensButton_Click(object sender, EventArgs e)
        {
            PostagensForm postagensForm = new PostagensForm(Utils.GetJsonToDataTable<Post>("https://jsonplaceholder.typicode.com/posts"));
            Hide();
            postagensForm.ShowDialog(this);
            Show();
        }

        private void AlbunsButton_Click(object sender, EventArgs e)
        {
            AlbunsForm albumsForm = new AlbunsForm(Utils.GetJsonToDataTable<Album>("https://jsonplaceholder.typicode.com/albums"));
            Hide();
            albumsForm.ShowDialog(this);
            Show();
        }
    }
}
