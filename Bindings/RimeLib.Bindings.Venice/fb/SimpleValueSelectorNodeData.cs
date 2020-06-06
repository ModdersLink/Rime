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
	public class SimpleValueSelectorNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public List<float> OutValues { get; set; } = new List<float>(); // 0x8 (8)
		
		[ContainerField(12)]
		public AudioGraphNodePort Index { get; set; } = new AudioGraphNodePort(); // 0xC (12)
		
		[ContainerField(20)]
		public AudioGraphNodePort Out { get; set; } = new AudioGraphNodePort(); // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2730967827:
					OutValues = (List<float>) p_Value;
					break;

				case 214509467:
					Index = (AudioGraphNodePort) p_Value;
					break;

				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
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
				case 2730967827:
					return OutValues;

				case 214509467:
					return Index;

				case 193453899:
					return Out;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2730967827:
					return typeof(SimpleValueSelectorNodeData).GetProperty(nameof(OutValues));

				case 214509467:
					return typeof(SimpleValueSelectorNodeData).GetProperty(nameof(Index));

				case 193453899:
					return typeof(SimpleValueSelectorNodeData).GetProperty(nameof(Out));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
