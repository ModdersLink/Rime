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
	public class PackagingCellData : 
		EntityData
	{
		[ContainerField(12)]
		public List<CtrRef<PackagingRule>> Rules { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<PackagingCellData>> Targets { get; set; } = new();

		[ContainerField(20)]
		public List<Vec2> Shape { get; set; } = new();

		public static void Deserialize(PackagingCellData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Rules.Clear();
			(RimeReader Reader, uint Count) s_Rules = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Rules.Count; ++i)
			{
				var s_CtrRef = new CtrRef<PackagingRule>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Rules.Reader.ReadUInt32()));
				p_Instance.Rules.Add(s_CtrRef);
			}
			
			s_Rules.Reader.Dispose();
			p_Instance.Targets.Clear();
			(RimeReader Reader, uint Count) s_Targets = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Targets.Count; ++i)
			{
				var s_CtrRef = new CtrRef<PackagingCellData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Targets.Reader.ReadUInt32()));
				p_Instance.Targets.Add(s_CtrRef);
			}
			
			s_Targets.Reader.Dispose();
			p_Instance.Shape.Clear();
			(RimeReader Reader, uint Count) s_Shape = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Shape.Count; ++i)
			{
				var s_Value = new Vec2();
				fb.Vec2.Deserialize(s_Value, s_Shape.Reader, p_Parser);
				p_Instance.Shape.Add(s_Value);
			}
			
			s_Shape.Reader.Dispose();
		}

	}
}
