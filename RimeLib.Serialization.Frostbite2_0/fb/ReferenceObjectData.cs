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
	[ContainerType(16, 96)]
	public class ReferenceObjectData :
		GameObjectData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public LinearTransform BlueprintTransform { get; set; } = new();

		[ContainerField(80), JsonProperty(Order = 80)]
		public CtrRef<Blueprint> Blueprint { get; set; } = new();

		[ContainerField(84), JsonProperty(Order = 84)]
		public CtrRef<ObjectVariation> ObjectVariation { get; set; } = new();

		[ContainerField(88), JsonProperty(Order = 88)]
		public StreamRealm StreamRealm { get; set; } = new();

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public bool CastSunShadowEnable { get; set; }

		[ContainerField(93), LayoutImmutable, Blittable, JsonProperty(Order = 93)]
		public bool Excluded { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(4);
			BlueprintTransform.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Blueprint));
			p_Writer.Write(p_EbxWriter.WriteImport(ObjectVariation));
			p_Writer.Write((int) StreamRealm);
			p_Writer.Write(CastSunShadowEnable);
			p_Writer.Write(Excluded);
			p_Writer.WriteNullBytes(2);
		}
	}
}
