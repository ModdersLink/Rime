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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 28)]
	public class UIComponentData : 
		Asset
	{
		protected string m_ShortName = string.Empty;
		[ContainerField(Name: "ShortName", Offset: 12, NameHash: 1803010032, Flags: 16509), LayoutImmutable]
		public string ShortName { get { return m_ShortName; } set { if (OnPropertyChanging("UIComponentData." + nameof(ShortName), this, m_ShortName, value)) m_ShortName = value; } } // 0xC (12)
		
		protected List<string> m_DataSources = new List<string>();
		[ContainerField(Name: "DataSources", Offset: 16, NameHash: 1204335067, Flags: 65)]
		public List<string> DataSources { get { return m_DataSources; } set { if (OnPropertyChanging("UIComponentData." + nameof(DataSources), this, m_DataSources, value)) m_DataSources = value; } } // 0x10 (16)
		
		protected UIUpdateType m_UpdateType = new UIUpdateType();
		[ContainerField(Name: "UpdateType", Offset: 20, NameHash: 2270667052, Flags: 137)]
		public UIUpdateType UpdateType { get { return m_UpdateType; } set { if (OnPropertyChanging("UIComponentData." + nameof(UpdateType), this, m_UpdateType, value)) m_UpdateType = value; } } // 0x14 (20)
		
		protected int m_UpdatesPerSecond = new int();
		[ContainerField(Name: "UpdatesPerSecond", Offset: 24, NameHash: 2192548880, Flags: 49405), LayoutImmutable, Blittable]
		public int UpdatesPerSecond { get { return m_UpdatesPerSecond; } set { if (OnPropertyChanging("UIComponentData." + nameof(UpdatesPerSecond), this, m_UpdatesPerSecond, value)) m_UpdatesPerSecond = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1803010032:
					ShortName = (string) p_Value;
					break;

				case 1204335067:
					DataSources = (List<string>) p_Value;
					break;

				case 2270667052:
					UpdateType = (UIUpdateType) Enum.ToObject(typeof(UIUpdateType), p_Value);
					break;

				case 2192548880:
					UpdatesPerSecond = (int) p_Value;
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
				case 1803010032:
					return ShortName;

				case 1204335067:
					return DataSources;

				case 2270667052:
					return UpdateType;

				case 2192548880:
					return UpdatesPerSecond;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1803010032:
					return typeof(UIComponentData).GetProperty(nameof(ShortName));

				case 1204335067:
					return typeof(UIComponentData).GetProperty(nameof(DataSources));

				case 2270667052:
					return typeof(UIComponentData).GetProperty(nameof(UpdateType));

				case 2192548880:
					return typeof(UIComponentData).GetProperty(nameof(UpdatesPerSecond));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
