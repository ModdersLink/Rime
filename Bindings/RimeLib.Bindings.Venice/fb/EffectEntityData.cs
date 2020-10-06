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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(112), ContainerClass]
	public class EffectEntityData : 
		SpatialEntityData
	{
		protected RefArray<GameObjectData> m_Components = new RefArray<GameObjectData>();
		[ContainerField(80), MemberInfoFlag(65), ContainerFieldNameHash(3391050425), ContainerRefArray]
		public RefArray<GameObjectData> Components { get { return m_Components; } set { if (OnPropertyChanging("EffectEntityData." + nameof(Components), this, m_Components, value)) m_Components = value; } } // 0x50 (80)
		
		protected uint m_MaxInstanceCount = new uint();
		[ContainerField(84), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3587631771)]
		public uint MaxInstanceCount { get { return m_MaxInstanceCount; } set { if (OnPropertyChanging("EffectEntityData." + nameof(MaxInstanceCount), this, m_MaxInstanceCount, value)) m_MaxInstanceCount = value; } } // 0x54 (84)
		
		protected float m_CullDistance = new float();
		[ContainerField(88), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1000432400)]
		public float CullDistance { get { return m_CullDistance; } set { if (OnPropertyChanging("EffectEntityData." + nameof(CullDistance), this, m_CullDistance, value)) m_CullDistance = value; } } // 0x58 (88)
		
		protected float m_StartDelay = new float();
		[ContainerField(92), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2731915920)]
		public float StartDelay { get { return m_StartDelay; } set { if (OnPropertyChanging("EffectEntityData." + nameof(StartDelay), this, m_StartDelay, value)) m_StartDelay = value; } } // 0x5C (92)
		
		protected bool m_HighEndPc = new bool();
		[ContainerField(96), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(47851991)]
		public bool HighEndPc { get { return m_HighEndPc; } set { if (OnPropertyChanging("EffectEntityData." + nameof(HighEndPc), this, m_HighEndPc, value)) m_HighEndPc = value; } } // 0x60 (96)
		
		protected bool m_MediumPc = new bool();
		[ContainerField(97), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(773886027)]
		public bool MediumPc { get { return m_MediumPc; } set { if (OnPropertyChanging("EffectEntityData." + nameof(MediumPc), this, m_MediumPc, value)) m_MediumPc = value; } } // 0x61 (97)
		
		protected bool m_LowEndPc = new bool();
		[ContainerField(98), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2485938765)]
		public bool LowEndPc { get { return m_LowEndPc; } set { if (OnPropertyChanging("EffectEntityData." + nameof(LowEndPc), this, m_LowEndPc, value)) m_LowEndPc = value; } } // 0x62 (98)
		
		protected bool m_ResetInstanceWhenStarted = new bool();
		[ContainerField(99), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1039558380)]
		public bool ResetInstanceWhenStarted { get { return m_ResetInstanceWhenStarted; } set { if (OnPropertyChanging("EffectEntityData." + nameof(ResetInstanceWhenStarted), this, m_ResetInstanceWhenStarted, value)) m_ResetInstanceWhenStarted = value; } } // 0x63 (99)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3391050425:
					Components = (RefArray<GameObjectData>) p_Value;
					break;

				case 3587631771:
					MaxInstanceCount = (uint) p_Value;
					break;

				case 1000432400:
					CullDistance = (float) p_Value;
					break;

				case 2731915920:
					StartDelay = (float) p_Value;
					break;

				case 47851991:
					HighEndPc = (bool) p_Value;
					break;

				case 773886027:
					MediumPc = (bool) p_Value;
					break;

				case 2485938765:
					LowEndPc = (bool) p_Value;
					break;

				case 1039558380:
					ResetInstanceWhenStarted = (bool) p_Value;
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
				case 3391050425:
					return Components;

				case 3587631771:
					return MaxInstanceCount;

				case 1000432400:
					return CullDistance;

				case 2731915920:
					return StartDelay;

				case 47851991:
					return HighEndPc;

				case 773886027:
					return MediumPc;

				case 2485938765:
					return LowEndPc;

				case 1039558380:
					return ResetInstanceWhenStarted;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3391050425:
					return typeof(EffectEntityData).GetProperty(nameof(Components));

				case 3587631771:
					return typeof(EffectEntityData).GetProperty(nameof(MaxInstanceCount));

				case 1000432400:
					return typeof(EffectEntityData).GetProperty(nameof(CullDistance));

				case 2731915920:
					return typeof(EffectEntityData).GetProperty(nameof(StartDelay));

				case 47851991:
					return typeof(EffectEntityData).GetProperty(nameof(HighEndPc));

				case 773886027:
					return typeof(EffectEntityData).GetProperty(nameof(MediumPc));

				case 2485938765:
					return typeof(EffectEntityData).GetProperty(nameof(LowEndPc));

				case 1039558380:
					return typeof(EffectEntityData).GetProperty(nameof(ResetInstanceWhenStarted));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
