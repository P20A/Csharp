using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Project
{
    internal class Game
    {
        private Square mainSquare;
        private int col , row ;
        private Square[,] squares;
        private Form1 form;
        private int squareWidth;
        private int originX;
        private int originY;
        private Color originColor;
        private Color[] colors = new Color[5];
        private int level = 1;
        private int score = 0;
        private bool endless;
        private bool multiplayer = false;
        public int player;
        private int set;
        public Game(Form1 form, bool endless, int set = 0, int player = 0, int width = 30)
        {
            this.form = form;
            this.squareWidth = width;
            this.endless = endless;
            this.player = player;
            this.set = set;
            colors[0] = Color.Blue;
            colors[1] = Color.Red;
            colors[2] = Color.Orange;
            colors[3] = Color.Green;
            colors[4] = Color.Purple;
            switch (player)
            {
                case 0:
                    originX = (form.Width / 2) - (col / 2) * squareWidth - 50;
                    originY = (form.Height / 2) - (row / 2) * squareWidth - 50;
                    form.highestScoreSetter(score);
                    break;
                case 1:
                    originX = ((form.Width / 2) - (col / 2) * squareWidth) + 50;
                    originY = (form.Height / 2) - (row / 2) * squareWidth;
                    multiplayer = true;
                    break;
                case 2:
                    originX = ((form.Width / 2) - (col / 2) * squareWidth) - 200;
                    originY = (form.Height / 2) - (row / 2) * squareWidth;
                    multiplayer = true;
                    break;
            }
        }
        public void generator()
        {
            levelDesign();
            squares = new Square[row, col];
            Random random = new Random();
            for (int i = 0; i < squares.GetLength(0); i++)
            {
                for (int j = 0; j < squares.GetLength(1); j++)
                {
                    Square temp = new Square(squareWidth, colors[random.Next(colors.Length)], form,set);
                    temp.showSquare(originX + i * squareWidth,originY + j * squareWidth);
                    squares[i, j] = temp;
                }
            }
            mainSquare = new Square(squareWidth, colors[random.Next(colors.Length)], form,set);
            mainSquare.showSquare(originX - squareWidth, originY);
            originColor = mainSquare.getColor();
            if (!multiplayer)
            {
                form.levelSetter(level);
                form.scoreSetter(score);
            }


        }
        public void levelDesign()
        {
            if (multiplayer)
            {
                row = 5; col = 5;
            }
            else
            {
                if (endless)
                {
                    if (level < 14)
                    {
                        row = level + 2;
                        col = level + 2;
                        originX -= 10;
                        originY -= 10;
                    }
                    else
                    {
                        row = 16;
                        col = 16;
                    }
                }
                else
                {
                    switch (level)
                    {
                        case 1:
                            row = 3; col = 3;
                            break;
                        case 2:
                            row = 4; col = 4;
                            break;
                        case 3:
                            row = 5; col = 5;
                            break;
                        case 4:
                            row = 6; col = 6;
                            break;
                        case 5:
                            row = 7; col = 7;
                            break;
                        case 6:
                            row = 8; col = 8;
                            break;
                    }
                }
            }
        }
        public void move(Dir dir)
        {
            int startX = originX - squareWidth;
            int endX = originX + (row * squareWidth);
            int startY = originY - squareWidth;
            int endY = originY + (col * squareWidth);
            switch (dir)
            {
                case Dir.up:
                    if (mainSquare.getY() > startY)
                    {
                        if (mainSquare.getY() == endY && mainSquare.getX() != startX && mainSquare.getX() != endX)
                        {
                            for (int i = 0; i < squares.GetLength(0); i++)
                            {
                                if (squares[i, 0].getY() == originY && squares[i, 0].getX() == mainSquare.getX())
                                {
                                    moveBlocks(i, Dir.up);
                                    break;
                                }
                            }
                            mainSquare.showSquare(mainSquare.getX(), startY);
                        }
                        else
                        {
                            mainSquare.setColor(originColor);
                            mainSquare.showSquare(mainSquare.getX(), mainSquare.getY() - squareWidth);
                        }
                    }
                    break;
                case Dir.down:
                    if (mainSquare.getY() < endY)
                    {
                        if (mainSquare.getY() == startY && mainSquare.getX() != startX && mainSquare.getX() != endX)
                        {
                            for (int i = 0; i < squares.GetLength(0); i++)
                            {
                                if (squares[i, col - 1].getY() == endY - squareWidth && squares[i, col - 1].getX() == mainSquare.getX())
                                {
                                    moveBlocks(i, Dir.down);
                                    break;
                                }
                            }
                            mainSquare.showSquare(mainSquare.getX(), endY);
                        }
                        else
                        {
                            mainSquare.setColor(originColor) ;
                            mainSquare.showSquare(mainSquare.getX(), mainSquare.getY() + squareWidth);
                        }
                    }
                    break;
                case Dir.left:
                    if (mainSquare.getX() > startX)
                    {
                        if (mainSquare.getX() == endX && mainSquare.getY() != startY && mainSquare.getY() != endY)
                        {
                            for (int i = 0; i < squares.GetLength(1); i++)
                            {
                                if (squares[row -1, i].getY() == mainSquare.getY() && squares[row - 1, i].getX() == endX - squareWidth)
                                {
                                    moveBlocks(i, Dir.left);
                                    break;
                                }
                            }
                            mainSquare.showSquare(startX, mainSquare.getY());
                        }
                        else
                        {
                            mainSquare.setColor(originColor);
                            mainSquare.showSquare(mainSquare.getX() - squareWidth, mainSquare.getY());
                        }
                    }
                    break;
                case Dir.right:
                    if (mainSquare.getX() < endX)
                    {
                        if (mainSquare.getX() == startX && mainSquare.getY() != startY && mainSquare.getY() != endY)
                        {
                            for (int i = 0; i < squares.GetLength(1); i++)
                            {
                                if (squares[0, i].getY() == mainSquare.getY() && squares[0, i].getX() == originX)
                                {
                                    moveBlocks(i,Dir.right);
                                    break;
                                }
                            }
                            mainSquare.showSquare(endX, mainSquare.getY());
                        }
                        else
                        {
                            mainSquare.setColor(originColor);
                            mainSquare.showSquare(mainSquare.getX() + squareWidth, mainSquare.getY());
                        }
                    }
                    break;
            }
            checkIfSync();
        }
        public void checkIfSync()
        {
            int colorCount = 0;
            if (row == 2 && col == 2)
            {
                for (int i = 0; i < squares.GetLength(0); i++)
                {
                    for (int j = 0; j < squares.GetLength(1); j++)
                    {
                        if (mainSquare.getColor() != squares[i, j].getColor())
                            colorCount++;
                    }
                }
                if (colorCount == 4)
                {
                    row = 1; col = 1;
                    checkIfSync();
                }
            }
            if (row <= 1 || col <= 1)
            {
                for(int i = 0;i < squares.GetLength(0); i++)
                {
                    for (int j = 0; j < squares.GetLength(1); j++)
                    {
                        squares[i, j].removeSquare();
                    }
                }
                mainSquare.removeSquare();
                if (multiplayer)
                {
                    form.winner(player);
                }
                else
                {
                    nextLevel();
                }

                return;
            }
            else
            {
                int count = 1;

                for (int j = 0; j < col; j++)
                {
                    count = 1;
                    for (int i = 1; i < row; i++)
                    {
                        if (squares[i, j].getColor() == squares[0, j].getColor())
                            count++;
                    }
                    if (count == row)
                    {
                        removeRow(j);
                        checkIfSync();
                    }
                }

                for (int i = 0; i < row; i++)
                {
                    count = 1;
                    for (int j = 1; j < col; j++)
                    {
                        if (j <= col - 1 && squares[i, j].getColor() == squares[i, 0].getColor())
                            count++;
                    }
                    if (count == col)
                    {
                        removeCol(i);
                        checkIfSync();
                    }
                }
            }
        }
        public void removeRow(int j)
        {
            for (int k = j + 1; k <= col ; k++)
            {
                for (int i = 0; i < row; i++)
                {
                    if (k == col)
                    {
                        squares[i,col - 1].removeSquare();
                    }
                    else
                        squares[i, k - 1].setColor(squares[i, k].getColor());
                }
            }
            if(!multiplayer)
                score = form.scoreSetter(score + (col * level));
            col--;
            if (mainSquare.getY() > originY + (col * squareWidth))
                mainSquare.showSquare(mainSquare.getX(), originY + (col * squareWidth));
            form.Update();
            System.Threading.Thread.Sleep(1000);
        }
        public void removeCol(int i)
        {
            for (int k = i + 1; k <= row; k++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (k == row)
                        squares[row - 1, j].removeSquare();
                    else
                        squares[k - 1, j].setColor(squares[k, j].getColor());
                }
            }
            if (!multiplayer)
                score = form.scoreSetter(score + (row * level));
            row--;
            if (mainSquare.getX() > originX + (row * squareWidth))
                mainSquare.showSquare(originX + (row * squareWidth), mainSquare.getY());
            form.Update();
            System.Threading.Thread.Sleep(1000);
        }
        public void moveBlocks(int i, Dir dir)
        {
            int count;
            switch (dir)
            {
                case Dir.up:
                    count = 0;
                    originColor = squares[i, count].getColor();
                    while (count < col - 1)
                    {
                        squares[i, count].setColor(squares[i, count + 1].getColor());
                        count++;
                    }
                    squares[i, col - 1].setColor(mainSquare.getColor());
                    mainSquare.setColor(originColor);
                    break;
                case Dir.down:
                    count = col - 1;
                    originColor = squares[i, count].getColor();
                    while (count > 0)
                    {
                        squares[i, count].setColor(squares[i, count - 1].getColor());
                        count--;
                    }
                    squares[i, 0].setColor(mainSquare.getColor());
                    mainSquare.setColor(originColor);
                    break;
                case Dir.left:
                    count = 0;
                    originColor = squares[count, i].getColor();
                    while (count < row - 1)
                    {
                        squares[count, i].setColor(squares[count + 1, i].getColor());
                        count++;
                    }
                    squares[row - 1, i].setColor(mainSquare.getColor());
                    mainSquare.setColor(originColor);
                    break;
                case Dir.right:
                    count = row - 1;
                    originColor = squares[count, i].getColor();
                    while (count > 0)
                    {
                        squares[count, i].setColor(squares[count - 1, i].getColor());
                        count--;
                    }
                    squares[0, i].setColor(mainSquare.getColor());
                    mainSquare.setColor(originColor);
                    break;
            }
        }
        public void nextLevel()
        {
            level++;
            generator();
            MessageBox.Show("next LEVEL!!!!!");
        }
        public void endGame()
        {
            form.highestScoreSetter(score);
            for (int i = 0; i < squares.GetLength(0); i++)
            {
                for (int j = 0; j < squares.GetLength(1); j++)
                {
                    squares[i, j].removeSquare();
                }
            }
            mainSquare.removeSquare();
        }
        public Square[,] getSquares()
        {
            return squares;
        }
        public Square getMainSquare()
        {
            return mainSquare;
        }
        public void setOriginColor(Color color)
        {
            originColor = color;
            mainSquare.setColor(originColor);
        }
    }
    class Square
    {
        private int width;
        //public Panel squarePanel;
        private PictureBox squareBox;
        Color squareColor;
        private Form1 form;
        int set;

        public Square(int w, Color SC, Form1 form,int set)
        {
            this.width = w;
            this.form = form;
            this.set = set;
            //this.squarePanel = new Panel();
            //this.squarePanel.BackColor = SC;
            //this.squarePanel.Size = new Size(width, width);
            //this.squarePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            squareColor = SC;
            squareBox = new PictureBox();
            squareBox.Size = new Size(width, width);
            squareBox.SizeMode = PictureBoxSizeMode.StretchImage;
            setColor(squareColor);
            this.form.Controls.Add(squareBox);
        }
        public void showSquare(int x, int y)
        {
            //this.squarePanel.Location = new Point(x, y);
            this.squareBox.Location = new Point(x, y);
        }
        public int getX()
        {
            //return this.squarePanel.Location.X;
            return this.squareBox.Location.X;
        }
        public int getY()
        {
            //return this.squarePanel.Location.Y;
            return this.squareBox.Location.Y;
        }
        public Color getColor()
        {
            //return this.squarePanel.BackColor;
            return squareColor;
        }
        public void setColor(Color color)
        {
            //this.squarePanel.BackColor = color;
            switch (color.Name)
            {
                case "Red":
                    switch (set)
                    {
                        case 1:
                            squareBox.Image = Properties.Resources.redSet1;
                            squareColor = color;
                            break;
                        case 2:
                            squareBox.Image = Properties.Resources.redSet2;
                            squareColor = color;
                            break;
                        case 3:
                            squareBox.Image = Properties.Resources.redSet3;
                            squareColor = color;
                            break;
                    }
                    break;
                case "Blue":
                    switch (set)
                    {
                        case 1:
                            squareBox.Image = Properties.Resources.blueSet1;
                            squareColor = color;
                            break;
                        case 2:
                            squareBox.Image = Properties.Resources.blueSet2;
                            squareColor = color;
                            break;
                        case 3:
                            squareBox.Image = Properties.Resources.blueSet3;
                            squareColor = color;
                            break;
                    }
                    break;
                case "Orange":
                    switch (set)
                    {
                        case 1:
                            squareBox.Image = Properties.Resources.orangeSet1;
                            squareColor = color;
                            break;
                        case 2:
                            squareBox.Image = Properties.Resources.orangeSet2;
                            squareColor = color;
                            break;
                        case 3:
                            squareBox.Image = Properties.Resources.orangeSet3;
                            squareColor = color;
                            break;
                    }
                    break;
                case "Green":
                    switch (set)
                    {
                        case 1:
                            squareBox.Image = Properties.Resources.greenSet1;
                            squareColor = color;
                            break;
                        case 2:
                            squareBox.Image = Properties.Resources.greenSet2;
                            squareColor = color;
                            break;
                        case 3:
                            squareBox.Image = Properties.Resources.greenSet3;
                            squareColor = color;
                            break;
                    }
                    break;
                case "Purple":
                    switch (set)
                    {
                        case 1:
                            squareBox.Image = Properties.Resources.purpleSet1;
                            squareColor = color;
                            break;
                        case 2:
                            squareBox.Image = Properties.Resources.purpleSet2;
                            squareColor = color;
                            break;
                        case 3:
                            squareBox.Image = Properties.Resources.purpleSet3;
                            squareColor = color;
                            break;
                    }
                    break;
            }
        }
        public void removeSquare()
        {
            //this.squarePanel.Dispose();
            this.squareBox.Dispose();
        }
    } 
}
