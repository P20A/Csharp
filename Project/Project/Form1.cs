using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private int highestscore;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "This game is made by parsa ataei";
            game = new Game(this);
            game.generator();
            highestScoreSetter(10);
            this.highestScoreIndecator.Text = $"Highest score: {highestscore}";
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
        public void levelSetter(int i)
        {
            this.levelIndecator.Text = $"Level: {i}";
        }
        public void scoreSetter(int score)
        {
            this.inGameScore.Text = $"Score: {score}";
        }
        public void highestScoreSetter(int score)
        {
            bool newHighestScore = false;
            using (StreamReader readHighestScore = new StreamReader("highestScore.txt", true))
            {
                highestscore = int.Parse(readHighestScore.ReadLine());
                if (score > highestscore)
                    newHighestScore = true;
            }
            if (newHighestScore)
            {
                TextWriter writeHighestScore = new StreamWriter("highestScore.txt",true);
                writeHighestScore.WriteLine(score);
                highestscore = score;
            }

            
        }
    }
    enum Dir
    {
        up, down, left, right,none
    }
}
