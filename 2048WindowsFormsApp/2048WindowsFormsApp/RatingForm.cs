using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class RatingForm : Form
    {
        private List<UserScore> usersScore;
        public RatingForm(List<UserScore> usersScore)
        {
            InitializeComponent();
            this.usersScore = usersScore;
        }

        private void RatingForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < usersScore.Count; i++)
            {
                var userScore = usersScore[i];
                usersScoreDataGridView.Rows.Add(userScore.name, userScore.score);
            }
        }
    }
}
