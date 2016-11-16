namespace RubensteinHomework2
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
            this.textGroupBox = new System.Windows.Forms.GroupBox();
            this.southTextbox = new System.Windows.Forms.TextBox();
            this.eastTextbox = new System.Windows.Forms.TextBox();
            this.westTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.southLabel = new System.Windows.Forms.Label();
            this.eastLabel = new System.Windows.Forms.Label();
            this.westLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.textGroupBox.SuspendLayout();
            this.labelGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // textGroupBox
            // 
            this.textGroupBox.Controls.Add(this.southTextbox);
            this.textGroupBox.Controls.Add(this.eastTextbox);
            this.textGroupBox.Controls.Add(this.westTextbox);
            this.textGroupBox.Controls.Add(this.label4);
            this.textGroupBox.Controls.Add(this.label3);
            this.textGroupBox.Controls.Add(this.label2);
            this.textGroupBox.Controls.Add(this.label1);
            this.textGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGroupBox.Location = new System.Drawing.Point(28, 30);
            this.textGroupBox.Name = "textGroupBox";
            this.textGroupBox.Size = new System.Drawing.Size(350, 312);
            this.textGroupBox.TabIndex = 0;
            this.textGroupBox.TabStop = false;
            this.textGroupBox.Text = "Permits Sold";
            // 
            // southTextbox
            // 
            this.southTextbox.Location = new System.Drawing.Point(220, 192);
            this.southTextbox.Name = "southTextbox";
            this.southTextbox.Size = new System.Drawing.Size(100, 22);
            this.southTextbox.TabIndex = 6;
            // 
            // eastTextbox
            // 
            this.eastTextbox.Location = new System.Drawing.Point(220, 150);
            this.eastTextbox.Name = "eastTextbox";
            this.eastTextbox.Size = new System.Drawing.Size(100, 22);
            this.eastTextbox.TabIndex = 5;
            // 
            // westTextbox
            // 
            this.westTextbox.Location = new System.Drawing.Point(220, 108);
            this.westTextbox.Name = "westTextbox";
            this.westTextbox.Size = new System.Drawing.Size(100, 22);
            this.westTextbox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(38, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "South Commuter:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(38, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "East Commuter:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(38, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "West Commuter:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of permits sold for each type of permit.";
            // 
            // labelGroupBox
            // 
            this.labelGroupBox.Controls.Add(this.label5);
            this.labelGroupBox.Controls.Add(this.label6);
            this.labelGroupBox.Controls.Add(this.totalLabel);
            this.labelGroupBox.Controls.Add(this.label7);
            this.labelGroupBox.Controls.Add(this.southLabel);
            this.labelGroupBox.Controls.Add(this.eastLabel);
            this.labelGroupBox.Controls.Add(this.westLabel);
            this.labelGroupBox.Controls.Add(this.label8);
            this.labelGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroupBox.Location = new System.Drawing.Point(417, 30);
            this.labelGroupBox.Name = "labelGroupBox";
            this.labelGroupBox.Size = new System.Drawing.Size(350, 312);
            this.labelGroupBox.TabIndex = 1;
            this.labelGroupBox.TabStop = false;
            this.labelGroupBox.Text = "Revenue Generated";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(19, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "South Commuter:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(19, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "East Commuter:";
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalLabel.Location = new System.Drawing.Point(224, 237);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(100, 23);
            this.totalLabel.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(19, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "West Commuter:";
            // 
            // southLabel
            // 
            this.southLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.southLabel.Location = new System.Drawing.Point(224, 194);
            this.southLabel.Name = "southLabel";
            this.southLabel.Size = new System.Drawing.Size(100, 23);
            this.southLabel.TabIndex = 13;
            // 
            // eastLabel
            // 
            this.eastLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.eastLabel.Location = new System.Drawing.Point(224, 152);
            this.eastLabel.Name = "eastLabel";
            this.eastLabel.Size = new System.Drawing.Size(100, 23);
            this.eastLabel.TabIndex = 12;
            // 
            // westLabel
            // 
            this.westLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.westLabel.Location = new System.Drawing.Point(224, 108);
            this.westLabel.Name = "westLabel";
            this.westLabel.Size = new System.Drawing.Size(100, 23);
            this.westLabel.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(19, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total Revenue:";
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(204, 362);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(121, 52);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate Revenue";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(340, 362);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(121, 52);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(476, 362);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(121, 52);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.labelGroupBox);
            this.Controls.Add(this.textGroupBox);
            this.Name = "Form1";
            this.Text = "Parking Revenue";
            this.textGroupBox.ResumeLayout(false);
            this.textGroupBox.PerformLayout();
            this.labelGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox textGroupBox;
        private System.Windows.Forms.TextBox southTextbox;
        private System.Windows.Forms.TextBox eastTextbox;
        private System.Windows.Forms.TextBox westTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox labelGroupBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label southLabel;
        private System.Windows.Forms.Label eastLabel;
        private System.Windows.Forms.Label westLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

