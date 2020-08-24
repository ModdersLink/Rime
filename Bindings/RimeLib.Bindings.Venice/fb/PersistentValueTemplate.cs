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
	public class PersistentValueTemplate : 
		DataContainer
	{
		protected PersistentValueTemplateData m_Data = new PersistentValueTemplateData();
		[ContainerField(8), MemberInfoFlag(41), ContainerFieldNameHash(2088730869)]
		public PersistentValueTemplateData Data { get { return m_Data; } set { if (OnPropertyChanging("PersistentValueTemplate." + nameof(Data), this, m_Data, value)) m_Data = value; } } // 0x8 (8)
		
		protected RefArray<AbstractPersistentStatRef> m_DerivedFormulaRefs = new RefArray<AbstractPersistentStatRef>();
		[ContainerField(44), MemberInfoFlag(65), ContainerFieldNameHash(98984868), ContainerRefArray]
		public RefArray<AbstractPersistentStatRef> DerivedFormulaRefs { get { return m_DerivedFormulaRefs; } set { if (OnPropertyChanging("PersistentValueTemplate." + nameof(DerivedFormulaRefs), this, m_DerivedFormulaRefs, value)) m_DerivedFormulaRefs = value; } } // 0x2C (44)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088730869:
					Data = (PersistentValueTemplateData) p_Value;
					break;

				case 98984868:
					DerivedFormulaRefs = (RefArray<AbstractPersistentStatRef>) p_Value;
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
				case 2088730869:
					return Data;

				case 98984868:
					return DerivedFormulaRefs;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088730869:
					return typeof(PersistentValueTemplate).GetProperty(nameof(Data));

				case 98984868:
					return typeof(PersistentValueTemplate).GetProperty(nameof(DerivedFormulaRefs));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
