///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class SpecialMoveVaultStateCriteria : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float DistToObject { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float DistToObjectTolerance { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float HeightOfObject { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float HeightOfObjectTolerance { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float LengthOfObject { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float LengthOfObjectTolerance { get; set; } // 0x14 (20)
		
		[ContainerField(24)]
		public SpecialMoveStateData SpecialMoveState { get; set; } = new SpecialMoveStateData(); // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1707862081:
					DistToObject = (float) p_Value;
					break;

				case 1717356072:
					DistToObjectTolerance = (float) p_Value;
					break;

				case 2836557414:
					HeightOfObject = (float) p_Value;
					break;

				case 1015099759:
					HeightOfObjectTolerance = (float) p_Value;
					break;

				case 1373639045:
					LengthOfObject = (float) p_Value;
					break;

				case 1401248364:
					LengthOfObjectTolerance = (float) p_Value;
					break;

				case 731667010:
					SpecialMoveState = (SpecialMoveStateData) p_Value;
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
				case 1707862081:
					return DistToObject;

				case 1717356072:
					return DistToObjectTolerance;

				case 2836557414:
					return HeightOfObject;

				case 1015099759:
					return HeightOfObjectTolerance;

				case 1373639045:
					return LengthOfObject;

				case 1401248364:
					return LengthOfObjectTolerance;

				case 731667010:
					return SpecialMoveState;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1707862081:
					return typeof(SpecialMoveVaultStateCriteria).GetProperty(nameof(DistToObject));

				case 1717356072:
					return typeof(SpecialMoveVaultStateCriteria).GetProperty(nameof(DistToObjectTolerance));

				case 2836557414:
					return typeof(SpecialMoveVaultStateCriteria).GetProperty(nameof(HeightOfObject));

				case 1015099759:
					return typeof(SpecialMoveVaultStateCriteria).GetProperty(nameof(HeightOfObjectTolerance));

				case 1373639045:
					return typeof(SpecialMoveVaultStateCriteria).GetProperty(nameof(LengthOfObject));

				case 1401248364:
					return typeof(SpecialMoveVaultStateCriteria).GetProperty(nameof(LengthOfObjectTolerance));

				case 731667010:
					return typeof(SpecialMoveVaultStateCriteria).GetProperty(nameof(SpecialMoveState));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
