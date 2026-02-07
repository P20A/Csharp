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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.guide = new System.Windows.Forms.Button();
            this.playerOneGuide = new System.Windows.Forms.Label();
            this.playerTwoGuide = new System.Windows.Forms.Label();
            this.timedModeGuide = new System.Windows.Forms.Label();
            this.oneVOneModeGuide = new System.Windows.Forms.Label();
            this.endlessModeGuide = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.escGuide = new System.Windows.Forms.Label();
            this.setting = new System.Windows.Forms.Button();
            this.set1 = new System.Windows.Forms.Button();
            this.set2 = new System.Windows.Forms.Button();
            this.set3 = new System.Windows.Forms.Button();
            this.bg1 = new System.Windows.Forms.Button();
            this.bg2 = new System.Windows.Forms.Button();
            this.bg3 = new System.Windows.Forms.Button();
            this.bg4 = new System.Windows.Forms.Button();
            this.credits = new System.Windows.Forms.Button();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.github = new System.Windows.Forms.Button();
            this.me = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.me)).BeginInit();
            this.SuspendLayout();
            // 
            // inGameScore
            // 
            this.inGameScore.AutoSize = true;
            this.inGameScore.BackColor = System.Drawing.Color.Transparent;
            this.inGameScore.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inGameScore.Location = new System.Drawing.Point(7, 40);
            this.inGameScore.Name = "inGameScore";
            this.inGameScore.Size = new System.Drawing.Size(0, 20);
            this.inGameScore.TabIndex = 4;
            // 
            // levelIndecator
            // 
            this.levelIndecator.AutoSize = true;
            this.levelIndecator.BackColor = System.Drawing.Color.Transparent;
            this.levelIndecator.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelIndecator.Location = new System.Drawing.Point(277, 40);
            this.levelIndecator.Name = "levelIndecator";
            this.levelIndecator.Size = new System.Drawing.Size(0, 58);
            this.levelIndecator.TabIndex = 1;
            // 
            // highestScoreIndecator
            // 
            this.highestScoreIndecator.AutoSize = true;
            this.highestScoreIndecator.BackColor = System.Drawing.Color.Transparent;
            this.highestScoreIndecator.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestScoreIndecator.Location = new System.Drawing.Point(6, 7);
            this.highestScoreIndecator.Name = "highestScoreIndecator";
            this.highestScoreIndecator.Size = new System.Drawing.Size(0, 20);
            this.highestScoreIndecator.TabIndex = 2;
            // 
            // Endless
            // 
            this.Endless.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.Timed.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.Mode.BackColor = System.Drawing.Color.Transparent;
            this.Mode.Font = new System.Drawing.Font("Magneto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mode.Location = new System.Drawing.Point(7, 79);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(0, 19);
            this.Mode.TabIndex = 7;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
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
            this.Timer_Count.BackColor = System.Drawing.Color.Transparent;
            this.Timer_Count.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer_Count.Location = new System.Drawing.Point(649, 12);
            this.Timer_Count.Name = "Timer_Count";
            this.Timer_Count.Size = new System.Drawing.Size(0, 20);
            this.Timer_Count.TabIndex = 9;
            // 
            // Easy
            // 
            this.Easy.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.Medium.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.Hard.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.oneVone.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.multiPlayerLabel.BackColor = System.Drawing.Color.Transparent;
            this.multiPlayerLabel.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiPlayerLabel.Location = new System.Drawing.Point(85, 80);
            this.multiPlayerLabel.Name = "multiPlayerLabel";
            this.multiPlayerLabel.Size = new System.Drawing.Size(0, 58);
            this.multiPlayerLabel.TabIndex = 14;
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.BackColor = System.Drawing.Color.Transparent;
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
            this.player2.BackColor = System.Drawing.Color.Transparent;
            this.player2.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2.Location = new System.Drawing.Point(250, 400);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(112, 25);
            this.player2.TabIndex = 16;
            this.player2.Text = "Player 2";
            // 
            // guide
            // 
            this.guide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guide.Location = new System.Drawing.Point(608, 419);
            this.guide.Name = "guide";
            this.guide.Size = new System.Drawing.Size(85, 60);
            this.guide.TabIndex = 17;
            this.guide.Text = "Guide";
            this.guide.UseVisualStyleBackColor = true;
            this.guide.Click += new System.EventHandler(this.guide_Click);
            // 
            // playerOneGuide
            // 
            this.playerOneGuide.AutoSize = true;
            this.playerOneGuide.BackColor = System.Drawing.Color.Transparent;
            this.playerOneGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneGuide.Location = new System.Drawing.Point(48, 118);
            this.playerOneGuide.Name = "playerOneGuide";
            this.playerOneGuide.Size = new System.Drawing.Size(32, 18);
            this.playerOneGuide.TabIndex = 18;
            this.playerOneGuide.Text = "ppp";
            // 
            // playerTwoGuide
            // 
            this.playerTwoGuide.AutoSize = true;
            this.playerTwoGuide.BackColor = System.Drawing.Color.Transparent;
            this.playerTwoGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoGuide.Location = new System.Drawing.Point(252, 118);
            this.playerTwoGuide.Name = "playerTwoGuide";
            this.playerTwoGuide.Size = new System.Drawing.Size(32, 18);
            this.playerTwoGuide.TabIndex = 19;
            this.playerTwoGuide.Text = "ppp";
            // 
            // timedModeGuide
            // 
            this.timedModeGuide.AutoSize = true;
            this.timedModeGuide.BackColor = System.Drawing.Color.Transparent;
            this.timedModeGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timedModeGuide.Location = new System.Drawing.Point(617, 118);
            this.timedModeGuide.Name = "timedModeGuide";
            this.timedModeGuide.Size = new System.Drawing.Size(32, 18);
            this.timedModeGuide.TabIndex = 20;
            this.timedModeGuide.Text = "ppp";
            // 
            // oneVOneModeGuide
            // 
            this.oneVOneModeGuide.AutoSize = true;
            this.oneVOneModeGuide.BackColor = System.Drawing.Color.Transparent;
            this.oneVOneModeGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneVOneModeGuide.Location = new System.Drawing.Point(48, 223);
            this.oneVOneModeGuide.Name = "oneVOneModeGuide";
            this.oneVOneModeGuide.Size = new System.Drawing.Size(32, 18);
            this.oneVOneModeGuide.TabIndex = 21;
            this.oneVOneModeGuide.Text = "ppp";
            // 
            // endlessModeGuide
            // 
            this.endlessModeGuide.AutoSize = true;
            this.endlessModeGuide.BackColor = System.Drawing.Color.Transparent;
            this.endlessModeGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endlessModeGuide.Location = new System.Drawing.Point(436, 118);
            this.endlessModeGuide.Name = "endlessModeGuide";
            this.endlessModeGuide.Size = new System.Drawing.Size(32, 18);
            this.endlessModeGuide.TabIndex = 22;
            this.endlessModeGuide.Text = "ppp";
            // 
            // back
            // 
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Location = new System.Drawing.Point(330, 337);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(85, 60);
            this.back.TabIndex = 23;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // escGuide
            // 
            this.escGuide.AutoSize = true;
            this.escGuide.BackColor = System.Drawing.Color.Transparent;
            this.escGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escGuide.Location = new System.Drawing.Point(436, 223);
            this.escGuide.Name = "escGuide";
            this.escGuide.Size = new System.Drawing.Size(32, 18);
            this.escGuide.TabIndex = 24;
            this.escGuide.Text = "ppp";
            // 
            // setting
            // 
            this.setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setting.Location = new System.Drawing.Point(228, 296);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(85, 60);
            this.setting.TabIndex = 25;
            this.setting.Text = "Setting";
            this.setting.UseVisualStyleBackColor = true;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // set1
            // 
            this.set1.BackColor = System.Drawing.Color.Transparent;
            this.set1.BackgroundImage = global::Project.Properties.Resources.blueSet1;
            this.set1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.set1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set1.Location = new System.Drawing.Point(58, 345);
            this.set1.Name = "set1";
            this.set1.Size = new System.Drawing.Size(100, 100);
            this.set1.TabIndex = 26;
            this.set1.UseVisualStyleBackColor = false;
            this.set1.Click += new System.EventHandler(this.set1_Click);
            // 
            // set2
            // 
            this.set2.BackColor = System.Drawing.Color.Transparent;
            this.set2.BackgroundImage = global::Project.Properties.Resources.blueSet2;
            this.set2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.set2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set2.Location = new System.Drawing.Point(58, 209);
            this.set2.Name = "set2";
            this.set2.Size = new System.Drawing.Size(100, 100);
            this.set2.TabIndex = 27;
            this.set2.UseVisualStyleBackColor = false;
            this.set2.Click += new System.EventHandler(this.set2_Click);
            // 
            // set3
            // 
            this.set3.BackColor = System.Drawing.Color.Transparent;
            this.set3.BackgroundImage = global::Project.Properties.Resources.blueSet3;
            this.set3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.set3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set3.Location = new System.Drawing.Point(207, 364);
            this.set3.Name = "set3";
            this.set3.Size = new System.Drawing.Size(100, 100);
            this.set3.TabIndex = 28;
            this.set3.UseVisualStyleBackColor = false;
            this.set3.Click += new System.EventHandler(this.set3_Click);
            // 
            // bg1
            // 
            this.bg1.BackColor = System.Drawing.Color.Transparent;
            this.bg1.BackgroundImage = global::Project.Properties.Resources.background1;
            this.bg1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bg1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bg1.Location = new System.Drawing.Point(593, 204);
            this.bg1.Name = "bg1";
            this.bg1.Size = new System.Drawing.Size(100, 100);
            this.bg1.TabIndex = 29;
            this.bg1.UseVisualStyleBackColor = false;
            this.bg1.Click += new System.EventHandler(this.back1_Click);
            // 
            // bg2
            // 
            this.bg2.BackColor = System.Drawing.Color.Transparent;
            this.bg2.BackgroundImage = global::Project.Properties.Resources.background2;
            this.bg2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bg2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bg2.Location = new System.Drawing.Point(474, 286);
            this.bg2.Name = "bg2";
            this.bg2.Size = new System.Drawing.Size(100, 100);
            this.bg2.TabIndex = 30;
            this.bg2.UseVisualStyleBackColor = false;
            this.bg2.Click += new System.EventHandler(this.back2_Click);
            // 
            // bg3
            // 
            this.bg3.BackColor = System.Drawing.Color.Transparent;
            this.bg3.BackgroundImage = global::Project.Properties.Resources.background3;
            this.bg3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bg3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bg3.Location = new System.Drawing.Point(406, 392);
            this.bg3.Name = "bg3";
            this.bg3.Size = new System.Drawing.Size(100, 100);
            this.bg3.TabIndex = 31;
            this.bg3.UseVisualStyleBackColor = false;
            this.bg3.Click += new System.EventHandler(this.back3_Click);
            // 
            // bg4
            // 
            this.bg4.BackColor = System.Drawing.Color.Transparent;
            this.bg4.BackgroundImage = global::Project.Properties.Resources.background4;
            this.bg4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bg4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bg4.Location = new System.Drawing.Point(325, 200);
            this.bg4.Name = "bg4";
            this.bg4.Size = new System.Drawing.Size(100, 100);
            this.bg4.TabIndex = 32;
            this.bg4.UseVisualStyleBackColor = false;
            this.bg4.Click += new System.EventHandler(this.back4_Click);
            // 
            // credits
            // 
            this.credits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.credits.Location = new System.Drawing.Point(641, 326);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(85, 60);
            this.credits.TabIndex = 33;
            this.credits.Text = "Credits";
            this.credits.UseVisualStyleBackColor = true;
            this.credits.Click += new System.EventHandler(this.credits_Click);
            // 
            // creditsLabel
            // 
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.BackColor = System.Drawing.Color.Transparent;
            this.creditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsLabel.Location = new System.Drawing.Point(24, 138);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(752, 52);
            this.creditsLabel.TabIndex = 34;
            this.creditsLabel.Text = "this game is developed by parsa ataei";
            // 
            // github
            // 
            this.github.Cursor = System.Windows.Forms.Cursors.Hand;
            this.github.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.github.Location = new System.Drawing.Point(308, 244);
            this.github.Name = "github";
            this.github.Size = new System.Drawing.Size(200, 60);
            this.github.TabIndex = 35;
            this.github.Text = "Go to git hub";
            this.github.UseVisualStyleBackColor = true;
            this.github.Click += new System.EventHandler(this.github_Click);
            // 
            // me
            // 
            this.me.BackColor = System.Drawing.Color.Transparent;
            this.me.BackgroundImage = global::Project.Properties.Resources.me;
            this.me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.me.Cursor = System.Windows.Forms.Cursors.Hand;
            this.me.Location = new System.Drawing.Point(268, 64);
            this.me.Name = "me";
            this.me.Size = new System.Drawing.Size(170, 170);
            this.me.TabIndex = 36;
            this.me.TabStop = false;
            this.me.Click += new System.EventHandler(this.github_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.me);
            this.Controls.Add(this.github);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.bg4);
            this.Controls.Add(this.bg3);
            this.Controls.Add(this.bg2);
            this.Controls.Add(this.bg1);
            this.Controls.Add(this.set3);
            this.Controls.Add(this.set2);
            this.Controls.Add(this.set1);
            this.Controls.Add(this.setting);
            this.Controls.Add(this.escGuide);
            this.Controls.Add(this.back);
            this.Controls.Add(this.endlessModeGuide);
            this.Controls.Add(this.oneVOneModeGuide);
            this.Controls.Add(this.timedModeGuide);
            this.Controls.Add(this.playerTwoGuide);
            this.Controls.Add(this.playerOneGuide);
            this.Controls.Add(this.guide);
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
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.me)).EndInit();
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
        private System.Windows.Forms.Button guide;
        private System.Windows.Forms.Label playerOneGuide;
        private System.Windows.Forms.Label playerTwoGuide;
        private System.Windows.Forms.Label timedModeGuide;
        private System.Windows.Forms.Label oneVOneModeGuide;
        private System.Windows.Forms.Label endlessModeGuide;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label escGuide;
        private System.Windows.Forms.Button setting;
        private System.Windows.Forms.Button set1;
        private System.Windows.Forms.Button set2;
        private System.Windows.Forms.Button set3;
        private System.Windows.Forms.Button bg1;
        private System.Windows.Forms.Button bg2;
        private System.Windows.Forms.Button bg3;
        private System.Windows.Forms.Button bg4;
        private System.Windows.Forms.Button credits;
        private System.Windows.Forms.Label creditsLabel;
        private System.Windows.Forms.Button github;
        private System.Windows.Forms.PictureBox me;
    }
}

