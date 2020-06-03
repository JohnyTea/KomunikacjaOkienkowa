namespace KomunikacjaOkienkowa
{
    partial class OkienkoLiczace
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
            this.LiczbaA_TextBox = new System.Windows.Forms.TextBox();
            this.LiczbaB_TextBox = new System.Windows.Forms.TextBox();
            this.ZnakDzialania_Label = new System.Windows.Forms.Label();
            this.Wynik_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LiczbaA_TextBox
            // 
            this.LiczbaA_TextBox.Location = new System.Drawing.Point(27, 41);
            this.LiczbaA_TextBox.Name = "LiczbaA_TextBox";
            this.LiczbaA_TextBox.Size = new System.Drawing.Size(100, 20);
            this.LiczbaA_TextBox.TabIndex = 0;
            // 
            // LiczbaB_TextBox
            // 
            this.LiczbaB_TextBox.Location = new System.Drawing.Point(426, 58);
            this.LiczbaB_TextBox.Name = "LiczbaB_TextBox";
            this.LiczbaB_TextBox.Size = new System.Drawing.Size(100, 20);
            this.LiczbaB_TextBox.TabIndex = 1;
            // 
            // ZnakDzialania_Label
            // 
            this.ZnakDzialania_Label.AutoSize = true;
            this.ZnakDzialania_Label.Font = new System.Drawing.Font("Rage Italic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZnakDzialania_Label.Location = new System.Drawing.Point(223, 27);
            this.ZnakDzialania_Label.Name = "ZnakDzialania_Label";
            this.ZnakDzialania_Label.Size = new System.Drawing.Size(67, 80);
            this.ZnakDzialania_Label.TabIndex = 2;
            this.ZnakDzialania_Label.Text = "+";
            // 
            // Wynik_Button
            // 
            this.Wynik_Button.Location = new System.Drawing.Point(351, 141);
            this.Wynik_Button.Name = "Wynik_Button";
            this.Wynik_Button.Size = new System.Drawing.Size(175, 155);
            this.Wynik_Button.TabIndex = 3;
            this.Wynik_Button.Text = "=";
            this.Wynik_Button.UseVisualStyleBackColor = true;
            this.Wynik_Button.Click += new System.EventHandler(this.Wynik_Button_Click);
            // 
            // OkienkoLiczace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 304);
            this.Controls.Add(this.Wynik_Button);
            this.Controls.Add(this.ZnakDzialania_Label);
            this.Controls.Add(this.LiczbaB_TextBox);
            this.Controls.Add(this.LiczbaA_TextBox);
            this.Name = "OkienkoLiczace";
            this.Text = "OkienkoLiczace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LiczbaA_TextBox;
        private System.Windows.Forms.TextBox LiczbaB_TextBox;
        private System.Windows.Forms.Label ZnakDzialania_Label;
        private System.Windows.Forms.Button Wynik_Button;
    }
}