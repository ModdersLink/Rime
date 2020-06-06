///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class SoundGraphVoiceInfo : FrostbiteContainer
	{
		[ContainerField(0)]
		public List<SoundGraphPluginInfo> Plugins { get; set; } = new List<SoundGraphPluginInfo>(); // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public sbyte ProcessingStage { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 14514271:
					Plugins = (List<SoundGraphPluginInfo>) p_Value;
					break;

				case 4200711978:
					ProcessingStage = (sbyte) p_Value;
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
				case 14514271:
					return Plugins;

				case 4200711978:
					return ProcessingStage;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 14514271:
					return typeof(SoundGraphVoiceInfo).GetProperty(nameof(Plugins));

				case 4200711978:
					return typeof(SoundGraphVoiceInfo).GetProperty(nameof(ProcessingStage));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
