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
	[ContainerType(4, 44)]
	public class TimingConstantData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float UpdateTimePerFrame { get; set; }

		[ContainerField(16)]
		public SubsystemTimingConfigData SubsystemTimeParts { get; set; } = new();

		[ContainerField(40)]
		public List<CtrRef<BotPriorityConfigData>> PriorityClasses { get; set; } = new();

		public static void Deserialize(TimingConstantData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.UpdateTimePerFrame = p_Reader.ReadSingle();
			fb.SubsystemTimingConfigData.Deserialize(p_Instance.SubsystemTimeParts, p_Reader, p_Parser);
			p_Instance.PriorityClasses.Clear();
			(RimeReader Reader, uint Count) s_PriorityClasses = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_PriorityClasses.Count; ++i)
			{
				var s_CtrRef = new CtrRef<BotPriorityConfigData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_PriorityClasses.Reader.ReadUInt32()));
				p_Instance.PriorityClasses.Add(s_CtrRef);
			}
			
			s_PriorityClasses.Reader.Dispose();
		}

	}
}
