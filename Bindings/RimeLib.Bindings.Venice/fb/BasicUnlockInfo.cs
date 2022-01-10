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
	[ContainerType(4, 36)]
	public class BasicUnlockInfo
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public GUID UnlockGuid { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint Identifier { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint UnlockScore { get; set; }
		
		[ContainerField(24)]
		public List<string> Licenses { get; set; } = new();
		
		[ContainerField(28)]
		public List<string> AdditionalLicenses { get; set; } = new();
		
		[ContainerField(32), LayoutImmutable]
		public string StringId { get; set; } = string.Empty;
		
		public static void Deserialize(BasicUnlockInfo p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.UnlockGuid = new GUID(p_Reader);
			p_Instance.Identifier = p_Reader.ReadUInt32();
			p_Instance.UnlockScore = p_Reader.ReadUInt32();
			p_Instance.Licenses.Clear();
			(RimeReader Reader, uint Count) s_Licenses = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Licenses.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_Licenses.Reader.ReadUInt32());
				p_Instance.Licenses.Add(s_Value);
			}
			
			s_Licenses.Reader.Dispose();
			p_Instance.AdditionalLicenses.Clear();
			(RimeReader Reader, uint Count) s_AdditionalLicenses = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_AdditionalLicenses.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_AdditionalLicenses.Reader.ReadUInt32());
				p_Instance.AdditionalLicenses.Add(s_Value);
			}
			
			s_AdditionalLicenses.Reader.Dispose();
			p_Instance.StringId = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
		}
	}
}
