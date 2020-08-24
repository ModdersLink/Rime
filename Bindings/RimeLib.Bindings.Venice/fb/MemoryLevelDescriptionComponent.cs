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
	public class MemoryLevelDescriptionComponent : 
		LevelDescriptionComponent
	{
		protected int m_TexturePoolSize = new int();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(1354314819)]
		public int TexturePoolSize { get { return m_TexturePoolSize; } set { if (OnPropertyChanging("MemoryLevelDescriptionComponent." + nameof(TexturePoolSize), this, m_TexturePoolSize, value)) m_TexturePoolSize = value; } } // 0x8 (8)
		
		protected int m_TexturePoolSizeXenon = new int();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2601129393)]
		public int TexturePoolSizeXenon { get { return m_TexturePoolSizeXenon; } set { if (OnPropertyChanging("MemoryLevelDescriptionComponent." + nameof(TexturePoolSizeXenon), this, m_TexturePoolSizeXenon, value)) m_TexturePoolSizeXenon = value; } } // 0xC (12)
		
		protected int m_TexturePoolSizePs3 = new int();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3737304851)]
		public int TexturePoolSizePs3 { get { return m_TexturePoolSizePs3; } set { if (OnPropertyChanging("MemoryLevelDescriptionComponent." + nameof(TexturePoolSizePs3), this, m_TexturePoolSizePs3, value)) m_TexturePoolSizePs3 = value; } } // 0x10 (16)
		
		protected int m_MeshPoolSizePs3 = new int();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3688895551)]
		public int MeshPoolSizePs3 { get { return m_MeshPoolSizePs3; } set { if (OnPropertyChanging("MemoryLevelDescriptionComponent." + nameof(MeshPoolSizePs3), this, m_MeshPoolSizePs3, value)) m_MeshPoolSizePs3 = value; } } // 0x14 (20)
		
		protected int m_MeshPoolSizePs3Cell = new int();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(979301689)]
		public int MeshPoolSizePs3Cell { get { return m_MeshPoolSizePs3Cell; } set { if (OnPropertyChanging("MemoryLevelDescriptionComponent." + nameof(MeshPoolSizePs3Cell), this, m_MeshPoolSizePs3Cell, value)) m_MeshPoolSizePs3Cell = value; } } // 0x18 (24)
		
		protected int m_MeshPoolSizeXenon = new int();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(1403770333)]
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
