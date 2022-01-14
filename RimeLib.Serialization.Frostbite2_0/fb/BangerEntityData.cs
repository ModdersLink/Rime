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
	[ContainerType(16, 144)]
	public class BangerEntityData :
		DynamicGamePhysicsEntityData
	{
		[ContainerField(112), JsonProperty(Order = 112)]
		public List<float> Scales { get; set; } = new();

		[ContainerField(116), JsonProperty(Order = 116)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new();

		[ContainerField(120), JsonProperty(Order = 120)]
		public CtrRef<ExplosionEntityData> Explosion { get; set; } = new();

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public float TimeToLive { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public uint DestructiblePartCount { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public bool UseVariableNetworkFrequency { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Scales = p_EbxWriter.GetArrayWriter(Scales.GetType(), Scales.Count);
			p_Writer.Write(s_Scales.ArrayIndex);
			foreach (var s_Entry in Scales)
			{
				s_Scales.Writer.Write(s_Entry);
			}
			p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
			p_Writer.Write(p_EbxWriter.WriteImport(Explosion));
			p_Writer.Write(TimeToLive);
			p_Writer.Write(DestructiblePartCount);
			p_Writer.Write(UseVariableNetworkFrequency);
			p_Writer.WriteNullBytes(11);
		}
	}
}
