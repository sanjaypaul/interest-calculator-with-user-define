namespace interest_calculator
{
    partial class calculator_UI
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
            this.amounttextBox = new System.Windows.Forms.TextBox();
            this.interesttextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yeartextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resulttextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Principal Amount";
            // 
            // amounttextBox
            // 
            this.amounttextBox.Location = new System.Drawing.Point(173, 22);
            this.amounttextBox.Name = "amounttextBox";
            this.amounttextBox.Size = new System.Drawing.Size(174, 20);
            this.amounttextBox.TabIndex = 1;
            // 
            // interesttextBox
            // 
            this.interesttextBox.Location = new System.Drawing.Point(173, 72);
            this.interesttextBox.Name = "interesttextBox";
            this.interesttextBox.Size = new System.Drawing.Size(174, 20);
            this.interesttextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Annual Interest Rate (%)";
            // 
            // yeartextBox
            // 
            this.yeartextBox.Location = new System.Drawing.Point(173, 119);
            this.yeartextBox.Name = "yeartextBox";
            this.yeartextBox.Size = new System.Drawing.Size(174, 20);
            this.yeartextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time Period (In Year)";
            // 
            // resulttextBox
            // 
            this.resulttextBox.Location = new System.Drawing.Point(173, 225);
            this.resulttextBox.Name = "resulttextBox";
            this.resulttextBox.Size = new System.Drawing.Size(174, 20);
            this.resulttextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Amount (Result)";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(227, 168);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // calculator_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 312);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resulttextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yeartextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.interesttextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amounttextBox);
            this.Controls.Add(this.label1);
            this.Name = "calculator_UI";
            this.Text = "calculator_UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amounttextBox;
        private System.Windows.Forms.TextBox interesttextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yeartextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resulttextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculateButton;
    }
}

