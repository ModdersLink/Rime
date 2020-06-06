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
	public class MultiCrossfaderNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public RefArray<MultiCrossfaderGroup> CrossfaderGroups { get; set; } = new RefArray<MultiCrossfaderGroup>(); // 0x8 (8)
		
		[ContainerField(12)]
		public AudioGraphNodePort Start { get; set; } = new AudioGraphNodePort(); // 0xC (12)
		
		[ContainerField(20)]
		public AudioGraphNodePort Stop { get; set; } = new AudioGraphNodePort(); // 0x14 (20)
		
		[ContainerField(28)]
		public AudioGraphNodePort Control { get; set; } = new AudioGraphNodePort(); // 0x1C (28)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public bool LockControlValue { get; set; } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 521495907:
					CrossfaderGroups = (RefArray<MultiCrossfaderGroup>) p_Value;
					break;

				case 230748069:
					Start = (AudioGraphNodePort) p_Value;
					break;

				case 2089401213:
					Stop = (AudioGraphNodePort) p_Value;
					break;

				case 3654305890:
					Control = (AudioGraphNodePort) p_Value;
					break;

				case 1905437282:
					LockControlValue = (bool) p_Value;
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
				case 521495907:
					return CrossfaderGroups;

				case 230748069:
					return Start;

				case 2089401213:
					return Stop;

				case 3654305890:
					return Control;

				case 1905437282:
					return LockControlValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 521495907:
					return typeof(MultiCrossfaderNodeData).GetProperty(nameof(CrossfaderGroups));

				case 230748069:
					return typeof(MultiCrossfaderNodeData).GetProperty(nameof(Start));

				case 2089401213:
					return typeof(MultiCrossfaderNodeData).GetProperty(nameof(Stop));

				case 3654305890:
					return typeof(MultiCrossfaderNodeData).GetProperty(nameof(Control));

				case 1905437282:
					return typeof(MultiCrossfaderNodeData).GetProperty(nameof(LockControlValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
