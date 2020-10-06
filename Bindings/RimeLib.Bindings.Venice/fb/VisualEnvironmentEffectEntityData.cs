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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(176), ContainerClass]
	public class VisualEnvironmentEffectEntityData : 
		EffectEntityData
	{
		protected Vec4 m_LifetimeCurve = new Vec4();
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(1623248993)]
		public Vec4 LifetimeCurve { get { return m_LifetimeCurve; } set { if (OnPropertyChanging("VisualEnvironmentEffectEntityData." + nameof(LifetimeCurve), this, m_LifetimeCurve, value)) m_LifetimeCurve = value; } } // 0x70 (112)
		
		protected Vec4 m_CullDistanceCurve = new Vec4();
		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(3239208743)]
		public Vec4 CullDistanceCurve { get { return m_CullDistanceCurve; } set { if (OnPropertyChanging("VisualEnvironmentEffectEntityData." + nameof(CullDistanceCurve), this, m_CullDistanceCurve, value)) m_CullDistanceCurve = value; } } // 0x80 (128)
		
		protected Vec4 m_CullAngleCurve = new Vec4();
		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(3589421957)]
		public Vec4 CullAngleCurve { get { return m_CullAngleCurve; } set { if (OnPropertyChanging("VisualEnvironmentEffectEntityData." + nameof(CullAngleCurve), this, m_CullAngleCurve, value)) m_CullAngleCurve = value; } } // 0x90 (144)
		
		protected float m_Lifetime = new float();
		[ContainerField(160), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2450521238)]
		public float Lifetime { get { return m_Lifetime; } set { if (OnPropertyChanging("VisualEnvironmentEffectEntityData." + nameof(Lifetime), this, m_Lifetime, value)) m_Lifetime = value; } } // 0xA0 (160)
		
		protected CtrRef<VisualEnvironmentBlueprint> m_VisualEnvironment = new CtrRef<VisualEnvironmentBlueprint>();
		[ContainerField(164), MemberInfoFlag(53), ContainerFieldNameHash(1724714788), ContainerCtrRef]
		public CtrRef<VisualEnvironmentBlueprint> VisualEnvironment { get { return m_VisualEnvironment; } set { if (OnPropertyChanging("VisualEnvironmentEffectEntityData." + nameof(VisualEnvironment), this, m_VisualEnvironment, value)) m_VisualEnvironment = value; } } // 0xA4 (164)
		
		protected bool m_SampleOnStartOnly = new bool();
		[ContainerField(168), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3530277558)]
		public bool SampleOnStartOnly { get { return m_SampleOnStartOnly; } set { if (OnPropertyChanging("VisualEnvironmentEffectEntityData." + nameof(SampleOnStartOnly), this, m_SampleOnStartOnly, value)) m_SampleOnStartOnly = value; } } // 0xA8 (168)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1623248993:
					LifetimeCurve = (Vec4) p_Value;
					break;

				case 3239208743:
					CullDistanceCurve = (Vec4) p_Value;
					break;

				case 3589421957:
					CullAngleCurve = (Vec4) p_Value;
					break;

				case 2450521238:
					Lifetime = (float) p_Value;
					break;

				case 1724714788:
					VisualEnvironment = (CtrRef<VisualEnvironmentBlueprint>) p_Value;
					break;

				case 3530277558:
					SampleOnStartOnly = (bool) p_Value;
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
				case 1623248993:
					return LifetimeCurve;

				case 3239208743:
					return CullDistanceCurve;

				case 3589421957:
					return CullAngleCurve;

				case 2450521238:
					return Lifetime;

				case 1724714788:
					return VisualEnvironment;

				case 3530277558:
					return SampleOnStartOnly;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1623248993:
					return typeof(VisualEnvironmentEffectEntityData).GetProperty(nameof(LifetimeCurve));

				case 3239208743:
					return typeof(VisualEnvironmentEffectEntityData).GetProperty(nameof(CullDistanceCurve));

				case 3589421957:
					return typeof(VisualEnvironmentEffectEntityData).GetProperty(nameof(CullAngleCurve));

				case 2450521238:
					return typeof(VisualEnvironmentEffectEntityData).GetProperty(nameof(Lifetime));

				case 1724714788:
					return typeof(VisualEnvironmentEffectEntityData).GetProperty(nameof(VisualEnvironment));

				case 3530277558:
					return typeof(VisualEnvironmentEffectEntityData).GetProperty(nameof(SampleOnStartOnly));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
