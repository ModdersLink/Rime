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
	public class MinMaxValueSelectorNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public RefArray<MinMaxValueSelectorEntry> Inputs { get; set; } = new RefArray<MinMaxValueSelectorEntry>(); // 0x8 (8)
		
		[ContainerField(12)]
		public AudioGraphNodePort MaxValue { get; set; } = new AudioGraphNodePort(); // 0xC (12)
		
		[ContainerField(20)]
		public AudioGraphNodePort MaxIndex { get; set; } = new AudioGraphNodePort(); // 0x14 (20)
		
		[ContainerField(28)]
		public AudioGraphNodePort MinValue { get; set; } = new AudioGraphNodePort(); // 0x1C (28)
		
		[ContainerField(36)]
		public AudioGraphNodePort MinIndex { get; set; } = new AudioGraphNodePort(); // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2784267136:
					Inputs = (RefArray<MinMaxValueSelectorEntry>) p_Value;
					break;

				case 408516922:
					MaxValue = (AudioGraphNodePort) p_Value;
					break;

				case 426400079:
					MaxIndex = (AudioGraphNodePort) p_Value;
					break;

				case 3371854436:
					MinValue = (AudioGraphNodePort) p_Value;
					break;

				case 3347206417:
					MinIndex = (AudioGraphNodePort) p_Value;
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

				case 408516922:
					return MaxValue;

				case 426400079:
					return MaxIndex;

				case 3371854436:
					return MinValue;

				case 3347206417:
					return MinIndex;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2784267136:
					return typeof(MinMaxValueSelectorNodeData).GetProperty(nameof(Inputs));

				case 408516922:
					return typeof(MinMaxValueSelectorNodeData).GetProperty(nameof(MaxValue));

				case 426400079:
					return typeof(MinMaxValueSelectorNodeData).GetProperty(nameof(MaxIndex));

				case 3371854436:
					return typeof(MinMaxValueSelectorNodeData).GetProperty(nameof(MinValue));

				case 3347206417:
					return typeof(MinMaxValueSelectorNodeData).GetProperty(nameof(MinIndex));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
