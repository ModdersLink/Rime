///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 112)]
	public class StreamGridEntityData : 
		SpatialEntityData
	{
		[ContainerField(80), LayoutImmutable, Blittable]
		public float CellSize { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public float ViewDistance { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public int MaxStreamInCountPerFrame { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public int MaxStreamOutCountPerFrame { get; set; }

		[ContainerField(96)]
		public List<StreamGridCell> Cells { get; set; } = new();

		public static void Deserialize(StreamGridEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.CellSize = p_Reader.ReadSingle();
			p_Instance.ViewDistance = p_Reader.ReadSingle();
			p_Instance.MaxStreamInCountPerFrame = p_Reader.ReadInt32();
			p_Instance.MaxStreamOutCountPerFrame = p_Reader.ReadInt32();
			p_Instance.Cells.Clear();
			(RimeReader Reader, uint Count) s_Cells = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Cells.Count; ++i)
			{
				var s_Value = new StreamGridCell();
				fb.StreamGridCell.Deserialize(s_Value, s_Cells.Reader, p_Parser);
				p_Instance.Cells.Add(s_Value);
			}
			
			s_Cells.Reader.Dispose();
			p_Reader.Seek(12, SeekOrigin.Current);
		}

	}
}
