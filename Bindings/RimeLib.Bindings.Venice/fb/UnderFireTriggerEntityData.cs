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
	public class UnderFireTriggerEntityData : 
		TriggerEntityData
	{
		protected float m_Radius = new float();
		[ContainerField(112), LayoutImmutable, Blittable, ContainerFieldNameHash(3298407133)]
		public float Radius { get { return m_Radius; } set { if (OnPropertyChanging("UnderFireTriggerEntityData." + nameof(Radius), this, m_Radius, value)) m_Radius = value; } } // 0x70 (112)
		
		protected float m_CoolDownTime = new float();
		[ContainerField(116), LayoutImmutable, Blittable, ContainerFieldNameHash(282296301)]
		public float CoolDownTime { get { return m_CoolDownTime; } set { if (OnPropertyChanging("UnderFireTriggerEntityData." + nameof(CoolDownTime), this, m_CoolDownTime, value)) m_CoolDownTime = value; } } // 0x74 (116)
		
		protected CtrRef<MaterialContainerPair> m_TriggerOnMaterialOnly = new CtrRef<MaterialContainerPair>();
		[ContainerField(120), ContainerFieldNameHash(3821487555)]
		public CtrRef<MaterialContainerPair> TriggerOnMaterialOnly { get { return m_TriggerOnMaterialOnly; } set { if (OnPropertyChanging("UnderFireTriggerEntityData." + nameof(TriggerOnMaterialOnly), this, m_TriggerOnMaterialOnly, value)) m_TriggerOnMaterialOnly = value; } } // 0x78 (120)
		
		protected AreaTriggerInclude m_TriggeredBy = new AreaTriggerInclude();
		[ContainerField(124), ContainerFieldNameHash(1020865575)]
		public AreaTriggerInclude TriggeredBy { get { return m_TriggeredBy; } set { if (OnPropertyChanging("UnderFireTriggerEntityData." + nameof(TriggeredBy), this, m_TriggeredBy, value)) m_TriggeredBy = value; } } // 0x7C (124)
		
		protected bool m_DisableIfTrackEntityIsLost = new bool();
		[ContainerField(128), LayoutImmutable, Blittable, ContainerFieldNameHash(1061491348)]
		public bool DisableIfTrackEntityIsLost { get { return m_DisableIfTrackEntityIsLost; } set { if (OnPropertyChanging("UnderFireTriggerEntityData." + nameof(DisableIfTrackEntityIsLost), this, m_DisableIfTrackEntityIsLost, value)) m_DisableIfTrackEntityIsLost = value; } } // 0x80 (128)
		
		protected bool m_RandomYaw = new bool();
		[ContainerField(129), LayoutImmutable, Blittable, ContainerFieldNameHash(1799468081)]
		public bool RandomYaw { get { return m_RandomYaw; } set { if (OnPropertyChanging("UnderFireTriggerEntityData." + nameof(RandomYaw), this, m_RandomYaw, value)) m_RandomYaw = value; } } // 0x81 (129)
		
		protected bool m_IndicateHit = new bool();
		[ContainerField(130), LayoutImmutable, Blittable, ContainerFieldNameHash(1494915465)]
		public bool IndicateHit { get { return m_IndicateHit; } set { if (OnPropertyChanging("UnderFireTriggerEntityData." + nameof(IndicateHit), this, m_IndicateHit, value)) m_IndicateHit = value; } } // 0x82 (130)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3298407133:
					Radius = (float) p_Value;
					break;

				case 282296301:
					CoolDownTime = (float) p_Value;
					break;

				case 3821487555:
					TriggerOnMaterialOnly = (CtrRef<MaterialContainerPair>) p_Value;
					break;

				case 1020865575:
					TriggeredBy = (AreaTriggerInclude) Enum.ToObject(typeof(AreaTriggerInclude), p_Value);
					break;

				case 1061491348:
					DisableIfTrackEntityIsLost = (bool) p_Value;
					break;

				case 1799468081:
					RandomYaw = (bool) p_Value;
					break;

				case 1494915465:
					IndicateHit = (bool) p_Value;
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
				case 3298407133:
					return Radius;

				case 282296301:
					return CoolDownTime;

				case 3821487555:
					return TriggerOnMaterialOnly;

				case 1020865575:
					return TriggeredBy;

				case 1061491348:
					return DisableIfTrackEntityIsLost;

				case 1799468081:
					return RandomYaw;

				case 1494915465:
					return IndicateHit;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3298407133:
					return typeof(UnderFireTriggerEntityData).GetProperty(nameof(Radius));

				case 282296301:
					return typeof(UnderFireTriggerEntityData).GetProperty(nameof(CoolDownTime));

				case 3821487555:
					return typeof(UnderFireTriggerEntityData).GetProperty(nameof(TriggerOnMaterialOnly));

				case 1020865575:
					return typeof(UnderFireTriggerEntityData).GetProperty(nameof(TriggeredBy));

				case 1061491348:
					return typeof(UnderFireTriggerEntityData).GetProperty(nameof(DisableIfTrackEntityIsLost));

				case 1799468081:
					return typeof(UnderFireTriggerEntityData).GetProperty(nameof(RandomYaw));

				case 1494915465:
					return typeof(UnderFireTriggerEntityData).GetProperty(nameof(IndicateHit));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
