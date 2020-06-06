///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class TransformHubEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform In4 { get; set; } = new LinearTransform(); // 0x10 (16)
		
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform In1 { get; set; } = new LinearTransform(); // 0x50 (80)
		
		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform In2 { get; set; } = new LinearTransform(); // 0x90 (144)
		
		[ContainerField(208), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform In3 { get; set; } = new LinearTransform(); // 0xD0 (208)
		
		[ContainerField(272), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform In8 { get; set; } = new LinearTransform(); // 0x110 (272)
		
		[ContainerField(336), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform In5 { get; set; } = new LinearTransform(); // 0x150 (336)
		
		[ContainerField(400), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform In6 { get; set; } = new LinearTransform(); // 0x190 (400)
		
		[ContainerField(464), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform In7 { get; set; } = new LinearTransform(); // 0x1D0 (464)
		
		[ContainerField(528)]
		public Realm Realm { get; set; } = new Realm(); // 0x210 (528)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193450870:
					In4 = (LinearTransform) p_Value;
					break;

				case 193450867:
					In1 = (LinearTransform) p_Value;
					break;

				case 193450864:
					In2 = (LinearTransform) p_Value;
					break;

				case 193450865:
					In3 = (LinearTransform) p_Value;
					break;

				case 193450874:
					In8 = (LinearTransform) p_Value;
					break;

				case 193450871:
					In5 = (LinearTransform) p_Value;
					break;

				case 193450868:
					In6 = (LinearTransform) p_Value;
					break;

				case 193450869:
					In7 = (LinearTransform) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
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
				case 193450870:
					return In4;

				case 193450867:
					return In1;

				case 193450864:
					return In2;

				case 193450865:
					return In3;

				case 193450874:
					return In8;

				case 193450871:
					return In5;

				case 193450868:
					return In6;

				case 193450869:
					return In7;

				case 229961746:
					return Realm;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193450870:
					return typeof(TransformHubEntityData).GetProperty(nameof(In4));

				case 193450867:
					return typeof(TransformHubEntityData).GetProperty(nameof(In1));

				case 193450864:
					return typeof(TransformHubEntityData).GetProperty(nameof(In2));

				case 193450865:
					return typeof(TransformHubEntityData).GetProperty(nameof(In3));

				case 193450874:
					return typeof(TransformHubEntityData).GetProperty(nameof(In8));

				case 193450871:
					return typeof(TransformHubEntityData).GetProperty(nameof(In5));

				case 193450868:
					return typeof(TransformHubEntityData).GetProperty(nameof(In6));

				case 193450869:
					return typeof(TransformHubEntityData).GetProperty(nameof(In7));

				case 229961746:
					return typeof(TransformHubEntityData).GetProperty(nameof(Realm));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
