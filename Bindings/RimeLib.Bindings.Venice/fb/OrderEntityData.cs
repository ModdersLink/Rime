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
	[ContainerType(4, 36)]
	public class OrderEntityData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable]
		public string DebugName { get; set; } = string.Empty;

		[ContainerField(16), LayoutImmutable, Blittable]
		public float IssueOrderDelay { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float OnCompleteTimeOut { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float OnFailedTimeOut { get; set; }

		[ContainerField(28)]
		public ReadinessLevel ReadinessOnStart { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable]
		public bool Enabled { get; set; }

		public static void Deserialize(OrderEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DebugName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.IssueOrderDelay = p_Reader.ReadSingle();
			p_Instance.OnCompleteTimeOut = p_Reader.ReadSingle();
			p_Instance.OnFailedTimeOut = p_Reader.ReadSingle();
			p_Instance.ReadinessOnStart = (ReadinessLevel) p_Reader.ReadInt32();
			p_Instance.Enabled = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
