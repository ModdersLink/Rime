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
	[ContainerType(16, 208)]
	public partial class DebrisClusterData :
		GameEntityData
	{
		[ObservableProperty]
		[property: ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private Vec3 _PushVelocityMul = new();

		[ObservableProperty]
		[property: ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private Vec3 _PushVelocityRndMul = new();

		[ObservableProperty]
		[property: ContainerField(128), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private Vec3 _InitRotationRndMul = new();

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private float _ClusterLifetime;

		[ObservableProperty]
		[property: ContainerField(148), JsonProperty(Order = 148)]
		private CtrRef<MeshAsset> _Mesh = new();

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private uint _CompositePartCount;

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private uint _MaxActivePartsCount;

		[ObservableProperty]
		[property: ContainerField(160), JsonProperty(Order = 160)]
		private List<DebrisClusterPartInfoData> _PartHierarchy = new();

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private float _ActivationPushForceMul;

		[ObservableProperty]
		[property: ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		private float _ProjectileForceTransferMul;

		[ObservableProperty]
		[property: ContainerField(172), JsonProperty(Order = 172)]
		private CtrRef<PhysicsEntityData> _PhysicsData = new();

		[ObservableProperty]
		[property: ContainerField(176), JsonProperty(Order = 176)]
		private CtrRef<GameEntityData> _Explosion = new();

		[ObservableProperty]
		[property: ContainerField(180), JsonProperty(Order = 180)]
		private CtrRef<EffectBlueprint> _ActivationEffect = new();

		[ObservableProperty]
		[property: ContainerField(184), JsonProperty(Order = 184)]
		private CtrRef<EffectBlueprint> _Effect = new();

		[ObservableProperty]
		[property: ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		private float _OnPartCollisionSpeedThreshold;

		[ObservableProperty]
		[property: ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		private bool _PartialDestruction;

		[ObservableProperty]
		[property: ContainerField(193), LayoutImmutable, Blittable, JsonProperty(Order = 193)]
		private bool _ClientSideOnly;

		[ObservableProperty]
		[property: ContainerField(194), LayoutImmutable, Blittable, JsonProperty(Order = 194)]
		private bool _OnPartCollisionEnable;

		[ObservableProperty]
		[property: ContainerField(195), LayoutImmutable, Blittable, JsonProperty(Order = 195)]
		private bool _NoCollision;

		[ObservableProperty]
		[property: ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		private bool _KillPartsOnCollision;

		[ObservableProperty]
		[property: ContainerField(197), LayoutImmutable, Blittable, JsonProperty(Order = 197)]
		private bool _DeactivatePartsOnSleep;

		[ObservableProperty]
		[property: ContainerField(198), LayoutImmutable, Blittable, JsonProperty(Order = 198)]
		private bool _ActivateOnSpawn;

		[ObservableProperty]
		[property: ContainerField(199), LayoutImmutable, Blittable, JsonProperty(Order = 199)]
		private bool _InEffectWorldOnly;

		[ObservableProperty]
		[property: ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		private bool _SpawnExplosionOnFirstImpactOnly;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			PushVelocityMul.Serialize(p_Writer, p_EbxWriter);
			PushVelocityRndMul.Serialize(p_Writer, p_EbxWriter);
			InitRotationRndMul.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ClusterLifetime);
			p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
			p_Writer.Write(CompositePartCount);
			p_Writer.Write(MaxActivePartsCount);
			(RimeWriter Writer, uint ArrayIndex) s_PartHierarchy = p_EbxWriter.GetArrayWriter(PartHierarchy.GetType(), PartHierarchy.Count);
			p_Writer.Write(s_PartHierarchy.ArrayIndex);
			foreach (var s_Entry in PartHierarchy)
			{
				s_Entry.Serialize(s_PartHierarchy.Writer, p_EbxWriter);
			}
			p_Writer.Write(ActivationPushForceMul);
			p_Writer.Write(ProjectileForceTransferMul);
			p_Writer.Write(p_EbxWriter.WriteImport(PhysicsData));
			p_Writer.Write(p_EbxWriter.WriteImport(Explosion));
			p_Writer.Write(p_EbxWriter.WriteImport(ActivationEffect));
			p_Writer.Write(p_EbxWriter.WriteImport(Effect));
			p_Writer.Write(OnPartCollisionSpeedThreshold);
			p_Writer.Write(PartialDestruction);
			p_Writer.Write(ClientSideOnly);
			p_Writer.Write(OnPartCollisionEnable);
			p_Writer.Write(NoCollision);
			p_Writer.Write(KillPartsOnCollision);
			p_Writer.Write(DeactivatePartsOnSleep);
			p_Writer.Write(ActivateOnSpawn);
			p_Writer.Write(InEffectWorldOnly);
			p_Writer.Write(SpawnExplosionOnFirstImpactOnly);
			p_Writer.WriteNullBytes(7);
		}
	}
}
