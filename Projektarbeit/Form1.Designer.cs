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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SBB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBZiel = new System.Windows.Forms.ComboBox();
            this.CBStart = new System.Windows.Forms.ComboBox();
            this.BSuchen = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LBMV = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LBWV = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelZeit = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
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
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(712, 464);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SBB);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.CBZiel);
            this.tabPage1.Controls.Add(this.CBStart);
            this.tabPage1.Controls.Add(this.BSuchen);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(704, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Suchen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SBB
            // 
            this.SBB.AutoSize = true;
            this.SBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SBB.Location = new System.Drawing.Point(6, 12);
            this.SBB.Name = "SBB";
            this.SBB.Size = new System.Drawing.Size(154, 38);
            this.SBB.TabIndex = 26;
            this.SBB.Text = "→SBB←";
            this.SBB.Click += new System.EventHandler(this.SBB_Click);
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
            // CBZiel
            // 
            this.CBZiel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBZiel.FormattingEnabled = true;
            this.CBZiel.Location = new System.Drawing.Point(6, 164);
            this.CBZiel.Name = "CBZiel";
            this.CBZiel.Size = new System.Drawing.Size(462, 28);
            this.CBZiel.TabIndex = 23;
            this.CBZiel.DropDown += new System.EventHandler(this.CBZiel_DropDown);
            // 
            // CBStart
            // 
            this.CBStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBStart.FormattingEnabled = true;
            this.CBStart.Location = new System.Drawing.Point(6, 104);
            this.CBStart.Name = "CBStart";
            this.CBStart.Size = new System.Drawing.Size(462, 28);
            this.CBStart.TabIndex = 22;
            this.CBStart.DropDown += new System.EventHandler(this.CBStart_DropDown);
            // 
            // BSuchen
            // 
            this.BSuchen.Location = new System.Drawing.Point(376, 204);
            this.BSuchen.Name = "BSuchen";
            this.BSuchen.Size = new System.Drawing.Size(92, 31);
            this.BSuchen.TabIndex = 16;
            this.BSuchen.Text = "Suchen";
            this.BSuchen.UseVisualStyleBackColor = true;
            this.BSuchen.Click += new System.EventHandler(this.BSuchen_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LBMV);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.LBWV);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(704, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Resultat";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LBMV
            // 
            this.LBMV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMV.FormattingEnabled = true;
            this.LBMV.ItemHeight = 18;
            this.LBMV.Location = new System.Drawing.Point(6, 53);
            this.LBMV.Name = "LBMV";
            this.LBMV.Size = new System.Drawing.Size(687, 148);
            this.LBMV.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(427, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Weitere Verbindungen von gewünschter Station";
            // 
            // LBWV
            // 
            this.LBWV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBWV.FormattingEnabled = true;
            this.LBWV.ItemHeight = 18;
            this.LBWV.Location = new System.Drawing.Point(6, 266);
            this.LBWV.Name = "LBWV";
            this.LBWV.Size = new System.Drawing.Size(687, 148);
            this.LBWV.TabIndex = 6;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 1;
            // 
            // labelZeit
            // 
            this.labelZeit.AutoSize = true;
            this.labelZeit.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZeit.Location = new System.Drawing.Point(13, 4);
            this.labelZeit.Name = "labelZeit";
            this.labelZeit.Size = new System.Drawing.Size(38, 23);
            this.labelZeit.TabIndex = 1;
            this.labelZeit.Text = "Zeit";
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 507);
            this.Controls.Add(this.labelZeit);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BSuchen;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LBWV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBZiel;
        private System.Windows.Forms.ComboBox CBStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox LBMV;
        private System.Windows.Forms.Label SBB;
        private System.Windows.Forms.Label labelZeit;
        private System.Windows.Forms.Timer timer;
    }
}

