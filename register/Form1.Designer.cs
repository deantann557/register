namespace register
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
            this.manaNumber = new System.Windows.Forms.Label();
            this.toxinNumber = new System.Windows.Forms.Label();
            this.thermalNumber = new System.Windows.Forms.Label();
            this.manaText = new System.Windows.Forms.TextBox();
            this.toxinText = new System.Windows.Forms.TextBox();
            this.thermalText = new System.Windows.Forms.TextBox();
            this.calculateTotal = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tenderLabel = new System.Windows.Forms.Label();
            this.tenderedText = new System.Windows.Forms.TextBox();
            this.calculateChange = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.printReceipt = new System.Windows.Forms.Button();
            this.Receipt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // manaNumber
            // 
            this.manaNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manaNumber.Location = new System.Drawing.Point(34, 122);
            this.manaNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.manaNumber.Name = "manaNumber";
            this.manaNumber.Size = new System.Drawing.Size(237, 29);
            this.manaNumber.TabIndex = 0;
            this.manaNumber.Text = "Number of Mana bombs";
            // 
            // toxinNumber
            // 
            this.toxinNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toxinNumber.Location = new System.Drawing.Point(27, 158);
            this.toxinNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toxinNumber.Name = "toxinNumber";
            this.toxinNumber.Size = new System.Drawing.Size(244, 29);
            this.toxinNumber.TabIndex = 1;
            this.toxinNumber.Text = "Number of Toxin bombs";
            // 
            // thermalNumber
            // 
            this.thermalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thermalNumber.Location = new System.Drawing.Point(22, 187);
            this.thermalNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.thermalNumber.Name = "thermalNumber";
            this.thermalNumber.Size = new System.Drawing.Size(249, 29);
            this.thermalNumber.TabIndex = 2;
            this.thermalNumber.Text = "Number of Thermal bombs";
            // 
            // manaText
            // 
            this.manaText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.manaText.Location = new System.Drawing.Point(279, 122);
            this.manaText.Margin = new System.Windows.Forms.Padding(4);
            this.manaText.Name = "manaText";
            this.manaText.Size = new System.Drawing.Size(132, 26);
            this.manaText.TabIndex = 3;
            this.manaText.Text = "0";
            // 
            // toxinText
            // 
            this.toxinText.Location = new System.Drawing.Point(279, 159);
            this.toxinText.Margin = new System.Windows.Forms.Padding(4);
            this.toxinText.Name = "toxinText";
            this.toxinText.Size = new System.Drawing.Size(132, 26);
            this.toxinText.TabIndex = 4;
            this.toxinText.Text = "0";
            // 
            // thermalText
            // 
            this.thermalText.Location = new System.Drawing.Point(279, 193);
            this.thermalText.Margin = new System.Windows.Forms.Padding(4);
            this.thermalText.Name = "thermalText";
            this.thermalText.Size = new System.Drawing.Size(132, 26);
            this.thermalText.TabIndex = 5;
            this.thermalText.Text = "0";
            // 
            // calculateTotal
            // 
            this.calculateTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculateTotal.Location = new System.Drawing.Point(209, 237);
            this.calculateTotal.Margin = new System.Windows.Forms.Padding(4);
            this.calculateTotal.Name = "calculateTotal";
            this.calculateTotal.Size = new System.Drawing.Size(146, 29);
            this.calculateTotal.TabIndex = 6;
            this.calculateTotal.Text = "Calculate Total";
            this.calculateTotal.UseVisualStyleBackColor = true;
            this.calculateTotal.Click += new System.EventHandler(this.calculateTotal_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.Location = new System.Drawing.Point(183, 270);
            this.subtotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(232, 29);
            this.subtotalLabel.TabIndex = 7;
            this.subtotalLabel.Text = "Subtotal        ";
            // 
            // taxLabel
            // 
            this.taxLabel.Location = new System.Drawing.Point(183, 299);
            this.taxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(232, 29);
            this.taxLabel.TabIndex = 8;
            this.taxLabel.Text = "Tax       ";
            // 
            // totalLabel
            // 
            this.totalLabel.Location = new System.Drawing.Point(183, 328);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(228, 29);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total       ";
            // 
            // tenderLabel
            // 
            this.tenderLabel.Location = new System.Drawing.Point(118, 368);
            this.tenderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tenderLabel.Name = "tenderLabel";
            this.tenderLabel.Size = new System.Drawing.Size(153, 29);
            this.tenderLabel.TabIndex = 10;
            this.tenderLabel.Text = "Amount Tendered";
            // 
            // tenderedText
            // 
            this.tenderedText.Location = new System.Drawing.Point(279, 371);
            this.tenderedText.Margin = new System.Windows.Forms.Padding(4);
            this.tenderedText.Name = "tenderedText";
            this.tenderedText.Size = new System.Drawing.Size(132, 26);
            this.tenderedText.TabIndex = 11;
            // 
            // calculateChange
            // 
            this.calculateChange.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculateChange.Location = new System.Drawing.Point(238, 405);
            this.calculateChange.Margin = new System.Windows.Forms.Padding(4);
            this.calculateChange.Name = "calculateChange";
            this.calculateChange.Size = new System.Drawing.Size(171, 29);
            this.calculateChange.TabIndex = 12;
            this.calculateChange.Text = "Calculate Change";
            this.calculateChange.UseVisualStyleBackColor = true;
            this.calculateChange.Click += new System.EventHandler(this.calculateChange_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.Location = new System.Drawing.Point(205, 438);
            this.changeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(205, 29);
            this.changeLabel.TabIndex = 13;
            this.changeLabel.Text = "Change       ";
            // 
            // printReceipt
            // 
            this.printReceipt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.printReceipt.Location = new System.Drawing.Point(253, 478);
            this.printReceipt.Margin = new System.Windows.Forms.Padding(4);
            this.printReceipt.Name = "printReceipt";
            this.printReceipt.Size = new System.Drawing.Size(128, 29);
            this.printReceipt.TabIndex = 14;
            this.printReceipt.Text = "Print Receipt";
            this.printReceipt.UseVisualStyleBackColor = true;
            this.printReceipt.Click += new System.EventHandler(this.printReceipt_Click);
            // 
            // Receipt
            // 
            this.Receipt.AutoSize = true;
            this.Receipt.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Receipt.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Receipt.Location = new System.Drawing.Point(711, -1);
            this.Receipt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Receipt.Name = "Receipt";
            this.Receipt.Size = new System.Drawing.Size(0, 20);
            this.Receipt.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 90);
            this.label1.TabIndex = 17;
            this.label1.Text = "BOMB.Co";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Receipt);
            this.Controls.Add(this.printReceipt);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.calculateChange);
            this.Controls.Add(this.tenderedText);
            this.Controls.Add(this.tenderLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calculateTotal);
            this.Controls.Add(this.thermalText);
            this.Controls.Add(this.toxinText);
            this.Controls.Add(this.manaText);
            this.Controls.Add(this.thermalNumber);
            this.Controls.Add(this.toxinNumber);
            this.Controls.Add(this.manaNumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label manaNumber;
        private System.Windows.Forms.Label toxinNumber;
        private System.Windows.Forms.Label thermalNumber;
        private System.Windows.Forms.TextBox manaText;
        private System.Windows.Forms.TextBox toxinText;
        private System.Windows.Forms.TextBox thermalText;
        private System.Windows.Forms.Button calculateTotal;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tenderLabel;
        private System.Windows.Forms.TextBox tenderedText;
        private System.Windows.Forms.Button calculateChange;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button printReceipt;
        private System.Windows.Forms.Label Receipt;
        private System.Windows.Forms.Label label1;
    }
}

