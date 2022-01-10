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
	public class Ps3ParentalLockAgeSettingsForCountry
	{
		[ContainerField(0), LayoutImmutable]
		public string CountryCode { get; set; } = string.Empty;
		
		[ContainerField(4)]
		public Ps3AgeLevels AgeLevels { get; set; } = new();
		
		public static void Deserialize(Ps3ParentalLockAgeSettingsForCountry p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.CountryCode = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			fb.Ps3AgeLevels.Deserialize(p_Instance.AgeLevels, p_Reader, p_Parser);
		}
	}
}
