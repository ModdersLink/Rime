///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 40)]
	public class PathfindingDebugSettings :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public int TypesToDrawMask { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public int TextOffsetY { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public int TextStartX { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public int TextStartY { get; set; }

		[ContainerField(24), JsonProperty(Order = 24)]
		public PathfindingReplayMode ReplayMode { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public bool DrawConnections { get; set; }

		[ContainerField(29), LayoutImmutable, Blittable, JsonProperty(Order = 29)]
		public bool DrawObstacles { get; set; }

		[ContainerField(30), LayoutImmutable, Blittable, JsonProperty(Order = 30)]
		public bool DrawPolygonOutline { get; set; }

		[ContainerField(31), LayoutImmutable, Blittable, JsonProperty(Order = 31)]
		public bool DrawFilledPolygons { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public bool DrawMemory { get; set; }

		[ContainerField(33), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
		public bool DrawStats { get; set; }

		[ContainerField(34), LayoutImmutable, Blittable, JsonProperty(Order = 34)]
		public bool DrawTimings { get; set; }

		[ContainerField(35), LayoutImmutable, Blittable, JsonProperty(Order = 35)]
		public bool OriginalPaths { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public bool RandomPositions { get; set; }

		[ContainerField(37), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
		public bool PotentialObstacles { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(TypesToDrawMask);
			p_Writer.Write(TextOffsetY);
			p_Writer.Write(TextStartX);
			p_Writer.Write(TextStartY);
			p_Writer.Write((int) ReplayMode);
			p_Writer.Write(DrawConnections);
			p_Writer.Write(DrawObstacles);
			p_Writer.Write(DrawPolygonOutline);
			p_Writer.Write(DrawFilledPolygons);
			p_Writer.Write(DrawMemory);
			p_Writer.Write(DrawStats);
			p_Writer.Write(DrawTimings);
			p_Writer.Write(OriginalPaths);
			p_Writer.Write(RandomPositions);
			p_Writer.Write(PotentialObstacles);
			p_Writer.WriteNullBytes(2);
		}
	}
}
