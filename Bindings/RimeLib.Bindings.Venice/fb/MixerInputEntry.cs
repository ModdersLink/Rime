///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class MixerInputEntry : 
		AudioGraphNodePortGroup
	{
		[ContainerField(8)]
		public AudioGraphNodePort Out { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public CtrRef<AudioGraphParameter> Source { get; set; } = new CtrRef<AudioGraphParameter>(); // 0x10 (16)
		
		[ContainerField(20)]
		public MixerValueAccumulateMode AccumulateMode { get; set; } = new MixerValueAccumulateMode(); // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
					break;

				case 3339738264:
					Source = (CtrRef<AudioGraphParameter>) p_Value;
					break;

				case 2760994582:
					AccumulateMode = (MixerValueAccumulateMode) Enum.ToObject(typeof(MixerValueAccumulateMode), p_Value);
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
				case 193453899:
					return Out;

				case 3339738264:
					return Source;

				case 2760994582:
					return AccumulateMode;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193453899:
					return typeof(MixerInputEntry).GetProperty(nameof(Out));

				case 3339738264:
					return typeof(MixerInputEntry).GetProperty(nameof(Source));

				case 2760994582:
					return typeof(MixerInputEntry).GetProperty(nameof(AccumulateMode));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
