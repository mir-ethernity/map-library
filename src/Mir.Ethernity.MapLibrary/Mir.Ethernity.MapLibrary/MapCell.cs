namespace Mir.Ethernity.MapLibrary
{
    public class MapCell
    {
        public byte BackFile { get; set; }
        public ushort BackImage { get; set; }

        public byte FrontAnimationFrame { get; set; }
        public byte FrontFile { get; set; }
        public ushort FrontImage { get; set; }

        public byte MiddleAnimationFrame { get; set; }
        public byte MiddleFile { get; set; }
        public ushort MiddleImage { get; set; }

        public byte Light { get; set; }
        public bool Flag { get; set; }
    }
}
