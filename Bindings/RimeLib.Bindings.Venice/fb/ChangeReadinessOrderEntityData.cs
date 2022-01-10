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
	[ContainerType(4, 52)]
	public class ChangeReadinessOrderEntityData : 
		BFOrderEntityData
	{
		[ContainerField(40)]
		public ReadinessLevel Pulse { get; set; } = new();

		[ContainerField(44)]
		public ReadinessLevel Minimum { get; set; } = new();

		[ContainerField(48), LayoutImmutable, Blittable]
		public bool AllowDecrease { get; set; }

		public static void Deserialize(ChangeReadinessOrderEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Pulse = (ReadinessLevel) p_Reader.ReadInt32();
			p_Instance.Minimum = (ReadinessLevel) p_Reader.ReadInt32();
			p_Instance.AllowDecrease = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
