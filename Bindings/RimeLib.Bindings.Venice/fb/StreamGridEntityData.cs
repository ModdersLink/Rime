///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class StreamGridEntityData : 
		SpatialEntityData
	{
		[ContainerField(80), LayoutImmutable, Blittable]
		public float CellSize { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float ViewDistance { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public int MaxStreamInCountPerFrame { get; set; } // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public int MaxStreamOutCountPerFrame { get; set; } // 0x5C (92)
		
		[ContainerField(96)]
		public List<StreamGridCell> Cells { get; set; } = new List<StreamGridCell>(); // 0x60 (96)
		
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
