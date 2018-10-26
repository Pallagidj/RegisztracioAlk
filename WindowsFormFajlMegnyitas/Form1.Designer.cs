namespace WindowsFormFajlMegnyitas
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
            this.Open = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.NEV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FERFI = new System.Windows.Forms.RadioButton();
            this.NOSTENY = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Hobbi = new System.Windows.Forms.ListBox();
            this.Hobbiszveg = new System.Windows.Forms.TextBox();
            this.Hozzaad = new System.Windows.Forms.Button();
            this.IDOZITO = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(298, 237);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(87, 37);
            this.Open.TabIndex = 0;
            this.Open.Text = "Betöltés";
            this.Open.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.AllowDrop = true;
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.Location = new System.Drawing.Point(187, 237);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(92, 37);
            this.Save.TabIndex = 1;
            this.Save.Text = "Mentés";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFile";
            this.openFileDialog.Filter = "Szöveges Fájlok |*.txt|Minden fájl|*.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Szöveges Fájlok |*.txt|Minden fájl|*.tx";
            // 
            // NEV
            // 
            this.NEV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NEV.Location = new System.Drawing.Point(99, 14);
            this.NEV.Multiline = true;
            this.NEV.Name = "NEV";
            this.NEV.Size = new System.Drawing.Size(110, 28);
            this.NEV.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(226, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kedvenc hobbi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Szül. dátum:";
            // 
            // FERFI
            // 
            this.FERFI.AutoSize = true;
            this.FERFI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FERFI.Location = new System.Drawing.Point(99, 110);
            this.FERFI.Name = "FERFI";
            this.FERFI.Size = new System.Drawing.Size(34, 21);
            this.FERFI.TabIndex = 8;
            this.FERFI.TabStop = true;
            this.FERFI.Text = "F";
            this.FERFI.UseVisualStyleBackColor = true;
            // 
            // NOSTENY
            // 
            this.NOSTENY.AutoSize = true;
            this.NOSTENY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NOSTENY.Location = new System.Drawing.Point(163, 110);
            this.NOSTENY.Name = "NOSTENY";
            this.NOSTENY.Size = new System.Drawing.Size(36, 21);
            this.NOSTENY.TabIndex = 9;
            this.NOSTENY.TabStop = true;
            this.NOSTENY.Text = "N";
            this.NOSTENY.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nem:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(197, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Új hobbi:";
            // 
            // Hobbi
            // 
            this.Hobbi.FormattingEnabled = true;
            this.Hobbi.Items.AddRange(new object[] {
            "Uszás",
            "Horgászat",
            "Futás"});
            this.Hobbi.Location = new System.Drawing.Point(250, 36);
            this.Hobbi.Name = "Hobbi";
            this.Hobbi.Size = new System.Drawing.Size(120, 95);
            this.Hobbi.TabIndex = 12;
            // 
            // Hobbiszveg
            // 
            this.Hobbiszveg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Hobbiszveg.Location = new System.Drawing.Point(267, 155);
            this.Hobbiszveg.Multiline = true;
            this.Hobbiszveg.Name = "Hobbiszveg";
            this.Hobbiszveg.Size = new System.Drawing.Size(103, 28);
            this.Hobbiszveg.TabIndex = 2;
            // 
            // Hozzaad
            // 
            this.Hozzaad.Location = new System.Drawing.Point(288, 189);
            this.Hozzaad.Name = "Hozzaad";
            this.Hozzaad.Size = new System.Drawing.Size(82, 29);
            this.Hozzaad.TabIndex = 13;
            this.Hozzaad.Text = "Hozzáad";
            this.Hozzaad.UseVisualStyleBackColor = true;
            this.Hozzaad.Click += new System.EventHandler(this.Hozzaad_Click);
            // 
            // IDOZITO
            // 
            this.IDOZITO.Location = new System.Drawing.Point(99, 59);
            this.IDOZITO.Name = "IDOZITO";
            this.IDOZITO.Size = new System.Drawing.Size(145, 20);
            this.IDOZITO.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 286);
            this.Controls.Add(this.IDOZITO);
            this.Controls.Add(this.Hozzaad);
            this.Controls.Add(this.Hobbi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NOSTENY);
            this.Controls.Add(this.FERFI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NEV);
            this.Controls.Add(this.Hobbiszveg);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Open);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox NEV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton FERFI;
        private System.Windows.Forms.RadioButton NOSTENY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox Hobbi;
        private System.Windows.Forms.TextBox Hobbiszveg;
        private System.Windows.Forms.Button Hozzaad;
        private System.Windows.Forms.DateTimePicker IDOZITO;
    }
}

