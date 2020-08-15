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
	[ContainerType(16)]
	public class SubScreenData : FrostbiteContainer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ScreenPosition { get; set; } = new Vec3(); // 0x0 (0)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float ProjectionAngleY { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float ProjectionAngleZ { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float ProjectionAngleX { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float ScreenSize { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float IconSize { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float ScaleIconSizeByDepthStrength { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float RenderTargetApectRatio { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public int RenderTargetIndex { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public bool UseRenderTarget { get; set; } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2288910864:
					ScreenPosition = (Vec3) p_Value;
					break;

				case 213589344:
					ProjectionAngleY = (float) p_Value;
					break;

				case 213589347:
					ProjectionAngleZ = (float) p_Value;
					break;

				case 213589345:
					ProjectionAngleX = (float) p_Value;
					break;

				case 2100560172:
					ScreenSize = (float) p_Value;
					break;

				case 269738667:
					IconSize = (float) p_Value;
					break;

				case 609483936:
					ScaleIconSizeByDepthStrength = (float) p_Value;
					break;

				case 984520476:
					RenderTargetApectRatio = (float) p_Value;
					break;

				case 3545373920:
					RenderTargetIndex = (int) p_Value;
					break;

				case 3192099997:
					UseRenderTarget = (bool) p_Value;
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
				case 2288910864:
					return ScreenPosition;

				case 213589344:
					return ProjectionAngleY;

				case 213589347:
					return ProjectionAngleZ;

				case 213589345:
					return ProjectionAngleX;

				case 2100560172:
					return ScreenSize;

				case 269738667:
					return IconSize;

				case 609483936:
					return ScaleIconSizeByDepthStrength;

				case 984520476:
					return RenderTargetApectRatio;

				case 3545373920:
					return RenderTargetIndex;

				case 3192099997:
					return UseRenderTarget;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2288910864:
					return typeof(SubScreenData).GetProperty(nameof(ScreenPosition));

				case 213589344:
					return typeof(SubScreenData).GetProperty(nameof(ProjectionAngleY));

				case 213589347:
					return typeof(SubScreenData).GetProperty(nameof(ProjectionAngleZ));

				case 213589345:
					return typeof(SubScreenData).GetProperty(nameof(ProjectionAngleX));

				case 2100560172:
					return typeof(SubScreenData).GetProperty(nameof(ScreenSize));

				case 269738667:
					return typeof(SubScreenData).GetProperty(nameof(IconSize));

				case 609483936:
					return typeof(SubScreenData).GetProperty(nameof(ScaleIconSizeByDepthStrength));

				case 984520476:
					return typeof(SubScreenData).GetProperty(nameof(RenderTargetApectRatio));

				case 3545373920:
					return typeof(SubScreenData).GetProperty(nameof(RenderTargetIndex));

				case 3192099997:
					return typeof(SubScreenData).GetProperty(nameof(UseRenderTarget));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
