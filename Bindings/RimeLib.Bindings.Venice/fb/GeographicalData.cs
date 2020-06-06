///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class GeographicalData : 
		DataContainer
	{
		[ContainerField(8)]
		public UIGeoLatitude Latitude { get; set; } = new UIGeoLatitude(); // 0x8 (8)
		
		[ContainerField(20)]
		public UIGeoLongitude Longitude { get; set; } = new UIGeoLongitude(); // 0x14 (20)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float SeaLevelOffset { get; set; } // 0x20 (32)
		
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
