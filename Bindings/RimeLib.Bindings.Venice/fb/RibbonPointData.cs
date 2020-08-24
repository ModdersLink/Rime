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
	[ContainerType(16), MemberInfoFlag(41), ContainerStruct]
	public class RibbonPointData : FrostbiteContainer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec4 UserMaskRight { get; set; } = new Vec4(); // 0x0 (0)
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec4 UserMaskLeft { get; set; } = new Vec4(); // 0x10 (16)
		
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float Right { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
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
