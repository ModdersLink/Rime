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
	public class SlowMotionEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(12), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("SlowMotionEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected float m_TimeScale = new float();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(169511528)]
		public float TimeScale { get { return m_TimeScale; } set { if (OnPropertyChanging("SlowMotionEntityData." + nameof(TimeScale), this, m_TimeScale, value)) m_TimeScale = value; } } // 0x10 (16)
		
		protected float m_ScaleDownTransitionTime = new float();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(3146782549)]
		public float ScaleDownTransitionTime { get { return m_ScaleDownTransitionTime; } set { if (OnPropertyChanging("SlowMotionEntityData." + nameof(ScaleDownTransitionTime), this, m_ScaleDownTransitionTime, value)) m_ScaleDownTransitionTime = value; } } // 0x14 (20)
		
		protected float m_ScaleUpTransitionTime = new float();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(877920322)]
		public float ScaleUpTransitionTime { get { return m_ScaleUpTransitionTime; } set { if (OnPropertyChanging("SlowMotionEntityData." + nameof(ScaleUpTransitionTime), this, m_ScaleUpTransitionTime, value)) m_ScaleUpTransitionTime = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 169511528:
					TimeScale = (float) p_Value;
					break;

				case 3146782549:
					ScaleDownTransitionTime = (float) p_Value;
					break;

				case 877920322:
					ScaleUpTransitionTime = (float) p_Value;
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
				case 229961746:
					return Realm;

				case 169511528:
					return TimeScale;

				case 3146782549:
					return ScaleDownTransitionTime;

				case 877920322:
					return ScaleUpTransitionTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(SlowMotionEntityData).GetProperty(nameof(Realm));

				case 169511528:
					return typeof(SlowMotionEntityData).GetProperty(nameof(TimeScale));

				case 3146782549:
					return typeof(SlowMotionEntityData).GetProperty(nameof(ScaleDownTransitionTime));

				case 877920322:
					return typeof(SlowMotionEntityData).GetProperty(nameof(ScaleUpTransitionTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
