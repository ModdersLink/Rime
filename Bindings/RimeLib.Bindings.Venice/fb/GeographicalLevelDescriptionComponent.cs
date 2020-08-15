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
	public class GeographicalLevelDescriptionComponent : 
		LevelDescriptionComponent
	{
		protected CtrRef<GeographicalData> m_GeographicalData = new CtrRef<GeographicalData>();
		[ContainerField(8), ContainerFieldNameHash(1880696403)]
		public CtrRef<GeographicalData> GeographicalData { get { return m_GeographicalData; } set { if (OnPropertyChanging("GeographicalLevelDescriptionComponent." + nameof(GeographicalData), this, m_GeographicalData, value)) m_GeographicalData = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1880696403:
					GeographicalData = (CtrRef<GeographicalData>) p_Value;
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
				case 1880696403:
					return GeographicalData;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1880696403:
					return typeof(GeographicalLevelDescriptionComponent).GetProperty(nameof(GeographicalData));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
