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
	[ContainerType(16)]
	public class JetEngineConfigData : 
		EngineConfigData
	{
		protected Vec2 m_PowerFadeOutRange = new Vec2();
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(4220367021)]
		public Vec2 PowerFadeOutRange { get { return m_PowerFadeOutRange; } set { if (OnPropertyChanging("JetEngineConfigData." + nameof(PowerFadeOutRange), this, m_PowerFadeOutRange, value)) m_PowerFadeOutRange = value; } } // 0x60 (96)
		
		protected float m_ForceMagnitudeMultiplier = new float();
		[ContainerField(104), LayoutImmutable, Blittable, ContainerFieldNameHash(3209574239)]
		public float ForceMagnitudeMultiplier { get { return m_ForceMagnitudeMultiplier; } set { if (OnPropertyChanging("JetEngineConfigData." + nameof(ForceMagnitudeMultiplier), this, m_ForceMagnitudeMultiplier, value)) m_ForceMagnitudeMultiplier = value; } } // 0x68 (104)
		
		protected float m_AngleInputYMultiplier = new float();
		[ContainerField(108), LayoutImmutable, Blittable, ContainerFieldNameHash(1243559936)]
		public float AngleInputYMultiplier { get { return m_AngleInputYMultiplier; } set { if (OnPropertyChanging("JetEngineConfigData." + nameof(AngleInputYMultiplier), this, m_AngleInputYMultiplier, value)) m_AngleInputYMultiplier = value; } } // 0x6C (108)
		
		protected float m_AngleInputPitchMultiplier = new float();
		[ContainerField(112), LayoutImmutable, Blittable, ContainerFieldNameHash(872926687)]
		public float AngleInputPitchMultiplier { get { return m_AngleInputPitchMultiplier; } set { if (OnPropertyChanging("JetEngineConfigData." + nameof(AngleInputPitchMultiplier), this, m_AngleInputPitchMultiplier, value)) m_AngleInputPitchMultiplier = value; } } // 0x70 (112)
		
		protected float m_MaxVelocity = new float();
		[ContainerField(116), LayoutImmutable, Blittable, ContainerFieldNameHash(81127366)]
		public float MaxVelocity { get { return m_MaxVelocity; } set { if (OnPropertyChanging("JetEngineConfigData." + nameof(MaxVelocity), this, m_MaxVelocity, value)) m_MaxVelocity = value; } } // 0x74 (116)
		
		protected uint m_DirectionVectorIndex = new uint();
		[ContainerField(120), LayoutImmutable, Blittable, ContainerFieldNameHash(3901228711)]
		public uint DirectionVectorIndex { get { return m_DirectionVectorIndex; } set { if (OnPropertyChanging("JetEngineConfigData." + nameof(DirectionVectorIndex), this, m_DirectionVectorIndex, value)) m_DirectionVectorIndex = value; } } // 0x78 (120)
		
		protected bool m_IsWaterJetEngine = new bool();
		[ContainerField(124), LayoutImmutable, Blittable, ContainerFieldNameHash(3093729791)]
		public bool IsWaterJetEngine { get { return m_IsWaterJetEngine; } set { if (OnPropertyChanging("JetEngineConfigData." + nameof(IsWaterJetEngine), this, m_IsWaterJetEngine, value)) m_IsWaterJetEngine = value; } } // 0x7C (124)
		
		protected bool m_IsTurnable = new bool();
		[ContainerField(125), LayoutImmutable, Blittable, ContainerFieldNameHash(2004357896)]
		public bool IsTurnable { get { return m_IsTurnable; } set { if (OnPropertyChanging("JetEngineConfigData." + nameof(IsTurnable), this, m_IsTurnable, value)) m_IsTurnable = value; } } // 0x7D (125)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4220367021:
					PowerFadeOutRange = (Vec2) p_Value;
					break;

				case 3209574239:
					ForceMagnitudeMultiplier = (float) p_Value;
					break;

				case 1243559936:
					AngleInputYMultiplier = (float) p_Value;
					break;

				case 872926687:
					AngleInputPitchMultiplier = (float) p_Value;
					break;

				case 81127366:
					MaxVelocity = (float) p_Value;
					break;

				case 3901228711:
					DirectionVectorIndex = (uint) p_Value;
					break;

				case 3093729791:
					IsWaterJetEngine = (bool) p_Value;
					break;

				case 2004357896:
					IsTurnable = (bool) p_Value;
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
				case 4220367021:
					return PowerFadeOutRange;

				case 3209574239:
					return ForceMagnitudeMultiplier;

				case 1243559936:
					return AngleInputYMultiplier;

				case 872926687:
					return AngleInputPitchMultiplier;

				case 81127366:
					return MaxVelocity;

				case 3901228711:
					return DirectionVectorIndex;

				case 3093729791:
					return IsWaterJetEngine;

				case 2004357896:
					return IsTurnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4220367021:
					return typeof(JetEngineConfigData).GetProperty(nameof(PowerFadeOutRange));

				case 3209574239:
					return typeof(JetEngineConfigData).GetProperty(nameof(ForceMagnitudeMultiplier));

				case 1243559936:
					return typeof(JetEngineConfigData).GetProperty(nameof(AngleInputYMultiplier));

				case 872926687:
					return typeof(JetEngineConfigData).GetProperty(nameof(AngleInputPitchMultiplier));

				case 81127366:
					return typeof(JetEngineConfigData).GetProperty(nameof(MaxVelocity));

				case 3901228711:
					return typeof(JetEngineConfigData).GetProperty(nameof(DirectionVectorIndex));

				case 3093729791:
					return typeof(JetEngineConfigData).GetProperty(nameof(IsWaterJetEngine));

				case 2004357896:
					return typeof(JetEngineConfigData).GetProperty(nameof(IsTurnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
