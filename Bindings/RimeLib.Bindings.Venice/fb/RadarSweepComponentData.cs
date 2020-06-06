///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class RadarSweepComponentData : 
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float ControllableSpeedThreshold { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float ControllableSweepRadius { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float ControllableSweepInterval { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float MineSweepInterval { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float MineSweepRadius { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public bool SweepForMines { get; set; } // 0x74 (116)
		
		[ContainerField(117), LayoutImmutable, Blittable]
		public bool SweepForControllables { get; set; } // 0x75 (117)
		
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
