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
	public class BotPriorityConfigData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 DebugColor { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float Distance { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public int Period { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float AngleOffset { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public bool AppliesToExecution { get; set; } // 0x2C (44)
		
		[ContainerField(45), LayoutImmutable, Blittable]
		public bool AppliesToDecisions { get; set; } // 0x2D (45)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2612071465:
					DebugColor = (Vec3) p_Value;
					break;

				case 408560070:
					Distance = (float) p_Value;
					break;

				case 3366831232:
					Period = (int) p_Value;
					break;

				case 1865391177:
					AngleOffset = (float) p_Value;
					break;

				case 2757011902:
					AppliesToExecution = (bool) p_Value;
					break;

				case 4242821263:
					AppliesToDecisions = (bool) p_Value;
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
				case 2612071465:
					return DebugColor;

				case 408560070:
					return Distance;

				case 3366831232:
					return Period;

				case 1865391177:
					return AngleOffset;

				case 2757011902:
					return AppliesToExecution;

				case 4242821263:
					return AppliesToDecisions;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2612071465:
					return typeof(BotPriorityConfigData).GetProperty(nameof(DebugColor));

				case 408560070:
					return typeof(BotPriorityConfigData).GetProperty(nameof(Distance));

				case 3366831232:
					return typeof(BotPriorityConfigData).GetProperty(nameof(Period));

				case 1865391177:
					return typeof(BotPriorityConfigData).GetProperty(nameof(AngleOffset));

				case 2757011902:
					return typeof(BotPriorityConfigData).GetProperty(nameof(AppliesToExecution));

				case 4242821263:
					return typeof(BotPriorityConfigData).GetProperty(nameof(AppliesToDecisions));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
