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
	[ContainerType(4, 92)]
	public class WeaponStateData :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public List<uint> ReferencedAssetHashes { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public RefArray<BoneFakePhysicsData> BoneFakePhysics { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public CtrRef<SkinnedMeshAsset> Mesh1p { get; set; } = new();
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<SkinnedMeshAsset> MeshZoom1p { get; set; } = new();
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<SkinnedMeshAsset> Mesh3p { get; set; } = new();
		
		[ContainerField(20), JsonProperty(Order = 20)]
		public AntRef Weapon { get; set; } = new();
		
		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float ZoomMeshTransitionFactor { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float ZoomScaleFactor { get; set; }
		
		[ContainerField(32), JsonProperty(Order = 32)]
		public List<float> ZoomInOutMeshTransitionFactors { get; set; } = new();
		
		[ContainerField(36), JsonProperty(Order = 36)]
		public CtrRef<ScopeFilterData> ZoomedScopeFilter { get; set; } = new();
		
		[ContainerField(40), JsonProperty(Order = 40)]
		public CtrRef<ScopeFilterData> NonZoomedScopeFilter { get; set; } = new();
		
		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float KeepAimingTime { get; set; }
		
		[ContainerField(48), JsonProperty(Order = 48)]
		public AnimationConfigurationData AnimationConfiguration { get; set; } = new();
		
		[ContainerField(60), JsonProperty(Order = 60)]
		public AnimatedFireEnum AnimatedFireType { get; set; } = new();
		
		[ContainerField(64), JsonProperty(Order = 64)]
		public AnimatedAimingEnum AnimatedAimingType { get; set; } = new();
		
		[ContainerField(68), JsonProperty(Order = 68)]
		public List<LinearTransform> Mesh3pTransforms { get; set; } = new();
		
		[ContainerField(72), JsonProperty(Order = 72)]
		public List<RigidMeshSocketTransform> Mesh3pRigidMeshSocketObjectTransforms { get; set; } = new();
		
		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public float HideProjectileAfterFireTime { get; set; }
		
		[ContainerField(80), LayoutImmutable, JsonProperty(Order = 80)]
		public string ProjectileBoneName { get; set; } = string.Empty;
		
		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public bool IsOneHanded { get; set; }
		
		[ContainerField(85), LayoutImmutable, Blittable, JsonProperty(Order = 85)]
		public bool PlayDeployAfterFire { get; set; }
		
		[ContainerField(86), LayoutImmutable, Blittable, JsonProperty(Order = 86)]
		public bool SkipFireAnimation { get; set; }
		
		[ContainerField(87), LayoutImmutable, Blittable, JsonProperty(Order = 87)]
		public bool SkipDeployAnimation { get; set; }
		
		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public bool SkipReloadAnimation { get; set; }
		
		[ContainerField(89), LayoutImmutable, Blittable, JsonProperty(Order = 89)]
		public bool AlwaysAimHead { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_ReferencedAssetHashes = p_EbxWriter.GetArrayWriter(ReferencedAssetHashes.GetType(), ReferencedAssetHashes.Count);
			p_Writer.Write(s_ReferencedAssetHashes.ArrayIndex);
			foreach (var s_Entry in ReferencedAssetHashes)
			{
				s_ReferencedAssetHashes.Writer.Write(s_Entry);
			}
			(RimeWriter Writer, uint ArrayIndex) s_BoneFakePhysics = p_EbxWriter.GetArrayWriter(BoneFakePhysics.GetType(), BoneFakePhysics.Count);
			p_Writer.Write(s_BoneFakePhysics.ArrayIndex);
			foreach (var s_Entry in BoneFakePhysics)
			{
				s_BoneFakePhysics.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteImport(Mesh1p));
			p_Writer.Write(p_EbxWriter.WriteImport(MeshZoom1p));
			p_Writer.Write(p_EbxWriter.WriteImport(Mesh3p));
			Weapon.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ZoomMeshTransitionFactor);
			p_Writer.Write(ZoomScaleFactor);
			(RimeWriter Writer, uint ArrayIndex) s_ZoomInOutMeshTransitionFactors = p_EbxWriter.GetArrayWriter(ZoomInOutMeshTransitionFactors.GetType(), ZoomInOutMeshTransitionFactors.Count);
			p_Writer.Write(s_ZoomInOutMeshTransitionFactors.ArrayIndex);
			foreach (var s_Entry in ZoomInOutMeshTransitionFactors)
			{
				s_ZoomInOutMeshTransitionFactors.Writer.Write(s_Entry);
			}
			p_Writer.Write(p_EbxWriter.WriteImport(ZoomedScopeFilter));
			p_Writer.Write(p_EbxWriter.WriteImport(NonZoomedScopeFilter));
			p_Writer.Write(KeepAimingTime);
			AnimationConfiguration.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) AnimatedFireType);
			p_Writer.Write((int) AnimatedAimingType);
			(RimeWriter Writer, uint ArrayIndex) s_Mesh3pTransforms = p_EbxWriter.GetArrayWriter(Mesh3pTransforms.GetType(), Mesh3pTransforms.Count);
			p_Writer.Write(s_Mesh3pTransforms.ArrayIndex);
			foreach (var s_Entry in Mesh3pTransforms)
			{
				s_Entry.Serialize(s_Mesh3pTransforms.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_Mesh3pRigidMeshSocketObjectTransforms = p_EbxWriter.GetArrayWriter(Mesh3pRigidMeshSocketObjectTransforms.GetType(), Mesh3pRigidMeshSocketObjectTransforms.Count);
			p_Writer.Write(s_Mesh3pRigidMeshSocketObjectTransforms.ArrayIndex);
			foreach (var s_Entry in Mesh3pRigidMeshSocketObjectTransforms)
			{
				s_Entry.Serialize(s_Mesh3pRigidMeshSocketObjectTransforms.Writer, p_EbxWriter);
			}
			p_Writer.Write(HideProjectileAfterFireTime);
			p_Writer.Write(p_EbxWriter.WriteString(ProjectileBoneName));
			p_Writer.Write(IsOneHanded);
			p_Writer.Write(PlayDeployAfterFire);
			p_Writer.Write(SkipFireAnimation);
			p_Writer.Write(SkipDeployAnimation);
			p_Writer.Write(SkipReloadAnimation);
			p_Writer.Write(AlwaysAimHead);
			p_Writer.WriteNullBytes(2);
		}
	}
}
