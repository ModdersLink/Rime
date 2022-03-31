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
	[ContainerType(16, 288)]
	public class SoldierEntityData :
		CharacterEntityData
	{
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public Vec3 FLIRKeyColor { get; set; } = new();

		[ContainerField(176), JsonProperty(Order = 176)]
		public CtrRef<MaterialContainerPair> HeadMaterialPair { get; set; } = new();

		[ContainerField(180), JsonProperty(Order = 180)]
		public RefArray<BoneFakePhysicsData> BoneFakePhysics { get; set; } = new();

		[ContainerField(184), JsonProperty(Order = 184)]
		public CtrRef<SoldierAutoAimData> AutoAim { get; set; } = new();

		[ContainerField(188), JsonProperty(Order = 188)]
		public CtrRef<SoldierAimingConstraintsData> AimingConstraints { get; set; } = new();

		[ContainerField(192), JsonProperty(Order = 192)]
		public CtrRef<SoldierHeadCollisionData> HeadCollision { get; set; } = new();

		[ContainerField(196), JsonProperty(Order = 196)]
		public CtrRef<CharacterPhysicsData> CharacterPhysics { get; set; } = new();

		[ContainerField(200), JsonProperty(Order = 200)]
		public CtrRef<MaterialContainerPair> FootMaterialPair { get; set; } = new();

		[ContainerField(204), JsonProperty(Order = 204)]
		public CtrRef<SoldierSprintSettingsData> SprintSettings { get; set; } = new();

		[ContainerField(208), JsonProperty(Order = 208)]
		public List<SoldierMeshData> Meshes1p { get; set; } = new();

		[ContainerField(212), JsonProperty(Order = 212)]
		public List<SoldierMeshData> Meshes3p { get; set; } = new();

		[ContainerField(216), JsonProperty(Order = 216)]
		public List<HidableSoldierMeshWeaponPart> HidableMeshParts { get; set; } = new();

		[ContainerField(220), JsonProperty(Order = 220)]
		public CtrRef<SoldierSoundData> Sound { get; set; } = new();

		[ContainerField(224), JsonProperty(Order = 224)]
		public CtrRef<StreamGroupData> StreamGroup1p { get; set; } = new();

		[ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		public float ImpulseReactionTime { get; set; }

		[ContainerField(232), JsonProperty(Order = 232)]
		public CtrRef<SoldierHealthModuleData> HealthModule { get; set; } = new();

		[ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		public float MaxHealth { get; set; }

		[ContainerField(240), JsonProperty(Order = 240)]
		public CtrRef<CollisionData> CollisionInfo { get; set; } = new();

		[ContainerField(244), JsonProperty(Order = 244)]
		public CtrRef<EntityVoiceOverInfo> VoiceOverInfo { get; set; } = new();

		[ContainerField(248), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
		public float FLIRValue { get; set; }

		[ContainerField(252), JsonProperty(Order = 252)]
		public RefArray<BreathControlData> BreathControl { get; set; } = new();

		[ContainerField(256), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
		public float ExplosionDamageModifier { get; set; }

		[ContainerField(260), JsonProperty(Order = 260)]
		public RefArray<UIPartData> UIParts { get; set; } = new();

		[ContainerField(264), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
		public float RegenerationDelayModifier { get; set; }

		[ContainerField(268), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
		public bool FreeSpaceCheck { get; set; }

		[ContainerField(269), LayoutImmutable, Blittable, JsonProperty(Order = 269)]
		public bool ProximityCheck { get; set; }

		[ContainerField(270), LayoutImmutable, Blittable, JsonProperty(Order = 270)]
		public bool EnableGroundmapLighting { get; set; }

		[ContainerField(271), LayoutImmutable, Blittable, JsonProperty(Order = 271)]
		public bool ShowWeaponWhenDead { get; set; }

		[ContainerField(272), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
		public bool LowerGunOnOwnTeam { get; set; }

		[ContainerField(273), LayoutImmutable, Blittable, JsonProperty(Order = 273)]
		public bool UseSpineXRotation { get; set; }

		[ContainerField(274), LayoutImmutable, Blittable, JsonProperty(Order = 274)]
		public bool CollisionEnabled { get; set; }

		[ContainerField(275), LayoutImmutable, Blittable, JsonProperty(Order = 275)]
		public bool PhysicsControlled { get; set; }

		[ContainerField(276), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
		public bool IsPushable { get; set; }

		[ContainerField(277), LayoutImmutable, Blittable, JsonProperty(Order = 277)]
		public bool HumanPlayerControlled { get; set; }

		[ContainerField(278), LayoutImmutable, Blittable, JsonProperty(Order = 278)]
		public bool InteractiveManDownAllowed { get; set; }

		[ContainerField(279), LayoutImmutable, Blittable, JsonProperty(Order = 279)]
		public bool ShowNametag { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			FLIRKeyColor.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(HeadMaterialPair));
			(RimeWriter Writer, uint ArrayIndex) s_BoneFakePhysics = p_EbxWriter.GetArrayWriter(BoneFakePhysics.GetType(), BoneFakePhysics.Count);
			p_Writer.Write(s_BoneFakePhysics.ArrayIndex);
			foreach (var s_Entry in BoneFakePhysics)
			{
				s_BoneFakePhysics.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteImport(AutoAim));
			p_Writer.Write(p_EbxWriter.WriteImport(AimingConstraints));
			p_Writer.Write(p_EbxWriter.WriteImport(HeadCollision));
			p_Writer.Write(p_EbxWriter.WriteImport(CharacterPhysics));
			p_Writer.Write(p_EbxWriter.WriteImport(FootMaterialPair));
			p_Writer.Write(p_EbxWriter.WriteImport(SprintSettings));
			(RimeWriter Writer, uint ArrayIndex) s_Meshes1p = p_EbxWriter.GetArrayWriter(Meshes1p.GetType(), Meshes1p.Count);
			p_Writer.Write(s_Meshes1p.ArrayIndex);
			foreach (var s_Entry in Meshes1p)
			{
				s_Entry.Serialize(s_Meshes1p.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_Meshes3p = p_EbxWriter.GetArrayWriter(Meshes3p.GetType(), Meshes3p.Count);
			p_Writer.Write(s_Meshes3p.ArrayIndex);
			foreach (var s_Entry in Meshes3p)
			{
				s_Entry.Serialize(s_Meshes3p.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_HidableMeshParts = p_EbxWriter.GetArrayWriter(HidableMeshParts.GetType(), HidableMeshParts.Count);
			p_Writer.Write(s_HidableMeshParts.ArrayIndex);
			foreach (var s_Entry in HidableMeshParts)
			{
				s_Entry.Serialize(s_HidableMeshParts.Writer, p_EbxWriter);
			}
			p_Writer.Write(p_EbxWriter.WriteImport(Sound));
			p_Writer.Write(p_EbxWriter.WriteImport(StreamGroup1p));
			p_Writer.Write(ImpulseReactionTime);
			p_Writer.Write(p_EbxWriter.WriteImport(HealthModule));
			p_Writer.Write(MaxHealth);
			p_Writer.Write(p_EbxWriter.WriteImport(CollisionInfo));
			p_Writer.Write(p_EbxWriter.WriteImport(VoiceOverInfo));
			p_Writer.Write(FLIRValue);
			(RimeWriter Writer, uint ArrayIndex) s_BreathControl = p_EbxWriter.GetArrayWriter(BreathControl.GetType(), BreathControl.Count);
			p_Writer.Write(s_BreathControl.ArrayIndex);
			foreach (var s_Entry in BreathControl)
			{
				s_BreathControl.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(ExplosionDamageModifier);
			(RimeWriter Writer, uint ArrayIndex) s_UIParts = p_EbxWriter.GetArrayWriter(UIParts.GetType(), UIParts.Count);
			p_Writer.Write(s_UIParts.ArrayIndex);
			foreach (var s_Entry in UIParts)
			{
				s_UIParts.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(RegenerationDelayModifier);
			p_Writer.Write(FreeSpaceCheck);
			p_Writer.Write(ProximityCheck);
			p_Writer.Write(EnableGroundmapLighting);
			p_Writer.Write(ShowWeaponWhenDead);
			p_Writer.Write(LowerGunOnOwnTeam);
			p_Writer.Write(UseSpineXRotation);
			p_Writer.Write(CollisionEnabled);
			p_Writer.Write(PhysicsControlled);
			p_Writer.Write(IsPushable);
			p_Writer.Write(HumanPlayerControlled);
			p_Writer.Write(InteractiveManDownAllowed);
			p_Writer.Write(ShowNametag);
			p_Writer.WriteNullBytes(8);
		}
	}
}
