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
	public class PersistenceRetentionPolicy : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public int DailyHistoryCount { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public int WeeklyHistoryCount { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public int MonthlyHistoryCount { get; set; } // 0x14 (20)
		
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
