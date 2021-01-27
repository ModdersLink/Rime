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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class PersistenceRetentionPolicy : 
		Asset
	{
		protected int m_DailyHistoryCount = new int();
		[ContainerField(Name: "DailyHistoryCount", Offset: 12, NameHash: 2827768221, Flags: 49405), LayoutImmutable, Blittable]
		public int DailyHistoryCount { get { return m_DailyHistoryCount; } set { if (OnPropertyChanging("PersistenceRetentionPolicy." + nameof(DailyHistoryCount), this, m_DailyHistoryCount, value)) m_DailyHistoryCount = value; } } // 0xC (12)
		
		protected int m_WeeklyHistoryCount = new int();
		[ContainerField(Name: "WeeklyHistoryCount", Offset: 16, NameHash: 808067565, Flags: 49405), LayoutImmutable, Blittable]
		public int WeeklyHistoryCount { get { return m_WeeklyHistoryCount; } set { if (OnPropertyChanging("PersistenceRetentionPolicy." + nameof(WeeklyHistoryCount), this, m_WeeklyHistoryCount, value)) m_WeeklyHistoryCount = value; } } // 0x10 (16)
		
		protected int m_MonthlyHistoryCount = new int();
		[ContainerField(Name: "MonthlyHistoryCount", Offset: 20, NameHash: 345590273, Flags: 49405), LayoutImmutable, Blittable]
		public int MonthlyHistoryCount { get { return m_MonthlyHistoryCount; } set { if (OnPropertyChanging("PersistenceRetentionPolicy." + nameof(MonthlyHistoryCount), this, m_MonthlyHistoryCount, value)) m_MonthlyHistoryCount = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2827768221:
					DailyHistoryCount = (int) p_Value;
					break;

				case 808067565:
					WeeklyHistoryCount = (int) p_Value;
					break;

				case 345590273:
					MonthlyHistoryCount = (int) p_Value;
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
				case 2827768221:
					return DailyHistoryCount;

				case 808067565:
					return WeeklyHistoryCount;

				case 345590273:
					return MonthlyHistoryCount;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2827768221:
					return typeof(PersistenceRetentionPolicy).GetProperty(nameof(DailyHistoryCount));

				case 808067565:
					return typeof(PersistenceRetentionPolicy).GetProperty(nameof(WeeklyHistoryCount));

				case 345590273:
					return typeof(PersistenceRetentionPolicy).GetProperty(nameof(MonthlyHistoryCount));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
