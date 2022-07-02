using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Commentator_Quick_Switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string NamePlaceholder = "";
        string TwitterPlaceholder = "";
        private void button6_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();

                string[] dirs = Directory.GetDirectories(folderBrowserDialog.SelectedPath);

                foreach(string dir in dirs)
                {
                    listBox1.Items.Add(Path.GetFileName(dir));
                }
                FolderDirectory.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void SetLeftbtn_Click(object sender, EventArgs e)
        {
            if (FolderDirectory.Text == "" || listBox1.SelectedItem == "")
            { 

            }
            else
            {
                LeftName.Text = File.ReadAllText(FolderDirectory.Text + "\\" + listBox1.SelectedItem + "\\" + "Name.txt");
                LeftTwitter.Text = File.ReadAllText(FolderDirectory.Text + "\\" + listBox1.SelectedItem + "\\" + "Twitter.txt");
                Savebtn.PerformClick();
            }
        }

        private void SetRightbtn_Click(object sender, EventArgs e)
        {
            if (FolderDirectory.Text == "" || listBox1.SelectedItem == "")
            {
            
            }
            else
            {
                RightName.Text = File.ReadAllText(FolderDirectory.Text + "\\" + listBox1.SelectedItem + "\\" + "Name.txt");
                RightTwitter.Text = File.ReadAllText(FolderDirectory.Text + "\\" + listBox1.SelectedItem + "\\" + "Twitter.txt");
                Savebtn.PerformClick();
            }
        }

        private void NewCommentatorbtn_Click(object sender, EventArgs e)
        {
            if (FolderDirectory.Text == "")
            {
                MessageBox.Show("Specify a folder to create your new commentator.");
            }
            else
            {
                NewCommentator customDialog = new NewCommentator();

                if (customDialog.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Add(customDialog.CommentatorName);
                    System.IO.Directory.CreateDirectory(FolderDirectory.Text + "\\" + customDialog.CommentatorName);
                    System.IO.File.WriteAllText(FolderDirectory.Text + "\\" + customDialog.CommentatorName + "\\" + "Name.txt", customDialog.CommentatorName);
                    System.IO.File.WriteAllText(FolderDirectory.Text + "\\" + customDialog.CommentatorName + "\\" + "Twitter.txt", customDialog.CommentatorTwitter);
                }
            }
        }

        private void Switchbtn_Click(object sender, EventArgs e)
        {
            NamePlaceholder = LeftName.Text;
            TwitterPlaceholder = LeftTwitter.Text;
            LeftName.Text = RightName.Text;
            LeftTwitter.Text = RightTwitter.Text;
            RightName.Text = NamePlaceholder;
            RightTwitter.Text = TwitterPlaceholder;
            Savebtn.PerformClick();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (FolderDirectory.Text == "")
            {

            }
            else
            {
                System.IO.File.WriteAllText(FolderDirectory.Text + "//" + "Left Name.txt", LeftName.Text);
                System.IO.File.WriteAllText(FolderDirectory.Text + "//" + "Left Twitter.txt", LeftTwitter.Text);
                System.IO.File.WriteAllText(FolderDirectory.Text + "//" + "Right Name.txt", RightName.Text);
                System.IO.File.WriteAllText(FolderDirectory.Text + "//" + "Right Twitter.txt", RightTwitter.Text);
            }
        }
    }
}
