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
	public class UnlockValuePair : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Id { get; set; } = string.Empty;

		public static void Deserialize(UnlockValuePair p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Id = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
		}

	}
}
