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
	public class MixerSendEntry : 
		AudioGraphNodePortGroup
	{
		[ContainerField(8)]
		public AudioGraphNodePort In { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public CtrRef<AudioGraphParameter> Target { get; set; } = new CtrRef<AudioGraphParameter>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<MixerAsset> Mixer { get; set; } = new CtrRef<MixerAsset>(); // 0x14 (20)
		
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

				case 209965422:
					Mixer = (CtrRef<MixerAsset>) p_Value;
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

				case 209965422:
					return Mixer;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(MixerSendEntry).GetProperty(nameof(In));

				case 3215022804:
					return typeof(MixerSendEntry).GetProperty(nameof(Target));

				case 209965422:
					return typeof(MixerSendEntry).GetProperty(nameof(Mixer));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
