namespace ShippingArray
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.weightListBox = new System.Windows.Forms.ListBox();
            this.zoneListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chargesLabel = new System.Windows.Forms.Label();
            this.lookUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "(Not to exceed)";
            // 
            // weightListBox
            // 
            this.weightListBox.FormattingEnabled = true;
            this.weightListBox.ItemHeight = 20;
            this.weightListBox.Items.AddRange(new object[] {
            "1 lb",
            "3 lb",
            "5 lb",
            "10 lb",
            ">10 lb"});
            this.weightListBox.Location = new System.Drawing.Point(60, 76);
            this.weightListBox.Name = "weightListBox";
            this.weightListBox.Size = new System.Drawing.Size(75, 104);
            this.weightListBox.TabIndex = 3;
            // 
            // zoneListBox
            // 
            this.zoneListBox.FormattingEnabled = true;
            this.zoneListBox.ItemHeight = 20;
            this.zoneListBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.zoneListBox.Location = new System.Drawing.Point(322, 76);
            this.zoneListBox.Name = "zoneListBox";
            this.zoneListBox.Size = new System.Drawing.Size(77, 84);
            this.zoneListBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Charges:";
            // 
            // chargesLabel
            // 
            this.chargesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chargesLabel.Location = new System.Drawing.Point(220, 212);
            this.chargesLabel.Name = "chargesLabel";
            this.chargesLabel.Size = new System.Drawing.Size(120, 32);
            this.chargesLabel.TabIndex = 6;
            this.chargesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lookUpButton
            // 
            this.lookUpButton.Location = new System.Drawing.Point(220, 267);
            this.lookUpButton.Name = "lookUpButton";
            this.lookUpButton.Size = new System.Drawing.Size(120, 35);
            this.lookUpButton.TabIndex = 7;
            this.lookUpButton.Text = "Look Up";
            this.lookUpButton.UseVisualStyleBackColor = true;
            this.lookUpButton.Click += new System.EventHandler(this.lookUpButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 339);
            this.Controls.Add(this.lookUpButton);
            this.Controls.Add(this.chargesLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zoneListBox);
            this.Controls.Add(this.weightListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Shipping Rate Lookup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox weightListBox;
        private System.Windows.Forms.ListBox zoneListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label chargesLabel;
        private System.Windows.Forms.Button lookUpButton;
    }
}

