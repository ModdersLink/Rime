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
	[ContainerType(16, 192)]
	public class MeshProjectileEntityData :
		ProjectileEntityData
	{
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public Vec3 InitialAngularVelocity { get; set; } = new();

		[ContainerField(176), JsonProperty(Order = 176)]
		public CtrRef<EffectBlueprint> TrailEffect { get; set; } = new();

		[ContainerField(180), JsonProperty(Order = 180)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new();

		[ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		public float MaxAttachableInclination { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		public bool ExtraDamping { get; set; }

		[ContainerField(189), LayoutImmutable, Blittable, JsonProperty(Order = 189)]
		public bool IsAttachable { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			InitialAngularVelocity.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(TrailEffect));
			p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
			p_Writer.Write(MaxAttachableInclination);
			p_Writer.Write(ExtraDamping);
			p_Writer.Write(IsAttachable);
			p_Writer.WriteNullBytes(2);
		}
	}
}
