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
	[ContainerType(4, 92)]
	public class WeaponStateData
	{
		[ContainerField(0)]
		public List<uint> ReferencedAssetHashes { get; set; } = new();
		
		[ContainerField(4)]
		public List<CtrRef<BoneFakePhysicsData>> BoneFakePhysics { get; set; } = new();
		
		[ContainerField(8)]
		public CtrRef<SkinnedMeshAsset> Mesh1p { get; set; } = new();
		
		[ContainerField(12)]
		public CtrRef<SkinnedMeshAsset> MeshZoom1p { get; set; } = new();
		
		[ContainerField(16)]
		public CtrRef<SkinnedMeshAsset> Mesh3p { get; set; } = new();
		
		[ContainerField(20)]
		public AntRef Weapon { get; set; } = new();
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float ZoomMeshTransitionFactor { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float ZoomScaleFactor { get; set; }
		
		[ContainerField(32)]
		public List<float> ZoomInOutMeshTransitionFactors { get; set; } = new();
		
		[ContainerField(36)]
		public CtrRef<ScopeFilterData> ZoomedScopeFilter { get; set; } = new();
		
		[ContainerField(40)]
		public CtrRef<ScopeFilterData> NonZoomedScopeFilter { get; set; } = new();
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float KeepAimingTime { get; set; }
		
		[ContainerField(48)]
		public AnimationConfigurationData AnimationConfiguration { get; set; } = new();
		
		[ContainerField(60)]
		public AnimatedFireEnum AnimatedFireType { get; set; } = new();
		
		[ContainerField(64)]
		public AnimatedAimingEnum AnimatedAimingType { get; set; } = new();
		
		[ContainerField(68)]
		public List<LinearTransform> Mesh3pTransforms { get; set; } = new();
		
		[ContainerField(72)]
		public List<RigidMeshSocketTransform> Mesh3pRigidMeshSocketObjectTransforms { get; set; } = new();
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public float HideProjectileAfterFireTime { get; set; }
		
		[ContainerField(80), LayoutImmutable]
		public string ProjectileBoneName { get; set; } = string.Empty;
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public bool IsOneHanded { get; set; }
		
		[ContainerField(85), LayoutImmutable, Blittable]
		public bool PlayDeployAfterFire { get; set; }
		
		[ContainerField(86), LayoutImmutable, Blittable]
		public bool SkipFireAnimation { get; set; }
		
		[ContainerField(87), LayoutImmutable, Blittable]
		public bool SkipDeployAnimation { get; set; }
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public bool SkipReloadAnimation { get; set; }
		
		[ContainerField(89), LayoutImmutable, Blittable]
		public bool AlwaysAimHead { get; set; }
		
		public static void Deserialize(WeaponStateData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ReferencedAssetHashes.Clear();
			(RimeReader Reader, uint Count) s_ReferencedAssetHashes = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ReferencedAssetHashes.Count; ++i)
			{
				var s_Value = s_ReferencedAssetHashes.Reader.ReadUInt32();
				p_Instance.ReferencedAssetHashes.Add(s_Value);
			}
			
			s_ReferencedAssetHashes.Reader.Dispose();
			p_Instance.BoneFakePhysics.Clear();
			(RimeReader Reader, uint Count) s_BoneFakePhysics = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_BoneFakePhysics.Count; ++i)
			{
				var s_CtrRef = new CtrRef<BoneFakePhysicsData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_BoneFakePhysics.Reader.ReadUInt32()));
				p_Instance.BoneFakePhysics.Add(s_CtrRef);
			}
			
			s_BoneFakePhysics.Reader.Dispose();
			p_Instance.Mesh1p.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.MeshZoom1p.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Mesh3p.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			fb.AntRef.Deserialize(p_Instance.Weapon, p_Reader, p_Parser);
			p_Instance.ZoomMeshTransitionFactor = p_Reader.ReadSingle();
			p_Instance.ZoomScaleFactor = p_Reader.ReadSingle();
			p_Instance.ZoomInOutMeshTransitionFactors.Clear();
			(RimeReader Reader, uint Count) s_ZoomInOutMeshTransitionFactors = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ZoomInOutMeshTransitionFactors.Count; ++i)
			{
				var s_Value = s_ZoomInOutMeshTransitionFactors.Reader.ReadSingle();
				p_Instance.ZoomInOutMeshTransitionFactors.Add(s_Value);
			}
			
			s_ZoomInOutMeshTransitionFactors.Reader.Dispose();
			p_Instance.ZoomedScopeFilter.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.NonZoomedScopeFilter.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.KeepAimingTime = p_Reader.ReadSingle();
			fb.AnimationConfigurationData.Deserialize(p_Instance.AnimationConfiguration, p_Reader, p_Parser);
			p_Instance.AnimatedFireType = (AnimatedFireEnum) p_Reader.ReadInt32();
			p_Instance.AnimatedAimingType = (AnimatedAimingEnum) p_Reader.ReadInt32();
			p_Instance.Mesh3pTransforms.Clear();
			(RimeReader Reader, uint Count) s_Mesh3pTransforms = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Mesh3pTransforms.Count; ++i)
			{
				var s_Value = new LinearTransform();
				fb.LinearTransform.Deserialize(s_Value, s_Mesh3pTransforms.Reader, p_Parser);
				p_Instance.Mesh3pTransforms.Add(s_Value);
			}
			
			s_Mesh3pTransforms.Reader.Dispose();
			p_Instance.Mesh3pRigidMeshSocketObjectTransforms.Clear();
			(RimeReader Reader, uint Count) s_Mesh3pRigidMeshSocketObjectTransforms = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Mesh3pRigidMeshSocketObjectTransforms.Count; ++i)
			{
				var s_Value = new RigidMeshSocketTransform();
				fb.RigidMeshSocketTransform.Deserialize(s_Value, s_Mesh3pRigidMeshSocketObjectTransforms.Reader, p_Parser);
				p_Instance.Mesh3pRigidMeshSocketObjectTransforms.Add(s_Value);
			}
			
			s_Mesh3pRigidMeshSocketObjectTransforms.Reader.Dispose();
			p_Instance.HideProjectileAfterFireTime = p_Reader.ReadSingle();
			p_Instance.ProjectileBoneName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.IsOneHanded = p_Reader.ReadBool();
			p_Instance.PlayDeployAfterFire = p_Reader.ReadBool();
			p_Instance.SkipFireAnimation = p_Reader.ReadBool();
			p_Instance.SkipDeployAnimation = p_Reader.ReadBool();
			p_Instance.SkipReloadAnimation = p_Reader.ReadBool();
			p_Instance.AlwaysAimHead = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}
	}
}
