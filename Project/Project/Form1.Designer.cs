namespace Project
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.inGameScore = new System.Windows.Forms.Label();
            this.levelIndecator = new System.Windows.Forms.Label();
            this.highestScoreIndecator = new System.Windows.Forms.Label();
            this.Endless = new System.Windows.Forms.Button();
            this.Timed = new System.Windows.Forms.Button();
            this.Mode = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Timer_Count = new System.Windows.Forms.Label();
            this.Easy = new System.Windows.Forms.Button();
            this.Medium = new System.Windows.Forms.Button();
            this.Hard = new System.Windows.Forms.Button();
            this.oneVone = new System.Windows.Forms.Button();
            this.multiPlayerLabel = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.Label();
            this.endGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inGameScore
            // 
            this.inGameScore.AutoSize = true;
            this.inGameScore.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inGameScore.Location = new System.Drawing.Point(7, 40);
            this.inGameScore.Name = "inGameScore";
            this.inGameScore.Size = new System.Drawing.Size(0, 20);
            this.inGameScore.TabIndex = 4;
            // 
            // levelIndecator
            // 
            this.levelIndecator.AutoSize = true;
            this.levelIndecator.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelIndecator.Location = new System.Drawing.Point(277, 40);
            this.levelIndecator.Name = "levelIndecator";
            this.levelIndecator.Size = new System.Drawing.Size(0, 58);
            this.levelIndecator.TabIndex = 1;
            // 
            // highestScoreIndecator
            // 
            this.highestScoreIndecator.AutoSize = true;
            this.highestScoreIndecator.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestScoreIndecator.Location = new System.Drawing.Point(6, 7);
            this.highestScoreIndecator.Name = "highestScoreIndecator";
            this.highestScoreIndecator.Size = new System.Drawing.Size(0, 20);
            this.highestScoreIndecator.TabIndex = 2;
            // 
            // Endless
            // 
            this.Endless.Location = new System.Drawing.Point(192, 204);
            this.Endless.Name = "Endless";
            this.Endless.Size = new System.Drawing.Size(85, 60);
            this.Endless.TabIndex = 5;
            this.Endless.Text = "Endless";
            this.Endless.UseVisualStyleBackColor = true;
            this.Endless.Click += new System.EventHandler(this.Endless_Click);
            // 
            // Timed
            // 
            this.Timed.Location = new System.Drawing.Point(474, 204);
            this.Timed.Name = "Timed";
            this.Timed.Size = new System.Drawing.Size(85, 60);
            this.Timed.TabIndex = 6;
            this.Timed.Text = "Timed";
            this.Timed.UseVisualStyleBackColor = true;
            this.Timed.Click += new System.EventHandler(this.Timed_Click);
            // 
            // Mode
            // 
            this.Mode.AutoSize = true;
            this.Mode.Font = new System.Drawing.Font("Magneto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mode.Location = new System.Drawing.Point(7, 79);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(0, 19);
            this.Mode.TabIndex = 7;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(85, 10);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(597, 58);
            this.Title.TabIndex = 8;
            this.Title.Text = "Russain Square game";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Timer_Count
            // 
            this.Timer_Count.AutoSize = true;
            this.Timer_Count.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer_Count.Location = new System.Drawing.Point(649, 12);
            this.Timer_Count.Name = "Timer_Count";
            this.Timer_Count.Size = new System.Drawing.Size(0, 20);
            this.Timer_Count.TabIndex = 9;
            // 
            // Easy
            // 
            this.Easy.Location = new System.Drawing.Point(340, 162);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(75, 23);
            this.Easy.TabIndex = 10;
            this.Easy.Text = "Easy";
            this.Easy.UseVisualStyleBackColor = true;
            this.Easy.Click += new System.EventHandler(this.Easy_Click);
            // 
            // Medium
            // 
            this.Medium.Location = new System.Drawing.Point(340, 223);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(75, 23);
            this.Medium.TabIndex = 11;
            this.Medium.Text = "Medium";
            this.Medium.UseVisualStyleBackColor = true;
            this.Medium.Click += new System.EventHandler(this.Medium_Click);
            // 
            // Hard
            // 
            this.Hard.Location = new System.Drawing.Point(340, 286);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(75, 23);
            this.Hard.TabIndex = 12;
            this.Hard.Text = "Hard";
            this.Hard.UseVisualStyleBackColor = true;
            this.Hard.Click += new System.EventHandler(this.Hard_Click);
            // 
            // oneVone
            // 
            this.oneVone.Location = new System.Drawing.Point(330, 204);
            this.oneVone.Name = "oneVone";
            this.oneVone.Size = new System.Drawing.Size(85, 60);
            this.oneVone.TabIndex = 13;
            this.oneVone.Text = "1 VS 1";
            this.oneVone.UseVisualStyleBackColor = true;
            this.oneVone.Click += new System.EventHandler(this.oneVone_Click);
            // 
            // multiPlayerLabel
            // 
            this.multiPlayerLabel.AutoSize = true;
            this.multiPlayerLabel.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiPlayerLabel.Location = new System.Drawing.Point(85, 80);
            this.multiPlayerLabel.Name = "multiPlayerLabel";
            this.multiPlayerLabel.Size = new System.Drawing.Size(0, 58);
            this.multiPlayerLabel.TabIndex = 14;
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1.Location = new System.Drawing.Point(94, 383);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(107, 25);
            this.player1.TabIndex = 15;
            this.player1.Text = "Player 1";
            // 
            // player2
            // 
            this.player2.AutoSize = true;
            this.player2.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2.Location = new System.Drawing.Point(250, 400);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(112, 25);
            this.player2.TabIndex = 16;
            this.player2.Text = "Player 2";
            // 
            // endGame
            // 
            this.endGame.Location = new System.Drawing.Point(551, 445);
            this.endGame.Name = "endGame";
            this.endGame.Size = new System.Drawing.Size(100, 50);
            this.endGame.TabIndex = 17;
            this.endGame.Text = "End Game";
            this.endGame.UseVisualStyleBackColor = true;
            this.endGame.Click += new System.EventHandler(this.endGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.endGame);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.multiPlayerLabel);
            this.Controls.Add(this.oneVone);
            this.Controls.Add(this.Hard);
            this.Controls.Add(this.Medium);
            this.Controls.Add(this.Easy);
            this.Controls.Add(this.Timer_Count);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Mode);
            this.Controls.Add(this.Timed);
            this.Controls.Add(this.Endless);
            this.Controls.Add(this.highestScoreIndecator);
            this.Controls.Add(this.levelIndecator);
            this.Controls.Add(this.inGameScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inGameScore;
        private System.Windows.Forms.Label levelIndecator;
        private System.Windows.Forms.Label highestScoreIndecator;
        private System.Windows.Forms.Button Endless;
        private System.Windows.Forms.Button Timed;
        private System.Windows.Forms.Label Mode;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label Timer_Count;
        private System.Windows.Forms.Button Easy;
        private System.Windows.Forms.Button Medium;
        private System.Windows.Forms.Button Hard;
        private System.Windows.Forms.Button oneVone;
        private System.Windows.Forms.Label multiPlayerLabel;
        private System.Windows.Forms.Label player1;
        private System.Windows.Forms.Label player2;
        private System.Windows.Forms.Button endGame;
    }
}

