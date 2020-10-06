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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(20), ContainerClass]
	public class VeniceUISettings : 
		SystemSettings
	{
		protected string m_MetaDataAssetPath = string.Empty;
		[ContainerField(12), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(1169897301)]
		public string MetaDataAssetPath { get { return m_MetaDataAssetPath; } set { if (OnPropertyChanging("VeniceUISettings." + nameof(MetaDataAssetPath), this, m_MetaDataAssetPath, value)) m_MetaDataAssetPath = value; } } // 0xC (12)
		
		protected bool m_GetStatsInOnlineFlow = new bool();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3247310760)]
		public bool GetStatsInOnlineFlow { get { return m_GetStatsInOnlineFlow; } set { if (OnPropertyChanging("VeniceUISettings." + nameof(GetStatsInOnlineFlow), this, m_GetStatsInOnlineFlow, value)) m_GetStatsInOnlineFlow = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1169897301:
					MetaDataAssetPath = (string) p_Value;
					break;

				case 3247310760:
					GetStatsInOnlineFlow = (bool) p_Value;
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
				case 1169897301:
					return MetaDataAssetPath;

				case 3247310760:
					return GetStatsInOnlineFlow;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1169897301:
					return typeof(VeniceUISettings).GetProperty(nameof(MetaDataAssetPath));

				case 3247310760:
					return typeof(VeniceUISettings).GetProperty(nameof(GetStatsInOnlineFlow));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
