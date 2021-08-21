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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class LevelSaveData : 
		DataContainer
	{
		protected uint m_SaveSize = new uint();
		[ContainerField(Name: "SaveSize", Offset: 8, NameHash: 968383361, Flags: 49421), LayoutImmutable, Blittable]
		public uint SaveSize { get { return m_SaveSize; } set { if (OnPropertyChanging("LevelSaveData." + nameof(SaveSize), this, m_SaveSize, value)) m_SaveSize = value; } } // 0x8 (8)
		
		protected List<string> m_SaveNames = new List<string>();
		[ContainerField(Name: "SaveNames", Offset: 12, NameHash: 1878430608, Flags: 65)]
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
