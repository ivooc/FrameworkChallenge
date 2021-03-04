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
            string postsJson = Utils.GetJson("https://jsonplaceholder.typicode.com/posts");
            List<Post> postsList = Utils.JsonToList<Post>(postsJson);
            PostagensForm postagensForm = new PostagensForm(Utils.JsonListToDataTable(postsList));
            Hide();
            postagensForm.ShowDialog(this);
            Show();
        }
    }
}
