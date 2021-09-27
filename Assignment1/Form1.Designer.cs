
namespace Assignment1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.childCountBox = new System.Windows.Forms.TextBox();
            this.studentCountBox = new System.Windows.Forms.TextBox();
            this.adultCountBox = new System.Windows.Forms.TextBox();
            this.childCountLabel = new System.Windows.Forms.Label();
            this.studentCountLabel = new System.Windows.Forms.Label();
            this.adultCountLabel = new System.Windows.Forms.Label();
            this.cashierNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(129, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(546, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(315, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 782);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.cashierNameBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 775);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.childCountBox);
            this.groupBox1.Controls.Add(this.studentCountBox);
            this.groupBox1.Controls.Add(this.adultCountBox);
            this.groupBox1.Controls.Add(this.childCountLabel);
            this.groupBox1.Controls.Add(this.studentCountLabel);
            this.groupBox1.Controls.Add(this.adultCountLabel);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(67, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 252);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets";
            // 
            // childCountBox
            // 
            this.childCountBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.childCountBox.Location = new System.Drawing.Point(418, 173);
            this.childCountBox.Name = "childCountBox";
            this.childCountBox.Size = new System.Drawing.Size(120, 39);
            this.childCountBox.TabIndex = 5;
            this.childCountBox.Text = "0";
            this.childCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // studentCountBox
            // 
            this.studentCountBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentCountBox.Location = new System.Drawing.Point(418, 119);
            this.studentCountBox.Name = "studentCountBox";
            this.studentCountBox.Size = new System.Drawing.Size(120, 39);
            this.studentCountBox.TabIndex = 4;
            this.studentCountBox.Text = "0";
            this.studentCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adultCountBox
            // 
            this.adultCountBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adultCountBox.Location = new System.Drawing.Point(418, 65);
            this.adultCountBox.Name = "adultCountBox";
            this.adultCountBox.Size = new System.Drawing.Size(120, 39);
            this.adultCountBox.TabIndex = 3;
            this.adultCountBox.Text = "0";
            this.adultCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // childCountLabel
            // 
            this.childCountLabel.AutoSize = true;
            this.childCountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.childCountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.childCountLabel.Location = new System.Drawing.Point(184, 175);
            this.childCountLabel.Name = "childCountLabel";
            this.childCountLabel.Size = new System.Drawing.Size(72, 32);
            this.childCountLabel.TabIndex = 2;
            this.childCountLabel.Text = "Child";
            // 
            // studentCountLabel
            // 
            this.studentCountLabel.AutoSize = true;
            this.studentCountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.studentCountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.studentCountLabel.Location = new System.Drawing.Point(159, 121);
            this.studentCountLabel.Name = "studentCountLabel";
            this.studentCountLabel.Size = new System.Drawing.Size(102, 32);
            this.studentCountLabel.TabIndex = 1;
            this.studentCountLabel.Text = "Student";
            // 
            // adultCountLabel
            // 
            this.adultCountLabel.AutoSize = true;
            this.adultCountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adultCountLabel.Location = new System.Drawing.Point(184, 67);
            this.adultCountLabel.Name = "adultCountLabel";
            this.adultCountLabel.Size = new System.Drawing.Size(77, 32);
            this.adultCountLabel.TabIndex = 0;
            this.adultCountLabel.Text = "Adult";
            this.adultCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cashierNameBox
            // 
            this.cashierNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cashierNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cashierNameBox.Location = new System.Drawing.Point(369, 64);
            this.cashierNameBox.Name = "cashierNameBox";
            this.cashierNameBox.Size = new System.Drawing.Size(302, 39);
            this.cashierNameBox.TabIndex = 1;
            this.cashierNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(67, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cashier Name\r\n\r\n\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 784);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Welcome to Mega Cinema";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label childCountLabel;
        private System.Windows.Forms.Label studentCountLabel;
        private System.Windows.Forms.Label adultCountLabel;
        private System.Windows.Forms.TextBox cashierNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adultCountBox;
        private System.Windows.Forms.TextBox childCountBox;
        private System.Windows.Forms.TextBox studentCountBox;
    }
}

