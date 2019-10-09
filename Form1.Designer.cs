namespace Snakee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.apple = new System.Windows.Forms.PictureBox();
            this.label_eaten = new System.Windows.Forms.Label();
            this.copyright = new System.Windows.Forms.Label();
            this.speed_gif = new System.Windows.Forms.PictureBox();
            this.speed_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed_gif)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 542);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(67, 542);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(16, 17);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "0";
            // 
            // apple
            // 
            this.apple.Image = ((System.Drawing.Image)(resources.GetObject("apple.Image")));
            this.apple.Location = new System.Drawing.Point(15, 451);
            this.apple.Name = "apple";
            this.apple.Size = new System.Drawing.Size(38, 35);
            this.apple.TabIndex = 3;
            this.apple.TabStop = false;
            // 
            // label_eaten
            // 
            this.label_eaten.AutoSize = true;
            this.label_eaten.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_eaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_eaten.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_eaten.Location = new System.Drawing.Point(59, 455);
            this.label_eaten.Name = "label_eaten";
            this.label_eaten.Size = new System.Drawing.Size(30, 31);
            this.label_eaten.TabIndex = 4;
            this.label_eaten.Text = "0";
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.copyright.Font = new System.Drawing.Font("Mistral", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.copyright.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.copyright.Location = new System.Drawing.Point(342, 451);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(347, 30);
            this.copyright.TabIndex = 5;
            this.copyright.Text = "@Copyright By Przemysław Drzewicz";
            // 
            // speed_gif
            // 
            this.speed_gif.Image = ((System.Drawing.Image)(resources.GetObject("speed_gif.Image")));
            this.speed_gif.Location = new System.Drawing.Point(109, 435);
            this.speed_gif.Name = "speed_gif";
            this.speed_gif.Size = new System.Drawing.Size(187, 134);
            this.speed_gif.TabIndex = 6;
            this.speed_gif.TabStop = false;
            // 
            // speed_lbl
            // 
            this.speed_lbl.AutoSize = true;
            this.speed_lbl.BackColor = System.Drawing.Color.Transparent;
            this.speed_lbl.Font = new System.Drawing.Font("Ravie", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed_lbl.ForeColor = System.Drawing.Color.Red;
            this.speed_lbl.Location = new System.Drawing.Point(149, 435);
            this.speed_lbl.Name = "speed_lbl";
            this.speed_lbl.Size = new System.Drawing.Size(147, 26);
            this.speed_lbl.TabIndex = 7;
            this.speed_lbl.Text = "SPEED UP !";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(728, 568);
            this.Controls.Add(this.speed_lbl);
            this.Controls.Add(this.speed_gif);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.label_eaten);
            this.Controls.Add(this.apple);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(746, 615);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed_gif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox apple;
        private System.Windows.Forms.Label label_eaten;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.PictureBox speed_gif;
        private System.Windows.Forms.Label speed_lbl;
        private System.Windows.Forms.Timer timer1;
    }
}

