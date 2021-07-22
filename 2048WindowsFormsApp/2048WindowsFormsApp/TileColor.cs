using System.Drawing;

namespace _2048WindowsFormsApp
{
    public class TileColor
    {
        public Color color;
        public Color fontColor;

        public TileColor(Color color, Color fontColor)
        {
            this.color = color;
            this.fontColor = fontColor;
        }
    }
}
