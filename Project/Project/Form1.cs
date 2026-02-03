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
        int min = 0;
        int sec = 0;
        int endTime = 0;
        int centerX;
        int centerY;
        bool multiPlayer = false;
        public Form1()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 600;
            centerX = (this.Width / 2);
            centerY = (this.Height / 2);
        }
        Game game;
        Game gameP1;
        Game gameP2;
        private int highestscore;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "This game is made by parsa ataei";
            Title.Location = new Point(centerX - 300, 0);
            Endless.Location = new Point(centerX - 150, centerY - 30);
            oneVone.Location = new Point(centerX - 50, centerY - 30);
            Timed.Location = new Point(centerX + 50, centerY - 30);
            Easy.Location = new Point(centerX - 50, centerY - 60);
            Medium.Location = new Point(centerX - 50, centerY - 30);
            Hard.Location = new Point(centerX - 50, centerY);
            endGame.Location = new Point(centerX * 2 - 150, 40);
            Easy.Hide();
            Medium.Hide();
            Hard.Hide();
            player1.Hide();
            player2.Hide();
            endGame.Hide();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (multiPlayer)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        gameP1.move(Dir.up);
                        break;
                    case Keys.Down:
                        gameP1.move(Dir.down);
                        break;
                    case Keys.Left:
                        gameP1.move(Dir.left);
                        break;
                    case Keys.Right:
                        gameP1.move(Dir.right);
                        break;
                    case Keys.W:
                        gameP2.move(Dir.up);
                        break;
                    case Keys.S:
                        gameP2.move(Dir.down);
                        break;
                    case Keys.A:
                        gameP2.move(Dir.left);
                        break;
                    case Keys.D:
                        gameP2.move(Dir.right);
                        break;
                }
            }
            else
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
        public void levelSetter(int i)
        {
            this.levelIndecator.Text = $"Level: {i}";
        }
        public int scoreSetter(int score)
        {
            this.inGameScore.Text = $"Score: {score}";
            return score;
        }
        public void highestScoreSetter(int score)
        {
            string path = "highestScore.txt";
            if (!File.Exists(path))
            {
                File.Create(path).Close();
                StreamWriter writeHighestScore = new StreamWriter(path, false);
                writeHighestScore.WriteLine(0);
                writeHighestScore.Close();

            }
            bool newHighestScore = false;
            using (StreamReader readHighestScore = new StreamReader(path, true))
            {
                highestscore = int.Parse(readHighestScore.ReadLine());
                if (score > highestscore)
                    newHighestScore = true;
            }
            if (newHighestScore)
            {
                StreamWriter writeHighestScore = new StreamWriter(path, false);
                writeHighestScore.WriteLine(score);
                writeHighestScore.Close();
                highestscore = score;
            }
            this.highestScoreIndecator.Text = $"Highest score: {highestscore}";
        }

        private void Timed_Click(object sender, EventArgs e)
        {
            disposer();
            Easy.Show();
            Medium.Show();
            Hard.Show();
        }

        private void Endless_Click(object sender, EventArgs e)
        {
            disposer();
            Mode.Text = "Mode: Endless";
            game = new Game(this, true);
            game.generator();
            levelIndecator.Show();
            highestScoreIndecator.Show();
            inGameScore.Show();
            Mode.Show();
            endGame.Show();
        }
        private void disposer()
        {
            Timed.Hide();
            Endless.Hide();
            Title.Hide();
            oneVone.Hide();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            sec--;
            if(sec < 0)
            {
                sec = 59;
                if(min <= 0)
                {
                    game.endGame();
                    levelIndecator.Hide();
                    highestScoreIndecator.Hide();
                    inGameScore.Hide();
                    Mode.Hide();
                    Timer_Count.Hide();
                }
                else
                    min--;
            }
            Timer_Count.Text = $"{min}:{sec}";
        }
        private void StartTimedGame()
        {
            min = endTime / 60;
            sec = endTime % 60;
            Mode.Text = "Mode: Timed";
            Timer_Count.Text = $"{min}:{sec}";
            game = new Game(this, false);
            game.generator();
            Timer.Start();
            Timer_Count.Show();
            Easy.Hide();
            Medium.Hide();
            Hard.Hide();
            levelIndecator.Show();
            highestScoreIndecator.Show();
            inGameScore.Show();
            Mode.Show();
            endGame.Show();
            
        }
        private void Easy_Click(object sender, EventArgs e)
        {
            endTime = 540;
            StartTimedGame();
        }

        private void Medium_Click(object sender, EventArgs e)
        {
            endTime = 360;
            StartTimedGame();
        }

        private void Hard_Click(object sender, EventArgs e)
        {
            endTime = 180;
            StartTimedGame();
        }

        private void oneVone_Click(object sender, EventArgs e)
        {
            disposer();
            multiPlayer = true;
            gameP1 = new Game(this, true,1);
            gameP1.generator();
            gameP2 = new Game(this, true,2);
            gameP2.generator();
            multiPlayerLabel.Text = "1 VS 1";
            multiPlayerLabel.Location = new Point(this.Width / 2 - 100, 80);
            Square[,] squaresP1 = gameP1.getSquares();
            Square[,] squaresP2 = gameP2.getSquares();
            for (int i = 0; i < squaresP1.GetLength(0); i++)
            {
                for (int j = 0; j < squaresP1.GetLength(1); j++)
                {
                    squaresP2[i,j].setColor(squaresP1[i,j].getColor());
                }
            }
            Square mainSquareP1 = gameP1.getMainSquare();
            Square mainSquareP2 = gameP2.getMainSquare();
            mainSquareP2.setColor(mainSquareP1.getColor());
            gameP2.setOriginColor(mainSquareP1.getColor());
            player1.Location = new Point((this.Width / 2) + 50, (this.Height / 2) - 100);
            player2.Location = new Point((this.Width / 2) - 150, (this.Height / 2) - 100);
            player1.Show();
            player2.Show();
        }
        public void winner(int player)
        {
            multiPlayerLabel.Text = $"winner is player {player}";
            multiPlayerLabel.Location = new Point(150, 80);
            gameP1.endGame();
            gameP2.endGame();
            player1.Hide();
            player2.Hide();
        }

        private void endGame_Click(object sender, EventArgs e)
        {
            game.endGame();
            levelIndecator.Hide();
            highestScoreIndecator.Hide();
            inGameScore.Hide();
            Mode.Hide();
            endGame.Hide();
            Timer.Stop();
            Timer_Count.Hide();
            Timed.Show();
            Endless.Show();
            Title.Show();
            oneVone.Show();

        }
    }
    enum Dir
    {
        up, down, left, right,none
    }
}
