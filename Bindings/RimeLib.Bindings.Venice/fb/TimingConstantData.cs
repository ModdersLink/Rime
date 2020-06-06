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
	public class TimingConstantData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float UpdateTimePerFrame { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public SubsystemTimingConfigData SubsystemTimeParts { get; set; } = new SubsystemTimingConfigData(); // 0x10 (16)
		
		[ContainerField(40)]
		public RefArray<BotPriorityConfigData> PriorityClasses { get; set; } = new RefArray<BotPriorityConfigData>(); // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2600656827:
					UpdateTimePerFrame = (float) p_Value;
					break;

				case 3741694197:
					SubsystemTimeParts = (SubsystemTimingConfigData) p_Value;
					break;

				case 1128874863:
					PriorityClasses = (RefArray<BotPriorityConfigData>) p_Value;
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
				case 2600656827:
					return UpdateTimePerFrame;

				case 3741694197:
					return SubsystemTimeParts;

				case 1128874863:
					return PriorityClasses;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2600656827:
					return typeof(TimingConstantData).GetProperty(nameof(UpdateTimePerFrame));

				case 3741694197:
					return typeof(TimingConstantData).GetProperty(nameof(SubsystemTimeParts));

				case 1128874863:
					return typeof(TimingConstantData).GetProperty(nameof(PriorityClasses));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
