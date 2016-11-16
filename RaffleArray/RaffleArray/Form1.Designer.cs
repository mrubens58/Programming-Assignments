namespace RaffleArray
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
            this.groupTextBox = new System.Windows.Forms.TextBox();
            this.salesTextBox = new System.Windows.Forms.TextBox();
            this.addToTotalButton = new System.Windows.Forms.Button();
            this.displayTotalsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.totalsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sales:";
            // 
            // groupTextBox
            // 
            this.groupTextBox.Location = new System.Drawing.Point(204, 59);
            this.groupTextBox.Name = "groupTextBox";
            this.groupTextBox.Size = new System.Drawing.Size(100, 29);
            this.groupTextBox.TabIndex = 2;
            // 
            // salesTextBox
            // 
            this.salesTextBox.Location = new System.Drawing.Point(204, 95);
            this.salesTextBox.Name = "salesTextBox";
            this.salesTextBox.Size = new System.Drawing.Size(100, 29);
            this.salesTextBox.TabIndex = 3;
            // 
            // addToTotalButton
            // 
            this.addToTotalButton.Location = new System.Drawing.Point(420, 180);
            this.addToTotalButton.Name = "addToTotalButton";
            this.addToTotalButton.Size = new System.Drawing.Size(140, 38);
            this.addToTotalButton.TabIndex = 4;
            this.addToTotalButton.Text = "Add to Total";
            this.addToTotalButton.UseVisualStyleBackColor = true;
            this.addToTotalButton.Click += new System.EventHandler(this.addToTotalButton_Click);
            // 
            // displayTotalsButton
            // 
            this.displayTotalsButton.Location = new System.Drawing.Point(420, 233);
            this.displayTotalsButton.Name = "displayTotalsButton";
            this.displayTotalsButton.Size = new System.Drawing.Size(140, 38);
            this.displayTotalsButton.TabIndex = 5;
            this.displayTotalsButton.Text = "Display Totals";
            this.displayTotalsButton.UseVisualStyleBackColor = true;
            this.displayTotalsButton.Click += new System.EventHandler(this.displayTotalsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(420, 287);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 38);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // totalsListBox
            // 
            this.totalsListBox.FormattingEnabled = true;
            this.totalsListBox.ItemHeight = 24;
            this.totalsListBox.Location = new System.Drawing.Point(32, 149);
            this.totalsListBox.Name = "totalsListBox";
            this.totalsListBox.Size = new System.Drawing.Size(361, 196);
            this.totalsListBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 419);
            this.Controls.Add(this.totalsListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayTotalsButton);
            this.Controls.Add(this.addToTotalButton);
            this.Controls.Add(this.salesTextBox);
            this.Controls.Add(this.groupTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Scout Raffle Ticket Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox groupTextBox;
        private System.Windows.Forms.TextBox salesTextBox;
        private System.Windows.Forms.Button addToTotalButton;
        private System.Windows.Forms.Button displayTotalsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox totalsListBox;
    }
}

