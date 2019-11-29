using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Mir.Ethernity.MapLibrary
{
    public interface IMapReader
    {
        Map Read(Stream stream);
    }
}
