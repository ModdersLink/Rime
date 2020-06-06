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
	public class PerformanceTrackerSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float Interval { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool Enabled { get; set; } // 0x10 (16)
		
		[ContainerField(17), LayoutImmutable, Blittable]
		public bool SupressPerformanceStatsOnIdle { get; set; } // 0x11 (17)
		
		[ContainerField(18), LayoutImmutable, Blittable]
		public bool SupressPerformanceStatsUntilSpawned { get; set; } // 0x12 (18)
		
		[ContainerField(19), LayoutImmutable, Blittable]
		public bool JuiceLogPerformance { get; set; } // 0x13 (19)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4280103418:
					Interval = (float) p_Value;
					break;

				case 2662400:
					Enabled = (bool) p_Value;
					break;

				case 1614849048:
					SupressPerformanceStatsOnIdle = (bool) p_Value;
					break;

				case 13225645:
					SupressPerformanceStatsUntilSpawned = (bool) p_Value;
					break;

				case 2821486313:
					JuiceLogPerformance = (bool) p_Value;
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
				case 4280103418:
					return Interval;

				case 2662400:
					return Enabled;

				case 1614849048:
					return SupressPerformanceStatsOnIdle;

				case 13225645:
					return SupressPerformanceStatsUntilSpawned;

				case 2821486313:
					return JuiceLogPerformance;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4280103418:
					return typeof(PerformanceTrackerSettings).GetProperty(nameof(Interval));

				case 2662400:
					return typeof(PerformanceTrackerSettings).GetProperty(nameof(Enabled));

				case 1614849048:
					return typeof(PerformanceTrackerSettings).GetProperty(nameof(SupressPerformanceStatsOnIdle));

				case 13225645:
					return typeof(PerformanceTrackerSettings).GetProperty(nameof(SupressPerformanceStatsUntilSpawned));

				case 2821486313:
					return typeof(PerformanceTrackerSettings).GetProperty(nameof(JuiceLogPerformance));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
