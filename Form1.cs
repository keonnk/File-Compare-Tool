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
using System.Collections;

namespace File_Compare
{
    public partial class Form1 : Form
    {
        //ArrayList buttons = new ArrayList();
        public List<String> files = new List<String>();

        public Form1()
        {
            InitializeComponent();
        }

        //(Compares files, not including file names, just contents) 
        private void compareButton_Click(object sender, EventArgs e)
        {
            List<String> checksumHashes = new List<String>();

            for(int i = 0; i<files.Count; i++)
            {
                if (!File.Exists(files[i]))
                {
                    MessageBox.Show("Error, one of the files can't be found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                byte[] bytes = File.ReadAllBytes(files[i]);

                using (SHA256 sha256hash = SHA256.Create())
                {
                    byte[] hash = sha256hash.ComputeHash(bytes);
                    String hashString = Encoding.Default.GetString(hash);
                    checksumHashes.Add(hashString);
                }
            }

            String exampleChecksum = checksumHashes.First(); //Will be used to compare with all the others

            for (int i = 0; i<checksumHashes.Count; i++)
            {
                if (!(checksumHashes[i] == exampleChecksum))
                {
                    MessageBox.Show("Files are not the same!", "File Compare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            MessageBox.Show("Files are all identical!", "File Compare", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e) {}

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) {}

        /**
         * Dynamically generate new buttons to add new directories
         */
        private void addDirectory_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Size = new Size(flowLayoutPanel1.Width, flowLayoutPanel1.Height + 20);
            flowLayoutPanel2.Size = new Size(flowLayoutPanel2.Width, flowLayoutPanel2.Height + 20);
            this.Size = new Size(this.Width, this.Height + 20);

            Button button = new Button();

            button.BackColor = System.Drawing.Color.DarkOrchid;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            //button.Location = new System.Drawing.Point(3, 3);
            button.Name = "addFile1Button";
            button.Size = new System.Drawing.Size(80, 21);
            button.TabIndex = 0;
            button.Text = "Add File 1";
            button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            button.UseVisualStyleBackColor = false;

            button.Click += new System.EventHandler(this.DynamicButton_Click);


            TextBox textBox = new TextBox();
            //this.file1TextBox.Location = new System.Drawing.Point(89, 3);
            this.file1TextBox.Name = "file1TextBox";
            this.file1TextBox.ReadOnly = true;
            this.file1TextBox.Size = new System.Drawing.Size(204, 20);
            this.file1TextBox.TabIndex = 1;

            flowLayoutPanel1.Controls.Add(button);
            flowLayoutPanel1.Controls.Add(textBox);
        }

        private void DynamicButton_Click(object sender, EventArgs e)
        {
            //Button btn = sender as Button;

            openFileDialog.ShowDialog();

            for(int i= 0; i < openFileDialog.FileNames.Length; i++)
            {
                files.Add(openFileDialog.FileNames[i]);
            }

            //TODO: Put file names in respective textbox
        }
    }
}
