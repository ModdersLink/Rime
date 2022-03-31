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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 128)]
	public class VehicleParachuteComponentData :
		ComponentData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public VehicleParachuteBinding Binding { get; set; } = new();

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float UndeployTime { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public float TimeInvisibleAfterSpawn { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public int VehicleType { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public bool DropParachuteOnUndeploy { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Binding.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(UndeployTime);
			p_Writer.Write(TimeInvisibleAfterSpawn);
			p_Writer.Write(VehicleType);
			p_Writer.Write(DropParachuteOnUndeploy);
			p_Writer.WriteNullBytes(11);
		}
	}
}
