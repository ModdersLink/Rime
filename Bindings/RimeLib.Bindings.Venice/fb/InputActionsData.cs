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
	[ContainerType(4)]
	public class InputActionsData : 
		DataContainer
	{
		protected string m_NameSid = new string();
		[ContainerField(8), LayoutImmutable, ContainerFieldNameHash(3153745340)]
		public string NameSid { get { return m_NameSid; } set { if (OnPropertyChanging("InputActionsData." + nameof(NameSid), this, m_NameSid, value)) m_NameSid = value; } } // 0x8 (8)
		
		protected InputConceptIdentifiers m_ConceptIdentifier = new InputConceptIdentifiers();
		[ContainerField(12), ContainerFieldNameHash(1320965734)]
		public InputConceptIdentifiers ConceptIdentifier { get { return m_ConceptIdentifier; } set { if (OnPropertyChanging("InputActionsData." + nameof(ConceptIdentifier), this, m_ConceptIdentifier, value)) m_ConceptIdentifier = value; } } // 0xC (12)
		
		protected InputConceptIdentifiers m_CopyKeyBindingFrom = new InputConceptIdentifiers();
		[ContainerField(16), ContainerFieldNameHash(1909891296)]
		public InputConceptIdentifiers CopyKeyBindingFrom { get { return m_CopyKeyBindingFrom; } set { if (OnPropertyChanging("InputActionsData." + nameof(CopyKeyBindingFrom), this, m_CopyKeyBindingFrom, value)) m_CopyKeyBindingFrom = value; } } // 0x10 (16)
		
		protected RefArray<InputActionData> m_InputActions = new RefArray<InputActionData>();
		[ContainerField(20), ContainerFieldNameHash(3504680894)]
		public RefArray<InputActionData> InputActions { get { return m_InputActions; } set { if (OnPropertyChanging("InputActionsData." + nameof(InputActions), this, m_InputActions, value)) m_InputActions = value; } } // 0x14 (20)
		
		protected bool m_HideInKeyBindings = new bool();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(3898345319)]
		public bool HideInKeyBindings { get { return m_HideInKeyBindings; } set { if (OnPropertyChanging("InputActionsData." + nameof(HideInKeyBindings), this, m_HideInKeyBindings, value)) m_HideInKeyBindings = value; } } // 0x18 (24)
		
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
