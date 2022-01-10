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
	[ContainerType(4, 32)]
	public class UIStateAsset : 
		Asset
	{
		[ContainerField(12)]
		public List<CtrRef<UIComponentData>> UIComponents { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<UIAsset>> ActionscriptLibraries { get; set; } = new();

		[ContainerField(20)]
		public List<string> ActionscriptNames { get; set; } = new();

		[ContainerField(24), LayoutImmutable]
		public string StateName { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable]
		public string StatePath { get; set; } = string.Empty;

		public static void Deserialize(UIStateAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.UIComponents.Clear();
			(RimeReader Reader, uint Count) s_UIComponents = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_UIComponents.Count; ++i)
			{
				var s_CtrRef = new CtrRef<UIComponentData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_UIComponents.Reader.ReadUInt32()));
				p_Instance.UIComponents.Add(s_CtrRef);
			}
			
			s_UIComponents.Reader.Dispose();
			p_Instance.ActionscriptLibraries.Clear();
			(RimeReader Reader, uint Count) s_ActionscriptLibraries = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ActionscriptLibraries.Count; ++i)
			{
				var s_CtrRef = new CtrRef<UIAsset>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_ActionscriptLibraries.Reader.ReadUInt32()));
				p_Instance.ActionscriptLibraries.Add(s_CtrRef);
			}
			
			s_ActionscriptLibraries.Reader.Dispose();
			p_Instance.ActionscriptNames.Clear();
			(RimeReader Reader, uint Count) s_ActionscriptNames = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ActionscriptNames.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_ActionscriptNames.Reader.ReadUInt32());
				p_Instance.ActionscriptNames.Add(s_Value);
			}
			
			s_ActionscriptNames.Reader.Dispose();
			p_Instance.StateName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.StatePath = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
		}

	}
}
