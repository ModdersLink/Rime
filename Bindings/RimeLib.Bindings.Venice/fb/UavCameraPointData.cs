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
	[ContainerType(4)]
	public class UavCameraPointData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float MinTime { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float MaxTime { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float Speed { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float AccelerationTime { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1013155226:
					MinTime = (float) p_Value;
					break;

				case 1313681284:
					MaxTime = (float) p_Value;
					break;

				case 230887042:
					Speed = (float) p_Value;
					break;

				case 1825667474:
					AccelerationTime = (float) p_Value;
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
				case 1013155226:
					return MinTime;

				case 1313681284:
					return MaxTime;

				case 230887042:
					return Speed;

				case 1825667474:
					return AccelerationTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1013155226:
					return typeof(UavCameraPointData).GetProperty(nameof(MinTime));

				case 1313681284:
					return typeof(UavCameraPointData).GetProperty(nameof(MaxTime));

				case 230887042:
					return typeof(UavCameraPointData).GetProperty(nameof(Speed));

				case 1825667474:
					return typeof(UavCameraPointData).GetProperty(nameof(AccelerationTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
