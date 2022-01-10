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
	[ContainerType(4, 28)]
	public class TimingViewCategory : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string CategoryName { get; set; } = string.Empty;

		[ContainerField(12)]
		public List<string> Keywords { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public float SpuBudget { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float CpuBudget { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float GpuBudget { get; set; }

		public static void Deserialize(TimingViewCategory p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.CategoryName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Keywords.Clear();
			(RimeReader Reader, uint Count) s_Keywords = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Keywords.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_Keywords.Reader.ReadUInt32());
				p_Instance.Keywords.Add(s_Value);
			}
			
			s_Keywords.Reader.Dispose();
			p_Instance.SpuBudget = p_Reader.ReadSingle();
			p_Instance.CpuBudget = p_Reader.ReadSingle();
			p_Instance.GpuBudget = p_Reader.ReadSingle();
		}

	}
}
