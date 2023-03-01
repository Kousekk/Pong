using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{   
    
    public partial class Pong : Form
    {
        // setting ball speed 
        int playerSpeed = 5;
        // variables for ball movement
        int ballx_coordinates = 3;
        int bally_coordinates = 3;
        // size variables
        int bottomBoundary;
        int middleX;
        int middleY;
        //players movement detection
        bool player1Up = false;
        bool player1Down = false;
        bool player2Up = false;
        bool player2Down = false;
        //variables for players score
        int player1Score = 0;
        int player2Score = 0;
        //variable for switching timer on and off
        bool timerSwitch = false;
        //variable for timer 2 for speed switching
        int speed_level = 3;
        bool timer_speed_switch = true;
        public Pong()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bottomBoundary = ClientSize.Height;
            middleX = ClientSize.Width / 2;
            middleY = ClientSize.Height / 2;
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //moves the ball
            ball.Top -= bally_coordinates;
            ball.Left -= ballx_coordinates; 
            //make sure ball stays in boundaries
            if (ball.Top < 0 || ball.Bottom > ClientSize.Height)
            {
                bally_coordinates = -(bally_coordinates); 

            }
            // check if ball hits player good side
            if (ball.Bounds.IntersectsWith(player1_pad.Bounds)|| ball.Bounds.IntersectsWith(player2_pad.Bounds))
            {
                ballx_coordinates = -ballx_coordinates;
            }
            //chech if the ball hits left or right side

            if (ball.Left < 0 || ball.Right > ClientSize.Width)
            {
                if (ball.Left < 0)
                {
                    //counting and showing score
                    player2Score++;
                    player2_score_label.Text = player2Score.ToString();
                }

                if (ball.Right > ClientSize.Width)
                {
                    //counting and showing score
                    player1Score++;
                    player1_score_label.Text = player1Score.ToString();
                    
                }
                
                ball.Left = middleX;
                ball.Top = middleY;
                ballx_coordinates = -ballx_coordinates;
                speed_level = 3;

            }
                
            if (player1Up == true && player1_pad.Top > 0){ player1_pad.Top -= playerSpeed; }
            if (player1Down == true && player1_pad.Bottom <ClientSize.Height){ player1_pad.Top += playerSpeed; }

            if (player2Up == true && player2_pad.Top > 0) { player2_pad.Top -= playerSpeed; }
            if (player2Down == true && player2_pad.Bottom < ClientSize.Height) { player2_pad.Top += playerSpeed; }

            //adding more speed to ball linear with time
            if (speed_level >= 3)
            {
                if (ballx_coordinates < 0) ballx_coordinates = -speed_level;
                else ballx_coordinates = speed_level;

                if (bally_coordinates < 0) bally_coordinates = -speed_level;
                else bally_coordinates = speed_level;

                label1.Text = (speed_level - 2).ToString();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) { player1Up = true; }
            if (e.KeyCode == Keys.S) { player1Down = true; }
            if (e.KeyCode == Keys.Up) { player2Up = true; }
            if (e.KeyCode == Keys.Down) { player2Down = true; }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.W) { player1Up = false; }
            if (e.KeyCode == Keys.S) { player1Down = false; }
            if (e.KeyCode == Keys.Up) { player2Up = false; }
            if (e.KeyCode == Keys.Down) { player2Down = false; }
            if (e.KeyCode == Keys.Space)
            {
                timerSwitch = !timerSwitch;
                if (timerSwitch)
                {
                    timer1.Start();
                    timer2.Start();
                }
                else
                {
                    timer1.Stop();
                    timer2.Stop(); 
                }
            }
            

        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {   // each 5 seconds of the new ball is speed of the ball increased
            speed_level++;
        }



    }
}
