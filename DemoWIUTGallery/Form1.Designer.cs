namespace DemoWIUTGallery
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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.connDbBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(239, 237);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(60, 28);
            this.deleteBtn.TabIndex = 19;
            this.deleteBtn.Text = "X";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // idTextBox1
            // 
            this.idTextBox1.Location = new System.Drawing.Point(372, 283);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(87, 20);
            this.idTextBox1.TabIndex = 18;
            this.idTextBox1.Visible = false;
            // 
            // connDbBtn
            // 
            this.connDbBtn.Location = new System.Drawing.Point(2, 2);
            this.connDbBtn.Name = "connDbBtn";
            this.connDbBtn.Size = new System.Drawing.Size(147, 28);
            this.connDbBtn.TabIndex = 17;
            this.connDbBtn.Text = "Connect and create table";
            this.connDbBtn.UseVisualStyleBackColor = true;
            this.connDbBtn.Click += new System.EventHandler(this.connDbBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(30, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name of photo";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(140, 95);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(146, 33);
            this.nameTextBox.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(336, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(336, 237);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(182, 28);
            this.browseBtn.TabIndex = 13;
            this.browseBtn.Text = "Add new photo";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(126, 237);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(91, 28);
            this.viewBtn.TabIndex = 12;
            this.viewBtn.Text = "View>>";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(19, 237);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(91, 28);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 330);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.idTextBox1);
            this.Controls.Add(this.connDbBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.saveBtn);
            this.Name = "Form1";
            this.Text = "WIUTGallery";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.Button connDbBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button saveBtn;
    }
}

