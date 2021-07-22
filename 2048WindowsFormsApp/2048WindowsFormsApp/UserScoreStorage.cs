using System.Collections.Generic;
using Newtonsoft.Json;

namespace _2048WindowsFormsApp
{
    public class UserScoreStorage
    {
        private static string userScorePath = "userScore.json";

        public static List<UserScore> GetUserScoreFromFile()
        {
            var serializedUserScore = FileProvider.Get(userScorePath);
            var userScore = JsonConvert.DeserializeObject<List<UserScore>>(serializedUserScore);
            return userScore;
        }

        public static void SaveUserScore(List<UserScore> userScore)
        {
            var serializedUserScore = JsonConvert.SerializeObject(userScore, Formatting.Indented);
            FileProvider.Set(userScorePath, serializedUserScore);
        }
    }
}
