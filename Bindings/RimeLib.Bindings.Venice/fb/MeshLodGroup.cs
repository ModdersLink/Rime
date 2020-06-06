///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class MeshLodGroup : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float Lod1Distance { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float Lod2Distance { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float Lod3Distance { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float Lod4Distance { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float Lod5Distance { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float ShadowDistance { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float CullScreenArea { get; set; } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3299281840:
					Lod1Distance = (float) p_Value;
					break;

				case 4081582771:
					Lod2Distance = (float) p_Value;
					break;

				case 2570967730:
					Lod3Distance = (float) p_Value;
					break;

				case 4154142901:
					Lod4Distance = (float) p_Value;
					break;

				case 890948276:
					Lod5Distance = (float) p_Value;
					break;

				case 4181554240:
					ShadowDistance = (float) p_Value;
					break;

				case 3413873864:
					CullScreenArea = (float) p_Value;
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
				case 3299281840:
					return Lod1Distance;

				case 4081582771:
					return Lod2Distance;

				case 2570967730:
					return Lod3Distance;

				case 4154142901:
					return Lod4Distance;

				case 890948276:
					return Lod5Distance;

				case 4181554240:
					return ShadowDistance;

				case 3413873864:
					return CullScreenArea;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3299281840:
					return typeof(MeshLodGroup).GetProperty(nameof(Lod1Distance));

				case 4081582771:
					return typeof(MeshLodGroup).GetProperty(nameof(Lod2Distance));

				case 2570967730:
					return typeof(MeshLodGroup).GetProperty(nameof(Lod3Distance));

				case 4154142901:
					return typeof(MeshLodGroup).GetProperty(nameof(Lod4Distance));

				case 890948276:
					return typeof(MeshLodGroup).GetProperty(nameof(Lod5Distance));

				case 4181554240:
					return typeof(MeshLodGroup).GetProperty(nameof(ShadowDistance));

				case 3413873864:
					return typeof(MeshLodGroup).GetProperty(nameof(CullScreenArea));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
