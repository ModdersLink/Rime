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
	[ContainerType(16, 128)]
	public class WheelComponentData : 
		PartComponentData
	{
		[ContainerField(112)]
		public CtrRef<WheelConfigData> Config { get; set; } = new();

		[ContainerField(116)]
		public WheelPhysicsType PhysicsType { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable]
		public float EffectClampVelocity { get; set; }

		public static void Deserialize(WheelComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Config.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.PhysicsType = (WheelPhysicsType) p_Reader.ReadInt32();
			p_Instance.EffectClampVelocity = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
