///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class MeshAsset : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<MeshLodGroup> LodGroup { get; set; } = new CtrRef<MeshLodGroup>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float LodScale { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float CullScale { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint NameHash { get; set; } // 0x18 (24)
		
		[ContainerField(28)]
		public EnlightenType EnlightenType { get; set; } = new EnlightenType(); // 0x1C (28)
		
		[ContainerField(32)]
		public RefArray<MeshMaterial> Materials { get; set; } = new RefArray<MeshMaterial>(); // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public bool OccluderHighPriority { get; set; } // 0x24 (36)
		
		[ContainerField(37), LayoutImmutable, Blittable]
		public bool StreamingEnable { get; set; } // 0x25 (37)
		
		[ContainerField(38), LayoutImmutable, Blittable]
		public bool DestructionMaterialEnable { get; set; } // 0x26 (38)
		
		[ContainerField(39), LayoutImmutable, Blittable]
		public bool OccluderMeshEnable { get; set; } // 0x27 (39)
		
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
