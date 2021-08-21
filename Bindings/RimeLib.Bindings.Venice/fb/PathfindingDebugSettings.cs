///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 40)]
	public class PathfindingDebugSettings : 
		DataContainer
	{
		protected int m_TypesToDrawMask = new int();
		[ContainerField(Name: "TypesToDrawMask", Offset: 8, NameHash: 2964791457, Flags: 49405), LayoutImmutable, Blittable]
		public int TypesToDrawMask { get { return m_TypesToDrawMask; } set { if (OnPropertyChanging("PathfindingDebugSettings." + nameof(TypesToDrawMask), this, m_TypesToDrawMask, value)) m_TypesToDrawMask = value; } } // 0x8 (8)
		
		protected int m_TextOffsetY = new int();
		[ContainerField(Name: "TextOffsetY", Offset: 12, NameHash: 3116283628, Flags: 49405), LayoutImmutable, Blittable]
		public int TextOffsetY { get { return m_TextOffsetY; } set { if (OnPropertyChanging("PathfindingDebugSettings." + nameof(TextOffsetY), this, m_TextOffsetY, value)) m_TextOffsetY = value; } } // 0xC (12)
		
		protected int m_TextStartX = new int();
		[ContainerField(Name: "TextStartX", Offset: 16, NameHash: 1212530848, Flags: 49405), LayoutImmutable, Blittable]
		public int TextStartX { get { return m_TextStartX; } set { if (OnPropertyChanging("PathfindingDebugSettings." + nameof(TextStartX), this, m_TextStartX, value)) m_TextStartX = value; } } // 0x10 (16)
		
		protected int m_TextStartY = new int();
		[ContainerField(Name: "TextStartY", Offset: 20, NameHash: 1212530849, Flags: 49405), LayoutImmutable, Blittable]
		public int TextStartY { get { return m_TextStartY; } set { if (OnPropertyChanging("PathfindingDebugSettings." + nameof(TextStartY), this, m_TextStartY, value)) m_TextStartY = value; } } // 0x14 (20)
		
		protected PathfindingReplayMode m_ReplayMode = new PathfindingReplayMode();
		[ContainerField(Name: "ReplayMode", Offset: 24, NameHash: 1723041685, Flags: 137)]
		public PathfindingReplayMode ReplayMode { get { return m_ReplayMode; } set { if (OnPropertyChanging("PathfindingDebugSettings." + nameof(ReplayMode), this, m_ReplayMode, value)) m_ReplayMode = value; } } // 0x18 (24)
		
		protected bool m_DrawConnections = new bool();
		[ContainerField(Name: "DrawConnections", Offset: 28, NameHash: 2313499072, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawConnections { get { return m_DrawConnections; } set { if (OnPropertyChanging("PathfindingDebugSettings." + nameof(DrawConnections), this, m_DrawConnections, value)) m_DrawConnections = value; } } // 0x1C (28)
		
		protected bool m_DrawObstacles = new bool();
		[ContainerField(Name: "DrawObstacles", Offset: 29, NameHash: 3626078967, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawObstacles { get { return m_DrawObstacles; } set { if (OnPropertyChanging("PathfindingDebugSettings." + nameof(DrawObstacles), this, m_DrawObstacles, value)) m_DrawObstacles = value; } } // 0x1D (29)
		
		protected bool m_DrawPolygonOutline = new bool();
		[ContainerField(Name: "DrawPolygonOutline", Offset: 30, NameHash: 4098331465, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawPolygonOutline { get { return m_DrawPolygonOutline; } set { if (OnPropertyChanging("PathfindingDebugSettings." + nameof(DrawPolygonOutline), this, m_DrawPolygonOutline, value)) m_DrawPolygonOutline = value; } } // 0x1E (30)
		
		protected bool m_DrawFilledPolygons = new bool();
		[ContainerField(Name: "DrawFilledPolygons", Offset: 31, NameHash: 297524372, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawFilledPolygons { get { return m_DrawFilledPolygons; } set { if (OnPropertyChanging("PathfindingDebugSettings." + nameof(DrawFilledPolygons), this, m_DrawFilledPolygons, value)) m_DrawFilledPolygons = value; } } // 0x1F (31)
		
		protected bool m_DrawMemory = new bool();
		[ContainerField(Name: "DrawMemory", Offset: 32, NameHash: 1651442660, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawMemory { get { return m_DrawMemory; } set { if (OnPropertyChanging("PathfindingDebugSettings." + nameof(DrawMemory), this, m_DrawMemory, value)) m_DrawMemory = value; } } // 0x20 (32)
		
		protected bool m_DrawStats = new bool();
		[ContainerField(Name: "DrawStats", Offset: 33, NameHash: 2413142628, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawStats { get { return m_DrawStats; } set { if (OnPropertyChanging("PathfindingDebugSettings." + nameof(DrawStats), this, m_DrawStats, value)) m_DrawStats = value; } } // 0x21 (33)
		
		protected bool m_DrawTimings = new bool();
		[ContainerField(Name: "DrawTimings", Offset: 34, NameHash: 560544582, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawTimings { get { return m_DrawTimings; } set { if (OnPropertyChanging("PathfindingDebugSettings." + nameof(DrawTimings), this, m_DrawTimings, value)) m_DrawTimings = value; } } // 0x22 (34)
		
		protected bool m_OriginalPaths = new bool();
		[ContainerField(Name: "OriginalPaths", Offset: 35, NameHash: 3948559810, Flags: 49325), LayoutImmutable, Blittable]
		public bool OriginalPaths { get { return m_OriginalPaths; } set { if (OnPropertyChanging("PathfindingDebugSettings." + nameof(OriginalPaths), this, m_OriginalPaths, value)) m_OriginalPaths = value; } } // 0x23 (35)
		
		protected bool m_RandomPositions = new bool();
		[ContainerField(Name: "RandomPositions", Offset: 36, NameHash: 4000636404, Flags: 49325), LayoutImmutable, Blittable]
		public bool RandomPositions { get { return m_RandomPositions; } set { if (OnPropertyChanging("PathfindingDebugSettings." + nameof(RandomPositions), this, m_RandomPositions, value)) m_RandomPositions = value; } } // 0x24 (36)
		
		protected bool m_PotentialObstacles = new bool();
		[ContainerField(Name: "PotentialObstacles", Offset: 37, NameHash: 1779192423, Flags: 49325), LayoutImmutable, Blittable]
		public bool PotentialObstacles { get { return m_PotentialObstacles; } set { if (OnPropertyChanging("PathfindingDebugSettings." + nameof(PotentialObstacles), this, m_PotentialObstacles, value)) m_PotentialObstacles = value; } } // 0x25 (37)
		
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
