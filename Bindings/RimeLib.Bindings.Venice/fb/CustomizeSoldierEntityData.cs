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
	public class CustomizeSoldierEntityData : 
		CustomizeBaseEntityData
	{
		[ContainerField(16)]
		public CtrRef<CustomizeSoldierData> CustomizeSoldierData { get; set; } = new();

		public static void Deserialize(CustomizeSoldierEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.CustomizeSoldierData.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
