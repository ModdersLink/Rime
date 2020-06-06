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
	public class MemoryLevelDescriptionComponent : 
		LevelDescriptionComponent
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public int TexturePoolSize { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public int TexturePoolSizeXenon { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public int TexturePoolSizePs3 { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public int MeshPoolSizePs3 { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public int MeshPoolSizePs3Cell { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public int MeshPoolSizeXenon { get; set; } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1354314819:
					TexturePoolSize = (int) p_Value;
					break;

				case 2601129393:
					TexturePoolSizeXenon = (int) p_Value;
					break;

				case 3737304851:
					TexturePoolSizePs3 = (int) p_Value;
					break;

				case 3688895551:
					MeshPoolSizePs3 = (int) p_Value;
					break;

				case 979301689:
					MeshPoolSizePs3Cell = (int) p_Value;
					break;

				case 1403770333:
					MeshPoolSizeXenon = (int) p_Value;
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
				case 1354314819:
					return TexturePoolSize;

				case 2601129393:
					return TexturePoolSizeXenon;

				case 3737304851:
					return TexturePoolSizePs3;

				case 3688895551:
					return MeshPoolSizePs3;

				case 979301689:
					return MeshPoolSizePs3Cell;

				case 1403770333:
					return MeshPoolSizeXenon;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1354314819:
					return typeof(MemoryLevelDescriptionComponent).GetProperty(nameof(TexturePoolSize));

				case 2601129393:
					return typeof(MemoryLevelDescriptionComponent).GetProperty(nameof(TexturePoolSizeXenon));

				case 3737304851:
					return typeof(MemoryLevelDescriptionComponent).GetProperty(nameof(TexturePoolSizePs3));

				case 3688895551:
					return typeof(MemoryLevelDescriptionComponent).GetProperty(nameof(MeshPoolSizePs3));

				case 979301689:
					return typeof(MemoryLevelDescriptionComponent).GetProperty(nameof(MeshPoolSizePs3Cell));

				case 1403770333:
					return typeof(MemoryLevelDescriptionComponent).GetProperty(nameof(MeshPoolSizeXenon));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
