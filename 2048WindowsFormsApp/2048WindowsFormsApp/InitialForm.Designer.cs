using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    partial class InitialForm
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.newPlayerButton = new System.Windows.Forms.Button();
            this.twoThousandFortyEightLabel = new System.Windows.Forms.Label();
            this.sizeMapButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.mapSizeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionLabel.Location = new System.Drawing.Point(172, 9);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(0, 29);
            this.questionLabel.TabIndex = 3;
            // 
            // newPlayerButton
            // 
            this.newPlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPlayerButton.Location = new System.Drawing.Point(37, 109);
            this.newPlayerButton.Name = "newPlayerButton";
            this.newPlayerButton.Size = new System.Drawing.Size(115, 38);
            this.newPlayerButton.TabIndex = 4;
            this.newPlayerButton.Text = "Ввести имя";
            this.newPlayerButton.UseVisualStyleBackColor = true;
            this.newPlayerButton.Click += new System.EventHandler(this.NewPlayerButton_Click);
            this.newPlayerButton.FlatAppearance.BorderSize = 0;
            this.newPlayerButton.FlatStyle = FlatStyle.Flat;
            // 
            // twoThousandFortyEightLabel
            // 
            this.twoThousandFortyEightLabel.AutoSize = true;
            this.twoThousandFortyEightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twoThousandFortyEightLabel.Location = new System.Drawing.Point(88, 19);
            this.twoThousandFortyEightLabel.Name = "twoThousandFortyEightLabel";
            this.twoThousandFortyEightLabel.Size = new System.Drawing.Size(180, 73);
            this.twoThousandFortyEightLabel.TabIndex = 5;
            this.twoThousandFortyEightLabel.Text = "2048";
            // 
            // sizeMapButton
            // 
            this.sizeMapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeMapButton.Location = new System.Drawing.Point(192, 109);
            this.sizeMapButton.Name = "sizeMapButton";
            this.sizeMapButton.Size = new System.Drawing.Size(115, 38);
            this.sizeMapButton.TabIndex = 6;
            this.sizeMapButton.Text = "Размер поля";
            this.sizeMapButton.UseVisualStyleBackColor = true;
            this.sizeMapButton.Click += new System.EventHandler(this.SizeMapButton_Click);
            this.sizeMapButton.FlatAppearance.BorderSize = 0;
            this.sizeMapButton.FlatStyle = FlatStyle.Flat;
            // 
            // newGameButton
            // 
            this.newGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newGameButton.Location = new System.Drawing.Point(37, 183);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(115, 38);
            this.newGameButton.TabIndex = 7;
            this.newGameButton.Text = "Начать игру";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            this.newGameButton.FlatAppearance.BorderSize = 0;
            this.newGameButton.FlatStyle = FlatStyle.Flat;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(192, 183);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(115, 38);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = FlatStyle.Flat;
            // 
            // mapSizeLabel
            // 
            this.mapSizeLabel.AutoSize = true;
            this.mapSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mapSizeLabel.Location = new System.Drawing.Point(243, 121);
            this.mapSizeLabel.Name = "mapSizeLabel";
            this.mapSizeLabel.Size = new System.Drawing.Size(15, 15);
            this.mapSizeLabel.TabIndex = 9;
            this.mapSizeLabel.Text = "4";
            this.mapSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 260);
            this.Controls.Add(this.mapSizeLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.sizeMapButton);
            this.Controls.Add(this.twoThousandFortyEightLabel);
            this.Controls.Add(this.newPlayerButton);
            this.Controls.Add(this.questionLabel);
            this.Name = "InitialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button newPlayerButton;
        private System.Windows.Forms.Label twoThousandFortyEightLabel;
        private System.Windows.Forms.Button sizeMapButton;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label mapSizeLabel;
    }
}