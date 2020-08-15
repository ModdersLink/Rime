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
	public class UrgencySetData : 
		DataContainer
	{
		protected string m_Name = new string();
		[ContainerField(8), LayoutImmutable, ContainerFieldNameHash(2088949890)]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("UrgencySetData." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x8 (8)
		
		protected List<UrgencyModifierData> m_UrgencyModifiers = new List<UrgencyModifierData>();
		[ContainerField(12), ContainerFieldNameHash(2098389712)]
		public List<UrgencyModifierData> UrgencyModifiers { get { return m_UrgencyModifiers; } set { if (OnPropertyChanging("UrgencySetData." + nameof(UrgencyModifiers), this, m_UrgencyModifiers, value)) m_UrgencyModifiers = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 2098389712:
					UrgencyModifiers = (List<UrgencyModifierData>) p_Value;
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

				case 2098389712:
					return UrgencyModifiers;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(UrgencySetData).GetProperty(nameof(Name));

				case 2098389712:
					return typeof(UrgencySetData).GetProperty(nameof(UrgencyModifiers));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
