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
	[ContainerType(Alignment: 1,  Flags: 41, Size: 3)]
	public class SoundGraphPluginRef : FrostbiteContainer
	{
		[ContainerField(Name: "IsValid", Offset: 0, NameHash: 2741198505, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsValid { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "VoiceIndex", Offset: 1, NameHash: 785984109, Flags: 49341), LayoutImmutable, Blittable]
		public sbyte VoiceIndex { get; set; } // 0x1 (1)
		
		[ContainerField(Name: "PluginIndex", Offset: 2, NameHash: 2855577170, Flags: 49341), LayoutImmutable, Blittable]
		public sbyte PluginIndex { get; set; } // 0x2 (2)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2741198505:
					IsValid = (bool) p_Value;
					break;

				case 785984109:
					VoiceIndex = (sbyte) p_Value;
					break;

				case 2855577170:
					PluginIndex = (sbyte) p_Value;
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
				case 2741198505:
					return IsValid;

				case 785984109:
					return VoiceIndex;

				case 2855577170:
					return PluginIndex;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2741198505:
					return typeof(SoundGraphPluginRef).GetProperty(nameof(IsValid));

				case 785984109:
					return typeof(SoundGraphPluginRef).GetProperty(nameof(VoiceIndex));

				case 2855577170:
					return typeof(SoundGraphPluginRef).GetProperty(nameof(PluginIndex));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
