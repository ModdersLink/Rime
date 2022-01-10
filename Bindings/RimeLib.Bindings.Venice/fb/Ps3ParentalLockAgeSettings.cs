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
	[ContainerType(4, 24)]
	public class Ps3ParentalLockAgeSettings
	{
		[ContainerField(0), LayoutImmutable]
		public string Region { get; set; } = string.Empty;
		
		[ContainerField(4)]
		public Ps3AgeLevels AgeLevels { get; set; } = new();
		
		[ContainerField(20)]
		public CtrRef<Ps3ParentalLockAgeSettingsOverrides> CountryOverrides { get; set; } = new();
		
		public static void Deserialize(Ps3ParentalLockAgeSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Region = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			fb.Ps3AgeLevels.Deserialize(p_Instance.AgeLevels, p_Reader, p_Parser);
			p_Instance.CountryOverrides.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}
	}
}
