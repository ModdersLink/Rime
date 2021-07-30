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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 128)]
	public class RadarSweepComponentData : 
		ComponentData
	{
		protected float m_ControllableSpeedThreshold = new float();
		[ContainerField(Name: "ControllableSpeedThreshold", Offset: 96, NameHash: 1580205332, Flags: 49469), LayoutImmutable, Blittable]
		public float ControllableSpeedThreshold { get { return m_ControllableSpeedThreshold; } set { if (OnPropertyChanging("RadarSweepComponentData." + nameof(ControllableSpeedThreshold), this, m_ControllableSpeedThreshold, value)) m_ControllableSpeedThreshold = value; } } // 0x60 (96)
		
		protected float m_ControllableSweepRadius = new float();
		[ContainerField(Name: "ControllableSweepRadius", Offset: 100, NameHash: 3505857000, Flags: 49469), LayoutImmutable, Blittable]
		public float ControllableSweepRadius { get { return m_ControllableSweepRadius; } set { if (OnPropertyChanging("RadarSweepComponentData." + nameof(ControllableSweepRadius), this, m_ControllableSweepRadius, value)) m_ControllableSweepRadius = value; } } // 0x64 (100)
		
		protected float m_ControllableSweepInterval = new float();
		[ContainerField(Name: "ControllableSweepInterval", Offset: 104, NameHash: 147831503, Flags: 49469), LayoutImmutable, Blittable]
		public float ControllableSweepInterval { get { return m_ControllableSweepInterval; } set { if (OnPropertyChanging("RadarSweepComponentData." + nameof(ControllableSweepInterval), this, m_ControllableSweepInterval, value)) m_ControllableSweepInterval = value; } } // 0x68 (104)
		
		protected float m_MineSweepInterval = new float();
		[ContainerField(Name: "MineSweepInterval", Offset: 108, NameHash: 2712402273, Flags: 49469), LayoutImmutable, Blittable]
		public float MineSweepInterval { get { return m_MineSweepInterval; } set { if (OnPropertyChanging("RadarSweepComponentData." + nameof(MineSweepInterval), this, m_MineSweepInterval, value)) m_MineSweepInterval = value; } } // 0x6C (108)
		
		protected float m_MineSweepRadius = new float();
		[ContainerField(Name: "MineSweepRadius", Offset: 112, NameHash: 2857682054, Flags: 49469), LayoutImmutable, Blittable]
		public float MineSweepRadius { get { return m_MineSweepRadius; } set { if (OnPropertyChanging("RadarSweepComponentData." + nameof(MineSweepRadius), this, m_MineSweepRadius, value)) m_MineSweepRadius = value; } } // 0x70 (112)
		
		protected bool m_SweepForMines = new bool();
		[ContainerField(Name: "SweepForMines", Offset: 116, NameHash: 3062743734, Flags: 49325), LayoutImmutable, Blittable]
		public bool SweepForMines { get { return m_SweepForMines; } set { if (OnPropertyChanging("RadarSweepComponentData." + nameof(SweepForMines), this, m_SweepForMines, value)) m_SweepForMines = value; } } // 0x74 (116)
		
		protected bool m_SweepForControllables = new bool();
		[ContainerField(Name: "SweepForControllables", Offset: 117, NameHash: 140300376, Flags: 49325), LayoutImmutable, Blittable]
		public bool SweepForControllables { get { return m_SweepForControllables; } set { if (OnPropertyChanging("RadarSweepComponentData." + nameof(SweepForControllables), this, m_SweepForControllables, value)) m_SweepForControllables = value; } } // 0x75 (117)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1580205332:
					ControllableSpeedThreshold = (float) p_Value;
					break;

				case 3505857000:
					ControllableSweepRadius = (float) p_Value;
					break;

				case 147831503:
					ControllableSweepInterval = (float) p_Value;
					break;

				case 2712402273:
					MineSweepInterval = (float) p_Value;
					break;

				case 2857682054:
					MineSweepRadius = (float) p_Value;
					break;

				case 3062743734:
					SweepForMines = (bool) p_Value;
					break;

				case 140300376:
					SweepForControllables = (bool) p_Value;
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
				case 1580205332:
					return ControllableSpeedThreshold;

				case 3505857000:
					return ControllableSweepRadius;

				case 147831503:
					return ControllableSweepInterval;

				case 2712402273:
					return MineSweepInterval;

				case 2857682054:
					return MineSweepRadius;

				case 3062743734:
					return SweepForMines;

				case 140300376:
					return SweepForControllables;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1580205332:
					return typeof(RadarSweepComponentData).GetProperty(nameof(ControllableSpeedThreshold));

				case 3505857000:
					return typeof(RadarSweepComponentData).GetProperty(nameof(ControllableSweepRadius));

				case 147831503:
					return typeof(RadarSweepComponentData).GetProperty(nameof(ControllableSweepInterval));

				case 2712402273:
					return typeof(RadarSweepComponentData).GetProperty(nameof(MineSweepInterval));

				case 2857682054:
					return typeof(RadarSweepComponentData).GetProperty(nameof(MineSweepRadius));

				case 3062743734:
					return typeof(RadarSweepComponentData).GetProperty(nameof(SweepForMines));

				case 140300376:
					return typeof(RadarSweepComponentData).GetProperty(nameof(SweepForControllables));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
