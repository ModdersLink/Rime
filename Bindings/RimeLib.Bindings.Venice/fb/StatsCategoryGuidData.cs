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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class StatsCategoryGuidData : 
		StatsCategoryBaseData
	{
		protected List<GUID> m_ObjectInstanceGuids = new List<GUID>();
		[ContainerField(Name: "ObjectInstanceGuids", Offset: 20, NameHash: 409262485, Flags: 65)]
		public List<GUID> ObjectInstanceGuids { get { return m_ObjectInstanceGuids; } set { if (OnPropertyChanging("StatsCategoryGuidData." + nameof(ObjectInstanceGuids), this, m_ObjectInstanceGuids, value)) m_ObjectInstanceGuids = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 409262485:
					ObjectInstanceGuids = (List<GUID>) p_Value;
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
				case 409262485:
					return ObjectInstanceGuids;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 409262485:
					return typeof(StatsCategoryGuidData).GetProperty(nameof(ObjectInstanceGuids));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
