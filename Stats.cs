using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
            player1_victory_count.Text = Pong.player1_wins.ToString();
            player2_victory_count.Text = Pong.player2_wins.ToString();
            max_speed.Text = Pong.max_speed.ToString();
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }
    }
}
