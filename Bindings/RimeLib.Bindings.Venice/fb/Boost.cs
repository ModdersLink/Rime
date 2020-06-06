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
	public class Boost : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float ForwardStrength { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float ReverseStrength { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float DissipationTime { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float RecoveryTime { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float CrawlStrength { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float AccelerationScale { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 91624507:
					ForwardStrength = (float) p_Value;
					break;

				case 91172096:
					ReverseStrength = (float) p_Value;
					break;

				case 3822739865:
					DissipationTime = (float) p_Value;
					break;

				case 359615635:
					RecoveryTime = (float) p_Value;
					break;

				case 3643856331:
					CrawlStrength = (float) p_Value;
					break;

				case 116231199:
					AccelerationScale = (float) p_Value;
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
				case 91624507:
					return ForwardStrength;

				case 91172096:
					return ReverseStrength;

				case 3822739865:
					return DissipationTime;

				case 359615635:
					return RecoveryTime;

				case 3643856331:
					return CrawlStrength;

				case 116231199:
					return AccelerationScale;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 91624507:
					return typeof(Boost).GetProperty(nameof(ForwardStrength));

				case 91172096:
					return typeof(Boost).GetProperty(nameof(ReverseStrength));

				case 3822739865:
					return typeof(Boost).GetProperty(nameof(DissipationTime));

				case 359615635:
					return typeof(Boost).GetProperty(nameof(RecoveryTime));

				case 3643856331:
					return typeof(Boost).GetProperty(nameof(CrawlStrength));

				case 116231199:
					return typeof(Boost).GetProperty(nameof(AccelerationScale));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
