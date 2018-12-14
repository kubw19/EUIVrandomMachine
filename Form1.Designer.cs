namespace losowanie
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
            this.components = new System.ComponentModel.Container();
            this.random = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Wyniki = new System.Windows.Forms.DataGridView();
            this.Gracz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.again = new System.Windows.Forms.DataGridViewButtonColumn();
            this.krajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Wyniki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.krajBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // random
            // 
            this.random.Location = new System.Drawing.Point(12, 215);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(304, 23);
            this.random.TabIndex = 10;
            this.random.Text = "Losuj";
            this.random.UseVisualStyleBackColor = true;
            this.random.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::losowanie.Properties.Resources.close;
            this.panel1.Location = new System.Drawing.Point(563, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 27);
            this.panel1.TabIndex = 37;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // Wyniki
            // 
            this.Wyniki.AllowUserToAddRows = false;
            this.Wyniki.AllowUserToDeleteRows = false;
            this.Wyniki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Wyniki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gracz,
            this.Country,
            this.again});
            this.Wyniki.Location = new System.Drawing.Point(12, 12);
            this.Wyniki.Name = "Wyniki";
            this.Wyniki.ReadOnly = true;
            this.Wyniki.RowHeadersVisible = false;
            this.Wyniki.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Wyniki.Size = new System.Drawing.Size(304, 188);
            this.Wyniki.TabIndex = 38;
            this.Wyniki.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Wyniki_CellContentClick_1);
            // 
            // Gracz
            // 
            this.Gracz.HeaderText = "Gracz";
            this.Gracz.Name = "Gracz";
            this.Gracz.ReadOnly = true;
            // 
            // Country
            // 
            this.Country.HeaderText = "Państwo";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            // 
            // again
            // 
            this.again.HeaderText = "Losuj";
            this.again.Name = "again";
            this.again.ReadOnly = true;
            this.again.Text = "Losuj";
            // 
            // krajBindingSource
            // 
            this.krajBindingSource.DataSource = typeof(losowanie.Losowanie.Kraj);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::losowanie.Properties.Resources.tlo1;
            this.ClientSize = new System.Drawing.Size(600, 250);
            this.Controls.Add(this.Wyniki);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.random);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "b";
            ((System.ComponentModel.ISupportInitialize)(this.Wyniki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.krajBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button random;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Wyniki;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gracz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewButtonColumn again;
        private System.Windows.Forms.BindingSource krajBindingSource;
    }
}

