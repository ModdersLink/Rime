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
	public class VoiceOverLogicFlow : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } // 0x8 (8)
		
		[ContainerField(12)]
		public CtrRef<VoiceOverGroup> Group { get; set; } = new CtrRef<VoiceOverGroup>(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<VoiceOverValue> Locals { get; set; } = new RefArray<VoiceOverValue>(); // 0x10 (16)
		
		[ContainerField(20)]
		public RefArray<VoiceOverEventNode> Roots { get; set; } = new RefArray<VoiceOverEventNode>(); // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 208130522:
					Group = (CtrRef<VoiceOverGroup>) p_Value;
					break;

				case 2904565275:
					Locals = (RefArray<VoiceOverValue>) p_Value;
					break;

				case 230317904:
					Roots = (RefArray<VoiceOverEventNode>) p_Value;
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
				case 2088949890:
					return Name;

				case 208130522:
					return Group;

				case 2904565275:
					return Locals;

				case 230317904:
					return Roots;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(VoiceOverLogicFlow).GetProperty(nameof(Name));

				case 208130522:
					return typeof(VoiceOverLogicFlow).GetProperty(nameof(Group));

				case 2904565275:
					return typeof(VoiceOverLogicFlow).GetProperty(nameof(Locals));

				case 230317904:
					return typeof(VoiceOverLogicFlow).GetProperty(nameof(Roots));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
