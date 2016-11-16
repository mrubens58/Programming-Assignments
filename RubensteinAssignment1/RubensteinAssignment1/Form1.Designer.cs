namespace RubensteinAssignment1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cardPictureBox1 = new System.Windows.Forms.PictureBox();
            this.cardPictureBox2 = new System.Windows.Forms.PictureBox();
            this.cardPictureBox3 = new System.Windows.Forms.PictureBox();
            this.cardPictureBox4 = new System.Windows.Forms.PictureBox();
            this.cardPictureBox5 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.displayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // cardPictureBox1
            // 
            this.cardPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("cardPictureBox1.Image")));
            this.cardPictureBox1.Location = new System.Drawing.Point(12, 82);
            this.cardPictureBox1.Name = "cardPictureBox1";
            this.cardPictureBox1.Size = new System.Drawing.Size(177, 240);
            this.cardPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardPictureBox1.TabIndex = 0;
            this.cardPictureBox1.TabStop = false;
            this.cardPictureBox1.Click += new System.EventHandler(this.cardPictureBox1_Click);
            // 
            // cardPictureBox2
            // 
            this.cardPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("cardPictureBox2.Image")));
            this.cardPictureBox2.Location = new System.Drawing.Point(195, 82);
            this.cardPictureBox2.Name = "cardPictureBox2";
            this.cardPictureBox2.Size = new System.Drawing.Size(177, 240);
            this.cardPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardPictureBox2.TabIndex = 1;
            this.cardPictureBox2.TabStop = false;
            this.cardPictureBox2.Click += new System.EventHandler(this.cardPictureBox2_Click);
            // 
            // cardPictureBox3
            // 
            this.cardPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("cardPictureBox3.Image")));
            this.cardPictureBox3.Location = new System.Drawing.Point(378, 82);
            this.cardPictureBox3.Name = "cardPictureBox3";
            this.cardPictureBox3.Size = new System.Drawing.Size(177, 240);
            this.cardPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardPictureBox3.TabIndex = 2;
            this.cardPictureBox3.TabStop = false;
            this.cardPictureBox3.Click += new System.EventHandler(this.cardPictureBox3_Click);
            // 
            // cardPictureBox4
            // 
            this.cardPictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("cardPictureBox4.Image")));
            this.cardPictureBox4.Location = new System.Drawing.Point(561, 82);
            this.cardPictureBox4.Name = "cardPictureBox4";
            this.cardPictureBox4.Size = new System.Drawing.Size(177, 240);
            this.cardPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardPictureBox4.TabIndex = 3;
            this.cardPictureBox4.TabStop = false;
            this.cardPictureBox4.Click += new System.EventHandler(this.cardPictureBox4_Click);
            // 
            // cardPictureBox5
            // 
            this.cardPictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("cardPictureBox5.Image")));
            this.cardPictureBox5.Location = new System.Drawing.Point(744, 82);
            this.cardPictureBox5.Name = "cardPictureBox5";
            this.cardPictureBox5.Size = new System.Drawing.Size(177, 240);
            this.cardPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardPictureBox5.TabIndex = 4;
            this.cardPictureBox5.TabStop = false;
            this.cardPictureBox5.Click += new System.EventHandler(this.cardPictureBox5_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(412, 401);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(108, 38);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Click to Exit";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.messageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTextBox.Location = new System.Drawing.Point(348, 33);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(236, 19);
            this.messageTextBox.TabIndex = 8;
            this.messageTextBox.Text = "Click a Card to See its Name";
            this.messageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // displayLabel
            // 
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(247, 347);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(438, 34);
            this.displayLabel.TabIndex = 9;
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.displayLabel.Click += new System.EventHandler(this.displayLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(932, 451);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.cardPictureBox5);
            this.Controls.Add(this.cardPictureBox4);
            this.Controls.Add(this.cardPictureBox3);
            this.Controls.Add(this.cardPictureBox2);
            this.Controls.Add(this.cardPictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cardPictureBox1;
        private System.Windows.Forms.PictureBox cardPictureBox2;
        private System.Windows.Forms.PictureBox cardPictureBox3;
        private System.Windows.Forms.PictureBox cardPictureBox4;
        private System.Windows.Forms.PictureBox cardPictureBox5;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label displayLabel;
    }
}

