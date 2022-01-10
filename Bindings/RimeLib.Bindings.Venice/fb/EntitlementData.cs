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
	public class EntitlementData
	{
		[ContainerField(0), LayoutImmutable]
		public string License { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable]
		public string EntitlementTag { get; set; } = string.Empty;
		
		[ContainerField(8), LayoutImmutable]
		public string GroupName { get; set; } = string.Empty;
		
		[ContainerField(12), LayoutImmutable]
		public string ProductId { get; set; } = string.Empty;
		
		[ContainerField(16), LayoutImmutable]
		public string ProjectId { get; set; } = string.Empty;
		
		[ContainerField(20)]
		public EntitlementType UsageType { get; set; } = new();
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public bool VerifyOwnership { get; set; }
		
		public static void Deserialize(EntitlementData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.License = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.EntitlementTag = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.GroupName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ProductId = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ProjectId = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.UsageType = (EntitlementType) p_Reader.ReadInt32();
			p_Instance.VerifyOwnership = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
