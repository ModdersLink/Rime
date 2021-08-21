///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 16,  Flags: 53, Size: 160)]
	public class StaticModelEntityData : 
		GamePhysicsEntityData
	{
		protected RefArray<PartLinkData> m_PartLinks = new RefArray<PartLinkData>();
		[ContainerField(Name: "PartLinks", Offset: 112, NameHash: 3210318177, Flags: 65)]
		public RefArray<PartLinkData> PartLinks { get { return m_PartLinks; } set { if (OnPropertyChanging("StaticModelEntityData." + nameof(PartLinks), this, m_PartLinks, value)) m_PartLinks = value; } } // 0x70 (112)
		
		protected CtrRef<MeshAsset> m_Mesh = new CtrRef<MeshAsset>();
		[ContainerField(Name: "Mesh", Offset: 116, NameHash: 2088783990, Flags: 53)]
		public CtrRef<MeshAsset> Mesh { get { return m_Mesh; } set { if (OnPropertyChanging("StaticModelEntityData." + nameof(Mesh), this, m_Mesh, value)) m_Mesh = value; } } // 0x74 (116)
		
		protected uint m_BoneCount = new uint();
		[ContainerField(Name: "BoneCount", Offset: 120, NameHash: 939250912, Flags: 49421), LayoutImmutable, Blittable]
		public uint BoneCount { get { return m_BoneCount; } set { if (OnPropertyChanging("StaticModelEntityData." + nameof(BoneCount), this, m_BoneCount, value)) m_BoneCount = value; } } // 0x78 (120)
		
		protected List<LinearTransform> m_BasePoseTransforms = new List<LinearTransform>();
		[ContainerField(Name: "BasePoseTransforms", Offset: 124, NameHash: 2949884966, Flags: 65)]
		public List<LinearTransform> BasePoseTransforms { get { return m_BasePoseTransforms; } set { if (OnPropertyChanging("StaticModelEntityData." + nameof(BasePoseTransforms), this, m_BasePoseTransforms, value)) m_BasePoseTransforms = value; } } // 0x7C (124)
		
		protected StaticModelNetworkInfo m_NetworkInfo = new StaticModelNetworkInfo();
		[ContainerField(Name: "NetworkInfo", Offset: 128, NameHash: 2269252597, Flags: 41)]
		public StaticModelNetworkInfo NetworkInfo { get { return m_NetworkInfo; } set { if (OnPropertyChanging("StaticModelEntityData." + nameof(NetworkInfo), this, m_NetworkInfo, value)) m_NetworkInfo = value; } } // 0x80 (128)
		
		protected List<PhysicsPartInfo> m_PhysicsPartInfos = new List<PhysicsPartInfo>();
		[ContainerField(Name: "PhysicsPartInfos", Offset: 144, NameHash: 361299716, Flags: 65)]
		public List<PhysicsPartInfo> PhysicsPartInfos { get { return m_PhysicsPartInfos; } set { if (OnPropertyChanging("StaticModelEntityData." + nameof(PhysicsPartInfos), this, m_PhysicsPartInfos, value)) m_PhysicsPartInfos = value; } } // 0x90 (144)
		
		protected bool m_ExcludeFromNearbyObjectDestruction = new bool();
		[ContainerField(Name: "ExcludeFromNearbyObjectDestruction", Offset: 148, NameHash: 2293634461, Flags: 49325), LayoutImmutable, Blittable]
		public bool ExcludeFromNearbyObjectDestruction { get { return m_ExcludeFromNearbyObjectDestruction; } set { if (OnPropertyChanging("StaticModelEntityData." + nameof(ExcludeFromNearbyObjectDestruction), this, m_ExcludeFromNearbyObjectDestruction, value)) m_ExcludeFromNearbyObjectDestruction = value; } } // 0x94 (148)
		
		protected bool m_AnimatePhysics = new bool();
		[ContainerField(Name: "AnimatePhysics", Offset: 149, NameHash: 443997333, Flags: 49325), LayoutImmutable, Blittable]
		public bool AnimatePhysics { get { return m_AnimatePhysics; } set { if (OnPropertyChanging("StaticModelEntityData." + nameof(AnimatePhysics), this, m_AnimatePhysics, value)) m_AnimatePhysics = value; } } // 0x95 (149)
		
		protected bool m_Visible = new bool();
		[ContainerField(Name: "Visible", Offset: 150, NameHash: 901540267, Flags: 49325), LayoutImmutable, Blittable]
		public bool Visible { get { return m_Visible; } set { if (OnPropertyChanging("StaticModelEntityData." + nameof(Visible), this, m_Visible, value)) m_Visible = value; } } // 0x96 (150)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3210318177:
					PartLinks = (RefArray<PartLinkData>) p_Value;
					break;

				case 2088783990:
					Mesh = (CtrRef<MeshAsset>) p_Value;
					break;

				case 939250912:
					BoneCount = (uint) p_Value;
					break;

				case 2949884966:
					BasePoseTransforms = (List<LinearTransform>) p_Value;
					break;

				case 2269252597:
					NetworkInfo = (StaticModelNetworkInfo) p_Value;
					break;

				case 361299716:
					PhysicsPartInfos = (List<PhysicsPartInfo>) p_Value;
					break;

				case 2293634461:
					ExcludeFromNearbyObjectDestruction = (bool) p_Value;
					break;

				case 443997333:
					AnimatePhysics = (bool) p_Value;
					break;

				case 901540267:
					Visible = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3210318177:
					return PartLinks;

				case 2088783990:
					return Mesh;

				case 939250912:
					return BoneCount;

				case 2949884966:
					return BasePoseTransforms;

				case 2269252597:
					return NetworkInfo;

				case 361299716:
					return PhysicsPartInfos;

				case 2293634461:
					return ExcludeFromNearbyObjectDestruction;

				case 443997333:
					return AnimatePhysics;

				case 901540267:
					return Visible;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3210318177:
					return typeof(StaticModelEntityData).GetProperty(nameof(PartLinks));

				case 2088783990:
					return typeof(StaticModelEntityData).GetProperty(nameof(Mesh));

				case 939250912:
					return typeof(StaticModelEntityData).GetProperty(nameof(BoneCount));

				case 2949884966:
					return typeof(StaticModelEntityData).GetProperty(nameof(BasePoseTransforms));

				case 2269252597:
					return typeof(StaticModelEntityData).GetProperty(nameof(NetworkInfo));

				case 361299716:
					return typeof(StaticModelEntityData).GetProperty(nameof(PhysicsPartInfos));

				case 2293634461:
					return typeof(StaticModelEntityData).GetProperty(nameof(ExcludeFromNearbyObjectDestruction));

				case 443997333:
					return typeof(StaticModelEntityData).GetProperty(nameof(AnimatePhysics));

				case 901540267:
					return typeof(StaticModelEntityData).GetProperty(nameof(Visible));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
