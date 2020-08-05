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

        public void Sort(string x)
        {
            int counter = 0;
            string folderLocation = textRoot.Text;

            string prefix = textPrefix.Text;
            if (string.IsNullOrWhiteSpace(textPrefix.Text))
            {
                prefix = " ";
            }
            DirectoryInfo d = new DirectoryInfo(folderLocation);
            FileInfo[] infos = d.GetFiles();
            foreach (FileInfo f in infos)
            {
                if  (checkFileType.Checked)
                {
                    if (!File.Exists(folderLocation + "\\" + prefix + counter.ToString() + x) && f.FullName.Contains(x))
                    {
                        File.Move(f.FullName, Path.Combine(f.DirectoryName, prefix + counter.ToString() + x));
                        counter++;
                    }
                    else
                        counter++;
                }
                else
                {
                    if (!File.Exists(folderLocation + "\\" + prefix + counter.ToString() + x))
                    {
                        File.Move(f.FullName, Path.Combine(f.DirectoryName, prefix + counter.ToString() + x));
                        counter++;
                    }
                    else
                        counter++;
                }

            }
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
            if (comboSort.Text.Equals("Sort JPG")){
                Sort(".jpg");
            }

            else if (comboSort.Text.Equals("Sort Video (mp4)"))
            {
                Sort(".mp4");
            }
            else if (comboSort.Text.Equals("Sort PDF"))
            {
                Sort(".pdf");
            }

            else
            {
                string fileType = Prompt.ShowDialog("Custom File Type", "Input a file type");
                Sort(fileType);

            }

            MessageBox.Show("Completed Sort. Press OK to continue.");


        }

        private void textRoot_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkFileType_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
