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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 128)]
	public class WingComponentData : 
		PartComponentData
	{
		protected CtrRef<WingPhysicsData> m_Config = new CtrRef<WingPhysicsData>();
		[ContainerField(Name: "Config", Offset: 112, NameHash: 2713732399, Flags: 53)]
		public CtrRef<WingPhysicsData> Config { get { return m_Config; } set { if (OnPropertyChanging("WingComponentData." + nameof(Config), this, m_Config, value)) m_Config = value; } } // 0x70 (112)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2713732399:
					Config = (CtrRef<WingPhysicsData>) p_Value;
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
				case 2713732399:
					return Config;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2713732399:
					return typeof(WingComponentData).GetProperty(nameof(Config));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
