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
	[ContainerType(4, 16)]
	public class TextUnlockPartData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string ShaderNodeName { get; set; } = string.Empty;

		[ContainerField(12)]
		public CtrRef<ObjectBlueprint> MeshBlueprint { get; set; } = new();

		public static void Deserialize(TextUnlockPartData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ShaderNodeName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.MeshBlueprint.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
