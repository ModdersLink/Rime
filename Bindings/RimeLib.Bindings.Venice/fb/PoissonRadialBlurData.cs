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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(20), ContainerStruct]
	public class PoissonRadialBlurData : FrostbiteContainer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec2 PoissonDiscScale { get; set; } = new Vec2(); // 0x0 (0)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float BlendFactor { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float RadialScale { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float RadialExponent { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 414320215:
					PoissonDiscScale = (Vec2) p_Value;
					break;

				case 2895077833:
					BlendFactor = (float) p_Value;
					break;

				case 948161198:
					RadialScale = (float) p_Value;
					break;

				case 3819783621:
					RadialExponent = (float) p_Value;
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
				case 414320215:
					return PoissonDiscScale;

				case 2895077833:
					return BlendFactor;

				case 948161198:
					return RadialScale;

				case 3819783621:
					return RadialExponent;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 414320215:
					return typeof(PoissonRadialBlurData).GetProperty(nameof(PoissonDiscScale));

				case 2895077833:
					return typeof(PoissonRadialBlurData).GetProperty(nameof(BlendFactor));

				case 948161198:
					return typeof(PoissonRadialBlurData).GetProperty(nameof(RadialScale));

				case 3819783621:
					return typeof(PoissonRadialBlurData).GetProperty(nameof(RadialExponent));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
