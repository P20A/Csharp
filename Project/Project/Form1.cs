using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
        int set = 1;
        int background = 1;
        PrivateFontCollection fonts;
        Font gameFont;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            loadFont();
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
            this.Text = "Russian square";
            Title.Location = new Point(centerX - 300, 0);
            Endless.Location = new Point(centerX - 140, centerY - 30);
            oneVone.Location = new Point(centerX - 40, centerY - 30);
            guide.Location = new Point(centerX - 40, centerY + 40);
            setting.Location = new Point(centerX - 140, centerY + 40);
            credits.Location = new Point(centerX + 60, centerY + 40);
            Timed.Location = new Point(centerX + 60, centerY - 30);
            Easy.Location = new Point(centerX - 50, centerY - 60);
            Medium.Location = new Point(centerX - 50, centerY - 30);
            Hard.Location = new Point(centerX - 50, centerY);
            creditsLabel.Location = new Point(centerX - 380, centerY - 150);
            github.Location = new Point(centerX - 100, centerY - 30);
            me.Location = new Point(centerX - 85,70);
            set1.Location = new Point(150, 150);
            set2.Location = new Point(350, 150);
            set3.Location = new Point(550, 150);
            bg1.Location = new Point(100, 300);
            bg2.Location = new Point(275, 300);
            bg3.Location = new Point(450, 300);
            bg4.Location = new Point(625, 300);
            Easy.Hide();
            Medium.Hide();
            Hard.Hide();
            player1.Hide();
            player2.Hide();
            playerOneGuide.Hide();
            playerTwoGuide.Hide();
            timedModeGuide.Hide();
            endlessModeGuide.Hide();
            oneVOneModeGuide.Hide();
            escGuide.Hide();
            back.Hide();
            set1.Hide();
            set2.Hide();
            set3.Hide();
            bg1.Hide();
            bg2.Hide();
            bg3.Hide();
            bg4.Hide();
            creditsLabel.Hide();
            github.Hide();
        }
        private void loadFont()
        {
            fonts = new PrivateFontCollection();
            byte[] fontData = Properties.Resources.myFont;
            IntPtr fontPtr = Marshal.AllocCoTaskMem( fontData.Length );
            Marshal.Copy(fontData,0,fontPtr, fontData.Length);
            fonts.AddMemoryFont(fontPtr,fontData.Length);
            Marshal.FreeCoTaskMem( fontPtr );
            gameFont = new Font(fonts.Families[0],12F);
            
            inGameScore.Font = gameFont;
            levelIndecator.Font = new Font(fonts.Families[0], 36F);
            highestScoreIndecator.Font=gameFont;
            Endless.Font = gameFont;
            Timed.Font = gameFont;
            Mode.Font = gameFont;
            Title.Font  = new Font(fonts.Families[0], 36F);
            Timer_Count.Font = gameFont;
            Easy.Font = gameFont;
            Medium.Font = gameFont;
            Hard.Font = gameFont;
            oneVone.Font = gameFont;
            multiPlayerLabel.Font = new Font(fonts.Families[0], 36F);
            player1.Font = new Font(fonts.Families[0], 16F);
            player2.Font = new Font(fonts.Families[0], 16F);
            guide.Font = gameFont;
            back.Font = gameFont;
            setting.Font = gameFont;
            credits.Font = gameFont;
            github.Font = new Font(fonts.Families[0], 16F);
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
                    case Keys.Escape:
                        gameEnder();
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
                    case Keys.Escape:
                        gameEnder();
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
            hider();
            Easy.Show();
            Medium.Show();
            Hard.Show();
        }

        private void Endless_Click(object sender, EventArgs e)
        {
            hider();
            Mode.Text = "Mode: Endless";
            levelIndecator.Show();
            highestScoreIndecator.Show();
            inGameScore.Show();
            Mode.Show();
            Title.Hide();
            game = new Game(this, true, set);
            game.generator();
        }
        private void hider()
        {
            Timed.Hide();
            Endless.Hide();
            oneVone.Hide();
            guide.Hide();
            setting.Hide();
            credits.Hide();
            me.Hide();
        }
        private void shower()
        {
            Timed.Show();
            Endless.Show();
            oneVone.Show();
            guide.Show();
            setting.Show();
            credits.Show();
            me.Show();
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
            Timer_Count.Show();
            Easy.Hide();
            Medium.Hide();
            Hard.Hide();
            Title.Hide();
            levelIndecator.Show();
            highestScoreIndecator.Show();
            inGameScore.Show();
            Mode.Show();
            game = new Game(this, false, set);
            game.generator();
            Timer.Start();
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
            hider();
            player1.Show();
            player2.Show();
            multiPlayerLabel.Show();
            multiPlayer = true;
            gameP1 = new Game(this, true, set, 1);
            gameP1.generator();
            gameP2 = new Game(this, true, set, 2);
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
        public void gameEnder()
        {
            if(game != null || gameP1 != null)
            {
                levelIndecator.Hide();
                highestScoreIndecator.Hide();
                inGameScore.Hide();
                Mode.Hide();
                player1.Hide();
                player2.Hide();
                multiPlayerLabel.Hide();
                Timer.Stop();
                Timer_Count.Hide();
                Title.Show();
                shower();
                if (multiPlayer)
                {
                    gameP1.endGame();
                    gameP2.endGame();
                }
                else
                    game.endGame();
                game = null;
                gameP1 = null;
                gameP2 = null;
                multiPlayer = false;
            }

        }

        private void guide_Click(object sender, EventArgs e)
        {
            hider();
            Title.Show();
            playerOneGuide.Show();
            playerOneGuide.Text = "Player 1 key bond:\narrow up for up\narrow down for down\narrow left for left\narrow right for right";
            playerTwoGuide.Show();
            playerTwoGuide.Text = "Player 2 key bond:\nW for up\nS for down\nA for left\nD for right";
            timedModeGuide.Show();
            timedModeGuide.Text = "Timed mode:\nEasy: 9 minutes\nMedium: 6 minutes\nHard: 3 minutes";
            oneVOneModeGuide.Show();
            oneVOneModeGuide.Text = "First player to end the game is the winner";
            endlessModeGuide.Show();
            endlessModeGuide.Text = "Score more points\nand set a record";
            escGuide.Show();
            escGuide.Text = "Press esc for ending the game";
            back.Location = new Point(centerX - 50, centerY + 40);
            back.Show();
        }
        private void setting_Click(object sender, EventArgs e)
        {
            hider();
            Title.Show();
            set1.Show();
            set2.Show();
            set3.Show();
            bg1.Show();
            bg2.Show();
            bg3.Show();
            bg4.Show();
            back.Location = new Point(centerX - 50, centerY + 140);
            back.Show();
        }
        private void closeSetting()
        {
            set1.Hide();
            set2.Hide();
            set3.Hide();
            bg1.Hide();
            bg2.Hide();
            bg3.Hide();
            bg4.Hide();
            back.Hide();
            Title.Show();
            shower();
        }
        private void set1_Click(object sender, EventArgs e)
        {
            set = 1;
            closeSetting();
        }

        private void set2_Click(object sender, EventArgs e)
        {
            set = 2;
            closeSetting();
        }

        private void set3_Click(object sender, EventArgs e)
        {
            set = 3;
            closeSetting();
        }

        private void back1_Click(object sender, EventArgs e)
        {
            background = 1;
            this.BackgroundImage = Properties.Resources.background1;
            closeSetting();
        }

        private void back2_Click(object sender, EventArgs e)
        {
            background = 2;
            this.BackgroundImage = Properties.Resources.background2;
            closeSetting();
        }

        private void back3_Click(object sender, EventArgs e)
        {
            background = 3;
            this.BackgroundImage = Properties.Resources.background3;
            closeSetting();
        }

        private void back4_Click(object sender, EventArgs e)
        {
            background = 4;
            this.BackgroundImage = Properties.Resources.background4;
            closeSetting();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            playerOneGuide.Hide();
            playerTwoGuide.Hide();
            timedModeGuide.Hide();
            endlessModeGuide.Hide();
            oneVOneModeGuide.Hide();
            github.Hide();
            creditsLabel.Hide();
            escGuide.Hide();
            Title.Show();
            closeSetting();
            back.Hide();

        }

        private void credits_Click(object sender, EventArgs e)
        {
            hider();
            creditsLabel.Show();
            github.Show();
            back.Show();
            back.Location = new Point(centerX - 40,centerY + 40);
        }

        private void github_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/P20A",
                UseShellExecute = true
            });
        }
    }
    enum Dir
    {
        up, down, left, right,none
    }
}
