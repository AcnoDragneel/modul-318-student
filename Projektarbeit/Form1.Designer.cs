namespace Projektarbeit
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LBNähe = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BSuchen = new System.Windows.Forms.Button();
            this.Datum = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.LBMV = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LBWV = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.CBStart = new System.Windows.Forms.ComboBox();
            this.CBZiel = new System.Windows.Forms.ComboBox();
            this.TBZeit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(390, 482);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TBZeit);
            this.tabPage1.Controls.Add(this.CBZiel);
            this.tabPage1.Controls.Add(this.CBStart);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.LBNähe);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.BSuchen);
            this.tabPage1.Controls.Add(this.Datum);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(382, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Suchen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.LBWV);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.LBMV);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(382, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Resultat";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LBNähe
            // 
            this.LBNähe.FormattingEnabled = true;
            this.LBNähe.ItemHeight = 16;
            this.LBNähe.Location = new System.Drawing.Point(6, 299);
            this.LBNähe.Name = "LBNähe";
            this.LBNähe.Size = new System.Drawing.Size(370, 132);
            this.LBNähe.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Standort in ihrer Nähe.";
            // 
            // BSuchen
            // 
            this.BSuchen.Location = new System.Drawing.Point(301, 203);
            this.BSuchen.Name = "BSuchen";
            this.BSuchen.Size = new System.Drawing.Size(75, 23);
            this.BSuchen.TabIndex = 16;
            this.BSuchen.Text = "Suchen";
            this.BSuchen.UseVisualStyleBackColor = true;
            // 
            // Datum
            // 
            this.Datum.Location = new System.Drawing.Point(90, 203);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(205, 22);
            this.Datum.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 1;
            // 
            // LBMV
            // 
            this.LBMV.FormattingEnabled = true;
            this.LBMV.ItemHeight = 16;
            this.LBMV.Location = new System.Drawing.Point(6, 50);
            this.LBMV.Name = "LBMV";
            this.LBMV.Size = new System.Drawing.Size(370, 100);
            this.LBMV.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(324, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Weitere Verbindungen von Standort";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 39);
            this.label3.TabIndex = 21;
            this.label3.Text = "SBB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mögliche Verbindungen";
            // 
            // LBWV
            // 
            this.LBWV.FormattingEnabled = true;
            this.LBWV.ItemHeight = 16;
            this.LBWV.Location = new System.Drawing.Point(6, 211);
            this.LBWV.Name = "LBWV";
            this.LBWV.Size = new System.Drawing.Size(370, 116);
            this.LBWV.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "Neue Angabe";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CBStart
            // 
            this.CBStart.FormattingEnabled = true;
            this.CBStart.Location = new System.Drawing.Point(6, 104);
            this.CBStart.Name = "CBStart";
            this.CBStart.Size = new System.Drawing.Size(370, 24);
            this.CBStart.TabIndex = 22;
            this.CBStart.DropDown += new System.EventHandler(this.CBStart_DropDown);
            // 
            // CBZiel
            // 
            this.CBZiel.FormattingEnabled = true;
            this.CBZiel.Location = new System.Drawing.Point(6, 155);
            this.CBZiel.Name = "CBZiel";
            this.CBZiel.Size = new System.Drawing.Size(370, 24);
            this.CBZiel.TabIndex = 23;
            this.CBZiel.DropDown += new System.EventHandler(this.CBZiel_DropDown);
            // 
            // TBZeit
            // 
            this.TBZeit.Location = new System.Drawing.Point(6, 203);
            this.TBZeit.Name = "TBZeit";
            this.TBZeit.Size = new System.Drawing.Size(78, 22);
            this.TBZeit.TabIndex = 24;
            this.TBZeit.Text = "Zeit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Geben sie ihren Standort und ihr Ziel ein.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 507);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox LBNähe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BSuchen;
        private System.Windows.Forms.DateTimePicker Datum;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox LBMV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox LBWV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBZiel;
        private System.Windows.Forms.ComboBox CBStart;
        private System.Windows.Forms.TextBox TBZeit;
        private System.Windows.Forms.Label label2;
    }
}

