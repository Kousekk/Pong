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
            ((System.ComponentModel.ISupportInitialize)(this.player1_pad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2_pad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // player1_pad
            // 
            this.player1_pad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player1_pad.BackColor = System.Drawing.Color.Green;
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
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.player2_pad);
            this.Controls.Add(this.player1_pad);
            this.Controls.Add(this.player1_score_label);
            this.Controls.Add(this.player2_score_label);
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

        }

        #endregion

        private System.Windows.Forms.PictureBox player1_pad;
        private System.Windows.Forms.PictureBox player2_pad;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label player1_score_label;
        private System.Windows.Forms.Label player2_score_label;
    }
}

