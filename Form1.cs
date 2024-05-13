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

        public List<KeyValuePair<Button, TextBox>> buttonTextBoxList = new List<KeyValuePair<Button, TextBox>>(); //To keep track of dynamic Button TextBox pairs
        public int rowCount = 1;
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
                    MessageBox.Show("One of the files can't be found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                byte[] bytes = File.ReadAllBytes(files[i]);

                using (SHA256 sha256hash = SHA256.Create())
                {
                    byte[] hash = sha256hash.ComputeHash(bytes);
                    String hashString = Encoding.Default.GetString(hash);
                    checksumHashes.Add(hashString);
                }
            }

            if(files.Count == 0)
            {
                MessageBox.Show("All fields are empty, please add file(s) before comparing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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

        private void Form1_Load(object sender, EventArgs e) 
        {
            buttonTextBoxList.Add(new KeyValuePair<Button, TextBox>(addFilesButton1, TextBox1)); //Adding initial row of components from form designer
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) {}

        /**
         * Dynamically generate new buttons to add new directories, along with corresponding textbox beside it
         */
        private void addDirectory_Click(object sender, EventArgs e)
        {
            rowCount++;

            flowLayoutPanel1.Size = new Size(flowLayoutPanel1.Width, flowLayoutPanel1.Height + 27);
            flowLayoutPanel2.Size = new Size(flowLayoutPanel2.Width, flowLayoutPanel2.Height + 27);
            this.Size = new Size(this.Width, this.Height + 27);

            Button button = new Button();

            button.BackColor = System.Drawing.Color.Azure;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            button.Name = "addFilesButton" + rowCount;
            button.Size = new System.Drawing.Size(140, 20);
            button.TabIndex = 0;
            button.Text = "Add Files From Directory " + rowCount;
            button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            button.UseVisualStyleBackColor = false;

            button.Click += new System.EventHandler(this.DynamicButton_Click);

            TextBox textBox = new TextBox();
            textBox.Name = "TextBox" + rowCount;
            textBox.ReadOnly = true;
            textBox.Size = new System.Drawing.Size(204, 20);
            textBox.TabIndex = 1;

            flowLayoutPanel1.Controls.Add(button);
            flowLayoutPanel1.Controls.Add(textBox);

            buttonTextBoxList.Add(new KeyValuePair<Button, TextBox>(button, textBox));
        }

        private void DynamicButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            openFileDialog.ShowDialog();

            TextBox textbox = buttonTextBoxList.Where(kvp => kvp.Key.Equals(btn)).First().Value;

            for(int i=0; i<openFileDialog.FileNames.Length; i++)
            {
                textbox.Text += openFileDialog.FileNames[i] + ", ";
                files.Add(openFileDialog.FileNames[i]);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            for(int i=0; i<buttonTextBoxList.Count; i++)
            {
                buttonTextBoxList[i].Value.Text = ""; //Clear all text boxes
            }

            //buttonTextBoxList.Clear();
            files.Clear();
        }
    }
}
