///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class LensFlareEntityData : 
		SpatialEntityData
	{
		[ContainerField(80)]
		public List<LensFlareElement> Elements { get; set; } = new List<LensFlareElement>(); // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float OccluderSize { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public bool Visible { get; set; } // 0x58 (88)
		
		[ContainerField(89), LayoutImmutable, Blittable]
		public bool HalfRes { get; set; } // 0x59 (89)
		
		[ContainerField(90), LayoutImmutable, Blittable]
		public bool DebugDrawOccluder { get; set; } // 0x5A (90)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2347524808:
					Elements = (List<LensFlareElement>) p_Value;
					break;

				case 2630779365:
					OccluderSize = (float) p_Value;
					break;

				case 901540267:
					Visible = (bool) p_Value;
					break;

				case 2152832706:
					HalfRes = (bool) p_Value;
					break;

				case 3156672721:
					DebugDrawOccluder = (bool) p_Value;
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
				case 2347524808:
					return Elements;

				case 2630779365:
					return OccluderSize;

				case 901540267:
					return Visible;

				case 2152832706:
					return HalfRes;

				case 3156672721:
					return DebugDrawOccluder;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2347524808:
					return typeof(LensFlareEntityData).GetProperty(nameof(Elements));

				case 2630779365:
					return typeof(LensFlareEntityData).GetProperty(nameof(OccluderSize));

				case 901540267:
					return typeof(LensFlareEntityData).GetProperty(nameof(Visible));

				case 2152832706:
					return typeof(LensFlareEntityData).GetProperty(nameof(HalfRes));

				case 3156672721:
					return typeof(LensFlareEntityData).GetProperty(nameof(DebugDrawOccluder));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
