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
	[ContainerType(16, 48)]
	public partial class BulletHitInfo :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private Vec3 _Direction = new();
		
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec3 _SpawnPosition = new();
		
		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private CtrRef<SoldierWeaponUnlockAsset> _WeaponUnlockAsset = new();
		
		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private AntHitReactionWeaponType _WeaponType = new();
		
		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private int _BoneType;
		
		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private int _ShooterPlayerId;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Direction.Serialize(p_Writer, p_EbxWriter);
			SpawnPosition.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(WeaponUnlockAsset));
			p_Writer.Write((int) WeaponType);
			p_Writer.Write(BoneType);
			p_Writer.Write(ShooterPlayerId);
		}
	}
}
