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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 32)]
	public class MemoryLevelDescriptionComponent : 
		LevelDescriptionComponent
	{
		protected int m_TexturePoolSize = new int();
		[ContainerField(Name: "TexturePoolSize", Offset: 8, NameHash: 1354314819, Flags: 49405), LayoutImmutable, Blittable]
		public int TexturePoolSize { get { return m_TexturePoolSize; } set { if (OnPropertyChanging("MemoryLevelDescriptionComponent." + nameof(TexturePoolSize), this, m_TexturePoolSize, value)) m_TexturePoolSize = value; } } // 0x8 (8)
		
		protected int m_TexturePoolSizeXenon = new int();
		[ContainerField(Name: "TexturePoolSizeXenon", Offset: 12, NameHash: 2601129393, Flags: 49405), LayoutImmutable, Blittable]
		public int TexturePoolSizeXenon { get { return m_TexturePoolSizeXenon; } set { if (OnPropertyChanging("MemoryLevelDescriptionComponent." + nameof(TexturePoolSizeXenon), this, m_TexturePoolSizeXenon, value)) m_TexturePoolSizeXenon = value; } } // 0xC (12)
		
		protected int m_TexturePoolSizePs3 = new int();
		[ContainerField(Name: "TexturePoolSizePs3", Offset: 16, NameHash: 3737304851, Flags: 49405), LayoutImmutable, Blittable]
		public int TexturePoolSizePs3 { get { return m_TexturePoolSizePs3; } set { if (OnPropertyChanging("MemoryLevelDescriptionComponent." + nameof(TexturePoolSizePs3), this, m_TexturePoolSizePs3, value)) m_TexturePoolSizePs3 = value; } } // 0x10 (16)
		
		protected int m_MeshPoolSizePs3 = new int();
		[ContainerField(Name: "MeshPoolSizePs3", Offset: 20, NameHash: 3688895551, Flags: 49405), LayoutImmutable, Blittable]
		public int MeshPoolSizePs3 { get { return m_MeshPoolSizePs3; } set { if (OnPropertyChanging("MemoryLevelDescriptionComponent." + nameof(MeshPoolSizePs3), this, m_MeshPoolSizePs3, value)) m_MeshPoolSizePs3 = value; } } // 0x14 (20)
		
		protected int m_MeshPoolSizePs3Cell = new int();
		[ContainerField(Name: "MeshPoolSizePs3Cell", Offset: 24, NameHash: 979301689, Flags: 49405), LayoutImmutable, Blittable]
		public int MeshPoolSizePs3Cell { get { return m_MeshPoolSizePs3Cell; } set { if (OnPropertyChanging("MemoryLevelDescriptionComponent." + nameof(MeshPoolSizePs3Cell), this, m_MeshPoolSizePs3Cell, value)) m_MeshPoolSizePs3Cell = value; } } // 0x18 (24)
		
		protected int m_MeshPoolSizeXenon = new int();
		[ContainerField(Name: "MeshPoolSizeXenon", Offset: 28, NameHash: 1403770333, Flags: 49405), LayoutImmutable, Blittable]
		public int MeshPoolSizeXenon { get { return m_MeshPoolSizeXenon; } set { if (OnPropertyChanging("MemoryLevelDescriptionComponent." + nameof(MeshPoolSizeXenon), this, m_MeshPoolSizeXenon, value)) m_MeshPoolSizeXenon = value; } } // 0x1C (28)
		
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
