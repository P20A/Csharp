using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Game game;
        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(this);
            game.generator();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    game.move(Dir.up);
                    break;
                case Keys.Down:
                    game.move(Dir.down);
                    break;
                case Keys.Left:
                    game.move(Dir.left);
                    break;
                case Keys.Right:
                    game.move(Dir.right);
                    break;
            }
        }
    }
    enum Dir
    {
        up, down, left, right,none
    }
}
