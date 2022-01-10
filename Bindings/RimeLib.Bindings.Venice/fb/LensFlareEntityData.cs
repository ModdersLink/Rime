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
	public class LensFlareEntityData : 
		SpatialEntityData
	{
		[ContainerField(80)]
		public List<LensFlareElement> Elements { get; set; } = new();

		[ContainerField(84), LayoutImmutable, Blittable]
		public float OccluderSize { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public bool Visible { get; set; }

		[ContainerField(89), LayoutImmutable, Blittable]
		public bool HalfRes { get; set; }

		[ContainerField(90), LayoutImmutable, Blittable]
		public bool DebugDrawOccluder { get; set; }

		public static void Deserialize(LensFlareEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Elements.Clear();
			(RimeReader Reader, uint Count) s_Elements = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Elements.Count; ++i)
			{
				var s_Value = new LensFlareElement();
				fb.LensFlareElement.Deserialize(s_Value, s_Elements.Reader, p_Parser);
				p_Instance.Elements.Add(s_Value);
			}
			
			s_Elements.Reader.Dispose();
			p_Instance.OccluderSize = p_Reader.ReadSingle();
			p_Instance.Visible = p_Reader.ReadBool();
			p_Instance.HalfRes = p_Reader.ReadBool();
			p_Instance.DebugDrawOccluder = p_Reader.ReadBool();
			p_Reader.Seek(5, SeekOrigin.Current);
		}

	}
}
