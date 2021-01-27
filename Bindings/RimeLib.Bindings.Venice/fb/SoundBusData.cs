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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class SoundBusData : 
		AudioGraphNodeData
	{
		protected string m_BusName = string.Empty;
		[ContainerField(Name: "BusName", Offset: 8, NameHash: 2742307846, Flags: 16509), LayoutImmutable]
		public string BusName { get { return m_BusName; } set { if (OnPropertyChanging("SoundBusData." + nameof(BusName), this, m_BusName, value)) m_BusName = value; } } // 0x8 (8)
		
		protected SoundGraphPluginRef m_SubmixPlugin = new SoundGraphPluginRef();
		[ContainerField(Name: "SubmixPlugin", Offset: 12, NameHash: 132398548, Flags: 41)]
		public SoundGraphPluginRef SubmixPlugin { get { return m_SubmixPlugin; } set { if (OnPropertyChanging("SoundBusData." + nameof(SubmixPlugin), this, m_SubmixPlugin, value)) m_SubmixPlugin = value; } } // 0xC (12)
		
		protected sbyte m_ChannelCount = new sbyte();
		[ContainerField(Name: "ChannelCount", Offset: 15, NameHash: 1014205285, Flags: 49341), LayoutImmutable, Blittable]
		public sbyte ChannelCount { get { return m_ChannelCount; } set { if (OnPropertyChanging("SoundBusData." + nameof(ChannelCount), this, m_ChannelCount, value)) m_ChannelCount = value; } } // 0xF (15)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2742307846:
					BusName = (string) p_Value;
					break;

				case 132398548:
					SubmixPlugin = (SoundGraphPluginRef) p_Value;
					break;

				case 1014205285:
					ChannelCount = (sbyte) p_Value;
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
				case 2742307846:
					return BusName;

				case 132398548:
					return SubmixPlugin;

				case 1014205285:
					return ChannelCount;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2742307846:
					return typeof(SoundBusData).GetProperty(nameof(BusName));

				case 132398548:
					return typeof(SoundBusData).GetProperty(nameof(SubmixPlugin));

				case 1014205285:
					return typeof(SoundBusData).GetProperty(nameof(ChannelCount));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
