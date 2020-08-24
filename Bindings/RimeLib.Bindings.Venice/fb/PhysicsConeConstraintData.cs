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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class PhysicsConeConstraintData : 
		PhysicsConstraintData
	{
		protected float m_MinAngle = new float();
		[ContainerField(96), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3356124462)]
		public float MinAngle { get { return m_MinAngle; } set { if (OnPropertyChanging("PhysicsConeConstraintData." + nameof(MinAngle), this, m_MinAngle, value)) m_MinAngle = value; } } // 0x60 (96)
		
		protected float m_AngularFriction = new float();
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1552731461)]
		public float AngularFriction { get { return m_AngularFriction; } set { if (OnPropertyChanging("PhysicsConeConstraintData." + nameof(AngularFriction), this, m_AngularFriction, value)) m_AngularFriction = value; } } // 0x64 (100)
		
		protected float m_MaxAngle = new float();
		[ContainerField(104), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(417488496)]
		public float MaxAngle { get { return m_MaxAngle; } set { if (OnPropertyChanging("PhysicsConeConstraintData." + nameof(MaxAngle), this, m_MaxAngle, value)) m_MaxAngle = value; } } // 0x68 (104)
		
		protected bool m_HasLimits = new bool();
		[ContainerField(108), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2421583705)]
		public bool HasLimits { get { return m_HasLimits; } set { if (OnPropertyChanging("PhysicsConeConstraintData." + nameof(HasLimits), this, m_HasLimits, value)) m_HasLimits = value; } } // 0x6C (108)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3356124462:
					MinAngle = (float) p_Value;
					break;

				case 1552731461:
					AngularFriction = (float) p_Value;
					break;

				case 417488496:
					MaxAngle = (float) p_Value;
					break;

				case 2421583705:
					HasLimits = (bool) p_Value;
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
				case 3356124462:
					return MinAngle;

				case 1552731461:
					return AngularFriction;

				case 417488496:
					return MaxAngle;

				case 2421583705:
					return HasLimits;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3356124462:
					return typeof(PhysicsConeConstraintData).GetProperty(nameof(MinAngle));

				case 1552731461:
					return typeof(PhysicsConeConstraintData).GetProperty(nameof(AngularFriction));

				case 417488496:
					return typeof(PhysicsConeConstraintData).GetProperty(nameof(MaxAngle));

				case 2421583705:
					return typeof(PhysicsConeConstraintData).GetProperty(nameof(HasLimits));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
