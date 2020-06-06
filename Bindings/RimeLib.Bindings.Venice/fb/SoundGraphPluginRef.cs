///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(1)]
	public class SoundGraphPluginRef : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public bool IsValid { get; set; } // 0x0 (0)
		
		[ContainerField(1), LayoutImmutable, Blittable]
		public sbyte VoiceIndex { get; set; } // 0x1 (1)
		
		[ContainerField(2), LayoutImmutable, Blittable]
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
