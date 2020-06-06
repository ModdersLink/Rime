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
	public class TransformSnapToGroundEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform In { get; set; } = new LinearTransform(); // 0x10 (16)
		
		[ContainerField(80)]
		public Realm Realm { get; set; } = new Realm(); // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float DistanceToGround { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public float RayCastLength { get; set; } // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public float RayCastUpOffset { get; set; } // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public bool AlignWithGroundNormal { get; set; } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (LinearTransform) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 3638863832:
					DistanceToGround = (float) p_Value;
					break;

				case 2786399190:
					RayCastLength = (float) p_Value;
					break;

				case 2052773058:
					RayCastUpOffset = (float) p_Value;
					break;

				case 387843516:
					AlignWithGroundNormal = (bool) p_Value;
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
				case 5862146:
					return In;

				case 229961746:
					return Realm;

				case 3638863832:
					return DistanceToGround;

				case 2786399190:
					return RayCastLength;

				case 2052773058:
					return RayCastUpOffset;

				case 387843516:
					return AlignWithGroundNormal;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(TransformSnapToGroundEntityData).GetProperty(nameof(In));

				case 229961746:
					return typeof(TransformSnapToGroundEntityData).GetProperty(nameof(Realm));

				case 3638863832:
					return typeof(TransformSnapToGroundEntityData).GetProperty(nameof(DistanceToGround));

				case 2786399190:
					return typeof(TransformSnapToGroundEntityData).GetProperty(nameof(RayCastLength));

				case 2052773058:
					return typeof(TransformSnapToGroundEntityData).GetProperty(nameof(RayCastUpOffset));

				case 387843516:
					return typeof(TransformSnapToGroundEntityData).GetProperty(nameof(AlignWithGroundNormal));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
