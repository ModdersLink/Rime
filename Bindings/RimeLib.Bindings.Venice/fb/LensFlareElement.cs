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
	public class LensFlareElement : FrostbiteContainer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 SizeCamDistCurve { get; set; } = new Vec4(); // 0x0 (0)
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 SizeAngleCurve { get; set; } = new Vec4(); // 0x10 (16)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 Size { get; set; } = new Vec2(); // 0x20 (32)
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 SizeOccluderCurve { get; set; } = new Vec4(); // 0x30 (48)
		
		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 SizeScreenPosCurve { get; set; } = new Vec4(); // 0x40 (64)
		
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 AlphaCamDistCurve { get; set; } = new Vec4(); // 0x50 (80)
		
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 AlphaOccluderCurve { get; set; } = new Vec4(); // 0x60 (96)
		
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 AlphaAngleCurve { get; set; } = new Vec4(); // 0x70 (112)
		
		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 AlphaScreenPosCurve { get; set; } = new Vec4(); // 0x80 (128)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public float SizeCamDistMax { get; set; } // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public float RayDistance { get; set; } // 0x94 (148)
		
		[ContainerField(152)]
		public CtrRef<SurfaceShaderBaseAsset> Shader { get; set; } = new CtrRef<SurfaceShaderBaseAsset>(); // 0x98 (152)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public float AlphaCamDistMax { get; set; } // 0x9C (156)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 581854770:
					SizeCamDistCurve = (Vec4) p_Value;
					break;

				case 2048655894:
					SizeAngleCurve = (Vec4) p_Value;
					break;

				case 2089429248:
					Size = (Vec2) p_Value;
					break;

				case 3776114:
					SizeOccluderCurve = (Vec4) p_Value;
					break;

				case 3056630583:
					SizeScreenPosCurve = (Vec4) p_Value;
					break;

				case 3212151939:
					AlphaCamDistCurve = (Vec4) p_Value;
					break;

				case 667546595:
					AlphaOccluderCurve = (Vec4) p_Value;
					break;

				case 4159333799:
					AlphaAngleCurve = (Vec4) p_Value;
					break;

				case 1611913286:
					AlphaScreenPosCurve = (Vec4) p_Value;
					break;

				case 1664889457:
					SizeCamDistMax = (float) p_Value;
					break;

				case 223111116:
					RayDistance = (float) p_Value;
					break;

				case 3352909900:
					Shader = (CtrRef<SurfaceShaderBaseAsset>) p_Value;
					break;

				case 961329344:
					AlphaCamDistMax = (float) p_Value;
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
				case 581854770:
					return SizeCamDistCurve;

				case 2048655894:
					return SizeAngleCurve;

				case 2089429248:
					return Size;

				case 3776114:
					return SizeOccluderCurve;

				case 3056630583:
					return SizeScreenPosCurve;

				case 3212151939:
					return AlphaCamDistCurve;

				case 667546595:
					return AlphaOccluderCurve;

				case 4159333799:
					return AlphaAngleCurve;

				case 1611913286:
					return AlphaScreenPosCurve;

				case 1664889457:
					return SizeCamDistMax;

				case 223111116:
					return RayDistance;

				case 3352909900:
					return Shader;

				case 961329344:
					return AlphaCamDistMax;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 581854770:
					return typeof(LensFlareElement).GetProperty(nameof(SizeCamDistCurve));

				case 2048655894:
					return typeof(LensFlareElement).GetProperty(nameof(SizeAngleCurve));

				case 2089429248:
					return typeof(LensFlareElement).GetProperty(nameof(Size));

				case 3776114:
					return typeof(LensFlareElement).GetProperty(nameof(SizeOccluderCurve));

				case 3056630583:
					return typeof(LensFlareElement).GetProperty(nameof(SizeScreenPosCurve));

				case 3212151939:
					return typeof(LensFlareElement).GetProperty(nameof(AlphaCamDistCurve));

				case 667546595:
					return typeof(LensFlareElement).GetProperty(nameof(AlphaOccluderCurve));

				case 4159333799:
					return typeof(LensFlareElement).GetProperty(nameof(AlphaAngleCurve));

				case 1611913286:
					return typeof(LensFlareElement).GetProperty(nameof(AlphaScreenPosCurve));

				case 1664889457:
					return typeof(LensFlareElement).GetProperty(nameof(SizeCamDistMax));

				case 223111116:
					return typeof(LensFlareElement).GetProperty(nameof(RayDistance));

				case 3352909900:
					return typeof(LensFlareElement).GetProperty(nameof(Shader));

				case 961329344:
					return typeof(LensFlareElement).GetProperty(nameof(AlphaCamDistMax));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
