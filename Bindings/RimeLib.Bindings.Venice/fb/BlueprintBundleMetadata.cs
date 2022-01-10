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
	public class BlueprintBundleMetadata : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string BundlePathName { get; set; } = string.Empty;

		[ContainerField(12), LayoutImmutable]
		public string BundleName { get; set; } = string.Empty;

		[ContainerField(16), LayoutImmutable]
		public string BlueprintName { get; set; } = string.Empty;

		public static void Deserialize(BlueprintBundleMetadata p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.BundlePathName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.BundleName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.BlueprintName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
		}

	}
}
