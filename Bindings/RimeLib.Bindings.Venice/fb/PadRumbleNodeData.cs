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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class PadRumbleNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_RumbleHigh = new AudioGraphNodePort();
		[ContainerField(Name: "RumbleHigh", Offset: 8, NameHash: 2053424650, Flags: 41)]
		public AudioGraphNodePort RumbleHigh { get { return m_RumbleHigh; } set { if (OnPropertyChanging("PadRumbleNodeData." + nameof(RumbleHigh), this, m_RumbleHigh, value)) m_RumbleHigh = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_RumbleLow = new AudioGraphNodePort();
		[ContainerField(Name: "RumbleLow", Offset: 16, NameHash: 2144629360, Flags: 41)]
		public AudioGraphNodePort RumbleLow { get { return m_RumbleLow; } set { if (OnPropertyChanging("PadRumbleNodeData." + nameof(RumbleLow), this, m_RumbleLow, value)) m_RumbleLow = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2053424650:
					RumbleHigh = (AudioGraphNodePort) p_Value;
					break;

				case 2144629360:
					RumbleLow = (AudioGraphNodePort) p_Value;
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
				case 2053424650:
					return RumbleHigh;

				case 2144629360:
					return RumbleLow;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2053424650:
					return typeof(PadRumbleNodeData).GetProperty(nameof(RumbleHigh));

				case 2144629360:
					return typeof(PadRumbleNodeData).GetProperty(nameof(RumbleLow));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
