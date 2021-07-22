namespace _2048WindowsFormsApp
{
    partial class MainForm
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
            this.scoreLabel = new System.Windows.Forms.Label();
            this.twoThousandFortyEightLabel = new System.Windows.Forms.Label();
            this.bestScoreLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.newGameLabel = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ratingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreLabel.Location = new System.Drawing.Point(251, 38);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(112, 54);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Счет";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // twoThousandFortyEightLabel
            // 
            this.twoThousandFortyEightLabel.AutoSize = true;
            this.twoThousandFortyEightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twoThousandFortyEightLabel.Location = new System.Drawing.Point(12, 24);
            this.twoThousandFortyEightLabel.Name = "twoThousandFortyEightLabel";
            this.twoThousandFortyEightLabel.Size = new System.Drawing.Size(219, 91);
            this.twoThousandFortyEightLabel.TabIndex = 6;
            this.twoThousandFortyEightLabel.Text = "2048";
            // 
            // bestScoreLabel
            // 
            this.bestScoreLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bestScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bestScoreLabel.Location = new System.Drawing.Point(369, 38);
            this.bestScoreLabel.Name = "bestScoreLabel";
            this.bestScoreLabel.Size = new System.Drawing.Size(112, 54);
            this.bestScoreLabel.TabIndex = 7;
            this.bestScoreLabel.Text = "Рекорд";
            this.bestScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.Location = new System.Drawing.Point(12, 125);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(287, 16);
            this.infoLabel.TabIndex = 8;
            this.infoLabel.Text = "Соединяй числа и получи число 2048!";
            // 
            // newGameLabel
            // 
            this.newGameLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.newGameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newGameLabel.Location = new System.Drawing.Point(344, 103);
            this.newGameLabel.Name = "newGameLabel";
            this.newGameLabel.Size = new System.Drawing.Size(137, 38);
            this.newGameLabel.TabIndex = 9;
            this.newGameLabel.Text = "Новая игра";
            this.newGameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.newGameLabel.Click += new System.EventHandler(this.NewGameLabel_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(506, 24);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem
            // 
            this.toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.rulesToolStripMenuItem,
            this.ratingToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem.Name = "toolStripMenuItem";
            this.toolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem.Text = "Файл";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.newGameToolStripMenuItem.Text = "Новая игра";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.rulesToolStripMenuItem.Text = "Правила игры";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.RulesToolStripMenuItem_Click);
            // 
            // ratingToolStripMenuItem
            // 
            this.ratingToolStripMenuItem.Name = "ratingToolStripMenuItem";
            this.ratingToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ratingToolStripMenuItem.Text = "Рейтинг игроков";
            this.ratingToolStripMenuItem.Click += new System.EventHandler(this.RatingToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(506, 642);
            this.Controls.Add(this.newGameLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.bestScoreLabel);
            this.Controls.Add(this.twoThousandFortyEightLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.menuStrip);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label twoThousandFortyEightLabel;
        private System.Windows.Forms.Label bestScoreLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label newGameLabel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ratingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

