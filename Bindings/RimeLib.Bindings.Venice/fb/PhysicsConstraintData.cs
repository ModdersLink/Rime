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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 96)]
	public class PhysicsConstraintData : 
		GameObjectData
	{
		protected LinearTransform m_Transform = new LinearTransform();
		[ContainerField(Name: "Transform", Offset: 16, NameHash: 2270319721, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform Transform { get { return m_Transform; } set { if (OnPropertyChanging("PhysicsConstraintData." + nameof(Transform), this, m_Transform, value)) m_Transform = value; } } // 0x10 (16)
		
		protected CtrRef<ReferenceObjectData> m_ConstrainedObject = new CtrRef<ReferenceObjectData>();
		[ContainerField(Name: "ConstrainedObject", Offset: 80, NameHash: 1695224768, Flags: 53)]
		public CtrRef<ReferenceObjectData> ConstrainedObject { get { return m_ConstrainedObject; } set { if (OnPropertyChanging("PhysicsConstraintData." + nameof(ConstrainedObject), this, m_ConstrainedObject, value)) m_ConstrainedObject = value; } } // 0x50 (80)
		
		protected float m_BreakThreshold = new float();
		[ContainerField(Name: "BreakThreshold", Offset: 84, NameHash: 869561325, Flags: 49469), LayoutImmutable, Blittable]
		public float BreakThreshold { get { return m_BreakThreshold; } set { if (OnPropertyChanging("PhysicsConstraintData." + nameof(BreakThreshold), this, m_BreakThreshold, value)) m_BreakThreshold = value; } } // 0x54 (84)
		
		protected bool m_IsBreakable = new bool();
		[ContainerField(Name: "IsBreakable", Offset: 88, NameHash: 3764480426, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsBreakable { get { return m_IsBreakable; } set { if (OnPropertyChanging("PhysicsConstraintData." + nameof(IsBreakable), this, m_IsBreakable, value)) m_IsBreakable = value; } } // 0x58 (88)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2270319721:
					Transform = (LinearTransform) p_Value;
					break;

				case 1695224768:
					ConstrainedObject = (CtrRef<ReferenceObjectData>) p_Value;
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

				case 1695224768:
					return ConstrainedObject;

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
					return typeof(PhysicsConstraintData).GetProperty(nameof(Transform));

				case 1695224768:
					return typeof(PhysicsConstraintData).GetProperty(nameof(ConstrainedObject));

				case 869561325:
					return typeof(PhysicsConstraintData).GetProperty(nameof(BreakThreshold));

				case 3764480426:
					return typeof(PhysicsConstraintData).GetProperty(nameof(IsBreakable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
