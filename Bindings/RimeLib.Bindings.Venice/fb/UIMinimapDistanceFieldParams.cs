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
	[ContainerType(Alignment: 16,  Flags: 41, Size: 64)]
	public class UIMinimapDistanceFieldParams : FrostbiteContainer
	{
		[ContainerField(Name: "ColorTint", Offset: 0, NameHash: 518108063, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 ColorTint { get; set; } = new Vec4(); // 0x0 (0)
		
		[ContainerField(Name: "OutlineColor", Offset: 16, NameHash: 3944405112, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 OutlineColor { get; set; } = new Vec4(); // 0x10 (16)
		
		[ContainerField(Name: "DistanceScale", Offset: 32, NameHash: 773140030, Flags: 49469), LayoutImmutable, Blittable]
		public float DistanceScale { get; set; } // 0x20 (32)
		
		[ContainerField(Name: "AlphaThreshold", Offset: 36, NameHash: 2686813414, Flags: 49469), LayoutImmutable, Blittable]
		public float AlphaThreshold { get; set; } // 0x24 (36)
		
		[ContainerField(Name: "OutlineInner", Offset: 40, NameHash: 3946538011, Flags: 49469), LayoutImmutable, Blittable]
		public float OutlineInner { get; set; } // 0x28 (40)
		
		[ContainerField(Name: "OutlineOuter", Offset: 44, NameHash: 3949917564, Flags: 49469), LayoutImmutable, Blittable]
		public float OutlineOuter { get; set; } // 0x2C (44)
		
		[ContainerField(Name: "DistanceField", Offset: 48, NameHash: 750822692, Flags: 53)]
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
