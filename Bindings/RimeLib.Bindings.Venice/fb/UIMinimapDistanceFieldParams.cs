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
	[ContainerType(16), MemberInfoFlag(41), ContainerSize(64), ContainerStruct]
	public class UIMinimapDistanceFieldParams : FrostbiteContainer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec4 ColorTint { get; set; } = new Vec4(); // 0x0 (0)
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec4 OutlineColor { get; set; } = new Vec4(); // 0x10 (16)
		
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float DistanceScale { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float AlphaThreshold { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float OutlineInner { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float OutlineOuter { get; set; } // 0x2C (44)
		
		[ContainerField(48), MemberInfoFlag(53), ContainerCtrRef]
		public CtrRef<UIDistanceFieldAsset> DistanceField { get; set; } = new CtrRef<UIDistanceFieldAsset>(); // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 518108063:
					ColorTint = (Vec4) p_Value;
					break;

				case 3944405112:
					OutlineColor = (Vec4) p_Value;
					break;

				case 773140030:
					DistanceScale = (float) p_Value;
					break;

				case 2686813414:
					AlphaThreshold = (float) p_Value;
					break;

				case 3946538011:
					OutlineInner = (float) p_Value;
					break;

				case 3949917564:
					OutlineOuter = (float) p_Value;
					break;

				case 750822692:
					DistanceField = (CtrRef<UIDistanceFieldAsset>) p_Value;
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
				case 518108063:
					return ColorTint;

				case 3944405112:
					return OutlineColor;

				case 773140030:
					return DistanceScale;

				case 2686813414:
					return AlphaThreshold;

				case 3946538011:
					return OutlineInner;

				case 3949917564:
					return OutlineOuter;

				case 750822692:
					return DistanceField;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 518108063:
					return typeof(UIMinimapDistanceFieldParams).GetProperty(nameof(ColorTint));

				case 3944405112:
					return typeof(UIMinimapDistanceFieldParams).GetProperty(nameof(OutlineColor));

				case 773140030:
					return typeof(UIMinimapDistanceFieldParams).GetProperty(nameof(DistanceScale));

				case 2686813414:
					return typeof(UIMinimapDistanceFieldParams).GetProperty(nameof(AlphaThreshold));

				case 3946538011:
					return typeof(UIMinimapDistanceFieldParams).GetProperty(nameof(OutlineInner));

				case 3949917564:
					return typeof(UIMinimapDistanceFieldParams).GetProperty(nameof(OutlineOuter));

				case 750822692:
					return typeof(UIMinimapDistanceFieldParams).GetProperty(nameof(DistanceField));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
