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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(16, 192)]
	public partial class MeshProjectileEntityData :
		ProjectileEntityData
	{
		[ObservableProperty]
		[property: ContainerField(160), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private Vec3 _InitialAngularVelocity = new();

		[ObservableProperty]
		[property: ContainerField(176), JsonProperty(Order = 176)]
		private CtrRef<EffectBlueprint> _TrailEffect = new();

		[ObservableProperty]
		[property: ContainerField(180), JsonProperty(Order = 180)]
		private CtrRef<MeshAsset> _Mesh = new();

		[ObservableProperty]
		[property: ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		private float _MaxAttachableInclination;

		[ObservableProperty]
		[property: ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		private bool _ExtraDamping;

		[ObservableProperty]
		[property: ContainerField(189), LayoutImmutable, Blittable, JsonProperty(Order = 189)]
		private bool _IsAttachable;

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
