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
	[ContainerType(4, 56)]
	public class WorldPartData : 
		SpatialPrefabBlueprint
	{
		[ContainerField(36), LayoutImmutable, Blittable]
		public GUID HackToSolveRealTimeTweakingIssue { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public bool UseDeferredEntityCreation { get; set; }

		[ContainerField(53), LayoutImmutable, Blittable]
		public bool Enabled { get; set; }

		public static void Deserialize(WorldPartData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.HackToSolveRealTimeTweakingIssue = new GUID(p_Reader);
			p_Instance.UseDeferredEntityCreation = p_Reader.ReadBool();
			p_Instance.Enabled = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
