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
	public class UrgencyUserData : 
		DataContainer
	{
		protected CtrRef<UrgencyUserData> m_Base = new CtrRef<UrgencyUserData>();
		[ContainerField(8), MemberInfoFlag(53), ContainerFieldNameHash(2088806864), ContainerCtrRef]
		public CtrRef<UrgencyUserData> Base { get { return m_Base; } set { if (OnPropertyChanging("UrgencyUserData." + nameof(Base), this, m_Base, value)) m_Base = value; } } // 0x8 (8)
		
		protected List<UrgencyModifierData> m_UrgencyModifiers = new List<UrgencyModifierData>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(2098389712), ContainerArray]
		public List<UrgencyModifierData> UrgencyModifiers { get { return m_UrgencyModifiers; } set { if (OnPropertyChanging("UrgencyUserData." + nameof(UrgencyModifiers), this, m_UrgencyModifiers, value)) m_UrgencyModifiers = value; } } // 0xC (12)
		
		protected RefArray<UrgencySetData> m_ModifierSets = new RefArray<UrgencySetData>();
		[ContainerField(16), MemberInfoFlag(65), ContainerFieldNameHash(2115619811), ContainerRefArray]
		public RefArray<UrgencySetData> ModifierSets { get { return m_ModifierSets; } set { if (OnPropertyChanging("UrgencyUserData." + nameof(ModifierSets), this, m_ModifierSets, value)) m_ModifierSets = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088806864:
					Base = (CtrRef<UrgencyUserData>) p_Value;
					break;

				case 2098389712:
					UrgencyModifiers = (List<UrgencyModifierData>) p_Value;
					break;

				case 2115619811:
					ModifierSets = (RefArray<UrgencySetData>) p_Value;
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
				case 2088806864:
					return Base;

				case 2098389712:
					return UrgencyModifiers;

				case 2115619811:
					return ModifierSets;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088806864:
					return typeof(UrgencyUserData).GetProperty(nameof(Base));

				case 2098389712:
					return typeof(UrgencyUserData).GetProperty(nameof(UrgencyModifiers));

				case 2115619811:
					return typeof(UrgencyUserData).GetProperty(nameof(ModifierSets));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
