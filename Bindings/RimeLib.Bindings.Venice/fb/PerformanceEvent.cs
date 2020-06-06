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
	public class PerformanceEvent : 
		MetricEvent
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Position { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float FreeCPUMemory { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float CPUAverage { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float AllocCPUMemory { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float FreeGPUMemory { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float GPUAverage { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public int DrawCallCount { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public int PrimitiveCount { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float AllocGPUMemory { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable]
		public string PerformanceLocation { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public GUID PerformanceLink { get; set; } // 0x44 (68)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3402582524:
					Position = (Vec3) p_Value;
					break;

				case 3299715286:
					FreeCPUMemory = (float) p_Value;
					break;

				case 2154799904:
					CPUAverage = (float) p_Value;
					break;

				case 964546863:
					AllocCPUMemory = (float) p_Value;
					break;

				case 1089095890:
					FreeGPUMemory = (float) p_Value;
					break;

				case 3225125796:
					GPUAverage = (float) p_Value;
					break;

				case 182572740:
					DrawCallCount = (int) p_Value;
					break;

				case 1563515559:
					PrimitiveCount = (int) p_Value;
					break;

				case 3048894763:
					AllocGPUMemory = (float) p_Value;
					break;

				case 69700128:
					PerformanceLocation = (string) p_Value;
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
				case 3402582524:
					return Position;

				case 3299715286:
					return FreeCPUMemory;

				case 2154799904:
					return CPUAverage;

				case 964546863:
					return AllocCPUMemory;

				case 1089095890:
					return FreeGPUMemory;

				case 3225125796:
					return GPUAverage;

				case 182572740:
					return DrawCallCount;

				case 1563515559:
					return PrimitiveCount;

				case 3048894763:
					return AllocGPUMemory;

				case 69700128:
					return PerformanceLocation;

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
				case 3402582524:
					return typeof(PerformanceEvent).GetProperty(nameof(Position));

				case 3299715286:
					return typeof(PerformanceEvent).GetProperty(nameof(FreeCPUMemory));

				case 2154799904:
					return typeof(PerformanceEvent).GetProperty(nameof(CPUAverage));

				case 964546863:
					return typeof(PerformanceEvent).GetProperty(nameof(AllocCPUMemory));

				case 1089095890:
					return typeof(PerformanceEvent).GetProperty(nameof(FreeGPUMemory));

				case 3225125796:
					return typeof(PerformanceEvent).GetProperty(nameof(GPUAverage));

				case 182572740:
					return typeof(PerformanceEvent).GetProperty(nameof(DrawCallCount));

				case 1563515559:
					return typeof(PerformanceEvent).GetProperty(nameof(PrimitiveCount));

				case 3048894763:
					return typeof(PerformanceEvent).GetProperty(nameof(AllocGPUMemory));

				case 69700128:
					return typeof(PerformanceEvent).GetProperty(nameof(PerformanceLocation));

				case 3478312829:
					return typeof(PerformanceEvent).GetProperty(nameof(PerformanceLink));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
