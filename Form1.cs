using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace File_Compare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addFile(int fileChoice) //1 for file1, 2 for file2
        {
            openFileDialog.ShowDialog();

            string fileName = openFileDialog.FileName;

            switch(fileChoice)
            {
                case 1:
                    file1TextBox.Text = fileName;
                    break;

                case 2:
                    file2TextBox.Text = fileName;
                    break;

                default:
                    MessageBox.Show("Add File Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            
        }

        private void addFile1Button_Click(object sender, EventArgs e)
        {
            addFile(1);
        }

        private void addFile2Button_Click(object sender, EventArgs e)
        {
            addFile(2);
        }

        //(Compares files, not including file names, just contents) 
        private void compareButton_Click(object sender, EventArgs e)
        {
            string file1Path = file1TextBox.Text;
            string file2Path = file2TextBox.Text;

            if (!File.Exists(file1Path) || !File.Exists(file2Path))
            {
                MessageBox.Show("Please choose two files to compare", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Turing files into byte arrays
                byte[] file1Bytes = File.ReadAllBytes(file1Path);
                byte[] file2Bytes = File.ReadAllBytes(file2Path);

                using (SHA256 sha256Hash = SHA256.Create())
                {
                    //Computing checksums
                    byte[] file1Hash = sha256Hash.ComputeHash(file1Bytes);
                    byte[] file2Hash = sha256Hash.ComputeHash(file2Bytes);

                    string file1HashString = "";
                    string file2HashString = "";

                    /*
                    for (int i=0; i<file1Hash.Length; i++) //Uses length of either one, because SHA256 hash output is always the same size
                    {
                        file1HashString += file1Hash[i].ToString();
                        file2HashString += file2Hash[i].ToString();
                    }
                    */

                    bool flag = true;

                    //Comparing each byte in hash to see if equal
                    for (int i = 0; i < file1Hash.Length; i++) //Uses length of either one, because SHA256 hash output is always the same size
                    {
                        if (file1Hash[i] == file2Hash[i])
                        {
                            continue;
                        }
                        else
                        {
                            MessageBox.Show("Files are not the same!", "File Compare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            flag = false;
                            break;
                        }
                    }

                    if (flag == true)
                    {
                        MessageBox.Show("Files are identical!", "File Compare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
            }
        }
    }
}
