///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 128)]
	public class WheelComponentData :
		PartComponentData
	{
		[ContainerField(112), JsonProperty(Order = 112)]
		public CtrRef<WheelConfigData> Config { get; set; } = new();

		[ContainerField(116), JsonProperty(Order = 116)]
		public WheelPhysicsType PhysicsType { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public float EffectClampVelocity { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Config));
			p_Writer.Write((int) PhysicsType);
			p_Writer.Write(EffectClampVelocity);
			p_Writer.WriteNullBytes(4);
		}
	}
}
