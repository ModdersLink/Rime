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
	public class SwitcherNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public RefArray<SwitcherEntry> Outputs { get; set; } = new RefArray<SwitcherEntry>(); // 0x8 (8)
		
		[ContainerField(12)]
		public AudioGraphNodePort Trigger { get; set; } = new AudioGraphNodePort(); // 0xC (12)
		
		[ContainerField(20)]
		public AudioGraphNodePort Value { get; set; } = new AudioGraphNodePort(); // 0x14 (20)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float DefaultCaseValue { get; set; } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1070022089:
					Outputs = (RefArray<SwitcherEntry>) p_Value;
					break;

				case 2606354109:
					Trigger = (AudioGraphNodePort) p_Value;
					break;

				case 225375086:
					Value = (AudioGraphNodePort) p_Value;
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
				case 1070022089:
					return Outputs;

				case 2606354109:
					return Trigger;

				case 225375086:
					return Value;

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
				case 1070022089:
					return typeof(SwitcherNodeData).GetProperty(nameof(Outputs));

				case 2606354109:
					return typeof(SwitcherNodeData).GetProperty(nameof(Trigger));

				case 225375086:
					return typeof(SwitcherNodeData).GetProperty(nameof(Value));

				case 3296679953:
					return typeof(SwitcherNodeData).GetProperty(nameof(DefaultCaseValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
