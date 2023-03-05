namespace Pong
{
    partial class Stats
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.player1_victory_count = new System.Windows.Forms.Label();
            this.player2_victory_count = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.max_speed = new System.Windows.Forms.Label();
            this.play_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Počet výher:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("BankGothic Md BT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("BankGothic Md BT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(559, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Player 2";
            // 
            // player1_victory_count
            // 
            this.player1_victory_count.AutoSize = true;
            this.player1_victory_count.Font = new System.Drawing.Font("BankGothic Md BT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1_victory_count.Location = new System.Drawing.Point(405, 144);
            this.player1_victory_count.Name = "player1_victory_count";
            this.player1_victory_count.Size = new System.Drawing.Size(0, 39);
            this.player1_victory_count.TabIndex = 3;
            this.player1_victory_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2_victory_count
            // 
            this.player2_victory_count.AutoSize = true;
            this.player2_victory_count.Font = new System.Drawing.Font("BankGothic Md BT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2_victory_count.Location = new System.Drawing.Point(622, 144);
            this.player2_victory_count.Name = "player2_victory_count";
            this.player2_victory_count.Size = new System.Drawing.Size(0, 39);
            this.player2_victory_count.TabIndex = 4;
            this.player2_victory_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("BankGothic Md BT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(432, 39);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nejvyšší rychlost:";
            // 
            // max_speed
            // 
            this.max_speed.AutoSize = true;
            this.max_speed.Font = new System.Drawing.Font("BankGothic Md BT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_speed.Location = new System.Drawing.Point(514, 237);
            this.max_speed.Name = "max_speed";
            this.max_speed.Size = new System.Drawing.Size(0, 39);
            this.max_speed.TabIndex = 6;
            // 
            // play_button
            // 
            this.play_button.BackColor = System.Drawing.Color.Violet;
            this.play_button.Font = new System.Drawing.Font("BankGothic Md BT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_button.Location = new System.Drawing.Point(378, 392);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(244, 84);
            this.play_button.TabIndex = 7;
            this.play_button.Text = "HRÁT";
            this.play_button.UseVisualStyleBackColor = false;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.max_speed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.player2_victory_count);
            this.Controls.Add(this.player1_victory_count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(950, 600);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Stats";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label player1_victory_count;
        private System.Windows.Forms.Label player2_victory_count;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label max_speed;
        private System.Windows.Forms.Button play_button;
    }
}