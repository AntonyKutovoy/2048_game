using System.Collections.Generic;
using System.Drawing;

namespace _2048WindowsFormsApp
{
    public class TilesColors
    {
        public static Dictionary<int, TileColor> GetTilesColors()
        {
            TileColor tile0 = new TileColor(Color.FromArgb(207, 197, 188), Color.FromArgb(207, 197, 188));
            TileColor tile2 = new TileColor(Color.FromArgb(238, 228, 218), Color.FromArgb(119, 110, 101));
            TileColor tile4 = new TileColor(Color.FromArgb(237, 224, 200), Color.FromArgb(119, 110, 101));
            TileColor tile8 = new TileColor(Color.FromArgb(242, 177, 121), Color.FromArgb(249, 246, 242));
            TileColor tile16 = new TileColor(Color.FromArgb(245, 149, 99), Color.FromArgb(249, 246, 242));
            TileColor tile32 = new TileColor(Color.FromArgb(246, 124, 95), Color.FromArgb(249, 246, 242));
            TileColor tile64 = new TileColor(Color.FromArgb(246, 94, 59), Color.FromArgb(249, 246, 242));
            TileColor tile128 = new TileColor(Color.FromArgb(237, 207, 114), Color.FromArgb(249, 246, 242));
            TileColor tile256 = new TileColor(Color.FromArgb(237, 204, 97), Color.FromArgb(249, 246, 242));
            TileColor tile512 = new TileColor(Color.FromArgb(237, 200, 80), Color.FromArgb(249, 246, 242));
            TileColor tile1024 = new TileColor(Color.FromArgb(237, 197, 63), Color.FromArgb(249, 246, 242));
            TileColor tile2048 = new TileColor(Color.FromArgb(237, 194, 46), Color.FromArgb(249, 246, 242));
            var tilesColors = new Dictionary<int, TileColor> { {1, tile0 }, {2, tile2 }, { 3, tile4 }, { 4, tile8 }, { 5, tile16 }, { 6, tile32 },
                {7, tile64 }, { 8, tile128 }, { 9, tile256 }, { 10, tile512 }, {11, tile1024 }, {12, tile2048 } };
            return tilesColors;
        }
    }
}
