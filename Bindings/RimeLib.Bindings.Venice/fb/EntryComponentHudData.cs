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
	[ContainerType(4, 12)]
	public class EntryComponentHudData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public int Index { get; set; }
		
		[ContainerField(4)]
		public EntrySeatType SeatType { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public bool Frustum { get; set; }
		
		[ContainerField(9), LayoutImmutable, Blittable]
		public bool Visible { get; set; }
		
		[ContainerField(10), LayoutImmutable, Blittable]
		public bool MaximizeMiniMapOnEntry { get; set; }
		
		public static void Deserialize(EntryComponentHudData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Index = p_Reader.ReadInt32();
			p_Instance.SeatType = (EntrySeatType) p_Reader.ReadInt32();
			p_Instance.Frustum = p_Reader.ReadBool();
			p_Instance.Visible = p_Reader.ReadBool();
			p_Instance.MaximizeMiniMapOnEntry = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}
	}
}
