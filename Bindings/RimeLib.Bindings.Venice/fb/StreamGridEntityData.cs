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
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class StreamGridEntityData : 
		SpatialEntityData
	{
		protected float m_CellSize = new float();
		[ContainerField(80), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2566448966)]
		public float CellSize { get { return m_CellSize; } set { if (OnPropertyChanging("StreamGridEntityData." + nameof(CellSize), this, m_CellSize, value)) m_CellSize = value; } } // 0x50 (80)
		
		protected float m_ViewDistance = new float();
		[ContainerField(84), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2201945291)]
		public float ViewDistance { get { return m_ViewDistance; } set { if (OnPropertyChanging("StreamGridEntityData." + nameof(ViewDistance), this, m_ViewDistance, value)) m_ViewDistance = value; } } // 0x54 (84)
		
		protected int m_MaxStreamInCountPerFrame = new int();
		[ContainerField(88), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3165880883)]
		public int MaxStreamInCountPerFrame { get { return m_MaxStreamInCountPerFrame; } set { if (OnPropertyChanging("StreamGridEntityData." + nameof(MaxStreamInCountPerFrame), this, m_MaxStreamInCountPerFrame, value)) m_MaxStreamInCountPerFrame = value; } } // 0x58 (88)
		
		protected int m_MaxStreamOutCountPerFrame = new int();
		[ContainerField(92), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(1065563290)]
		public int MaxStreamOutCountPerFrame { get { return m_MaxStreamOutCountPerFrame; } set { if (OnPropertyChanging("StreamGridEntityData." + nameof(MaxStreamOutCountPerFrame), this, m_MaxStreamOutCountPerFrame, value)) m_MaxStreamOutCountPerFrame = value; } } // 0x5C (92)
		
		protected List<StreamGridCell> m_Cells = new List<StreamGridCell>();
		[ContainerField(96), MemberInfoFlag(65), ContainerFieldNameHash(212327888), ContainerArray]
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
