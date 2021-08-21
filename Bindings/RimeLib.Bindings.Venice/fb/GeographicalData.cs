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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 36)]
	public class GeographicalData : 
		DataContainer
	{
		protected UIGeoLatitude m_Latitude = new UIGeoLatitude();
		[ContainerField(Name: "Latitude", Offset: 8, NameHash: 591028213, Flags: 41)]
		public UIGeoLatitude Latitude { get { return m_Latitude; } set { if (OnPropertyChanging("GeographicalData." + nameof(Latitude), this, m_Latitude, value)) m_Latitude = value; } } // 0x8 (8)
		
		protected UIGeoLongitude m_Longitude = new UIGeoLongitude();
		[ContainerField(Name: "Longitude", Offset: 20, NameHash: 3158300774, Flags: 41)]
		public UIGeoLongitude Longitude { get { return m_Longitude; } set { if (OnPropertyChanging("GeographicalData." + nameof(Longitude), this, m_Longitude, value)) m_Longitude = value; } } // 0x14 (20)
		
		protected float m_SeaLevelOffset = new float();
		[ContainerField(Name: "SeaLevelOffset", Offset: 32, NameHash: 2454050473, Flags: 49469), LayoutImmutable, Blittable]
		public float SeaLevelOffset { get { return m_SeaLevelOffset; } set { if (OnPropertyChanging("GeographicalData." + nameof(SeaLevelOffset), this, m_SeaLevelOffset, value)) m_SeaLevelOffset = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 591028213:
					Latitude = (UIGeoLatitude) p_Value;
					break;

				case 3158300774:
					Longitude = (UIGeoLongitude) p_Value;
					break;

				case 2454050473:
					SeaLevelOffset = (float) p_Value;
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
				case 591028213:
					return Latitude;

				case 3158300774:
					return Longitude;

				case 2454050473:
					return SeaLevelOffset;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 591028213:
					return typeof(GeographicalData).GetProperty(nameof(Latitude));

				case 3158300774:
					return typeof(GeographicalData).GetProperty(nameof(Longitude));

				case 2454050473:
					return typeof(GeographicalData).GetProperty(nameof(SeaLevelOffset));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
