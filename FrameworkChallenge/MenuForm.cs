using System;
using System.Collections.Generic;
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
            List<Post> postsList = Utils.GetJsonToList<Post>("https://jsonplaceholder.typicode.com/posts");
            PostagensForm postagensForm = new PostagensForm(Utils.JsonListToDataTable(postsList));
            Hide();
            postagensForm.ShowDialog(this);
            Show();
        }

        private void AlbunsButton_Click(object sender, EventArgs e)
        {
            List<Album> albumsList = Utils.GetJsonToList<Album>("https://jsonplaceholder.typicode.com/albums");
            AlbunsForm albumsForm = new AlbunsForm(Utils.JsonListToDataTable(albumsList));
            Hide();
            albumsForm.ShowDialog(this);
            Show();
        }
    }
}
