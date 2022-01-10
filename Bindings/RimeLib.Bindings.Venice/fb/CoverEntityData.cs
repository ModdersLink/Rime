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
	[ContainerType(16, 96)]
	public class CoverEntityData : 
		SpatialEntityData
	{
		[ContainerField(80), LayoutImmutable, Blittable]
		public float Width { get; set; }

		[ContainerField(84)]
		public CoverType CoverType { get; set; } = new();

		[ContainerField(88)]
		public List<CoverSlot> Slots { get; set; } = new();

		[ContainerField(92), LayoutImmutable, Blittable]
		public bool RightEdgeBlocked { get; set; }

		[ContainerField(93), LayoutImmutable, Blittable]
		public bool TopBlocked { get; set; }

		[ContainerField(94), LayoutImmutable, Blittable]
		public bool LeftEdgeBlocked { get; set; }

		public static void Deserialize(CoverEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Width = p_Reader.ReadSingle();
			p_Instance.CoverType = (CoverType) p_Reader.ReadInt32();
			p_Instance.Slots.Clear();
			(RimeReader Reader, uint Count) s_Slots = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Slots.Count; ++i)
			{
				var s_Value = new CoverSlot();
				fb.CoverSlot.Deserialize(s_Value, s_Slots.Reader, p_Parser);
				p_Instance.Slots.Add(s_Value);
			}
			
			s_Slots.Reader.Dispose();
			p_Instance.RightEdgeBlocked = p_Reader.ReadBool();
			p_Instance.TopBlocked = p_Reader.ReadBool();
			p_Instance.LeftEdgeBlocked = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
