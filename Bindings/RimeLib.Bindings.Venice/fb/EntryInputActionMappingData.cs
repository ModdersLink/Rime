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
	public class EntryInputActionMappingData : 
		InputActionMappingData
	{
		[ContainerField(8)]
		public EntryInputActionEnum ActionIdentifier { get; set; } = new EntryInputActionEnum(); // 0x8 (8)
		
		[ContainerField(12)]
		public InputConceptIdentifiers ConceptIdentifier { get; set; } = new InputConceptIdentifiers(); // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2090288440:
					ActionIdentifier = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
					break;

				case 1320965734:
					ConceptIdentifier = (InputConceptIdentifiers) Enum.ToObject(typeof(InputConceptIdentifiers), p_Value);
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
				case 2090288440:
					return ActionIdentifier;

				case 1320965734:
					return ConceptIdentifier;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2090288440:
					return typeof(EntryInputActionMappingData).GetProperty(nameof(ActionIdentifier));

				case 1320965734:
					return typeof(EntryInputActionMappingData).GetProperty(nameof(ConceptIdentifier));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
