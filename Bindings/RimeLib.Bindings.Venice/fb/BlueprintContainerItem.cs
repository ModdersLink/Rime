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
	[ContainerType(4, 12)]
	public class BlueprintContainerItem : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<BlueprintBundleMetadata> Metadata { get; set; } = new();

		public static void Deserialize(BlueprintContainerItem p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Metadata.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
