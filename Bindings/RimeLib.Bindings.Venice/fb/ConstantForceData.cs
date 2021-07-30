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
	[ContainerType(Alignment: 16,  Flags: 41, Size: 32)]
	public class ConstantForceData : FrostbiteContainer
	{
		[ContainerField(Name: "Value", Offset: 0, NameHash: 225375086, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Value { get; set; } = new Vec3(); // 0x0 (0)
		
		[ContainerField(Name: "Condition", Offset: 16, NameHash: 1800624758, Flags: 137)]
		public ForceCondition Condition { get; set; } = new ForceCondition(); // 0x10 (16)
		
		[ContainerField(Name: "TypeOfForce", Offset: 20, NameHash: 2167151145, Flags: 137)]
		public ForceType TypeOfForce { get; set; } = new ForceType(); // 0x14 (20)
		
		[ContainerField(Name: "Space", Offset: 24, NameHash: 230891329, Flags: 137)]
		public SpaceType Space { get; set; } = new SpaceType(); // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 225375086:
					Value = (Vec3) p_Value;
					break;

				case 1800624758:
						Condition = (ForceCondition) Enum.ToObject(typeof(ForceCondition), p_Value);
					break;

				case 2167151145:
						TypeOfForce = (ForceType) Enum.ToObject(typeof(ForceType), p_Value);
					break;

				case 230891329:
						Space = (SpaceType) Enum.ToObject(typeof(SpaceType), p_Value);
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
				case 225375086:
					return Value;

				case 1800624758:
					return Condition;

				case 2167151145:
					return TypeOfForce;

				case 230891329:
					return Space;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 225375086:
					return typeof(ConstantForceData).GetProperty(nameof(Value));

				case 1800624758:
					return typeof(ConstantForceData).GetProperty(nameof(Condition));

				case 2167151145:
					return typeof(ConstantForceData).GetProperty(nameof(TypeOfForce));

				case 230891329:
					return typeof(ConstantForceData).GetProperty(nameof(Space));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
