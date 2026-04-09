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
	[ContainerType(16, 288)]
	public partial class SoldierEntityData :
		CharacterEntityData
	{
		[ObservableProperty]
		[property: ContainerField(160), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private Vec3 _FLIRKeyColor = new();

		[ObservableProperty]
		[property: ContainerField(176), JsonProperty(Order = 176)]
		private CtrRef<MaterialContainerPair> _HeadMaterialPair = new();

		[ObservableProperty]
		[property: ContainerField(180), JsonProperty(Order = 180)]
		private RefArray<BoneFakePhysicsData> _BoneFakePhysics = new();

		[ObservableProperty]
		[property: ContainerField(184), JsonProperty(Order = 184)]
		private CtrRef<SoldierAutoAimData> _AutoAim = new();

		[ObservableProperty]
		[property: ContainerField(188), JsonProperty(Order = 188)]
		private CtrRef<SoldierAimingConstraintsData> _AimingConstraints = new();

		[ObservableProperty]
		[property: ContainerField(192), JsonProperty(Order = 192)]
		private CtrRef<SoldierHeadCollisionData> _HeadCollision = new();

		[ObservableProperty]
		[property: ContainerField(196), JsonProperty(Order = 196)]
		private CtrRef<CharacterPhysicsData> _CharacterPhysics = new();

		[ObservableProperty]
		[property: ContainerField(200), JsonProperty(Order = 200)]
		private CtrRef<MaterialContainerPair> _FootMaterialPair = new();

		[ObservableProperty]
		[property: ContainerField(204), JsonProperty(Order = 204)]
		private CtrRef<SoldierSprintSettingsData> _SprintSettings = new();

		[ObservableProperty]
		[property: ContainerField(208), JsonProperty(Order = 208)]
		private List<SoldierMeshData> _Meshes1p = new();

		[ObservableProperty]
		[property: ContainerField(212), JsonProperty(Order = 212)]
		private List<SoldierMeshData> _Meshes3p = new();

		[ObservableProperty]
		[property: ContainerField(216), JsonProperty(Order = 216)]
		private List<HidableSoldierMeshWeaponPart> _HidableMeshParts = new();

		[ObservableProperty]
		[property: ContainerField(220), JsonProperty(Order = 220)]
		private CtrRef<SoldierSoundData> _Sound = new();

		[ObservableProperty]
		[property: ContainerField(224), JsonProperty(Order = 224)]
		private CtrRef<StreamGroupData> _StreamGroup1p = new();

		[ObservableProperty]
		[property: ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		private float _ImpulseReactionTime;

		[ObservableProperty]
		[property: ContainerField(232), JsonProperty(Order = 232)]
		private CtrRef<SoldierHealthModuleData> _HealthModule = new();

		[ObservableProperty]
		[property: ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		private float _MaxHealth;

		[ObservableProperty]
		[property: ContainerField(240), JsonProperty(Order = 240)]
		private CtrRef<CollisionData> _CollisionInfo = new();

		[ObservableProperty]
		[property: ContainerField(244), JsonProperty(Order = 244)]
		private CtrRef<EntityVoiceOverInfo> _VoiceOverInfo = new();

		[ObservableProperty]
		[property: ContainerField(248), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
		private float _FLIRValue;

		[ObservableProperty]
		[property: ContainerField(252), JsonProperty(Order = 252)]
		private RefArray<BreathControlData> _BreathControl = new();

		[ObservableProperty]
		[property: ContainerField(256), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
		private float _ExplosionDamageModifier;

		[ObservableProperty]
		[property: ContainerField(260), JsonProperty(Order = 260)]
		private RefArray<UIPartData> _UIParts = new();

		[ObservableProperty]
		[property: ContainerField(264), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
		private float _RegenerationDelayModifier;

		[ObservableProperty]
		[property: ContainerField(268), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
		private bool _FreeSpaceCheck;

		[ObservableProperty]
		[property: ContainerField(269), LayoutImmutable, Blittable, JsonProperty(Order = 269)]
		private bool _ProximityCheck;

		[ObservableProperty]
		[property: ContainerField(270), LayoutImmutable, Blittable, JsonProperty(Order = 270)]
		private bool _EnableGroundmapLighting;

		[ObservableProperty]
		[property: ContainerField(271), LayoutImmutable, Blittable, JsonProperty(Order = 271)]
		private bool _ShowWeaponWhenDead;

		[ObservableProperty]
		[property: ContainerField(272), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
		private bool _LowerGunOnOwnTeam;

		[ObservableProperty]
		[property: ContainerField(273), LayoutImmutable, Blittable, JsonProperty(Order = 273)]
		private bool _UseSpineXRotation;

		[ObservableProperty]
		[property: ContainerField(274), LayoutImmutable, Blittable, JsonProperty(Order = 274)]
		private bool _CollisionEnabled;

		[ObservableProperty]
		[property: ContainerField(275), LayoutImmutable, Blittable, JsonProperty(Order = 275)]
		private bool _PhysicsControlled;

		[ObservableProperty]
		[property: ContainerField(276), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
		private bool _IsPushable;

		[ObservableProperty]
		[property: ContainerField(277), LayoutImmutable, Blittable, JsonProperty(Order = 277)]
		private bool _HumanPlayerControlled;

		[ObservableProperty]
		[property: ContainerField(278), LayoutImmutable, Blittable, JsonProperty(Order = 278)]
		private bool _InteractiveManDownAllowed;

		[ObservableProperty]
		[property: ContainerField(279), LayoutImmutable, Blittable, JsonProperty(Order = 279)]
		private bool _ShowNametag;

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
