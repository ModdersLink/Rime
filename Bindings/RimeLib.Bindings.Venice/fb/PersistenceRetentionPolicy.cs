///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 24)]
	public class PersistenceRetentionPolicy : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public int DailyHistoryCount { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public int WeeklyHistoryCount { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public int MonthlyHistoryCount { get; set; }

		public static void Deserialize(PersistenceRetentionPolicy p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DailyHistoryCount = p_Reader.ReadInt32();
			p_Instance.WeeklyHistoryCount = p_Reader.ReadInt32();
			p_Instance.MonthlyHistoryCount = p_Reader.ReadInt32();
		}

	}
}
