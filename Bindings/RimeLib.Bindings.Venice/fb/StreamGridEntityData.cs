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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class StreamGridEntityData : 
		SpatialEntityData
	{
		protected float m_CellSize = new float();
		[ContainerField(Name: "CellSize", Offset: 80, NameHash: 2566448966, Flags: 49469), LayoutImmutable, Blittable]
		public float CellSize { get { return m_CellSize; } set { if (OnPropertyChanging("StreamGridEntityData." + nameof(CellSize), this, m_CellSize, value)) m_CellSize = value; } } // 0x50 (80)
		
		protected float m_ViewDistance = new float();
		[ContainerField(Name: "ViewDistance", Offset: 84, NameHash: 2201945291, Flags: 49469), LayoutImmutable, Blittable]
		public float ViewDistance { get { return m_ViewDistance; } set { if (OnPropertyChanging("StreamGridEntityData." + nameof(ViewDistance), this, m_ViewDistance, value)) m_ViewDistance = value; } } // 0x54 (84)
		
		protected int m_MaxStreamInCountPerFrame = new int();
		[ContainerField(Name: "MaxStreamInCountPerFrame", Offset: 88, NameHash: 3165880883, Flags: 49405), LayoutImmutable, Blittable]
		public int MaxStreamInCountPerFrame { get { return m_MaxStreamInCountPerFrame; } set { if (OnPropertyChanging("StreamGridEntityData." + nameof(MaxStreamInCountPerFrame), this, m_MaxStreamInCountPerFrame, value)) m_MaxStreamInCountPerFrame = value; } } // 0x58 (88)
		
		protected int m_MaxStreamOutCountPerFrame = new int();
		[ContainerField(Name: "MaxStreamOutCountPerFrame", Offset: 92, NameHash: 1065563290, Flags: 49405), LayoutImmutable, Blittable]
		public int MaxStreamOutCountPerFrame { get { return m_MaxStreamOutCountPerFrame; } set { if (OnPropertyChanging("StreamGridEntityData." + nameof(MaxStreamOutCountPerFrame), this, m_MaxStreamOutCountPerFrame, value)) m_MaxStreamOutCountPerFrame = value; } } // 0x5C (92)
		
		protected List<StreamGridCell> m_Cells = new List<StreamGridCell>();
		[ContainerField(Name: "Cells", Offset: 96, NameHash: 212327888, Flags: 65)]
		public List<StreamGridCell> Cells { get { return m_Cells; } set { if (OnPropertyChanging("StreamGridEntityData." + nameof(Cells), this, m_Cells, value)) m_Cells = value; } } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2566448966:
					CellSize = (float) p_Value;
					break;

				case 2201945291:
					ViewDistance = (float) p_Value;
					break;

				case 3165880883:
					MaxStreamInCountPerFrame = (int) p_Value;
					break;

				case 1065563290:
					MaxStreamOutCountPerFrame = (int) p_Value;
					break;

				case 212327888:
					Cells = (List<StreamGridCell>) p_Value;
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
				case 2566448966:
					return CellSize;

				case 2201945291:
					return ViewDistance;

				case 3165880883:
					return MaxStreamInCountPerFrame;

				case 1065563290:
					return MaxStreamOutCountPerFrame;

				case 212327888:
					return Cells;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2566448966:
					return typeof(StreamGridEntityData).GetProperty(nameof(CellSize));

				case 2201945291:
					return typeof(StreamGridEntityData).GetProperty(nameof(ViewDistance));

				case 3165880883:
					return typeof(StreamGridEntityData).GetProperty(nameof(MaxStreamInCountPerFrame));

				case 1065563290:
					return typeof(StreamGridEntityData).GetProperty(nameof(MaxStreamOutCountPerFrame));

				case 212327888:
					return typeof(StreamGridEntityData).GetProperty(nameof(Cells));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
