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
	public class Ps3ParentalLockAgeSettingsOverrides : 
		DataContainer
	{
		[ContainerField(8)]
		public List<Ps3ParentalLockAgeSettingsForCountry> Overrides { get; set; } = new();

		public static void Deserialize(Ps3ParentalLockAgeSettingsOverrides p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Overrides.Clear();
			(RimeReader Reader, uint Count) s_Overrides = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Overrides.Count; ++i)
			{
				var s_Value = new Ps3ParentalLockAgeSettingsForCountry();
				fb.Ps3ParentalLockAgeSettingsForCountry.Deserialize(s_Value, s_Overrides.Reader, p_Parser);
				p_Instance.Overrides.Add(s_Value);
			}
			
			s_Overrides.Reader.Dispose();
		}

	}
}
