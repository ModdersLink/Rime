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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 12)]
	public class MinimapCameraOffsetData : FrostbiteContainer
	{
		[ContainerField(Name: "Position", Offset: 0, NameHash: 3402582524, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 Position { get; set; } = new Vec2(); // 0x0 (0)
		
		[ContainerField(Name: "CameraFov", Offset: 8, NameHash: 1789541379, Flags: 49469), LayoutImmutable, Blittable]
		public float CameraFov { get; set; } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3402582524:
					Position = (Vec2) p_Value;
					break;

				case 1789541379:
					CameraFov = (float) p_Value;
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
				case 3402582524:
					return Position;

				case 1789541379:
					return CameraFov;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3402582524:
					return typeof(MinimapCameraOffsetData).GetProperty(nameof(Position));

				case 1789541379:
					return typeof(MinimapCameraOffsetData).GetProperty(nameof(CameraFov));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
