namespace DrinkMachine
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.colaLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colaPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rootbeerLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rootbeerPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lemonlimeLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lemonlimePictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grapeLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.grapePictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.creamLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.creamPictureBox = new System.Windows.Forms.PictureBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colaPictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rootbeerPictureBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lemonlimePictureBox)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grapePictureBox)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creamPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Drink";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.colaLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.colaPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // colaLabel
            // 
            this.colaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colaLabel.Location = new System.Drawing.Point(86, 62);
            this.colaLabel.Name = "colaLabel";
            this.colaLabel.Size = new System.Drawing.Size(83, 23);
            this.colaLabel.TabIndex = 3;
            this.colaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(86, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Drinks Left:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "$1.00";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colaPictureBox
            // 
            this.colaPictureBox.Image = global::DrinkMachine.Properties.Resources.Cola;
            this.colaPictureBox.Location = new System.Drawing.Point(16, 19);
            this.colaPictureBox.Name = "colaPictureBox";
            this.colaPictureBox.Size = new System.Drawing.Size(64, 64);
            this.colaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.colaPictureBox.TabIndex = 0;
            this.colaPictureBox.TabStop = false;
            this.colaPictureBox.Click += new System.EventHandler(this.colaPictureBox_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rootbeerLabel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.rootbeerPictureBox);
            this.groupBox2.Location = new System.Drawing.Point(203, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // rootbeerLabel
            // 
            this.rootbeerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rootbeerLabel.Location = new System.Drawing.Point(86, 62);
            this.rootbeerLabel.Name = "rootbeerLabel";
            this.rootbeerLabel.Size = new System.Drawing.Size(83, 23);
            this.rootbeerLabel.TabIndex = 3;
            this.rootbeerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(86, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Drinks Left:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(86, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "$1.00";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rootbeerPictureBox
            // 
            this.rootbeerPictureBox.Image = global::DrinkMachine.Properties.Resources.RootBeer;
            this.rootbeerPictureBox.Location = new System.Drawing.Point(16, 19);
            this.rootbeerPictureBox.Name = "rootbeerPictureBox";
            this.rootbeerPictureBox.Size = new System.Drawing.Size(64, 64);
            this.rootbeerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rootbeerPictureBox.TabIndex = 0;
            this.rootbeerPictureBox.TabStop = false;
            this.rootbeerPictureBox.Click += new System.EventHandler(this.rootbeerPictureBox_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lemonlimeLabel);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lemonlimePictureBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // lemonlimeLabel
            // 
            this.lemonlimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lemonlimeLabel.Location = new System.Drawing.Point(86, 62);
            this.lemonlimeLabel.Name = "lemonlimeLabel";
            this.lemonlimeLabel.Size = new System.Drawing.Size(83, 23);
            this.lemonlimeLabel.TabIndex = 3;
            this.lemonlimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(86, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "Drinks Left:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(86, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "$1.00";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lemonlimePictureBox
            // 
            this.lemonlimePictureBox.Image = global::DrinkMachine.Properties.Resources.LemonLime;
            this.lemonlimePictureBox.Location = new System.Drawing.Point(16, 19);
            this.lemonlimePictureBox.Name = "lemonlimePictureBox";
            this.lemonlimePictureBox.Size = new System.Drawing.Size(62, 64);
            this.lemonlimePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lemonlimePictureBox.TabIndex = 0;
            this.lemonlimePictureBox.TabStop = false;
            this.lemonlimePictureBox.Click += new System.EventHandler(this.lemonlimePictureBox_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grapeLabel);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.grapePictureBox);
            this.groupBox4.Location = new System.Drawing.Point(203, 143);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(185, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // grapeLabel
            // 
            this.grapeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grapeLabel.Location = new System.Drawing.Point(86, 62);
            this.grapeLabel.Name = "grapeLabel";
            this.grapeLabel.Size = new System.Drawing.Size(83, 23);
            this.grapeLabel.TabIndex = 3;
            this.grapeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(86, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 23);
            this.label12.TabIndex = 2;
            this.label12.Text = "Drinks Left:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(86, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 23);
            this.label13.TabIndex = 1;
            this.label13.Text = "$1.50";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grapePictureBox
            // 
            this.grapePictureBox.Image = global::DrinkMachine.Properties.Resources.GrapeSoda;
            this.grapePictureBox.Location = new System.Drawing.Point(16, 19);
            this.grapePictureBox.Name = "grapePictureBox";
            this.grapePictureBox.Size = new System.Drawing.Size(62, 64);
            this.grapePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.grapePictureBox.TabIndex = 0;
            this.grapePictureBox.TabStop = false;
            this.grapePictureBox.Click += new System.EventHandler(this.grapePictureBox_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.creamLabel);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.creamPictureBox);
            this.groupBox5.Location = new System.Drawing.Point(12, 249);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(185, 100);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // creamLabel
            // 
            this.creamLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.creamLabel.Location = new System.Drawing.Point(86, 62);
            this.creamLabel.Name = "creamLabel";
            this.creamLabel.Size = new System.Drawing.Size(83, 23);
            this.creamLabel.TabIndex = 3;
            this.creamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(86, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 23);
            this.label15.TabIndex = 2;
            this.label15.Text = "Drinks Left:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(86, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 23);
            this.label16.TabIndex = 1;
            this.label16.Text = "$1.50";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // creamPictureBox
            // 
            this.creamPictureBox.Image = global::DrinkMachine.Properties.Resources.CreamSoda;
            this.creamPictureBox.Location = new System.Drawing.Point(16, 19);
            this.creamPictureBox.Name = "creamPictureBox";
            this.creamPictureBox.Size = new System.Drawing.Size(62, 64);
            this.creamPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.creamPictureBox.TabIndex = 0;
            this.creamPictureBox.TabStop = false;
            this.creamPictureBox.Click += new System.EventHandler(this.creamPictureBox_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(255, 311);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(83, 23);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(255, 288);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 23);
            this.label18.TabIndex = 2;
            this.label18.Text = "Total Sales:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(166, 355);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 35);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 402);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drink Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colaPictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rootbeerPictureBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lemonlimePictureBox)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grapePictureBox)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creamPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox colaPictureBox;
        private System.Windows.Forms.Label colaLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label rootbeerLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox rootbeerPictureBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lemonlimeLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox lemonlimePictureBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label grapeLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox grapePictureBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label creamLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox creamPictureBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button exitButton;
    }
}

