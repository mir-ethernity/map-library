namespace Mir.Ethernity.MapLibrary
{
    public class MapCellLayer
    {
        public byte? AnimationFrame { get; set; }
        public MapTileType TileType { get; set; }
        public MapFileType FileType { get; set; }
        public ushort ImageIndex { get; set; }
    }
}
