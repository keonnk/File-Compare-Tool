
namespace File_Compare
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.addFile1Button = new System.Windows.Forms.Button();
            this.file1TextBox = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.compareButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddDirectory = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Multiselect = true;
            // 
            // addFile1Button
            // 
            this.addFile1Button.BackColor = System.Drawing.Color.DarkOrchid;
            this.addFile1Button.FlatAppearance.BorderSize = 0;
            this.addFile1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFile1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFile1Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addFile1Button.Location = new System.Drawing.Point(3, 3);
            this.addFile1Button.Name = "addFile1Button";
            this.addFile1Button.Size = new System.Drawing.Size(80, 20);
            this.addFile1Button.TabIndex = 0;
            this.addFile1Button.Text = "Add File 1";
            this.addFile1Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addFile1Button.UseVisualStyleBackColor = false;
            this.addFile1Button.Click += new System.EventHandler(this.DynamicButton_Click);
            // 
            // file1TextBox
            // 
            this.file1TextBox.Location = new System.Drawing.Point(89, 3);
            this.file1TextBox.Name = "file1TextBox";
            this.file1TextBox.ReadOnly = true;
            this.file1TextBox.Size = new System.Drawing.Size(204, 20);
            this.file1TextBox.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.Title.ForeColor = System.Drawing.SystemColors.Control;
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(298, 39);
            this.Title.TabIndex = 4;
            this.Title.Text = "File Compare Tool";
            // 
            // compareButton
            // 
            this.compareButton.BackColor = System.Drawing.Color.DarkOrchid;
            this.compareButton.FlatAppearance.BorderSize = 0;
            this.compareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compareButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.compareButton.Location = new System.Drawing.Point(104, 41);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(74, 34);
            this.compareButton.TabIndex = 5;
            this.compareButton.Text = "Compare";
            this.compareButton.UseVisualStyleBackColor = false;
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.addFile1Button);
            this.flowLayoutPanel1.Controls.Add(this.file1TextBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(316, 32);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // AddDirectory
            // 
            this.AddDirectory.BackColor = System.Drawing.Color.DarkOrchid;
            this.AddDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDirectory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddDirectory.Location = new System.Drawing.Point(3, 41);
            this.AddDirectory.Name = "AddDirectory";
            this.AddDirectory.Size = new System.Drawing.Size(95, 34);
            this.AddDirectory.TabIndex = 7;
            this.AddDirectory.Text = "Add Directory";
            this.AddDirectory.UseVisualStyleBackColor = false;
            this.AddDirectory.Click += new System.EventHandler(this.addDirectory_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel2.Controls.Add(this.AddDirectory);
            this.flowLayoutPanel2.Controls.Add(this.compareButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(19, 51);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(325, 105);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(366, 184);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.Title);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "File Compare Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button addFile1Button;
        private System.Windows.Forms.TextBox file1TextBox;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button compareButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button AddDirectory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}

