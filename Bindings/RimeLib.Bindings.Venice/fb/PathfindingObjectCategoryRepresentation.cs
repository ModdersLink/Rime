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
	[ContainerType(4, 8)]
	public class PathfindingObjectCategoryRepresentation
	{
		[ContainerField(0)]
		public CtrRef<PathfindingObjectCategoryAsset> Category { get; set; } = new();
		
		[ContainerField(4)]
		public PathfindingRepresentation Representation { get; set; } = new();
		
		public static void Deserialize(PathfindingObjectCategoryRepresentation p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Category.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Representation = (PathfindingRepresentation) p_Reader.ReadInt32();
		}
	}
}
