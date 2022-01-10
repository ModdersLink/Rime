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
	public class VoiceOverLogicFlow : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } = string.Empty;

		[ContainerField(12)]
		public CtrRef<VoiceOverGroup> Group { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<VoiceOverValue>> Locals { get; set; } = new();

		[ContainerField(20)]
		public List<CtrRef<VoiceOverEventNode>> Roots { get; set; } = new();

		public static void Deserialize(VoiceOverLogicFlow p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Name = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Group.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Locals.Clear();
			(RimeReader Reader, uint Count) s_Locals = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Locals.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverValue>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Locals.Reader.ReadUInt32()));
				p_Instance.Locals.Add(s_CtrRef);
			}
			
			s_Locals.Reader.Dispose();
			p_Instance.Roots.Clear();
			(RimeReader Reader, uint Count) s_Roots = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Roots.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverEventNode>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Roots.Reader.ReadUInt32()));
				p_Instance.Roots.Add(s_CtrRef);
			}
			
			s_Roots.Reader.Dispose();
		}

	}
}
