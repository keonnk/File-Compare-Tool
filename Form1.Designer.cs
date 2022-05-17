
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
            this.addFile2Button = new System.Windows.Forms.Button();
            this.file2TextBox = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.compareButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // addFile1Button
            // 
            this.addFile1Button.BackColor = System.Drawing.Color.DarkOrchid;
            this.addFile1Button.FlatAppearance.BorderSize = 0;
            this.addFile1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFile1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFile1Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addFile1Button.Location = new System.Drawing.Point(12, 105);
            this.addFile1Button.Name = "addFile1Button";
            this.addFile1Button.Size = new System.Drawing.Size(80, 21);
            this.addFile1Button.TabIndex = 0;
            this.addFile1Button.Text = "Add File 1";
            this.addFile1Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addFile1Button.UseVisualStyleBackColor = false;
            this.addFile1Button.Click += new System.EventHandler(this.addFile1Button_Click);
            // 
            // file1TextBox
            // 
            this.file1TextBox.Location = new System.Drawing.Point(98, 105);
            this.file1TextBox.Name = "file1TextBox";
            this.file1TextBox.ReadOnly = true;
            this.file1TextBox.Size = new System.Drawing.Size(204, 20);
            this.file1TextBox.TabIndex = 1;
            // 
            // addFile2Button
            // 
            this.addFile2Button.BackColor = System.Drawing.Color.DarkOrchid;
            this.addFile2Button.FlatAppearance.BorderSize = 0;
            this.addFile2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFile2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFile2Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addFile2Button.Location = new System.Drawing.Point(12, 156);
            this.addFile2Button.Name = "addFile2Button";
            this.addFile2Button.Size = new System.Drawing.Size(80, 20);
            this.addFile2Button.TabIndex = 2;
            this.addFile2Button.Text = "Add File 2";
            this.addFile2Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addFile2Button.UseVisualStyleBackColor = false;
            this.addFile2Button.Click += new System.EventHandler(this.addFile2Button_Click);
            // 
            // file2TextBox
            // 
            this.file2TextBox.Location = new System.Drawing.Point(98, 156);
            this.file2TextBox.Name = "file2TextBox";
            this.file2TextBox.ReadOnly = true;
            this.file2TextBox.Size = new System.Drawing.Size(204, 20);
            this.file2TextBox.TabIndex = 3;
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
            this.compareButton.Location = new System.Drawing.Point(228, 192);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(74, 34);
            this.compareButton.TabIndex = 5;
            this.compareButton.Text = "Compare";
            this.compareButton.UseVisualStyleBackColor = false;
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(316, 261);
            this.Controls.Add(this.compareButton);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.file2TextBox);
            this.Controls.Add(this.addFile2Button);
            this.Controls.Add(this.file1TextBox);
            this.Controls.Add(this.addFile1Button);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "File Compare Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button addFile1Button;
        private System.Windows.Forms.TextBox file1TextBox;
        private System.Windows.Forms.Button addFile2Button;
        private System.Windows.Forms.TextBox file2TextBox;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button compareButton;
    }
}

