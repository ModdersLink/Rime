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
	[ContainerType(Alignment: 16,  Flags: 41, Size: 48)]
	public class RibbonPointData : FrostbiteContainer
	{
		[ContainerField(Name: "UserMaskRight", Offset: 0, NameHash: 1923208736, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 UserMaskRight { get; set; } = new Vec4(); // 0x0 (0)
		
		[ContainerField(Name: "UserMaskLeft", Offset: 16, NameHash: 2010169083, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 UserMaskLeft { get; set; } = new Vec4(); // 0x10 (16)
		
		[ContainerField(Name: "Right", Offset: 32, NameHash: 230390021, Flags: 49469), LayoutImmutable, Blittable]
		public float Right { get; set; } // 0x20 (32)
		
		[ContainerField(Name: "Left", Offset: 36, NameHash: 2089021886, Flags: 49469), LayoutImmutable, Blittable]
		public float Left { get; set; } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1923208736:
					UserMaskRight = (Vec4) p_Value;
					break;

				case 2010169083:
					UserMaskLeft = (Vec4) p_Value;
					break;

				case 230390021:
					Right = (float) p_Value;
					break;

				case 2089021886:
					Left = (float) p_Value;
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
				case 1923208736:
					return UserMaskRight;

				case 2010169083:
					return UserMaskLeft;

				case 230390021:
					return Right;

				case 2089021886:
					return Left;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1923208736:
					return typeof(RibbonPointData).GetProperty(nameof(UserMaskRight));

				case 2010169083:
					return typeof(RibbonPointData).GetProperty(nameof(UserMaskLeft));

				case 230390021:
					return typeof(RibbonPointData).GetProperty(nameof(Right));

				case 2089021886:
					return typeof(RibbonPointData).GetProperty(nameof(Left));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
