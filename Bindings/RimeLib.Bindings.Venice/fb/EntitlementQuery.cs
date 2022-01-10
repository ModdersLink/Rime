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
	public class EntitlementQuery : 
		Asset
	{
		[ContainerField(12)]
		public List<EntitlementData> EntitlementsData { get; set; } = new();

		[ContainerField(16)]
		public List<string> GroupNames { get; set; } = new();

		[ContainerField(20)]
		public GamePlatform Platform { get; set; } = new();

		[ContainerField(24), LayoutImmutable]
		public string EntitlementTag { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable]
		public string ProductId { get; set; } = string.Empty;

		[ContainerField(32), LayoutImmutable]
		public string ProjectId { get; set; } = string.Empty;

		public static void Deserialize(EntitlementQuery p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.EntitlementsData.Clear();
			(RimeReader Reader, uint Count) s_EntitlementsData = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_EntitlementsData.Count; ++i)
			{
				var s_Value = new EntitlementData();
				fb.EntitlementData.Deserialize(s_Value, s_EntitlementsData.Reader, p_Parser);
				p_Instance.EntitlementsData.Add(s_Value);
			}
			
			s_EntitlementsData.Reader.Dispose();
			p_Instance.GroupNames.Clear();
			(RimeReader Reader, uint Count) s_GroupNames = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_GroupNames.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_GroupNames.Reader.ReadUInt32());
				p_Instance.GroupNames.Add(s_Value);
			}
			
			s_GroupNames.Reader.Dispose();
			p_Instance.Platform = (GamePlatform) p_Reader.ReadInt32();
			p_Instance.EntitlementTag = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ProductId = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ProjectId = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
		}

	}
}
