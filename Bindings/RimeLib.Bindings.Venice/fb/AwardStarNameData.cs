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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 12)]
	public class AwardStarNameData : 
		DataContainer
	{
		protected List<AwardStarNameInstance> m_NameInstances = new List<AwardStarNameInstance>();
		[ContainerField(Name: "NameInstances", Offset: 8, NameHash: 3979655928, Flags: 65)]
		public List<AwardStarNameInstance> NameInstances { get { return m_NameInstances; } set { if (OnPropertyChanging("AwardStarNameData." + nameof(NameInstances), this, m_NameInstances, value)) m_NameInstances = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3979655928:
					NameInstances = (List<AwardStarNameInstance>) p_Value;
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
				case 3979655928:
					return NameInstances;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3979655928:
					return typeof(AwardStarNameData).GetProperty(nameof(NameInstances));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
