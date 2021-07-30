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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class OnlineProviderAsset : 
		Asset
	{
		protected List<OnlineProviderConfiguration> m_Configurations = new List<OnlineProviderConfiguration>();
		[ContainerField(Name: "Configurations", Offset: 12, NameHash: 4211240070, Flags: 65)]
		public List<OnlineProviderConfiguration> Configurations { get { return m_Configurations; } set { if (OnPropertyChanging("OnlineProviderAsset." + nameof(Configurations), this, m_Configurations, value)) m_Configurations = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4211240070:
					Configurations = (List<OnlineProviderConfiguration>) p_Value;
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
				case 4211240070:
					return Configurations;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4211240070:
					return typeof(OnlineProviderAsset).GetProperty(nameof(Configurations));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
