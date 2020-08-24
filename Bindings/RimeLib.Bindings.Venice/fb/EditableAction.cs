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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class EditableAction : 
		DataContainer
	{
		protected InputConceptIdentifiers m_Concept = new InputConceptIdentifiers();
		[ContainerField(8), MemberInfoFlag(137), ContainerFieldNameHash(3653994469)]
		public InputConceptIdentifiers Concept { get { return m_Concept; } set { if (OnPropertyChanging("EditableAction." + nameof(Concept), this, m_Concept, value)) m_Concept = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3653994469:
					Concept = (InputConceptIdentifiers) Enum.ToObject(typeof(InputConceptIdentifiers), p_Value);
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
				case 3653994469:
					return Concept;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3653994469:
					return typeof(EditableAction).GetProperty(nameof(Concept));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
