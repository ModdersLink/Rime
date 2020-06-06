///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(8)]
	public class FramerateHistogramPerformanceEvent : 
		MetricEvent
	{
		[ContainerField(16), LayoutImmutable, Blittable]
		public float SpikeAverage { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float Below5 { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float Below10 { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float Below15 { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float Below20 { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float Below25 { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float Below30 { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float Below60 { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float Above60 { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public GUID PerformanceLink { get; set; } // 0x34 (52)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4281755330:
					SpikeAverage = (float) p_Value;
					break;

				case 2668044995:
					Below5 = (float) p_Value;
					break;

				case 2146139031:
					Below10 = (float) p_Value;
					break;

				case 2146139026:
					Below15 = (float) p_Value;
					break;

				case 2146138996:
					Below20 = (float) p_Value;
					break;

				case 2146138993:
					Below25 = (float) p_Value;
					break;

				case 2146138965:
					Below30 = (float) p_Value;
					break;

				case 2146138864:
					Below60 = (float) p_Value;
					break;

				case 402579644:
					Above60 = (float) p_Value;
					break;

				case 3478312829:
					PerformanceLink = (GUID) p_Value;
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
				case 4281755330:
					return SpikeAverage;

				case 2668044995:
					return Below5;

				case 2146139031:
					return Below10;

				case 2146139026:
					return Below15;

				case 2146138996:
					return Below20;

				case 2146138993:
					return Below25;

				case 2146138965:
					return Below30;

				case 2146138864:
					return Below60;

				case 402579644:
					return Above60;

				case 3478312829:
					return PerformanceLink;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4281755330:
					return typeof(FramerateHistogramPerformanceEvent).GetProperty(nameof(SpikeAverage));

				case 2668044995:
					return typeof(FramerateHistogramPerformanceEvent).GetProperty(nameof(Below5));

				case 2146139031:
					return typeof(FramerateHistogramPerformanceEvent).GetProperty(nameof(Below10));

				case 2146139026:
					return typeof(FramerateHistogramPerformanceEvent).GetProperty(nameof(Below15));

				case 2146138996:
					return typeof(FramerateHistogramPerformanceEvent).GetProperty(nameof(Below20));

				case 2146138993:
					return typeof(FramerateHistogramPerformanceEvent).GetProperty(nameof(Below25));

				case 2146138965:
					return typeof(FramerateHistogramPerformanceEvent).GetProperty(nameof(Below30));

				case 2146138864:
					return typeof(FramerateHistogramPerformanceEvent).GetProperty(nameof(Below60));

				case 402579644:
					return typeof(FramerateHistogramPerformanceEvent).GetProperty(nameof(Above60));

				case 3478312829:
					return typeof(FramerateHistogramPerformanceEvent).GetProperty(nameof(PerformanceLink));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
