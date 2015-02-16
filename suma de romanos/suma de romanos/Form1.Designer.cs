namespace suma_de_romanos
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
            this.arabicNumber1 = new System.Windows.Forms.TextBox();
            this.arabicNumber2 = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.romanAnswer = new System.Windows.Forms.Label();
            this.arabicAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // arabicNumber1
            // 
            this.arabicNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arabicNumber1.Location = new System.Drawing.Point(15, 55);
            this.arabicNumber1.MaxLength = 6;
            this.arabicNumber1.Name = "arabicNumber1";
            this.arabicNumber1.Size = new System.Drawing.Size(272, 31);
            this.arabicNumber1.TabIndex = 0;
            this.arabicNumber1.TextChanged += new System.EventHandler(this.arabicNumber1_TextChanged);
            // 
            // arabicNumber2
            // 
            this.arabicNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arabicNumber2.Location = new System.Drawing.Point(313, 55);
            this.arabicNumber2.MaxLength = 6;
            this.arabicNumber2.Name = "arabicNumber2";
            this.arabicNumber2.Size = new System.Drawing.Size(272, 31);
            this.arabicNumber2.TabIndex = 1;
            this.arabicNumber2.TextChanged += new System.EventHandler(this.arabicNumber2_TextChanged);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(212, 131);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(120, 45);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "SUMAR";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // romanAnswer
            // 
            this.romanAnswer.AutoSize = true;
            this.romanAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.romanAnswer.Location = new System.Drawing.Point(150, 211);
            this.romanAnswer.Name = "romanAnswer";
            this.romanAnswer.Size = new System.Drawing.Size(0, 25);
            this.romanAnswer.TabIndex = 3;
            this.romanAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arabicAnswer
            // 
            this.arabicAnswer.AutoSize = true;
            this.arabicAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arabicAnswer.Location = new System.Drawing.Point(150, 251);
            this.arabicAnswer.Name = "arabicAnswer";
            this.arabicAnswer.Size = new System.Drawing.Size(0, 25);
            this.arabicAnswer.TabIndex = 4;
            this.arabicAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.arabicAnswer.Click += new System.EventHandler(this.arabicAnswer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 334);
            this.Controls.Add(this.arabicAnswer);
            this.Controls.Add(this.romanAnswer);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.arabicNumber2);
            this.Controls.Add(this.arabicNumber1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox arabicNumber1;
        private System.Windows.Forms.TextBox arabicNumber2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label romanAnswer;
        private System.Windows.Forms.Label arabicAnswer;
    }
}

