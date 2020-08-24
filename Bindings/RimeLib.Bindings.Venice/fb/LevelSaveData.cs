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
	public class LevelSaveData : 
		DataContainer
	{
		protected uint m_SaveSize = new uint();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(968383361)]
		public uint SaveSize { get { return m_SaveSize; } set { if (OnPropertyChanging("LevelSaveData." + nameof(SaveSize), this, m_SaveSize, value)) m_SaveSize = value; } } // 0x8 (8)
		
		protected List<string> m_SaveNames = new List<string>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(1878430608), ContainerArray]
		public List<string> SaveNames { get { return m_SaveNames; } set { if (OnPropertyChanging("LevelSaveData." + nameof(SaveNames), this, m_SaveNames, value)) m_SaveNames = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 968383361:
					SaveSize = (uint) p_Value;
					break;

				case 1878430608:
					SaveNames = (List<string>) p_Value;
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
				case 968383361:
					return SaveSize;

				case 1878430608:
					return SaveNames;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 968383361:
					return typeof(LevelSaveData).GetProperty(nameof(SaveSize));

				case 1878430608:
					return typeof(LevelSaveData).GetProperty(nameof(SaveNames));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
