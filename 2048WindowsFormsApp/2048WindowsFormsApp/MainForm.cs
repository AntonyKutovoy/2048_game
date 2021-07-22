using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace _2048WindowsFormsApp
{
    public partial class MainForm : Form
    {

        private const int margin = 15;
        private const int tileSize = 100;
        private int mapSize;
        private Label[,] map;
        private int bestScore;
        private bool move = true;
        private Dictionary<int, TileColor> tilesColor = TilesColors.GetTilesColors();
        private TileColor tilecolor;
        private User user;
        private List <UserScore> usersScore = new List<UserScore>();

        public MainForm()
        {
            InitializeComponent();
            AutoScroll = true;
        }

        public void ExitMessageBox()
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите выйти?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var initialForm = new InitialForm();
            if (initialForm.ShowDialog(this) == DialogResult.OK)
            {
                user = new User(initialForm.userNameTextBox.Text, initialForm.mapSize);
                mapSize = user.mapSize;
                BackColor = Color.FromArgb(250, 248, 239);
                if(mapSize > 4)
                {
                    Width += (tileSize + margin) * (mapSize - 4);
                    Height += (tileSize + margin) * (mapSize - 4);
                }
                menuStrip.BackColor = Color.FromArgb(250, 248, 239);
                twoThousandFortyEightLabel.ForeColor = Color.FromArgb(119, 110, 101);
                infoLabel.ForeColor = Color.FromArgb(119, 110, 101);
                bestScoreLabel.BackColor = Color.FromArgb(187, 173, 160);
                bestScoreLabel.ForeColor = Color.FromArgb(249, 246, 242);
                scoreLabel.BackColor = Color.FromArgb(187, 173, 160);
                scoreLabel.ForeColor = Color.FromArgb(249, 246, 242);
                newGameLabel.BackColor = Color.FromArgb(119, 110, 101);
                newGameLabel.ForeColor = Color.FromArgb(249, 246, 242);
                tilesColor = TilesColors.GetTilesColors();
                InitMap();
                NewGame();
            }
            else
            {
                Close();
            }
        }

        private void SaveScore()
        {
            if (File.Exists("userScore.json"))
            {
                usersScore = UserScoreStorage.GetUserScoreFromFile();
            }
            var userScore = new UserScore(user.name, user.score);
            usersScore.Add(userScore);
            UserScoreStorage.SaveUserScore(usersScore);
        }

        private void ShowScore()
        {
            scoreLabel.Text = "Счет" + "\n" + user.score.ToString();
            if (!File.Exists("userScore.json") || user.score > bestScore)
            {
                bestScore = user.score;
            }
            else
            {
                usersScore = UserScoreStorage.GetUserScoreFromFile();
                bestScore = Convert.ToInt32(usersScore[0].score);
                for (int i = 1; i < usersScore.Count; i++)
                {
                    if (bestScore < Convert.ToInt32(usersScore[i].score))
                    {
                        bestScore = Convert.ToInt32(usersScore[i].score);
                    }
                }
                if (user.score > bestScore)
                {
                    bestScore = user.score;
                }
            }
            bestScoreLabel.Text = "Рекорд" + "\n" + bestScore.ToString();
        }

        private void InitMap()
        {
            var backGroundLabel = CreateBackGroundLabel(((tileSize + margin) * mapSize) + margin);
            Controls.Add(backGroundLabel);
            map = new Label[mapSize, mapSize];
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = CreateLabel(i, j);
                    backGroundLabel.Controls.Add(newLabel);
                    map[i, j] = newLabel;
                }
            }
        }

        private void NewGame()
        {
            user.score = 0;
            move = true;
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    tilecolor = tilesColor[1];
                    map[i, j].Text = string.Empty;
                    map[i, j].BackColor = tilecolor.color;
                }
            }
            GenerateNumber();
            ShowScore();
        }

        private Label CreateLabel(int rowIndex, int columnIndex)
        {
            var label = new Label();
            label.BackColor = Color.FromArgb(207, 197, 188);
            label.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            label.Size = new Size(tileSize, tileSize);
            label.TextAlign = ContentAlignment.MiddleCenter;
            var x = margin + columnIndex * (tileSize + margin);
            var y = margin + rowIndex * (tileSize + margin);
            label.Location = new Point(x, y);
            return label;
        }

        private Label CreateBackGroundLabel(int size)
        {
            var label = new Label();
            label.BackColor = Color.FromArgb(187, 173, 160);
            label.Size = new Size(size, size);
            var x = margin;
            var y = tileSize + tileSize / 2;
            label.Location = new Point(x, y);
            return label;
        }

        private bool CheckEmptyTiles()
        {
            var emptyTiles = mapSize * mapSize;
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (map[i, j].Text != string.Empty)
                    {
                        emptyTiles--;
                    }
                }
            }
            if (emptyTiles != 0)
            {
                return true;
            }
            return false;
        }

        private void GenerateNumber()
        {
            var random = new Random();
            while (move)
            {
                var rowIndex = random.Next(mapSize);
                var columnIndex = random.Next(mapSize);
                if (map[rowIndex, columnIndex].Text == string.Empty)
                {
                    int value = random.Next(0, 100) < 90 ? (int)2 : (int)4;
                    map[rowIndex, columnIndex].Text = value.ToString();
                    CheckTileColor(rowIndex, columnIndex);

                    break;
                }
            }
            move = false;
        }

        private void CheckTileColor(int rowIndex, int columnIndex)
        {
            int sum = Convert.ToInt32(map[rowIndex, columnIndex].Text);
            for (int i = 1; i <= 12; i++)
            {
                if (sum == Math.Pow(2, i))
                {
                    if (sum == 2048)
                    {
                        DialogResult result = MessageBox.Show("Поздравляем! Вы выиграли! Хотите начать сначала?", "Выигрыш", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            SaveScore();
                            NewGame();
                        }
                        else
                        {
                            SaveScore();
                            Close();
                        }
                    }
                    tilecolor = tilesColor[i + 1];
                    map[rowIndex, columnIndex].BackColor = tilecolor.color;
                    map[rowIndex, columnIndex].ForeColor = tilecolor.fontColor;
                    break;
                }

            }
        }

        private void GameOver()
        {
            if (!CheckEmptyTiles())
            {
                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = 0; j < mapSize; j++)
                    {
                        if (map[i, j].Text != string.Empty)
                        {
                            for (int k = j + 1; k < mapSize; k++)
                            {
                                if (map[i, k].Text != string.Empty)
                                {
                                    if (map[i, k].Text == map[i, j].Text)
                                    {
                                        return;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }

                for (int j = 0; j < mapSize; j++)
                {
                    for (int i = 0; i < mapSize; i++)
                    {
                        if (map[i, j].Text != string.Empty)
                        {
                            for (int k = i + 1; k < mapSize; k++)
                            {
                                if (map[k, j].Text != string.Empty)
                                {
                                    if (map[k, j].Text == map[i, j].Text)
                                    {
                                        return;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                if (MessageBox.Show("Вы проиграли! Хотите начать сначала?","Конец игры",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    SaveScore();
                    NewGame();

                    
                }
                else
                {
                    SaveScore();
                    Close();
                }

            }
        }


        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            RightClick(e);
            LeftClick(e);
            UpClick(e);
            DownClick(e);
            GenerateNumber();
            GameOver();
            ShowScore();
        }

        private void RightClick(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = mapSize - 1; j >= 0; j--)
                    {
                        if (map[i, j].Text != string.Empty)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (map[i, k].Text != string.Empty)
                                {
                                    if (map[i, k].Text == map[i, j].Text)
                                    {
                                        var number = Convert.ToInt32(map[i, j].Text);
                                        map[i, j].Text = (number * 2).ToString();
                                        map[i, k].Text = string.Empty;
                                        map[i, k].BackColor = tilesColor[1].color;
                                        CheckTileColor(i, j);
                                        user.score += number * 2;
                                        move = true;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = mapSize - 1; j >= 0; j--)
                    {
                        if (map[i, j].Text == string.Empty)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (map[i, k].Text != string.Empty)
                                {
                                    map[i, j].Text = map[i, k].Text;
                                    map[i, k].Text = string.Empty;
                                    CheckTileColor(i, j);
                                    map[i, k].BackColor = tilesColor[1].color;
                                    move = true;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
        private void LeftClick(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = 0; j < mapSize; j++)
                    {
                        if (map[i, j].Text != string.Empty)
                        {
                            for (int k = j + 1; k < mapSize; k++)
                            {
                                if (map[i, k].Text != string.Empty)
                                {
                                    if (map[i, k].Text == map[i, j].Text)
                                    {
                                        var number = Convert.ToInt32(map[i, j].Text);
                                        map[i, j].Text = (number * 2).ToString();
                                        map[i, k].Text = string.Empty;
                                        map[i, k].BackColor = tilesColor[1].color;
                                        CheckTileColor(i, j);
                                        user.score += number * 2;
                                        move = true;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = 0; j < mapSize; j++)
                    {
                        if (map[i, j].Text == string.Empty)
                        {
                            for (int k = j + 1; k < mapSize; k++)
                            {
                                if (map[i, k].Text != string.Empty)
                                {
                                    map[i, j].Text = map[i, k].Text;
                                    map[i, k].Text = string.Empty;
                                    CheckTileColor(i, j);
                                    map[i, k].BackColor = tilesColor[1].color;
                                    move = true;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
        private void UpClick(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    for (int i = 0; i < mapSize; i++)
                    {
                        if (map[i, j].Text != string.Empty)
                        {
                            for (int k = i + 1; k < mapSize; k++)
                            {
                                if (map[k, j].Text != string.Empty)
                                {
                                    if (map[k, j].Text == map[i, j].Text)
                                    {
                                        var number = Convert.ToInt32(map[i, j].Text);
                                        map[i, j].Text = (number * 2).ToString();
                                        map[k, j].Text = string.Empty;
                                        map[k, j].BackColor = tilesColor[1].color;
                                        CheckTileColor(i, j);
                                        user.score += number * 2;
                                        move = true;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (int j = 0; j < mapSize; j++)
                {
                    for (int i = 0; i < mapSize; i++)
                    {
                        if (map[i, j].Text == string.Empty)
                        {
                            for (int k = i + 1; k < mapSize; k++)
                            {
                                if (map[k, j].Text != string.Empty)
                                {
                                    map[i, j].Text = map[k, j].Text;
                                    map[k, j].Text = string.Empty;
                                    CheckTileColor(i, j);
                                    map[k, j].BackColor = tilesColor[1].color;
                                    move = true;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
        private void DownClick(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    for (int i = mapSize - 1; i >= 0; i--)
                    {
                        if (map[i, j].Text != string.Empty)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (map[k, j].Text != string.Empty)
                                {
                                    if (map[k, j].Text == map[i, j].Text)
                                    {
                                        var number = Convert.ToInt32(map[i, j].Text);
                                        map[i, j].Text = (number * 2).ToString();
                                        map[k, j].Text = string.Empty;
                                        map[k, j].BackColor = tilesColor[1].color;
                                        CheckTileColor(i, j);
                                        user.score += number * 2;
                                        move = true;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (int j = 0; j < mapSize; j++)
                {
                    for (int i = mapSize - 1; i >= 0; i--)
                    {
                        if (map[i, j].Text == string.Empty)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (map[k, j].Text != string.Empty)
                                {
                                    map[i, j].Text = map[k, j].Text;
                                    map[k, j].Text = string.Empty;
                                    CheckTileColor(i, j);
                                    map[k, j].BackColor = tilesColor[1].color;
                                    move = true;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void NewGameLabel_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. В каждом раунде появляется плитка номинала «2» (с вероятностью 90 %) или «4» (с вероятностью 10 %).\n\n" +
                "2. Нажатием стрелки игрок может скинуть все плитки игрового поля в одну из 4 сторон. Если при сбрасывании две плитки одного номинала «налетают» одна на другую, то они" +
                "превращаются в одну, номинал которой равен сумме соединившихся плиток. После каждого хода на свободной секции поля появляется новая плитка номиналом «2» или" +
                "«4». Если при нажатии кнопки местоположение плиток или их номинал не изменится, то ход не совершается.\n\n" +
                "3. Если в одной строчке или в одном столбце находится более двух плиток одного номинала, то при сбрасывании они начинают соединяться с той стороны, в которую были" +
                "направлены. Например, находящиеся в одной строке плитки (4, 4, 4) после хода влево превратятся в (8, 4), а после хода вправо — в (4, 8).\n\n" +
                "4. За каждое соединение игровые очки увеличиваются на номинал получившейся плитки.\n\n" +
                "5.Игра заканчивается поражением, если после очередного хода невозможно совершить действие.\n\n" +
                "6. Цель игры получить в одной из плиток число 2048.", "Правила игры");
        }

        private void RatingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RatingForm ratings = new RatingForm(usersScore);
            ratings.Show();
        }
    }
}
