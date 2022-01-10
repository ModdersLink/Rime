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
	public class StaticEnlightenEntityData : 
		EnlightenEntityData
	{
		[ContainerField(24)]
		public CtrRef<StaticEnlightenData> EnlightenData { get; set; } = new();

		[ContainerField(28)]
		public CtrRef<EnlightenDataAsset> DynamicEnlightenData { get; set; } = new();

		public static void Deserialize(StaticEnlightenEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.EnlightenData.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.DynamicEnlightenData.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
