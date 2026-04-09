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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 40)]
	public partial class PathfindingDebugSettings :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private int _TypesToDrawMask;

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private int _TextOffsetY;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private int _TextStartX;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private int _TextStartY;

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private PathfindingReplayMode _ReplayMode = new();

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private bool _DrawConnections;

		[ObservableProperty]
		[property: ContainerField(29), LayoutImmutable, Blittable, JsonProperty(Order = 29)]
		private bool _DrawObstacles;

		[ObservableProperty]
		[property: ContainerField(30), LayoutImmutable, Blittable, JsonProperty(Order = 30)]
		private bool _DrawPolygonOutline;

		[ObservableProperty]
		[property: ContainerField(31), LayoutImmutable, Blittable, JsonProperty(Order = 31)]
		private bool _DrawFilledPolygons;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private bool _DrawMemory;

		[ObservableProperty]
		[property: ContainerField(33), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
		private bool _DrawStats;

		[ObservableProperty]
		[property: ContainerField(34), LayoutImmutable, Blittable, JsonProperty(Order = 34)]
		private bool _DrawTimings;

		[ObservableProperty]
		[property: ContainerField(35), LayoutImmutable, Blittable, JsonProperty(Order = 35)]
		private bool _OriginalPaths;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private bool _RandomPositions;

		[ObservableProperty]
		[property: ContainerField(37), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
		private bool _PotentialObstacles;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
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
