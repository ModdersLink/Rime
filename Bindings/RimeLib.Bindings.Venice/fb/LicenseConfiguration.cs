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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class LicenseConfiguration : 
		Asset
	{
		protected List<LicenseInfo> m_Licenses = new List<LicenseInfo>();
		[ContainerField(Name: "Licenses", Offset: 12, NameHash: 2259172461, Flags: 65)]
		public List<LicenseInfo> Licenses { get { return m_Licenses; } set { if (OnPropertyChanging("LicenseConfiguration." + nameof(Licenses), this, m_Licenses, value)) m_Licenses = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2259172461:
					Licenses = (List<LicenseInfo>) p_Value;
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
				case 2259172461:
					return Licenses;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2259172461:
					return typeof(LicenseConfiguration).GetProperty(nameof(Licenses));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
