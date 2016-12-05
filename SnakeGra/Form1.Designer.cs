namespace Snake
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
            this.components = new System.ComponentModel.Container();
            this.plansza = new System.Windows.Forms.PictureBox();
            this.lblPunkty = new System.Windows.Forms.Label();
            this.lblPunkty2 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.plansza)).BeginInit();
            this.SuspendLayout();
            // 
            // plansza
            // 
            this.plansza.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.plansza.Location = new System.Drawing.Point(12, 9);
            this.plansza.Name = "plansza";
            this.plansza.Size = new System.Drawing.Size(356, 380);
            this.plansza.TabIndex = 0;
            this.plansza.TabStop = false;
            // 
            // lblPunkty
            // 
            this.lblPunkty.AutoSize = true;
            this.lblPunkty.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPunkty.Location = new System.Drawing.Point(374, 9);
            this.lblPunkty.Name = "lblPunkty";
            this.lblPunkty.Size = new System.Drawing.Size(128, 33);
            this.lblPunkty.TabIndex = 1;
            this.lblPunkty.Text = "Punkty :";
            // 
            // lblPunkty2
            // 
            this.lblPunkty2.AutoSize = true;
            this.lblPunkty2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPunkty2.Location = new System.Drawing.Point(508, 9);
            this.lblPunkty2.Name = "lblPunkty2";
            this.lblPunkty2.Size = new System.Drawing.Size(0, 33);
            this.lblPunkty2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(645, 401);
            this.Controls.Add(this.lblPunkty2);
            this.Controls.Add(this.lblPunkty);
            this.Controls.Add(this.plansza);
            this.Name = "Form1";
            this.Text = "Snake";
            ((System.ComponentModel.ISupportInitialize)(this.plansza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox plansza;
        private System.Windows.Forms.Label lblPunkty;
        private System.Windows.Forms.Label lblPunkty2;
        private System.Windows.Forms.Timer Timer;
    }
}

