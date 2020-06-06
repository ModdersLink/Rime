///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class MixerOutputEntry : 
		AudioGraphNodePortGroup
	{
		[ContainerField(8)]
		public AudioGraphNodePort In { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public CtrRef<AudioGraphParameter> Target { get; set; } = new CtrRef<AudioGraphParameter>(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (AudioGraphNodePort) p_Value;
					break;

				case 3215022804:
					Target = (CtrRef<AudioGraphParameter>) p_Value;
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
				case 5862146:
					return In;

				case 3215022804:
					return Target;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(MixerOutputEntry).GetProperty(nameof(In));

				case 3215022804:
					return typeof(MixerOutputEntry).GetProperty(nameof(Target));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
