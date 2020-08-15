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
	[ContainerType(4)]
	public class UIInteractionCompData : 
		UI3dIconCompData
	{
		protected float m_RepairSnapDistance = new float();
		[ContainerField(160), LayoutImmutable, Blittable, ContainerFieldNameHash(619854519)]
		public float RepairSnapDistance { get { return m_RepairSnapDistance; } set { if (OnPropertyChanging("UIInteractionCompData." + nameof(RepairSnapDistance), this, m_RepairSnapDistance, value)) m_RepairSnapDistance = value; } } // 0xA0 (160)
		
		protected bool m_RepairSnapCircle = new bool();
		[ContainerField(164), LayoutImmutable, Blittable, ContainerFieldNameHash(4082184934)]
		public bool RepairSnapCircle { get { return m_RepairSnapCircle; } set { if (OnPropertyChanging("UIInteractionCompData." + nameof(RepairSnapCircle), this, m_RepairSnapCircle, value)) m_RepairSnapCircle = value; } } // 0xA4 (164)
		
		protected bool m_PickupShrinkSnap = new bool();
		[ContainerField(165), LayoutImmutable, Blittable, ContainerFieldNameHash(1291739672)]
		public bool PickupShrinkSnap { get { return m_PickupShrinkSnap; } set { if (OnPropertyChanging("UIInteractionCompData." + nameof(PickupShrinkSnap), this, m_PickupShrinkSnap, value)) m_PickupShrinkSnap = value; } } // 0xA5 (165)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 619854519:
					RepairSnapDistance = (float) p_Value;
					break;

				case 4082184934:
					RepairSnapCircle = (bool) p_Value;
					break;

				case 1291739672:
					PickupShrinkSnap = (bool) p_Value;
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
				case 619854519:
					return RepairSnapDistance;

				case 4082184934:
					return RepairSnapCircle;

				case 1291739672:
					return PickupShrinkSnap;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 619854519:
					return typeof(UIInteractionCompData).GetProperty(nameof(RepairSnapDistance));

				case 4082184934:
					return typeof(UIInteractionCompData).GetProperty(nameof(RepairSnapCircle));

				case 1291739672:
					return typeof(UIInteractionCompData).GetProperty(nameof(PickupShrinkSnap));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
