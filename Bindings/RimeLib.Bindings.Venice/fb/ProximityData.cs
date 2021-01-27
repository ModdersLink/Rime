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
	public class ProximityData : 
		DataContainer
	{
		protected ProximityObjectType m_ProximityType = new ProximityObjectType();
		[ContainerField(Name: "ProximityType", Offset: 8, NameHash: 259289960, Flags: 137)]
		public ProximityObjectType ProximityType { get { return m_ProximityType; } set { if (OnPropertyChanging("ProximityData." + nameof(ProximityType), this, m_ProximityType, value)) m_ProximityType = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 259289960:
					ProximityType = (ProximityObjectType) Enum.ToObject(typeof(ProximityObjectType), p_Value);
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
				case 259289960:
					return ProximityType;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 259289960:
					return typeof(ProximityData).GetProperty(nameof(ProximityType));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
