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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 104)]
	public class AwardStarData : 
		AwardData
	{
		protected CtrRef<AwardStarNameData> m_StarTemplate = new CtrRef<AwardStarNameData>();
		[ContainerField(Name: "StarTemplate", Offset: 100, NameHash: 982112673, Flags: 53)]
		public CtrRef<AwardStarNameData> StarTemplate { get { return m_StarTemplate; } set { if (OnPropertyChanging("AwardStarData." + nameof(StarTemplate), this, m_StarTemplate, value)) m_StarTemplate = value; } } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 982112673:
					StarTemplate = (CtrRef<AwardStarNameData>) p_Value;
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
				case 982112673:
					return StarTemplate;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 982112673:
					return typeof(AwardStarData).GetProperty(nameof(StarTemplate));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
