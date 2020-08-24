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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class TimingConstantData : 
		Asset
	{
		protected float m_UpdateTimePerFrame = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2600656827)]
		public float UpdateTimePerFrame { get { return m_UpdateTimePerFrame; } set { if (OnPropertyChanging("TimingConstantData." + nameof(UpdateTimePerFrame), this, m_UpdateTimePerFrame, value)) m_UpdateTimePerFrame = value; } } // 0xC (12)
		
		protected SubsystemTimingConfigData m_SubsystemTimeParts = new SubsystemTimingConfigData();
		[ContainerField(16), MemberInfoFlag(41), ContainerFieldNameHash(3741694197)]
		public SubsystemTimingConfigData SubsystemTimeParts { get { return m_SubsystemTimeParts; } set { if (OnPropertyChanging("TimingConstantData." + nameof(SubsystemTimeParts), this, m_SubsystemTimeParts, value)) m_SubsystemTimeParts = value; } } // 0x10 (16)
		
		protected RefArray<BotPriorityConfigData> m_PriorityClasses = new RefArray<BotPriorityConfigData>();
		[ContainerField(40), MemberInfoFlag(65), ContainerFieldNameHash(1128874863), ContainerRefArray]
		public RefArray<BotPriorityConfigData> PriorityClasses { get { return m_PriorityClasses; } set { if (OnPropertyChanging("TimingConstantData." + nameof(PriorityClasses), this, m_PriorityClasses, value)) m_PriorityClasses = value; } } // 0x28 (40)
		
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
