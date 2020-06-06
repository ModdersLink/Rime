///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class MixerGraphData : 
		AudioGraphData
	{
		[ContainerField(28)]
		public RefArray<AudioGraphParameter> Inputs { get; set; } = new RefArray<AudioGraphParameter>(); // 0x1C (28)
		
		[ContainerField(32)]
		public List<MixerValueAccumulateMode> AccumulateModes { get; set; } = new List<MixerValueAccumulateMode>(); // 0x20 (32)
		
		[ContainerField(36)]
		public RefArray<AudioGraphParameter> Outputs { get; set; } = new RefArray<AudioGraphParameter>(); // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2784267136:
					Inputs = (RefArray<AudioGraphParameter>) p_Value;
					break;

				case 918507941:
					if (p_Value.GetType() == typeof (List<uint>))
						AccumulateModes = ((List<uint>) p_Value).Select(x => (MixerValueAccumulateMode) Enum.ToObject(typeof(MixerValueAccumulateMode), x)).ToList();
					else
						AccumulateModes = (List<MixerValueAccumulateMode>) p_Value;
					break;

				case 1070022089:
					Outputs = (RefArray<AudioGraphParameter>) p_Value;
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
				case 2784267136:
					return Inputs;

				case 918507941:
					return AccumulateModes;

				case 1070022089:
					return Outputs;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2784267136:
					return typeof(MixerGraphData).GetProperty(nameof(Inputs));

				case 918507941:
					return typeof(MixerGraphData).GetProperty(nameof(AccumulateModes));

				case 1070022089:
					return typeof(MixerGraphData).GetProperty(nameof(Outputs));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
