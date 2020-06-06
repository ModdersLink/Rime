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
	public class PhysicsConeConstraintData : 
		PhysicsConstraintData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float MinAngle { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float AngularFriction { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float MaxAngle { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public bool HasLimits { get; set; } // 0x6C (108)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3356124462:
					MinAngle = (float) p_Value;
					break;

				case 1552731461:
					AngularFriction = (float) p_Value;
					break;

				case 417488496:
					MaxAngle = (float) p_Value;
					break;

				case 2421583705:
					HasLimits = (bool) p_Value;
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
				case 3356124462:
					return MinAngle;

				case 1552731461:
					return AngularFriction;

				case 417488496:
					return MaxAngle;

				case 2421583705:
					return HasLimits;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3356124462:
					return typeof(PhysicsConeConstraintData).GetProperty(nameof(MinAngle));

				case 1552731461:
					return typeof(PhysicsConeConstraintData).GetProperty(nameof(AngularFriction));

				case 417488496:
					return typeof(PhysicsConeConstraintData).GetProperty(nameof(MaxAngle));

				case 2421583705:
					return typeof(PhysicsConeConstraintData).GetProperty(nameof(HasLimits));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
