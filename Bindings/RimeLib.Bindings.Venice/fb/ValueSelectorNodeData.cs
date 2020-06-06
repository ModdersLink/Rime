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
	public class ValueSelectorNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public RefArray<ValueSelectorEntry> Inputs { get; set; } = new RefArray<ValueSelectorEntry>(); // 0x8 (8)
		
		[ContainerField(12)]
		public AudioGraphNodePort Value { get; set; } = new AudioGraphNodePort(); // 0xC (12)
		
		[ContainerField(20)]
		public AudioGraphNodePort Out { get; set; } = new AudioGraphNodePort(); // 0x14 (20)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float DefaultCaseValue { get; set; } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2784267136:
					Inputs = (RefArray<ValueSelectorEntry>) p_Value;
					break;

				case 225375086:
					Value = (AudioGraphNodePort) p_Value;
					break;

				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
					break;

				case 3296679953:
					DefaultCaseValue = (float) p_Value;
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

				case 225375086:
					return Value;

				case 193453899:
					return Out;

				case 3296679953:
					return DefaultCaseValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2784267136:
					return typeof(ValueSelectorNodeData).GetProperty(nameof(Inputs));

				case 225375086:
					return typeof(ValueSelectorNodeData).GetProperty(nameof(Value));

				case 193453899:
					return typeof(ValueSelectorNodeData).GetProperty(nameof(Out));

				case 3296679953:
					return typeof(ValueSelectorNodeData).GetProperty(nameof(DefaultCaseValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
