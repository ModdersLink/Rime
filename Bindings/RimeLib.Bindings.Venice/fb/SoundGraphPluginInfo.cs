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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 12)]
	public class SoundGraphPluginInfo : FrostbiteContainer
	{
		[ContainerField(Name: "Id", Offset: 0, NameHash: 5862152, Flags: 49421), LayoutImmutable, Blittable]
		public uint Id { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "EnableAttributeReadMask", Offset: 4, NameHash: 482068574, Flags: 49421), LayoutImmutable, Blittable]
		public uint EnableAttributeReadMask { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "ConnectionIndex", Offset: 8, NameHash: 2316221069, Flags: 49341), LayoutImmutable, Blittable]
		public sbyte ConnectionIndex { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "OutputChannelCount", Offset: 9, NameHash: 4054579418, Flags: 49341), LayoutImmutable, Blittable]
		public sbyte OutputChannelCount { get; set; } // 0x9 (9)
		
		[ContainerField(Name: "ConstructParamsIndex", Offset: 10, NameHash: 226456690, Flags: 49341), LayoutImmutable, Blittable]
		public sbyte ConstructParamsIndex { get; set; } // 0xA (10)
		
		[ContainerField(Name: "ConstructParamCount", Offset: 11, NameHash: 1363907676, Flags: 49341), LayoutImmutable, Blittable]
		public sbyte ConstructParamCount { get; set; } // 0xB (11)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862152:
					Id = (uint) p_Value;
					break;

				case 482068574:
					EnableAttributeReadMask = (uint) p_Value;
					break;

				case 2316221069:
					ConnectionIndex = (sbyte) p_Value;
					break;

				case 4054579418:
					OutputChannelCount = (sbyte) p_Value;
					break;

				case 226456690:
					ConstructParamsIndex = (sbyte) p_Value;
					break;

				case 1363907676:
					ConstructParamCount = (sbyte) p_Value;
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
				case 5862152:
					return Id;

				case 482068574:
					return EnableAttributeReadMask;

				case 2316221069:
					return ConnectionIndex;

				case 4054579418:
					return OutputChannelCount;

				case 226456690:
					return ConstructParamsIndex;

				case 1363907676:
					return ConstructParamCount;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862152:
					return typeof(SoundGraphPluginInfo).GetProperty(nameof(Id));

				case 482068574:
					return typeof(SoundGraphPluginInfo).GetProperty(nameof(EnableAttributeReadMask));

				case 2316221069:
					return typeof(SoundGraphPluginInfo).GetProperty(nameof(ConnectionIndex));

				case 4054579418:
					return typeof(SoundGraphPluginInfo).GetProperty(nameof(OutputChannelCount));

				case 226456690:
					return typeof(SoundGraphPluginInfo).GetProperty(nameof(ConstructParamsIndex));

				case 1363907676:
					return typeof(SoundGraphPluginInfo).GetProperty(nameof(ConstructParamCount));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
