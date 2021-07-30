///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class EntryInputActionMappingData : 
		InputActionMappingData
	{
		protected EntryInputActionEnum m_ActionIdentifier = new EntryInputActionEnum();
		[ContainerField(Name: "ActionIdentifier", Offset: 8, NameHash: 2090288440, Flags: 137)]
		public EntryInputActionEnum ActionIdentifier { get { return m_ActionIdentifier; } set { if (OnPropertyChanging("EntryInputActionMappingData." + nameof(ActionIdentifier), this, m_ActionIdentifier, value)) m_ActionIdentifier = value; } } // 0x8 (8)
		
		protected InputConceptIdentifiers m_ConceptIdentifier = new InputConceptIdentifiers();
		[ContainerField(Name: "ConceptIdentifier", Offset: 12, NameHash: 1320965734, Flags: 137)]
		public InputConceptIdentifiers ConceptIdentifier { get { return m_ConceptIdentifier; } set { if (OnPropertyChanging("EntryInputActionMappingData." + nameof(ConceptIdentifier), this, m_ConceptIdentifier, value)) m_ConceptIdentifier = value; } } // 0xC (12)
		
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
