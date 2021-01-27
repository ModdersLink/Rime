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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 36)]
	public class SpringData : FrostbiteContainer
	{
		[ContainerField(Name: "Length", Offset: 0, NameHash: 2906827577, Flags: 49469), LayoutImmutable, Blittable]
		public float Length { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "Stiffness", Offset: 4, NameHash: 721813632, Flags: 49469), LayoutImmutable, Blittable]
		public float Stiffness { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "Damping", Offset: 8, NameHash: 3862601053, Flags: 49469), LayoutImmutable, Blittable]
		public float Damping { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "MaxSpringForce", Offset: 12, NameHash: 140975709, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxSpringForce { get; set; } // 0xC (12)
		
		[ContainerField(Name: "ProgressiveStartRatio", Offset: 16, NameHash: 623340227, Flags: 49469), LayoutImmutable, Blittable]
		public float ProgressiveStartRatio { get; set; } // 0x10 (16)
		
		[ContainerField(Name: "ProgressiveExponent", Offset: 20, NameHash: 487101329, Flags: 49469), LayoutImmutable, Blittable]
		public float ProgressiveExponent { get; set; } // 0x14 (20)
		
		[ContainerField(Name: "VisualClipOffset", Offset: 24, NameHash: 4006753322, Flags: 49469), LayoutImmutable, Blittable]
		public float VisualClipOffset { get; set; } // 0x18 (24)
		
		[ContainerField(Name: "AttachOffsetY", Offset: 28, NameHash: 1742442042, Flags: 49469), LayoutImmutable, Blittable]
		public float AttachOffsetY { get; set; } // 0x1C (28)
		
		[ContainerField(Name: "DisabledStrenghModifier", Offset: 32, NameHash: 1291254003, Flags: 49469), LayoutImmutable, Blittable]
		public float DisabledStrenghModifier { get; set; } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2906827577:
					Length = (float) p_Value;
					break;

				case 721813632:
					Stiffness = (float) p_Value;
					break;

				case 3862601053:
					Damping = (float) p_Value;
					break;

				case 140975709:
					MaxSpringForce = (float) p_Value;
					break;

				case 623340227:
					ProgressiveStartRatio = (float) p_Value;
					break;

				case 487101329:
					ProgressiveExponent = (float) p_Value;
					break;

				case 4006753322:
					VisualClipOffset = (float) p_Value;
					break;

				case 1742442042:
					AttachOffsetY = (float) p_Value;
					break;

				case 1291254003:
					DisabledStrenghModifier = (float) p_Value;
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
				case 2906827577:
					return Length;

				case 721813632:
					return Stiffness;

				case 3862601053:
					return Damping;

				case 140975709:
					return MaxSpringForce;

				case 623340227:
					return ProgressiveStartRatio;

				case 487101329:
					return ProgressiveExponent;

				case 4006753322:
					return VisualClipOffset;

				case 1742442042:
					return AttachOffsetY;

				case 1291254003:
					return DisabledStrenghModifier;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2906827577:
					return typeof(SpringData).GetProperty(nameof(Length));

				case 721813632:
					return typeof(SpringData).GetProperty(nameof(Stiffness));

				case 3862601053:
					return typeof(SpringData).GetProperty(nameof(Damping));

				case 140975709:
					return typeof(SpringData).GetProperty(nameof(MaxSpringForce));

				case 623340227:
					return typeof(SpringData).GetProperty(nameof(ProgressiveStartRatio));

				case 487101329:
					return typeof(SpringData).GetProperty(nameof(ProgressiveExponent));

				case 4006753322:
					return typeof(SpringData).GetProperty(nameof(VisualClipOffset));

				case 1742442042:
					return typeof(SpringData).GetProperty(nameof(AttachOffsetY));

				case 1291254003:
					return typeof(SpringData).GetProperty(nameof(DisabledStrenghModifier));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
