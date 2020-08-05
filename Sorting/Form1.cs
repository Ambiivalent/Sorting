using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form();
                prompt.Width = 500;
                prompt.Height = 500;
                prompt.Text = caption;
                Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
                TextBox inputBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
                Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70 };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(inputBox);
                prompt.ShowDialog();
                return inputBox.Text;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Path = null;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                Path = fbd.SelectedPath;
            textRoot.Text = Path;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void comboSort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string sortValue = comboSort.Text;
            string folderLocation = textRoot.Text;

            if (sortValue.Equals("Sort JPG")){
                string prefix = textPrefix.Text;
                if (string.IsNullOrWhiteSpace(textPrefix.Text))
                {
                    prefix = " ";
                }
                DirectoryInfo d = new DirectoryInfo(folderLocation);
                FileInfo[] infos = d.GetFiles();
                foreach (FileInfo f in infos)
                {
                    if (!File.Exists(folderLocation + "\\" + prefix + counter.ToString() + ".jpg"))
                    {
                        File.Move(f.FullName, Path.Combine(f.DirectoryName, prefix + counter.ToString() + ".jpg"));
                        counter++;
                    }
                    else
                        counter++;
                    
                }

            }

            else if (sortValue.Equals("Sort Video (mp4)"))
            {
                string prefix = textPrefix.Text;
                if (string.IsNullOrWhiteSpace(textPrefix.Text))
                {
                    prefix = " ";
                }
                DirectoryInfo d = new DirectoryInfo(folderLocation);
                FileInfo[] infos = d.GetFiles();
                foreach (FileInfo f in infos)
                {
                    if (!File.Exists(folderLocation + "\\" + prefix + counter.ToString() + ".mp4"))
                    {
                        File.Move(f.FullName, Path.Combine(f.DirectoryName, prefix + counter.ToString() + ".mp4"));
                        counter++;
                    }
                    else
                        counter++;
                }

            }
            else if (sortValue.Equals("Sort PDF"))
            {
                string prefix = textPrefix.Text;
                if (string.IsNullOrWhiteSpace(textPrefix.Text))
                {
                    prefix = " ";
                }
                DirectoryInfo d = new DirectoryInfo(folderLocation);
                FileInfo[] infos = d.GetFiles();
                foreach (FileInfo f in infos)
                {
                    if (!File.Exists(folderLocation + "\\" + prefix + counter.ToString() + ".pdf"))
                    {
                        File.Move(f.FullName, Path.Combine(f.DirectoryName, prefix + counter.ToString() + ".pdf"));
                        counter++;
                    }
                    else
                        counter++;
                }

            }

            else
            {
                string fileType = Prompt.ShowDialog("Custom File Type", "Input a file type");
                string prefix = textPrefix.Text;
                if (string.IsNullOrWhiteSpace(textPrefix.Text))
                {
                    prefix = " ";
                }
                DirectoryInfo d = new DirectoryInfo(folderLocation);
                FileInfo[] infos = d.GetFiles();
                foreach (FileInfo f in infos)
                {
                    if (!File.Exists(folderLocation + "\\" + prefix + counter.ToString() + fileType))
                    {
                        File.Move(f.FullName, Path.Combine(f.DirectoryName, prefix + counter.ToString() + fileType));
                        counter++;
                    }
                    else
                        counter++;
                }

            }

            MessageBox.Show("Complete");


        }

        private void textRoot_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
