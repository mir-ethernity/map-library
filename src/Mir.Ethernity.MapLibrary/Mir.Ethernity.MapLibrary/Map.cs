using System;

namespace Mir.Ethernity.MapLibrary
{
    public class Map
    {
        public ushort Width { get; set; }
        public ushort Height { get; set; }
        public MapCell[,] Cells { get; set; }
    }
}
