namespace _2048WindowsFormsApp
{
    public class User
    {
        public string name;
        public int score;
        public int mapSize;
        public User(string name, int mapSize)
        {
            this.name = name;
            this.mapSize = mapSize;
            score = 0;
        }

    }
}
