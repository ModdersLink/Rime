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
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class MeshAsset : 
		Asset
	{
		protected CtrRef<MeshLodGroup> m_LodGroup = new CtrRef<MeshLodGroup>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(2046326013), ContainerCtrRef]
		public CtrRef<MeshLodGroup> LodGroup { get { return m_LodGroup; } set { if (OnPropertyChanging("MeshAsset." + nameof(LodGroup), this, m_LodGroup, value)) m_LodGroup = value; } } // 0xC (12)
		
		protected float m_LodScale = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2060016442)]
		public float LodScale { get { return m_LodScale; } set { if (OnPropertyChanging("MeshAsset." + nameof(LodScale), this, m_LodScale, value)) m_LodScale = value; } } // 0x10 (16)
		
		protected float m_CullScale = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2045441291)]
		public float CullScale { get { return m_CullScale; } set { if (OnPropertyChanging("MeshAsset." + nameof(CullScale), this, m_CullScale, value)) m_CullScale = value; } } // 0x14 (20)
		
		protected uint m_NameHash = new uint();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(994057744)]
		public uint NameHash { get { return m_NameHash; } set { if (OnPropertyChanging("MeshAsset." + nameof(NameHash), this, m_NameHash, value)) m_NameHash = value; } } // 0x18 (24)
		
		protected EnlightenType m_EnlightenType = new EnlightenType();
		[ContainerField(28), MemberInfoFlag(137), ContainerFieldNameHash(1801654019)]
		public EnlightenType EnlightenType { get { return m_EnlightenType; } set { if (OnPropertyChanging("MeshAsset." + nameof(EnlightenType), this, m_EnlightenType, value)) m_EnlightenType = value; } } // 0x1C (28)
		
		protected RefArray<MeshMaterial> m_Materials = new RefArray<MeshMaterial>();
		[ContainerField(32), MemberInfoFlag(65), ContainerFieldNameHash(2136313565), ContainerRefArray]
		public RefArray<MeshMaterial> Materials { get { return m_Materials; } set { if (OnPropertyChanging("MeshAsset." + nameof(Materials), this, m_Materials, value)) m_Materials = value; } } // 0x20 (32)
		
		protected bool m_OccluderHighPriority = new bool();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1133933052)]
		public bool OccluderHighPriority { get { return m_OccluderHighPriority; } set { if (OnPropertyChanging("MeshAsset." + nameof(OccluderHighPriority), this, m_OccluderHighPriority, value)) m_OccluderHighPriority = value; } } // 0x24 (36)
		
		protected bool m_StreamingEnable = new bool();
		[ContainerField(37), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(958910872)]
		public bool StreamingEnable { get { return m_StreamingEnable; } set { if (OnPropertyChanging("MeshAsset." + nameof(StreamingEnable), this, m_StreamingEnable, value)) m_StreamingEnable = value; } } // 0x25 (37)
		
		protected bool m_DestructionMaterialEnable = new bool();
		[ContainerField(38), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(927750673)]
		public bool DestructionMaterialEnable { get { return m_DestructionMaterialEnable; } set { if (OnPropertyChanging("MeshAsset." + nameof(DestructionMaterialEnable), this, m_DestructionMaterialEnable, value)) m_DestructionMaterialEnable = value; } } // 0x26 (38)
		
		protected bool m_OccluderMeshEnable = new bool();
		[ContainerField(39), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1918782450)]
		public bool OccluderMeshEnable { get { return m_OccluderMeshEnable; } set { if (OnPropertyChanging("MeshAsset." + nameof(OccluderMeshEnable), this, m_OccluderMeshEnable, value)) m_OccluderMeshEnable = value; } } // 0x27 (39)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2046326013:
					LodGroup = (CtrRef<MeshLodGroup>) p_Value;
					break;

				case 2060016442:
					LodScale = (float) p_Value;
					break;

				case 2045441291:
					CullScale = (float) p_Value;
					break;

				case 994057744:
					NameHash = (uint) p_Value;
					break;

				case 1801654019:
					EnlightenType = (EnlightenType) Enum.ToObject(typeof(EnlightenType), p_Value);
					break;

				case 2136313565:
					Materials = (RefArray<MeshMaterial>) p_Value;
					break;

				case 1133933052:
					OccluderHighPriority = (bool) p_Value;
					break;

				case 958910872:
					StreamingEnable = (bool) p_Value;
					break;

				case 927750673:
					DestructionMaterialEnable = (bool) p_Value;
					break;

				case 1918782450:
					OccluderMeshEnable = (bool) p_Value;
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
				case 2046326013:
					return LodGroup;

				case 2060016442:
					return LodScale;

				case 2045441291:
					return CullScale;

				case 994057744:
					return NameHash;

				case 1801654019:
					return EnlightenType;

				case 2136313565:
					return Materials;

				case 1133933052:
					return OccluderHighPriority;

				case 958910872:
					return StreamingEnable;

				case 927750673:
					return DestructionMaterialEnable;

				case 1918782450:
					return OccluderMeshEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2046326013:
					return typeof(MeshAsset).GetProperty(nameof(LodGroup));

				case 2060016442:
					return typeof(MeshAsset).GetProperty(nameof(LodScale));

				case 2045441291:
					return typeof(MeshAsset).GetProperty(nameof(CullScale));

				case 994057744:
					return typeof(MeshAsset).GetProperty(nameof(NameHash));

				case 1801654019:
					return typeof(MeshAsset).GetProperty(nameof(EnlightenType));

				case 2136313565:
					return typeof(MeshAsset).GetProperty(nameof(Materials));

				case 1133933052:
					return typeof(MeshAsset).GetProperty(nameof(OccluderHighPriority));

				case 958910872:
					return typeof(MeshAsset).GetProperty(nameof(StreamingEnable));

				case 927750673:
					return typeof(MeshAsset).GetProperty(nameof(DestructionMaterialEnable));

				case 1918782450:
					return typeof(MeshAsset).GetProperty(nameof(OccluderMeshEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
