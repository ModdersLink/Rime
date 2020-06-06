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
	public class PerformanceProfileState : 
		MetricState
	{
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint ProcessorCount { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public uint ProcessorCoreCount { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public uint ProcessorClock { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public uint TotalMemMB { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public uint GpuMemMB { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable]
		public string GraphicAdapterName { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable]
		public string Platform { get; set; } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 391539216:
					ProcessorCount = (uint) p_Value;
					break;

				case 2243702507:
					ProcessorCoreCount = (uint) p_Value;
					break;

				case 391374875:
					ProcessorClock = (uint) p_Value;
					break;

				case 4037894605:
					TotalMemMB = (uint) p_Value;
					break;

				case 4164397837:
					GpuMemMB = (uint) p_Value;
					break;

				case 631166483:
					GraphicAdapterName = (string) p_Value;
					break;

				case 942751002:
					Platform = (string) p_Value;
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
				case 391539216:
					return ProcessorCount;

				case 2243702507:
					return ProcessorCoreCount;

				case 391374875:
					return ProcessorClock;

				case 4037894605:
					return TotalMemMB;

				case 4164397837:
					return GpuMemMB;

				case 631166483:
					return GraphicAdapterName;

				case 942751002:
					return Platform;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 391539216:
					return typeof(PerformanceProfileState).GetProperty(nameof(ProcessorCount));

				case 2243702507:
					return typeof(PerformanceProfileState).GetProperty(nameof(ProcessorCoreCount));

				case 391374875:
					return typeof(PerformanceProfileState).GetProperty(nameof(ProcessorClock));

				case 4037894605:
					return typeof(PerformanceProfileState).GetProperty(nameof(TotalMemMB));

				case 4164397837:
					return typeof(PerformanceProfileState).GetProperty(nameof(GpuMemMB));

				case 631166483:
					return typeof(PerformanceProfileState).GetProperty(nameof(GraphicAdapterName));

				case 942751002:
					return typeof(PerformanceProfileState).GetProperty(nameof(Platform));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
