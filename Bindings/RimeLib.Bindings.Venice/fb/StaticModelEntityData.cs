///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class StaticModelEntityData : 
		GamePhysicsEntityData
	{
		[ContainerField(112)]
		public RefArray<PartLinkData> PartLinks { get; set; } = new RefArray<PartLinkData>(); // 0x70 (112)
		
		[ContainerField(116)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new CtrRef<MeshAsset>(); // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public uint BoneCount { get; set; } // 0x78 (120)
		
		[ContainerField(124)]
		public List<LinearTransform> BasePoseTransforms { get; set; } = new List<LinearTransform>(); // 0x7C (124)
		
		[ContainerField(128)]
		public StaticModelNetworkInfo NetworkInfo { get; set; } = new StaticModelNetworkInfo(); // 0x80 (128)
		
		[ContainerField(144)]
		public List<PhysicsPartInfo> PhysicsPartInfos { get; set; } = new List<PhysicsPartInfo>(); // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public bool ExcludeFromNearbyObjectDestruction { get; set; } // 0x94 (148)
		
		[ContainerField(149), LayoutImmutable, Blittable]
		public bool AnimatePhysics { get; set; } // 0x95 (149)
		
		[ContainerField(150), LayoutImmutable, Blittable]
		public bool Visible { get; set; } // 0x96 (150)
		
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
