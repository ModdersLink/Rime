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
	public class UIDistanceFieldAsset : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<TextureAsset> DistanceFieldTexture { get; set; } = new();

		public static void Deserialize(UIDistanceFieldAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DistanceFieldTexture.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
