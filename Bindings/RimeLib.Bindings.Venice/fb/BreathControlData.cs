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
	public class BreathControlData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float BreathControlTime { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float BreathControlReleaseTime { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float BreathControlPenaltyMultiplier { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float BreathControlPenaltyTimeout { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4153846207:
					BreathControlTime = (float) p_Value;
					break;

				case 1085847638:
					BreathControlReleaseTime = (float) p_Value;
					break;

				case 735731002:
					BreathControlPenaltyMultiplier = (float) p_Value;
					break;

				case 3387044330:
					BreathControlPenaltyTimeout = (float) p_Value;
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
				case 4153846207:
					return BreathControlTime;

				case 1085847638:
					return BreathControlReleaseTime;

				case 735731002:
					return BreathControlPenaltyMultiplier;

				case 3387044330:
					return BreathControlPenaltyTimeout;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4153846207:
					return typeof(BreathControlData).GetProperty(nameof(BreathControlTime));

				case 1085847638:
					return typeof(BreathControlData).GetProperty(nameof(BreathControlReleaseTime));

				case 735731002:
					return typeof(BreathControlData).GetProperty(nameof(BreathControlPenaltyMultiplier));

				case 3387044330:
					return typeof(BreathControlData).GetProperty(nameof(BreathControlPenaltyTimeout));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
