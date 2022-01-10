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
	public class LevelControlEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable]
		public string LevelToLoad { get; set; } = string.Empty;

		[ContainerField(100), LayoutImmutable, Blittable]
		public bool RollCredits { get; set; }

		public static void Deserialize(LevelControlEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.LevelToLoad = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.RollCredits = p_Reader.ReadBool();
			p_Reader.Seek(11, SeekOrigin.Current);
		}

	}
}
