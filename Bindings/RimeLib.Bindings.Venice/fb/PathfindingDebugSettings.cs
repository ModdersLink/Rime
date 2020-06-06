///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class PathfindingDebugSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public int TypesToDrawMask { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public int TextOffsetY { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public int TextStartX { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public int TextStartY { get; set; } // 0x14 (20)
		
		[ContainerField(24)]
		public PathfindingReplayMode ReplayMode { get; set; } = new PathfindingReplayMode(); // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public bool DrawConnections { get; set; } // 0x1C (28)
		
		[ContainerField(29), LayoutImmutable, Blittable]
		public bool DrawObstacles { get; set; } // 0x1D (29)
		
		[ContainerField(30), LayoutImmutable, Blittable]
		public bool DrawPolygonOutline { get; set; } // 0x1E (30)
		
		[ContainerField(31), LayoutImmutable, Blittable]
		public bool DrawFilledPolygons { get; set; } // 0x1F (31)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public bool DrawMemory { get; set; } // 0x20 (32)
		
		[ContainerField(33), LayoutImmutable, Blittable]
		public bool DrawStats { get; set; } // 0x21 (33)
		
		[ContainerField(34), LayoutImmutable, Blittable]
		public bool DrawTimings { get; set; } // 0x22 (34)
		
		[ContainerField(35), LayoutImmutable, Blittable]
		public bool OriginalPaths { get; set; } // 0x23 (35)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public bool RandomPositions { get; set; } // 0x24 (36)
		
		[ContainerField(37), LayoutImmutable, Blittable]
		public bool PotentialObstacles { get; set; } // 0x25 (37)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2964791457:
					TypesToDrawMask = (int) p_Value;
					break;

				case 3116283628:
					TextOffsetY = (int) p_Value;
					break;

				case 1212530848:
					TextStartX = (int) p_Value;
					break;

				case 1212530849:
					TextStartY = (int) p_Value;
					break;

				case 1723041685:
					ReplayMode = (PathfindingReplayMode) Enum.ToObject(typeof(PathfindingReplayMode), p_Value);
					break;

				case 2313499072:
					DrawConnections = (bool) p_Value;
					break;

				case 3626078967:
					DrawObstacles = (bool) p_Value;
					break;

				case 4098331465:
					DrawPolygonOutline = (bool) p_Value;
					break;

				case 297524372:
					DrawFilledPolygons = (bool) p_Value;
					break;

				case 1651442660:
					DrawMemory = (bool) p_Value;
					break;

				case 2413142628:
					DrawStats = (bool) p_Value;
					break;

				case 560544582:
					DrawTimings = (bool) p_Value;
					break;

				case 3948559810:
					OriginalPaths = (bool) p_Value;
					break;

				case 4000636404:
					RandomPositions = (bool) p_Value;
					break;

				case 1779192423:
					PotentialObstacles = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2964791457:
					return TypesToDrawMask;

				case 3116283628:
					return TextOffsetY;

				case 1212530848:
					return TextStartX;

				case 1212530849:
					return TextStartY;

				case 1723041685:
					return ReplayMode;

				case 2313499072:
					return DrawConnections;

				case 3626078967:
					return DrawObstacles;

				case 4098331465:
					return DrawPolygonOutline;

				case 297524372:
					return DrawFilledPolygons;

				case 1651442660:
					return DrawMemory;

				case 2413142628:
					return DrawStats;

				case 560544582:
					return DrawTimings;

				case 3948559810:
					return OriginalPaths;

				case 4000636404:
					return RandomPositions;

				case 1779192423:
					return PotentialObstacles;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2964791457:
					return typeof(PathfindingDebugSettings).GetProperty(nameof(TypesToDrawMask));

				case 3116283628:
					return typeof(PathfindingDebugSettings).GetProperty(nameof(TextOffsetY));

				case 1212530848:
					return typeof(PathfindingDebugSettings).GetProperty(nameof(TextStartX));

				case 1212530849:
					return typeof(PathfindingDebugSettings).GetProperty(nameof(TextStartY));

				case 1723041685:
					return typeof(PathfindingDebugSettings).GetProperty(nameof(ReplayMode));

				case 2313499072:
					return typeof(PathfindingDebugSettings).GetProperty(nameof(DrawConnections));

				case 3626078967:
					return typeof(PathfindingDebugSettings).GetProperty(nameof(DrawObstacles));

				case 4098331465:
					return typeof(PathfindingDebugSettings).GetProperty(nameof(DrawPolygonOutline));

				case 297524372:
					return typeof(PathfindingDebugSettings).GetProperty(nameof(DrawFilledPolygons));

				case 1651442660:
					return typeof(PathfindingDebugSettings).GetProperty(nameof(DrawMemory));

				case 2413142628:
					return typeof(PathfindingDebugSettings).GetProperty(nameof(DrawStats));

				case 560544582:
					return typeof(PathfindingDebugSettings).GetProperty(nameof(DrawTimings));

				case 3948559810:
					return typeof(PathfindingDebugSettings).GetProperty(nameof(OriginalPaths));

				case 4000636404:
					return typeof(PathfindingDebugSettings).GetProperty(nameof(RandomPositions));

				case 1779192423:
					return typeof(PathfindingDebugSettings).GetProperty(nameof(PotentialObstacles));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
