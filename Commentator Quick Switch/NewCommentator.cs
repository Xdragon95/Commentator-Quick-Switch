using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commentator_Quick_Switch
{
    public partial class NewCommentator : Form
    {
        public string CommentatorName { get; set; }
        public string CommentatorTwitter { get; set; }
        public NewCommentator()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Name.Text == "" || Twitter.Text == "")
            {
                MessageBox.Show("Fill out Both boxes.");
            }
            else
            {
                CommentatorName = Name.Text;
                CommentatorTwitter = Twitter.Text;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
