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
	[ContainerType(Alignment: 1,  Flags: 41, Size: 12)]
	public class SamplerPlugins : FrostbiteContainer
	{
		[ContainerField(Name: "SndPlayer", Offset: 0, NameHash: 728257487, Flags: 41)]
		public SoundGraphPluginRef SndPlayer { get; set; } = new SoundGraphPluginRef(); // 0x0 (0)
		
		[ContainerField(Name: "Resample", Offset: 3, NameHash: 53347764, Flags: 41)]
		public SoundGraphPluginRef Resample { get; set; } = new SoundGraphPluginRef(); // 0x3 (3)
		
		[ContainerField(Name: "Pause", Offset: 6, NameHash: 232316407, Flags: 41)]
		public SoundGraphPluginRef Pause { get; set; } = new SoundGraphPluginRef(); // 0x6 (6)
		
		[ContainerField(Name: "Gain", Offset: 9, NameHash: 2088703076, Flags: 41)]
		public SoundGraphPluginRef Gain { get; set; } = new SoundGraphPluginRef(); // 0x9 (9)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 728257487:
					SndPlayer = (SoundGraphPluginRef) p_Value;
					break;

				case 53347764:
					Resample = (SoundGraphPluginRef) p_Value;
					break;

				case 232316407:
					Pause = (SoundGraphPluginRef) p_Value;
					break;

				case 2088703076:
					Gain = (SoundGraphPluginRef) p_Value;
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
				case 728257487:
					return SndPlayer;

				case 53347764:
					return Resample;

				case 232316407:
					return Pause;

				case 2088703076:
					return Gain;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 728257487:
					return typeof(SamplerPlugins).GetProperty(nameof(SndPlayer));

				case 53347764:
					return typeof(SamplerPlugins).GetProperty(nameof(Resample));

				case 232316407:
					return typeof(SamplerPlugins).GetProperty(nameof(Pause));

				case 2088703076:
					return typeof(SamplerPlugins).GetProperty(nameof(Gain));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
