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
	public class AwardHeaderData : 
		AbstractAwardData
	{
		protected AwardGroup m_Group = new AwardGroup();
		[ContainerField(12), ContainerFieldNameHash(208130522)]
		public AwardGroup Group { get { return m_Group; } set { if (OnPropertyChanging("AwardHeaderData." + nameof(Group), this, m_Group, value)) m_Group = value; } } // 0xC (12)
		
		protected StatsMultiplicity m_Multiplicity = new StatsMultiplicity();
		[ContainerField(16), ContainerFieldNameHash(2648087582)]
		public StatsMultiplicity Multiplicity { get { return m_Multiplicity; } set { if (OnPropertyChanging("AwardHeaderData." + nameof(Multiplicity), this, m_Multiplicity, value)) m_Multiplicity = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 208130522:
					Group = (AwardGroup) Enum.ToObject(typeof(AwardGroup), p_Value);
					break;

				case 2648087582:
					Multiplicity = (StatsMultiplicity) Enum.ToObject(typeof(StatsMultiplicity), p_Value);
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
				case 208130522:
					return Group;

				case 2648087582:
					return Multiplicity;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 208130522:
					return typeof(AwardHeaderData).GetProperty(nameof(Group));

				case 2648087582:
					return typeof(AwardHeaderData).GetProperty(nameof(Multiplicity));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
