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
	[ContainerType(16, 64)]
	public class KillEvent : 
		MetricEvent
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Position { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 VictimPosition { get; set; } = new();

		[ContainerField(48), LayoutImmutable, Blittable]
		public ulong VictimId { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public float Time { get; set; }

		[ContainerField(60), LayoutImmutable]
		public string Weapon { get; set; } = string.Empty;

		public static void Deserialize(KillEvent p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.Position, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.VictimPosition, p_Reader, p_Parser);
			p_Instance.VictimId = p_Reader.ReadUInt64();
			p_Instance.Time = p_Reader.ReadSingle();
			p_Instance.Weapon = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
		}

	}
}
