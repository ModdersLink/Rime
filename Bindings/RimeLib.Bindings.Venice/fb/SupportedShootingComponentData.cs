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
	[ContainerType(16, 112)]
	public class SupportedShootingComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public CtrRef<SupportedShootingCommonData> CommonData { get; set; } = new();

		public static void Deserialize(SupportedShootingComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.CommonData.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(12, SeekOrigin.Current);
		}

	}
}
