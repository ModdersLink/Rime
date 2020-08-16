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
	[ContainerType(4)]
	public class UICoopLevelDescription : 
		LevelDescriptionComponent
	{
		protected string m_Debriefing = string.Empty;
		[ContainerField(8), LayoutImmutable, ContainerFieldNameHash(1664834078)]
		public string Debriefing { get { return m_Debriefing; } set { if (OnPropertyChanging("UICoopLevelDescription." + nameof(Debriefing), this, m_Debriefing, value)) m_Debriefing = value; } } // 0x8 (8)
		
		protected int m_DevTime = new int();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(4015961031)]
		public int DevTime { get { return m_DevTime; } set { if (OnPropertyChanging("UICoopLevelDescription." + nameof(DevTime), this, m_DevTime, value)) m_DevTime = value; } } // 0xC (12)
		
		protected List<string> m_UnlockedByLevels = new List<string>();
		[ContainerField(16), ContainerFieldNameHash(2749335882)]
		public List<string> UnlockedByLevels { get { return m_UnlockedByLevels; } set { if (OnPropertyChanging("UICoopLevelDescription." + nameof(UnlockedByLevels), this, m_UnlockedByLevels, value)) m_UnlockedByLevels = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1664834078:
					Debriefing = (string) p_Value;
					break;

				case 4015961031:
					DevTime = (int) p_Value;
					break;

				case 2749335882:
					UnlockedByLevels = (List<string>) p_Value;
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
				case 1664834078:
					return Debriefing;

				case 4015961031:
					return DevTime;

				case 2749335882:
					return UnlockedByLevels;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1664834078:
					return typeof(UICoopLevelDescription).GetProperty(nameof(Debriefing));

				case 4015961031:
					return typeof(UICoopLevelDescription).GetProperty(nameof(DevTime));

				case 2749335882:
					return typeof(UICoopLevelDescription).GetProperty(nameof(UnlockedByLevels));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
