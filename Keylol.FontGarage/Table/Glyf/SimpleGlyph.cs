﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keylol.FontGarage.Table.Glyf
{
    public class SimpleGlyph : Glyph
    {
        public byte[] Data { get; set; }

        public override void Serialize(BinaryWriter writer, long startOffset, OpenTypeFont font)
        {
            writer.BaseStream.Position = startOffset;
            writer.Write(Data);
        }

        public static SimpleGlyph Deserialize(BinaryReader reader, long startOffset, uint length)
        {
            reader.BaseStream.Position = startOffset;
            return new SimpleGlyph
            {
                Data = reader.ReadBytes((int) length)
            };
        }
    }
}