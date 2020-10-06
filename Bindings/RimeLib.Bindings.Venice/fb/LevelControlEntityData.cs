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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(112), ContainerClass]
	public class LevelControlEntityData : 
		GameEntityData
	{
		protected string m_LevelToLoad = string.Empty;
		[ContainerField(96), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(932165454)]
		public string LevelToLoad { get { return m_LevelToLoad; } set { if (OnPropertyChanging("LevelControlEntityData." + nameof(LevelToLoad), this, m_LevelToLoad, value)) m_LevelToLoad = value; } } // 0x60 (96)
		
		protected bool m_RollCredits = new bool();
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3139123878)]
		public bool RollCredits { get { return m_RollCredits; } set { if (OnPropertyChanging("LevelControlEntityData." + nameof(RollCredits), this, m_RollCredits, value)) m_RollCredits = value; } } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 932165454:
					LevelToLoad = (string) p_Value;
					break;

				case 3139123878:
					RollCredits = (bool) p_Value;
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
				case 932165454:
					return LevelToLoad;

				case 3139123878:
					return RollCredits;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 932165454:
					return typeof(LevelControlEntityData).GetProperty(nameof(LevelToLoad));

				case 3139123878:
					return typeof(LevelControlEntityData).GetProperty(nameof(RollCredits));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
