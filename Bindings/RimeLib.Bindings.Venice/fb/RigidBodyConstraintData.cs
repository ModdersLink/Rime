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
	public class RigidBodyConstraintData : 
		GameObjectData
	{
		protected LinearTransform m_Transform = new LinearTransform();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(2270319721)]
		public LinearTransform Transform { get { return m_Transform; } set { if (OnPropertyChanging("RigidBodyConstraintData." + nameof(Transform), this, m_Transform, value)) m_Transform = value; } } // 0x10 (16)
		
		protected CtrRef<RigidBodyData> m_ParentBody = new CtrRef<RigidBodyData>();
		[ContainerField(80), ContainerFieldNameHash(2813534665)]
		public CtrRef<RigidBodyData> ParentBody { get { return m_ParentBody; } set { if (OnPropertyChanging("RigidBodyConstraintData." + nameof(ParentBody), this, m_ParentBody, value)) m_ParentBody = value; } } // 0x50 (80)
		
		protected float m_BreakThreshold = new float();
		[ContainerField(84), LayoutImmutable, Blittable, ContainerFieldNameHash(869561325)]
		public float BreakThreshold { get { return m_BreakThreshold; } set { if (OnPropertyChanging("RigidBodyConstraintData." + nameof(BreakThreshold), this, m_BreakThreshold, value)) m_BreakThreshold = value; } } // 0x54 (84)
		
		protected bool m_IsBreakable = new bool();
		[ContainerField(88), LayoutImmutable, Blittable, ContainerFieldNameHash(3764480426)]
		public bool IsBreakable { get { return m_IsBreakable; } set { if (OnPropertyChanging("RigidBodyConstraintData." + nameof(IsBreakable), this, m_IsBreakable, value)) m_IsBreakable = value; } } // 0x58 (88)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2270319721:
					Transform = (LinearTransform) p_Value;
					break;

				case 2813534665:
					ParentBody = (CtrRef<RigidBodyData>) p_Value;
					break;

				case 869561325:
					BreakThreshold = (float) p_Value;
					break;

				case 3764480426:
					IsBreakable = (bool) p_Value;
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
				case 2270319721:
					return Transform;

				case 2813534665:
					return ParentBody;

				case 869561325:
					return BreakThreshold;

				case 3764480426:
					return IsBreakable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2270319721:
					return typeof(RigidBodyConstraintData).GetProperty(nameof(Transform));

				case 2813534665:
					return typeof(RigidBodyConstraintData).GetProperty(nameof(ParentBody));

				case 869561325:
					return typeof(RigidBodyConstraintData).GetProperty(nameof(BreakThreshold));

				case 3764480426:
					return typeof(RigidBodyConstraintData).GetProperty(nameof(IsBreakable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
