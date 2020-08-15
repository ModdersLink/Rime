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
	public class VehicleEntryListenerComponentData : 
		ComponentData
	{
		protected VehicleEntryListenerBinding m_VehicleEntryListener = new VehicleEntryListenerBinding();
		[ContainerField(96), ContainerFieldNameHash(1646308695)]
		public VehicleEntryListenerBinding VehicleEntryListener { get { return m_VehicleEntryListener; } set { if (OnPropertyChanging("VehicleEntryListenerComponentData." + nameof(VehicleEntryListener), this, m_VehicleEntryListener, value)) m_VehicleEntryListener = value; } } // 0x60 (96)
		
		protected VehicleCameraControlBinding m_VehicleCameraControl = new VehicleCameraControlBinding();
		[ContainerField(156), ContainerFieldNameHash(478775939)]
		public VehicleCameraControlBinding VehicleCameraControl { get { return m_VehicleCameraControl; } set { if (OnPropertyChanging("VehicleEntryListenerComponentData." + nameof(VehicleCameraControl), this, m_VehicleCameraControl, value)) m_VehicleCameraControl = value; } } // 0x9C (156)
		
		protected int m_AnimationEntitySpacePriority = new int();
		[ContainerField(160), LayoutImmutable, Blittable, ContainerFieldNameHash(4041607518)]
		public int AnimationEntitySpacePriority { get { return m_AnimationEntitySpacePriority; } set { if (OnPropertyChanging("VehicleEntryListenerComponentData." + nameof(AnimationEntitySpacePriority), this, m_AnimationEntitySpacePriority, value)) m_AnimationEntitySpacePriority = value; } } // 0xA0 (160)
		
		protected float m_AnimationWheelTransformDelay = new float();
		[ContainerField(164), LayoutImmutable, Blittable, ContainerFieldNameHash(2638640185)]
		public float AnimationWheelTransformDelay { get { return m_AnimationWheelTransformDelay; } set { if (OnPropertyChanging("VehicleEntryListenerComponentData." + nameof(AnimationWheelTransformDelay), this, m_AnimationWheelTransformDelay, value)) m_AnimationWheelTransformDelay = value; } } // 0xA4 (164)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1646308695:
					VehicleEntryListener = (VehicleEntryListenerBinding) p_Value;
					break;

				case 478775939:
					VehicleCameraControl = (VehicleCameraControlBinding) p_Value;
					break;

				case 4041607518:
					AnimationEntitySpacePriority = (int) p_Value;
					break;

				case 2638640185:
					AnimationWheelTransformDelay = (float) p_Value;
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
				case 1646308695:
					return VehicleEntryListener;

				case 478775939:
					return VehicleCameraControl;

				case 4041607518:
					return AnimationEntitySpacePriority;

				case 2638640185:
					return AnimationWheelTransformDelay;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1646308695:
					return typeof(VehicleEntryListenerComponentData).GetProperty(nameof(VehicleEntryListener));

				case 478775939:
					return typeof(VehicleEntryListenerComponentData).GetProperty(nameof(VehicleCameraControl));

				case 4041607518:
					return typeof(VehicleEntryListenerComponentData).GetProperty(nameof(AnimationEntitySpacePriority));

				case 2638640185:
					return typeof(VehicleEntryListenerComponentData).GetProperty(nameof(AnimationWheelTransformDelay));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
