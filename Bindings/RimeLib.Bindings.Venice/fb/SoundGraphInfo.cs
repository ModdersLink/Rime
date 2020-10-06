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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(24), ContainerStruct]
	public class SoundGraphInfo : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(65), ContainerArray]
		public List<SoundGraphVoiceInfo> Voices { get; set; } = new List<SoundGraphVoiceInfo>(); // 0x0 (0)
		
		[ContainerField(4), MemberInfoFlag(65), ContainerArray]
		public List<SoundGraphLinkedPluginAttribute> LinkedPluginAttributes { get; set; } = new List<SoundGraphLinkedPluginAttribute>(); // 0x4 (4)
		
		[ContainerField(8), MemberInfoFlag(65), ContainerArray]
		public List<SoundGraphPluginConnection> Connections { get; set; } = new List<SoundGraphPluginConnection>(); // 0x8 (8)
		
		[ContainerField(12), MemberInfoFlag(65), ContainerArray]
		public List<SoundGraphPluginConstructParam> ConstructParams { get; set; } = new List<SoundGraphPluginConstructParam>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49421)]
		public uint PluginsParamCount { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49421)]
		public uint PluginCount { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3158134624:
					Voices = (List<SoundGraphVoiceInfo>) p_Value;
					break;

				case 307480642:
					LinkedPluginAttributes = (List<SoundGraphLinkedPluginAttribute>) p_Value;
					break;

				case 1202806848:
					Connections = (List<SoundGraphPluginConnection>) p_Value;
					break;

				case 2981928268:
					ConstructParams = (List<SoundGraphPluginConstructParam>) p_Value;
					break;

				case 1688877395:
					PluginsParamCount = (uint) p_Value;
					break;

				case 2862163855:
					PluginCount = (uint) p_Value;
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
				case 3158134624:
					return Voices;

				case 307480642:
					return LinkedPluginAttributes;

				case 1202806848:
					return Connections;

				case 2981928268:
					return ConstructParams;

				case 1688877395:
					return PluginsParamCount;

				case 2862163855:
					return PluginCount;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3158134624:
					return typeof(SoundGraphInfo).GetProperty(nameof(Voices));

				case 307480642:
					return typeof(SoundGraphInfo).GetProperty(nameof(LinkedPluginAttributes));

				case 1202806848:
					return typeof(SoundGraphInfo).GetProperty(nameof(Connections));

				case 2981928268:
					return typeof(SoundGraphInfo).GetProperty(nameof(ConstructParams));

				case 1688877395:
					return typeof(SoundGraphInfo).GetProperty(nameof(PluginsParamCount));

				case 2862163855:
					return typeof(SoundGraphInfo).GetProperty(nameof(PluginCount));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
