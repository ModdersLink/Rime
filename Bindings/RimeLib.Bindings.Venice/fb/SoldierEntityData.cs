///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 288)]
	public class SoldierEntityData : 
		CharacterEntityData
	{
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 FLIRKeyColor { get; set; } = new();

		[ContainerField(176)]
		public CtrRef<MaterialContainerPair> HeadMaterialPair { get; set; } = new();

		[ContainerField(180)]
		public List<CtrRef<BoneFakePhysicsData>> BoneFakePhysics { get; set; } = new();

		[ContainerField(184)]
		public CtrRef<SoldierAutoAimData> AutoAim { get; set; } = new();

		[ContainerField(188)]
		public CtrRef<SoldierAimingConstraintsData> AimingConstraints { get; set; } = new();

		[ContainerField(192)]
		public CtrRef<SoldierHeadCollisionData> HeadCollision { get; set; } = new();

		[ContainerField(196)]
		public CtrRef<CharacterPhysicsData> CharacterPhysics { get; set; } = new();

		[ContainerField(200)]
		public CtrRef<MaterialContainerPair> FootMaterialPair { get; set; } = new();

		[ContainerField(204)]
		public CtrRef<SoldierSprintSettingsData> SprintSettings { get; set; } = new();

		[ContainerField(208)]
		public List<SoldierMeshData> Meshes1p { get; set; } = new();

		[ContainerField(212)]
		public List<SoldierMeshData> Meshes3p { get; set; } = new();

		[ContainerField(216)]
		public List<HidableSoldierMeshWeaponPart> HidableMeshParts { get; set; } = new();

		[ContainerField(220)]
		public CtrRef<SoldierSoundData> Sound { get; set; } = new();

		[ContainerField(224)]
		public CtrRef<StreamGroupData> StreamGroup1p { get; set; } = new();

		[ContainerField(228), LayoutImmutable, Blittable]
		public float ImpulseReactionTime { get; set; }

		[ContainerField(232)]
		public CtrRef<SoldierHealthModuleData> HealthModule { get; set; } = new();

		[ContainerField(236), LayoutImmutable, Blittable]
		public float MaxHealth { get; set; }

		[ContainerField(240)]
		public CtrRef<CollisionData> CollisionInfo { get; set; } = new();

		[ContainerField(244)]
		public CtrRef<EntityVoiceOverInfo> VoiceOverInfo { get; set; } = new();

		[ContainerField(248), LayoutImmutable, Blittable]
		public float FLIRValue { get; set; }

		[ContainerField(252)]
		public List<CtrRef<BreathControlData>> BreathControl { get; set; } = new();

		[ContainerField(256), LayoutImmutable, Blittable]
		public float ExplosionDamageModifier { get; set; }

		[ContainerField(260)]
		public List<CtrRef<UIPartData>> UIParts { get; set; } = new();

		[ContainerField(264), LayoutImmutable, Blittable]
		public float RegenerationDelayModifier { get; set; }

		[ContainerField(268), LayoutImmutable, Blittable]
		public bool FreeSpaceCheck { get; set; }

		[ContainerField(269), LayoutImmutable, Blittable]
		public bool ProximityCheck { get; set; }

		[ContainerField(270), LayoutImmutable, Blittable]
		public bool EnableGroundmapLighting { get; set; }

		[ContainerField(271), LayoutImmutable, Blittable]
		public bool ShowWeaponWhenDead { get; set; }

		[ContainerField(272), LayoutImmutable, Blittable]
		public bool LowerGunOnOwnTeam { get; set; }

		[ContainerField(273), LayoutImmutable, Blittable]
		public bool UseSpineXRotation { get; set; }

		[ContainerField(274), LayoutImmutable, Blittable]
		public bool CollisionEnabled { get; set; }

		[ContainerField(275), LayoutImmutable, Blittable]
		public bool PhysicsControlled { get; set; }

		[ContainerField(276), LayoutImmutable, Blittable]
		public bool IsPushable { get; set; }

		[ContainerField(277), LayoutImmutable, Blittable]
		public bool HumanPlayerControlled { get; set; }

		[ContainerField(278), LayoutImmutable, Blittable]
		public bool InteractiveManDownAllowed { get; set; }

		[ContainerField(279), LayoutImmutable, Blittable]
		public bool ShowNametag { get; set; }

		public static void Deserialize(SoldierEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.FLIRKeyColor, p_Reader, p_Parser);
			p_Instance.HeadMaterialPair.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.BoneFakePhysics.Clear();
			(RimeReader Reader, uint Count) s_BoneFakePhysics = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_BoneFakePhysics.Count; ++i)
			{
				var s_CtrRef = new CtrRef<BoneFakePhysicsData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_BoneFakePhysics.Reader.ReadUInt32()));
				p_Instance.BoneFakePhysics.Add(s_CtrRef);
			}
			
			s_BoneFakePhysics.Reader.Dispose();
			p_Instance.AutoAim.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.AimingConstraints.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.HeadCollision.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.CharacterPhysics.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.FootMaterialPair.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.SprintSettings.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Meshes1p.Clear();
			(RimeReader Reader, uint Count) s_Meshes1p = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Meshes1p.Count; ++i)
			{
				var s_Value = new SoldierMeshData();
				fb.SoldierMeshData.Deserialize(s_Value, s_Meshes1p.Reader, p_Parser);
				p_Instance.Meshes1p.Add(s_Value);
			}
			
			s_Meshes1p.Reader.Dispose();
			p_Instance.Meshes3p.Clear();
			(RimeReader Reader, uint Count) s_Meshes3p = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Meshes3p.Count; ++i)
			{
				var s_Value = new SoldierMeshData();
				fb.SoldierMeshData.Deserialize(s_Value, s_Meshes3p.Reader, p_Parser);
				p_Instance.Meshes3p.Add(s_Value);
			}
			
			s_Meshes3p.Reader.Dispose();
			p_Instance.HidableMeshParts.Clear();
			(RimeReader Reader, uint Count) s_HidableMeshParts = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_HidableMeshParts.Count; ++i)
			{
				var s_Value = new HidableSoldierMeshWeaponPart();
				fb.HidableSoldierMeshWeaponPart.Deserialize(s_Value, s_HidableMeshParts.Reader, p_Parser);
				p_Instance.HidableMeshParts.Add(s_Value);
			}
			
			s_HidableMeshParts.Reader.Dispose();
			p_Instance.Sound.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.StreamGroup1p.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.ImpulseReactionTime = p_Reader.ReadSingle();
			p_Instance.HealthModule.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.MaxHealth = p_Reader.ReadSingle();
			p_Instance.CollisionInfo.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.VoiceOverInfo.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.FLIRValue = p_Reader.ReadSingle();
			p_Instance.BreathControl.Clear();
			(RimeReader Reader, uint Count) s_BreathControl = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_BreathControl.Count; ++i)
			{
				var s_CtrRef = new CtrRef<BreathControlData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_BreathControl.Reader.ReadUInt32()));
				p_Instance.BreathControl.Add(s_CtrRef);
			}
			
			s_BreathControl.Reader.Dispose();
			p_Instance.ExplosionDamageModifier = p_Reader.ReadSingle();
			p_Instance.UIParts.Clear();
			(RimeReader Reader, uint Count) s_UIParts = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_UIParts.Count; ++i)
			{
				var s_CtrRef = new CtrRef<UIPartData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_UIParts.Reader.ReadUInt32()));
				p_Instance.UIParts.Add(s_CtrRef);
			}
			
			s_UIParts.Reader.Dispose();
			p_Instance.RegenerationDelayModifier = p_Reader.ReadSingle();
			p_Instance.FreeSpaceCheck = p_Reader.ReadBool();
			p_Instance.ProximityCheck = p_Reader.ReadBool();
			p_Instance.EnableGroundmapLighting = p_Reader.ReadBool();
			p_Instance.ShowWeaponWhenDead = p_Reader.ReadBool();
			p_Instance.LowerGunOnOwnTeam = p_Reader.ReadBool();
			p_Instance.UseSpineXRotation = p_Reader.ReadBool();
			p_Instance.CollisionEnabled = p_Reader.ReadBool();
			p_Instance.PhysicsControlled = p_Reader.ReadBool();
			p_Instance.IsPushable = p_Reader.ReadBool();
			p_Instance.HumanPlayerControlled = p_Reader.ReadBool();
			p_Instance.InteractiveManDownAllowed = p_Reader.ReadBool();
			p_Instance.ShowNametag = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
