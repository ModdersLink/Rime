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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(20), ContainerClass]
	public class PerformanceTrackerSettings : 
		SystemSettings
	{
		protected float m_Interval = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4280103418)]
		public float Interval { get { return m_Interval; } set { if (OnPropertyChanging("PerformanceTrackerSettings." + nameof(Interval), this, m_Interval, value)) m_Interval = value; } } // 0xC (12)
		
		protected bool m_Enabled = new bool();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2662400)]
		public bool Enabled { get { return m_Enabled; } set { if (OnPropertyChanging("PerformanceTrackerSettings." + nameof(Enabled), this, m_Enabled, value)) m_Enabled = value; } } // 0x10 (16)
		
		protected bool m_SupressPerformanceStatsOnIdle = new bool();
		[ContainerField(17), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1614849048)]
		public bool SupressPerformanceStatsOnIdle { get { return m_SupressPerformanceStatsOnIdle; } set { if (OnPropertyChanging("PerformanceTrackerSettings." + nameof(SupressPerformanceStatsOnIdle), this, m_SupressPerformanceStatsOnIdle, value)) m_SupressPerformanceStatsOnIdle = value; } } // 0x11 (17)
		
		protected bool m_SupressPerformanceStatsUntilSpawned = new bool();
		[ContainerField(18), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(13225645)]
		public bool SupressPerformanceStatsUntilSpawned { get { return m_SupressPerformanceStatsUntilSpawned; } set { if (OnPropertyChanging("PerformanceTrackerSettings." + nameof(SupressPerformanceStatsUntilSpawned), this, m_SupressPerformanceStatsUntilSpawned, value)) m_SupressPerformanceStatsUntilSpawned = value; } } // 0x12 (18)
		
		protected bool m_JuiceLogPerformance = new bool();
		[ContainerField(19), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2821486313)]
		public bool JuiceLogPerformance { get { return m_JuiceLogPerformance; } set { if (OnPropertyChanging("PerformanceTrackerSettings." + nameof(JuiceLogPerformance), this, m_JuiceLogPerformance, value)) m_JuiceLogPerformance = value; } } // 0x13 (19)
		
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
