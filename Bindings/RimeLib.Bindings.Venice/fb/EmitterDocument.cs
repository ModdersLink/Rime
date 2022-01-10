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
	public class EmitterDocument : 
		EmitterAsset
	{
		[ContainerField(12)]
		public CtrRef<ProcessorData> RootProcessor { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<EmitterTemplateData> TemplateData { get; set; } = new();

		public static void Deserialize(EmitterDocument p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.RootProcessor.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.TemplateData.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
