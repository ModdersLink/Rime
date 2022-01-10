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
	[ContainerType(4, 36)]
	public class ObjectBlueprint : 
		Blueprint
	{
		[ContainerField(32)]
		public CtrRef<GameObjectData> Object { get; set; } = new();

		public static void Deserialize(ObjectBlueprint p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Object.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
