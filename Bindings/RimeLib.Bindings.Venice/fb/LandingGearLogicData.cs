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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 32)]
	public class LandingGearLogicData : 
		DataContainer
	{
		protected LandingGearConditionData m_RetractCondition = new LandingGearConditionData();
		[ContainerField(Name: "RetractCondition", Offset: 8, NameHash: 750548785, Flags: 41)]
		public LandingGearConditionData RetractCondition { get { return m_RetractCondition; } set { if (OnPropertyChanging("LandingGearLogicData." + nameof(RetractCondition), this, m_RetractCondition, value)) m_RetractCondition = value; } } // 0x8 (8)
		
		protected LandingGearConditionData m_DeployCondition = new LandingGearConditionData();
		[ContainerField(Name: "DeployCondition", Offset: 20, NameHash: 3008584093, Flags: 41)]
		public LandingGearConditionData DeployCondition { get { return m_DeployCondition; } set { if (OnPropertyChanging("LandingGearLogicData." + nameof(DeployCondition), this, m_DeployCondition, value)) m_DeployCondition = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 750548785:
					RetractCondition = (LandingGearConditionData) p_Value;
					break;

				case 3008584093:
					DeployCondition = (LandingGearConditionData) p_Value;
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
				case 750548785:
					return RetractCondition;

				case 3008584093:
					return DeployCondition;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 750548785:
					return typeof(LandingGearLogicData).GetProperty(nameof(RetractCondition));

				case 3008584093:
					return typeof(LandingGearLogicData).GetProperty(nameof(DeployCondition));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
