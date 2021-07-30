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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 12)]
	public class PersistentValueTemplateStatRef : 
		AbstractPersistentStatRef
	{
		protected CtrRef<PersistentValueTemplate> m_Definition = new CtrRef<PersistentValueTemplate>();
		[ContainerField(Name: "Definition", Offset: 8, NameHash: 2980331600, Flags: 53)]
		public CtrRef<PersistentValueTemplate> Definition { get { return m_Definition; } set { if (OnPropertyChanging("PersistentValueTemplateStatRef." + nameof(Definition), this, m_Definition, value)) m_Definition = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2980331600:
					Definition = (CtrRef<PersistentValueTemplate>) p_Value;
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
				case 2980331600:
					return Definition;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2980331600:
					return typeof(PersistentValueTemplateStatRef).GetProperty(nameof(Definition));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
