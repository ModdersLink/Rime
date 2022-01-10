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
	[ContainerType(16, 80)]
	public class ColorTintScopeFilterData : 
		ScopeFilterData
	{
		[ContainerField(16)]
		public ColorTintData ColorTintData { get; set; } = new();

		public static void Deserialize(ColorTintScopeFilterData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.ColorTintData.Deserialize(p_Instance.ColorTintData, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
