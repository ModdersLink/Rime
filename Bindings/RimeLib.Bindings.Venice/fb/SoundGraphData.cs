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
	public class SoundGraphData : 
		AudioGraphData
	{
		[ContainerField(28)]
		public SoundGraphInfo Info { get; set; } = new SoundGraphInfo(); // 0x1C (28)
		
		[ContainerField(52)]
		public RefArray<AudioGraphParameter> InputParameters { get; set; } = new RefArray<AudioGraphParameter>(); // 0x34 (52)
		
		[ContainerField(56)]
		public RefArray<AudioGraphParameter> OutputParameters { get; set; } = new RefArray<AudioGraphParameter>(); // 0x38 (56)
		
		[ContainerField(60)]
		public RefArray<AudioGraphEvent> InputEvents { get; set; } = new RefArray<AudioGraphEvent>(); // 0x3C (60)
		
		[ContainerField(64)]
		public RefArray<AudioGraphEvent> OutputEvents { get; set; } = new RefArray<AudioGraphEvent>(); // 0x40 (64)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088908747:
					Info = (SoundGraphInfo) p_Value;
					break;

				case 344313993:
					InputParameters = (RefArray<AudioGraphParameter>) p_Value;
					break;

				case 1377250080:
					OutputParameters = (RefArray<AudioGraphParameter>) p_Value;
					break;

				case 1542460652:
					InputEvents = (RefArray<AudioGraphEvent>) p_Value;
					break;

				case 3452448709:
					OutputEvents = (RefArray<AudioGraphEvent>) p_Value;
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
				case 2088908747:
					return Info;

				case 344313993:
					return InputParameters;

				case 1377250080:
					return OutputParameters;

				case 1542460652:
					return InputEvents;

				case 3452448709:
					return OutputEvents;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088908747:
					return typeof(SoundGraphData).GetProperty(nameof(Info));

				case 344313993:
					return typeof(SoundGraphData).GetProperty(nameof(InputParameters));

				case 1377250080:
					return typeof(SoundGraphData).GetProperty(nameof(OutputParameters));

				case 1542460652:
					return typeof(SoundGraphData).GetProperty(nameof(InputEvents));

				case 3452448709:
					return typeof(SoundGraphData).GetProperty(nameof(OutputEvents));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
