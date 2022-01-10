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
	public class PlayFromHereAsset : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<Blueprint> Soldier { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<AnimatedSkeletonDatabase> AnimatedSkeletonDatabase { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<AntProjectAsset> AntProject { get; set; } = new();

		public static void Deserialize(PlayFromHereAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Soldier.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.AnimatedSkeletonDatabase.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.AntProject.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
