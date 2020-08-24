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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class PersistenceRetentionPolicy : 
		Asset
	{
		protected int m_DailyHistoryCount = new int();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2827768221)]
		public int DailyHistoryCount { get { return m_DailyHistoryCount; } set { if (OnPropertyChanging("PersistenceRetentionPolicy." + nameof(DailyHistoryCount), this, m_DailyHistoryCount, value)) m_DailyHistoryCount = value; } } // 0xC (12)
		
		protected int m_WeeklyHistoryCount = new int();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(808067565)]
		public int WeeklyHistoryCount { get { return m_WeeklyHistoryCount; } set { if (OnPropertyChanging("PersistenceRetentionPolicy." + nameof(WeeklyHistoryCount), this, m_WeeklyHistoryCount, value)) m_WeeklyHistoryCount = value; } } // 0x10 (16)
		
		protected int m_MonthlyHistoryCount = new int();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(345590273)]
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
