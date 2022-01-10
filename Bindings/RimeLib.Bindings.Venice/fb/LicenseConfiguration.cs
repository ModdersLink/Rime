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
	public class LicenseConfiguration : 
		Asset
	{
		[ContainerField(12)]
		public List<LicenseInfo> Licenses { get; set; } = new();

		public static void Deserialize(LicenseConfiguration p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Licenses.Clear();
			(RimeReader Reader, uint Count) s_Licenses = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Licenses.Count; ++i)
			{
				var s_Value = new LicenseInfo();
				fb.LicenseInfo.Deserialize(s_Value, s_Licenses.Reader, p_Parser);
				p_Instance.Licenses.Add(s_Value);
			}
			
			s_Licenses.Reader.Dispose();
		}

	}
}
