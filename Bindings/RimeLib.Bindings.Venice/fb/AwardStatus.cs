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
	[ContainerType(4, 20)]
	public class AwardStatus
	{
		[ContainerField(0), LayoutImmutable]
		public string Code { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public uint CurrentValue { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint OriginalValue { get; set; }
		
		[ContainerField(12)]
		public List<CounterStatus> Counters { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool IsCounting { get; set; }
		
		public static void Deserialize(AwardStatus p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Code = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.CurrentValue = p_Reader.ReadUInt32();
			p_Instance.OriginalValue = p_Reader.ReadUInt32();
			p_Instance.Counters.Clear();
			(RimeReader Reader, uint Count) s_Counters = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Counters.Count; ++i)
			{
				var s_Value = new CounterStatus();
				fb.CounterStatus.Deserialize(s_Value, s_Counters.Reader, p_Parser);
				p_Instance.Counters.Add(s_Value);
			}
			
			s_Counters.Reader.Dispose();
			p_Instance.IsCounting = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
