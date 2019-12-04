namespace Mir.Ethernity.MapLibrary
{
    public class MapCell
    {
        public MapCellLayer Back { get; set; }
        public MapCellLayer Middle { get; set; }
        public MapCellLayer Front { get; set; }

        public byte Light { get; set; }
        public bool Flag { get; set; }
    }
}
