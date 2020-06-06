///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class VeniceExplosionEntityData : 
		ExplosionEntityData
	{
		[ContainerField(176), LayoutImmutable, Blittable]
		public float UnspottableTime { get; set; } // 0xB0 (176)
		
		[ContainerField(180), LayoutImmutable, Blittable]
		public bool UnspotsOnExplode { get; set; } // 0xB4 (180)
		
		[ContainerField(181), LayoutImmutable, Blittable]
		public bool SpotsOnExplode { get; set; } // 0xB5 (181)
		
		[ContainerField(182), LayoutImmutable, Blittable]
		public bool IsCausingSuppression { get; set; } // 0xB6 (182)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 985310797:
					UnspottableTime = (float) p_Value;
					break;

				case 958509307:
					UnspotsOnExplode = (bool) p_Value;
					break;

				case 516835456:
					SpotsOnExplode = (bool) p_Value;
					break;

				case 617259970:
					IsCausingSuppression = (bool) p_Value;
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
				case 985310797:
					return UnspottableTime;

				case 958509307:
					return UnspotsOnExplode;

				case 516835456:
					return SpotsOnExplode;

				case 617259970:
					return IsCausingSuppression;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 985310797:
					return typeof(VeniceExplosionEntityData).GetProperty(nameof(UnspottableTime));

				case 958509307:
					return typeof(VeniceExplosionEntityData).GetProperty(nameof(UnspotsOnExplode));

				case 516835456:
					return typeof(VeniceExplosionEntityData).GetProperty(nameof(SpotsOnExplode));

				case 617259970:
					return typeof(VeniceExplosionEntityData).GetProperty(nameof(IsCausingSuppression));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
