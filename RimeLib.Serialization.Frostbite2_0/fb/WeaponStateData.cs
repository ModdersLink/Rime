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
	[ContainerType(4, 92)]
	public partial class WeaponStateData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private List<uint> _ReferencedAssetHashes = new();
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private RefArray<BoneFakePhysicsData> _BoneFakePhysics = new();
		
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private CtrRef<SkinnedMeshAsset> _Mesh1p = new();
		
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private CtrRef<SkinnedMeshAsset> _MeshZoom1p = new();
		
		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private CtrRef<SkinnedMeshAsset> _Mesh3p = new();
		
		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private AntRef _Weapon = new();
		
		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _ZoomMeshTransitionFactor;
		
		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _ZoomScaleFactor;
		
		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private List<float> _ZoomInOutMeshTransitionFactors = new();
		
		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private CtrRef<ScopeFilterData> _ZoomedScopeFilter = new();
		
		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private CtrRef<ScopeFilterData> _NonZoomedScopeFilter = new();
		
		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _KeepAimingTime;
		
		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private AnimationConfigurationData _AnimationConfiguration = new();
		
		[ObservableProperty]
		[property: ContainerField(60), JsonProperty(Order = 60)]
		private AnimatedFireEnum _AnimatedFireType = new();
		
		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private AnimatedAimingEnum _AnimatedAimingType = new();
		
		[ObservableProperty]
		[property: ContainerField(68), JsonProperty(Order = 68)]
		private List<LinearTransform> _Mesh3pTransforms = new();
		
		[ObservableProperty]
		[property: ContainerField(72), JsonProperty(Order = 72)]
		private List<RigidMeshSocketTransform> _Mesh3pRigidMeshSocketObjectTransforms = new();
		
		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private float _HideProjectileAfterFireTime;
		
		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, JsonProperty(Order = 80)]
		private string _ProjectileBoneName = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private bool _IsOneHanded;
		
		[ObservableProperty]
		[property: ContainerField(85), LayoutImmutable, Blittable, JsonProperty(Order = 85)]
		private bool _PlayDeployAfterFire;
		
		[ObservableProperty]
		[property: ContainerField(86), LayoutImmutable, Blittable, JsonProperty(Order = 86)]
		private bool _SkipFireAnimation;
		
		[ObservableProperty]
		[property: ContainerField(87), LayoutImmutable, Blittable, JsonProperty(Order = 87)]
		private bool _SkipDeployAnimation;
		
		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private bool _SkipReloadAnimation;
		
		[ObservableProperty]
		[property: ContainerField(89), LayoutImmutable, Blittable, JsonProperty(Order = 89)]
		private bool _AlwaysAimHead;
		
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
