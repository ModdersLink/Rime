///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class CameraProximityEvaluatorData : 
		EvaluatorData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Size { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Offset { get; set; } = new Vec3(); // 0x20 (32)
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InnerRadiusDirection { get; set; } = new Vec3(); // 0x30 (48)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float InnerRadius { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float ForwardOffset { get; set; } // 0x44 (68)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2089429248:
					Size = (Vec3) p_Value;
					break;

				case 2871410728:
					Offset = (Vec3) p_Value;
					break;

				case 3044199494:
					InnerRadiusDirection = (Vec3) p_Value;
					break;

				case 3334193859:
					InnerRadius = (float) p_Value;
					break;

				case 2564135379:
					ForwardOffset = (float) p_Value;
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
				case 2089429248:
					return Size;

				case 2871410728:
					return Offset;

				case 3044199494:
					return InnerRadiusDirection;

				case 3334193859:
					return InnerRadius;

				case 2564135379:
					return ForwardOffset;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2089429248:
					return typeof(CameraProximityEvaluatorData).GetProperty(nameof(Size));

				case 2871410728:
					return typeof(CameraProximityEvaluatorData).GetProperty(nameof(Offset));

				case 3044199494:
					return typeof(CameraProximityEvaluatorData).GetProperty(nameof(InnerRadiusDirection));

				case 3334193859:
					return typeof(CameraProximityEvaluatorData).GetProperty(nameof(InnerRadius));

				case 2564135379:
					return typeof(CameraProximityEvaluatorData).GetProperty(nameof(ForwardOffset));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
