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
	[ContainerType(4, 40)]
	public class PathfindingDebugSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public int TypesToDrawMask { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public int TextOffsetY { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public int TextStartX { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public int TextStartY { get; set; }

		[ContainerField(24)]
		public PathfindingReplayMode ReplayMode { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable]
		public bool DrawConnections { get; set; }

		[ContainerField(29), LayoutImmutable, Blittable]
		public bool DrawObstacles { get; set; }

		[ContainerField(30), LayoutImmutable, Blittable]
		public bool DrawPolygonOutline { get; set; }

		[ContainerField(31), LayoutImmutable, Blittable]
		public bool DrawFilledPolygons { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public bool DrawMemory { get; set; }

		[ContainerField(33), LayoutImmutable, Blittable]
		public bool DrawStats { get; set; }

		[ContainerField(34), LayoutImmutable, Blittable]
		public bool DrawTimings { get; set; }

		[ContainerField(35), LayoutImmutable, Blittable]
		public bool OriginalPaths { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public bool RandomPositions { get; set; }

		[ContainerField(37), LayoutImmutable, Blittable]
		public bool PotentialObstacles { get; set; }

		public static void Deserialize(PathfindingDebugSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.TypesToDrawMask = p_Reader.ReadInt32();
			p_Instance.TextOffsetY = p_Reader.ReadInt32();
			p_Instance.TextStartX = p_Reader.ReadInt32();
			p_Instance.TextStartY = p_Reader.ReadInt32();
			p_Instance.ReplayMode = (PathfindingReplayMode) p_Reader.ReadInt32();
			p_Instance.DrawConnections = p_Reader.ReadBool();
			p_Instance.DrawObstacles = p_Reader.ReadBool();
			p_Instance.DrawPolygonOutline = p_Reader.ReadBool();
			p_Instance.DrawFilledPolygons = p_Reader.ReadBool();
			p_Instance.DrawMemory = p_Reader.ReadBool();
			p_Instance.DrawStats = p_Reader.ReadBool();
			p_Instance.DrawTimings = p_Reader.ReadBool();
			p_Instance.OriginalPaths = p_Reader.ReadBool();
			p_Instance.RandomPositions = p_Reader.ReadBool();
			p_Instance.PotentialObstacles = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
