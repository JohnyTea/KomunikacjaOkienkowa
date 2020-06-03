namespace KomunikacjaOkienkowa
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Dodawanie_But = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Dzielenie_But = new System.Windows.Forms.Button();
            this.Mnozenie_But = new System.Windows.Forms.Button();
            this.Odejmowanie_But = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dodawanie_But
            // 
            this.Dodawanie_But.Location = new System.Drawing.Point(12, 12);
            this.Dodawanie_But.Name = "Dodawanie_But";
            this.Dodawanie_But.Size = new System.Drawing.Size(639, 23);
            this.Dodawanie_But.TabIndex = 0;
            this.Dodawanie_But.Text = "+";
            this.Dodawanie_But.UseVisualStyleBackColor = true;
            this.Dodawanie_But.Click += new System.EventHandler(this.Dodawanie_But_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 108);
            this.label1.TabIndex = 1;
            this.label1.Text = "?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Dzielenie_But
            // 
            this.Dzielenie_But.Location = new System.Drawing.Point(512, 53);
            this.Dzielenie_But.Name = "Dzielenie_But";
            this.Dzielenie_But.Size = new System.Drawing.Size(242, 186);
            this.Dzielenie_But.TabIndex = 2;
            this.Dzielenie_But.Text = "/";
            this.Dzielenie_But.UseVisualStyleBackColor = true;
            this.Dzielenie_But.Click += new System.EventHandler(this.button2_Click);
            // 
            // Mnozenie_But
            // 
            this.Mnozenie_But.Location = new System.Drawing.Point(66, 53);
            this.Mnozenie_But.Name = "Mnozenie_But";
            this.Mnozenie_But.Size = new System.Drawing.Size(75, 95);
            this.Mnozenie_But.TabIndex = 3;
            this.Mnozenie_But.Text = "*";
            this.Mnozenie_But.UseVisualStyleBackColor = true;
            this.Mnozenie_But.Click += new System.EventHandler(this.Mnozenie_But_Click);
            // 
            // Odejmowanie_But
            // 
            this.Odejmowanie_But.Location = new System.Drawing.Point(115, 363);
            this.Odejmowanie_But.Name = "Odejmowanie_But";
            this.Odejmowanie_But.Size = new System.Drawing.Size(31, 23);
            this.Odejmowanie_But.TabIndex = 4;
            this.Odejmowanie_But.Text = "-";
            this.Odejmowanie_But.UseVisualStyleBackColor = true;
            this.Odejmowanie_But.Click += new System.EventHandler(this.Odejmowanie_But_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 444);
            this.Controls.Add(this.Odejmowanie_But);
            this.Controls.Add(this.Mnozenie_But);
            this.Controls.Add(this.Dzielenie_But);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dodawanie_But);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Dodawanie_But;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Dzielenie_But;
        private System.Windows.Forms.Button Mnozenie_But;
        private System.Windows.Forms.Button Odejmowanie_But;
    }
}

