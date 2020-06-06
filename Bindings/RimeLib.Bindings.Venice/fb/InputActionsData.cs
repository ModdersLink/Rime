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
	public class InputActionsData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string NameSid { get; set; } // 0x8 (8)
		
		[ContainerField(12)]
		public InputConceptIdentifiers ConceptIdentifier { get; set; } = new InputConceptIdentifiers(); // 0xC (12)
		
		[ContainerField(16)]
		public InputConceptIdentifiers CopyKeyBindingFrom { get; set; } = new InputConceptIdentifiers(); // 0x10 (16)
		
		[ContainerField(20)]
		public RefArray<InputActionData> InputActions { get; set; } = new RefArray<InputActionData>(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public bool HideInKeyBindings { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3153745340:
					NameSid = (string) p_Value;
					break;

				case 1320965734:
					ConceptIdentifier = (InputConceptIdentifiers) Enum.ToObject(typeof(InputConceptIdentifiers), p_Value);
					break;

				case 1909891296:
					CopyKeyBindingFrom = (InputConceptIdentifiers) Enum.ToObject(typeof(InputConceptIdentifiers), p_Value);
					break;

				case 3504680894:
					InputActions = (RefArray<InputActionData>) p_Value;
					break;

				case 3898345319:
					HideInKeyBindings = (bool) p_Value;
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
				case 3153745340:
					return NameSid;

				case 1320965734:
					return ConceptIdentifier;

				case 1909891296:
					return CopyKeyBindingFrom;

				case 3504680894:
					return InputActions;

				case 3898345319:
					return HideInKeyBindings;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3153745340:
					return typeof(InputActionsData).GetProperty(nameof(NameSid));

				case 1320965734:
					return typeof(InputActionsData).GetProperty(nameof(ConceptIdentifier));

				case 1909891296:
					return typeof(InputActionsData).GetProperty(nameof(CopyKeyBindingFrom));

				case 3504680894:
					return typeof(InputActionsData).GetProperty(nameof(InputActions));

				case 3898345319:
					return typeof(InputActionsData).GetProperty(nameof(HideInKeyBindings));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
