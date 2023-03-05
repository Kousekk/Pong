namespace Pong
{
    partial class Pong
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.player1_pad = new System.Windows.Forms.PictureBox();
            this.player2_pad = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.player1_score_label = new System.Windows.Forms.Label();
            this.player2_score_label = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.winner_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player1_pad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2_pad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // player1_pad
            // 
            this.player1_pad.BackColor = System.Drawing.Color.Green;
            this.player1_pad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player1_pad.Location = new System.Drawing.Point(10, 255);
            this.player1_pad.MaximumSize = new System.Drawing.Size(20, 90);
            this.player1_pad.MinimumSize = new System.Drawing.Size(20, 90);
            this.player1_pad.Name = "player1_pad";
            this.player1_pad.Size = new System.Drawing.Size(20, 90);
            this.player1_pad.TabIndex = 0;
            this.player1_pad.TabStop = false;
            // 
            // player2_pad
            // 
            this.player2_pad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player2_pad.BackColor = System.Drawing.Color.Green;
            this.player2_pad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player2_pad.Location = new System.Drawing.Point(900, 255);
            this.player2_pad.MaximumSize = new System.Drawing.Size(20, 90);
            this.player2_pad.MinimumSize = new System.Drawing.Size(20, 90);
            this.player2_pad.Name = "player2_pad";
            this.player2_pad.Size = new System.Drawing.Size(20, 90);
            this.player2_pad.TabIndex = 1;
            this.player2_pad.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ball.Location = new System.Drawing.Point(468, 293);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(15, 15);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // player1_score_label
            // 
            this.player1_score_label.Font = new System.Drawing.Font("Gill Sans MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1_score_label.ForeColor = System.Drawing.Color.White;
            this.player1_score_label.Location = new System.Drawing.Point(340, 20);
            this.player1_score_label.Name = "player1_score_label";
            this.player1_score_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.player1_score_label.Size = new System.Drawing.Size(120, 80);
            this.player1_score_label.TabIndex = 3;
            this.player1_score_label.Text = "0";
            this.player1_score_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // player2_score_label
            // 
            this.player2_score_label.Font = new System.Drawing.Font("Gill Sans MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2_score_label.ForeColor = System.Drawing.Color.White;
            this.player2_score_label.Location = new System.Drawing.Point(490, 20);
            this.player2_score_label.Name = "player2_score_label";
            this.player2_score_label.Size = new System.Drawing.Size(120, 80);
            this.player2_score_label.TabIndex = 4;
            this.player2_score_label.Text = "0";
            this.player2_score_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(858, 20);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(62, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(660, 20);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(213, 51);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rychlost:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // winner_label
            // 
            this.winner_label.AutoSize = true;
            this.winner_label.Font = new System.Drawing.Font("Franklin Gothic Demi", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.winner_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.winner_label.Location = new System.Drawing.Point(228, 244);
            this.winner_label.Name = "winner_label";
            this.winner_label.Size = new System.Drawing.Size(0, 101);
            this.winner_label.TabIndex = 7;
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.winner_label);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.player2_pad);
            this.Controls.Add(this.player1_pad);
            this.Controls.Add(this.player1_score_label);
            this.Controls.Add(this.player2_score_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(950, 600);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Pong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player1_pad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2_pad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player1_pad;
        private System.Windows.Forms.PictureBox player2_pad;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label player1_score_label;
        private System.Windows.Forms.Label player2_score_label;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label winner_label;
    }
}

