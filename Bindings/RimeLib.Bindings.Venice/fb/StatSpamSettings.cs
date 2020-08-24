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
	public class StatSpamSettings : 
		Asset
	{
		protected List<StatSpamSetting> m_SpamList = new List<StatSpamSetting>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(3963373928), ContainerArray]
		public List<StatSpamSetting> SpamList { get { return m_SpamList; } set { if (OnPropertyChanging("StatSpamSettings." + nameof(SpamList), this, m_SpamList, value)) m_SpamList = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3963373928:
					SpamList = (List<StatSpamSetting>) p_Value;
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
				case 3963373928:
					return SpamList;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3963373928:
					return typeof(StatSpamSettings).GetProperty(nameof(SpamList));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
