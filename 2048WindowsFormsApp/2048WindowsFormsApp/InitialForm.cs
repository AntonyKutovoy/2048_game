using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class InitialForm : Form
    {
        public TextBox userNameTextBox;
        public int mapSize = 4;
        private MainForm mainForm = new MainForm();
        private Button increaseMapSizeButton;
        private Button reduceMapSizeButton;

        public InitialForm()
        {
            InitializeComponent();
            CreateUserNameTextBox();
            CreateIncreaseMapSizeButton();
            CreateReduceMapSizeButton();
            mapSizeLabel.Visible = false;
            mapSizeLabel.ForeColor = Color.FromArgb(119, 110, 101);
            ShowMapSize();
            this.BackColor = Color.FromArgb(250, 248, 239);
            twoThousandFortyEightLabel.ForeColor = Color.FromArgb(119, 110, 101);
            newPlayerButton.BackColor = Color.FromArgb(119, 110, 101);
            newPlayerButton.ForeColor = Color.FromArgb(249, 246, 242);
            sizeMapButton.BackColor = Color.FromArgb(119, 110, 101);
            sizeMapButton.ForeColor = Color.FromArgb(249, 246, 242);
            newGameButton.BackColor = Color.FromArgb(119, 110, 101);
            newGameButton.ForeColor = Color.FromArgb(249, 246, 242);
            exitButton.BackColor = Color.FromArgb(119, 110, 101);
            exitButton.ForeColor = Color.FromArgb(249, 246, 242);
            increaseMapSizeButton.BackColor = Color.FromArgb(119, 110, 101);
            increaseMapSizeButton.ForeColor = Color.FromArgb(249, 246, 242);
            reduceMapSizeButton.BackColor = Color.FromArgb(119, 110, 101);
            reduceMapSizeButton.ForeColor = Color.FromArgb(249, 246, 242);

        }

        private void CreateUserNameTextBox()
        {
            userNameTextBox = new TextBox();
            userNameTextBox.Location = new Point(37, 119);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(115, 20);
            userNameTextBox.TabIndex = 1;
            Controls.Add(userNameTextBox);
            userNameTextBox.Text = "Игрок";
            userNameTextBox.Visible = false;
        }

        private void CreateIncreaseMapSizeButton()
        {
            increaseMapSizeButton = new Button();
            increaseMapSizeButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            increaseMapSizeButton.Location = new Point(269, 109);
            increaseMapSizeButton.Name = "increaseMapSizeButton";
            increaseMapSizeButton.Size = new Size(38, 38);
            increaseMapSizeButton.TabIndex = 9;
            increaseMapSizeButton.Text = ">";
            increaseMapSizeButton.UseVisualStyleBackColor = true;
            increaseMapSizeButton.Click += new EventHandler(this.IncreaseMapSizeButton_Click);
            Controls.Add(increaseMapSizeButton);
            increaseMapSizeButton.Visible = false;
        }

        private void CreateReduceMapSizeButton()
        {
            reduceMapSizeButton = new Button();
            reduceMapSizeButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            reduceMapSizeButton.Location = new Point(192, 109);
            reduceMapSizeButton.Name = "reduceMapSizeButton";
            reduceMapSizeButton.Size = new Size(38, 38);
            reduceMapSizeButton.TabIndex = 10;
            reduceMapSizeButton.Text = "<";
            reduceMapSizeButton.UseVisualStyleBackColor = true;
            reduceMapSizeButton.Click += new EventHandler(this.ReduceMapSizeButton_Click);
            Controls.Add(reduceMapSizeButton);
            reduceMapSizeButton.Visible = false;
        }

        private void NewPlayerButton_Click(object sender, EventArgs e)
        {
            newPlayerButton.Visible = false;
            userNameTextBox.Text = "";
            userNameTextBox.Visible = true;
        }

        private void SizeMapButton_Click(object sender, EventArgs e)
        {
            sizeMapButton.Visible = false;
            increaseMapSizeButton.Visible = true;
            reduceMapSizeButton.Visible = true;
            mapSizeLabel.Visible = true;
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(userNameTextBox.Text))
            {
                userNameTextBox.Text = "Игрок";
            }
            this.DialogResult = DialogResult.OK;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            mainForm.ExitMessageBox();
        }

        private void IncreaseMapSizeButton_Click(object sender, EventArgs e)
        {
            mapSize++;
            ShowMapSize();
        }

        private void ReduceMapSizeButton_Click(object sender, EventArgs e)
        {
            mapSize--;
            if (mapSize < 3)
            {
                mapSize = 3;
            }
            ShowMapSize();
        }
        private void ShowMapSize()
        {
            mapSizeLabel.Text = mapSize.ToString();
        }
    }
}
