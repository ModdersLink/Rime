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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 136)]
	public class PhysicsDrivenAnimationEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 12, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("PhysicsDrivenAnimationEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected PhysicsDrivenAnimationEntityBinding m_Binding = new PhysicsDrivenAnimationEntityBinding();
		[ContainerField(Name: "Binding", Offset: 16, NameHash: 2590060228, Flags: 41)]
		public PhysicsDrivenAnimationEntityBinding Binding { get { return m_Binding; } set { if (OnPropertyChanging("PhysicsDrivenAnimationEntityData." + nameof(Binding), this, m_Binding, value)) m_Binding = value; } } // 0x10 (16)
		
		protected int m_AnimationEntitySpacePriority = new int();
		[ContainerField(Name: "AnimationEntitySpacePriority", Offset: 132, NameHash: 4041607518, Flags: 49405), LayoutImmutable, Blittable]
		public int AnimationEntitySpacePriority { get { return m_AnimationEntitySpacePriority; } set { if (OnPropertyChanging("PhysicsDrivenAnimationEntityData." + nameof(AnimationEntitySpacePriority), this, m_AnimationEntitySpacePriority, value)) m_AnimationEntitySpacePriority = value; } } // 0x84 (132)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 2590060228:
					Binding = (PhysicsDrivenAnimationEntityBinding) p_Value;
					break;

				case 4041607518:
					AnimationEntitySpacePriority = (int) p_Value;
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

				case 2590060228:
					return Binding;

				case 4041607518:
					return AnimationEntitySpacePriority;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(PhysicsDrivenAnimationEntityData).GetProperty(nameof(Realm));

				case 2590060228:
					return typeof(PhysicsDrivenAnimationEntityData).GetProperty(nameof(Binding));

				case 4041607518:
					return typeof(PhysicsDrivenAnimationEntityData).GetProperty(nameof(AnimationEntitySpacePriority));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
