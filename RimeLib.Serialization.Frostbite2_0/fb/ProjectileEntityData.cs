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
	[ContainerType(16, 160)]
	public partial class ProjectileEntityData :
		GamePhysicsEntityData
	{
		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _VisualConvergeDistance;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _InitialSpeed;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private float _TimeToLive;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private uint _MaxCount;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private float _InitMeshHideTime;

		[ObservableProperty]
		[property: ContainerField(132), JsonProperty(Order = 132)]
		private CtrRef<MaterialContainerPair> _MaterialPair = new();

		[ObservableProperty]
		[property: ContainerField(136), JsonProperty(Order = 136)]
		private AntHitReactionWeaponType _HitReactionWeaponType = new();

		[ObservableProperty]
		[property: ContainerField(140), JsonProperty(Order = 140)]
		private CtrRef<ExplosionEntityData> _Explosion = new();

		[ObservableProperty]
		[property: ContainerField(144), JsonProperty(Order = 144)]
		private CtrRef<WeaponSuppressionData> _SuppressionData = new();

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, JsonProperty(Order = 148)]
		private string _AmmunitionType = string.Empty;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private bool _ServerProjectileDisabled;

		[ObservableProperty]
		[property: ContainerField(153), LayoutImmutable, Blittable, JsonProperty(Order = 153)]
		private bool _DetonateOnTimeout;

		[ObservableProperty]
		[property: ContainerField(154), LayoutImmutable, Blittable, JsonProperty(Order = 154)]
		private bool _SuppressOwnerVehicleDamage;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(VisualConvergeDistance);
			p_Writer.Write(InitialSpeed);
			p_Writer.Write(TimeToLive);
			p_Writer.Write(MaxCount);
			p_Writer.Write(InitMeshHideTime);
			p_Writer.Write(p_EbxWriter.WriteImport(MaterialPair));
			p_Writer.Write((int) HitReactionWeaponType);
			p_Writer.Write(p_EbxWriter.WriteImport(Explosion));
			p_Writer.Write(p_EbxWriter.WriteImport(SuppressionData));
			p_Writer.Write(p_EbxWriter.WriteString(AmmunitionType));
			p_Writer.Write(ServerProjectileDisabled);
			p_Writer.Write(DetonateOnTimeout);
			p_Writer.Write(SuppressOwnerVehicleDamage);
			p_Writer.WriteNullBytes(5);
		}
	}
}
