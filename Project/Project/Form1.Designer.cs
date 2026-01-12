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
            this.inGameScore = new System.Windows.Forms.Label();
            this.levelIndecator = new System.Windows.Forms.Label();
            this.highestScoreIndecator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inGameScore
            // 
            this.inGameScore.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inGameScore.Location = new System.Drawing.Point(7, 40);
            this.inGameScore.Name = "inGameScore";
            this.inGameScore.Size = new System.Drawing.Size(100, 23);
            this.inGameScore.TabIndex = 4;
            // 
            // levelIndecator
            // 
            this.levelIndecator.AutoSize = true;
            this.levelIndecator.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelIndecator.Location = new System.Drawing.Point(306, 27);
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
            this.highestScoreIndecator.Size = new System.Drawing.Size(157, 20);
            this.highestScoreIndecator.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.highestScoreIndecator);
            this.Controls.Add(this.levelIndecator);
            this.Controls.Add(this.inGameScore);
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
    }
}

