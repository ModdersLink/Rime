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
	[ContainerType(1), MemberInfoFlag(41), ContainerStruct]
	public class DivisibleLoopPlayerPlugins : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(41)]
		public SoundGraphPluginRef SndPlayer { get; set; } = new SoundGraphPluginRef(); // 0x0 (0)
		
		[ContainerField(3), MemberInfoFlag(41)]
		public SoundGraphPluginRef Pause { get; set; } = new SoundGraphPluginRef(); // 0x3 (3)
		
		[ContainerField(6), MemberInfoFlag(41)]
		public SoundGraphPluginRef Gain { get; set; } = new SoundGraphPluginRef(); // 0x6 (6)
		
		[ContainerField(9), MemberInfoFlag(41)]
		public SoundGraphPluginRef GainFader { get; set; } = new SoundGraphPluginRef(); // 0x9 (9)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 728257487:
					SndPlayer = (SoundGraphPluginRef) p_Value;
					break;

				case 232316407:
					Pause = (SoundGraphPluginRef) p_Value;
					break;

				case 2088703076:
					Gain = (SoundGraphPluginRef) p_Value;
					break;

				case 2943317296:
					GainFader = (SoundGraphPluginRef) p_Value;
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

				case 232316407:
					return Pause;

				case 2088703076:
					return Gain;

				case 2943317296:
					return GainFader;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 728257487:
					return typeof(DivisibleLoopPlayerPlugins).GetProperty(nameof(SndPlayer));

				case 232316407:
					return typeof(DivisibleLoopPlayerPlugins).GetProperty(nameof(Pause));

				case 2088703076:
					return typeof(DivisibleLoopPlayerPlugins).GetProperty(nameof(Gain));

				case 2943317296:
					return typeof(DivisibleLoopPlayerPlugins).GetProperty(nameof(GainFader));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
