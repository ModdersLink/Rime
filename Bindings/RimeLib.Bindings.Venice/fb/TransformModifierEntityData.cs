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
	public class TransformModifierEntityData : 
		EntityData
	{
		protected LinearTransform m_In = new LinearTransform();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(5862146)]
		public LinearTransform In { get { return m_In; } set { if (OnPropertyChanging("TransformModifierEntityData." + nameof(In), this, m_In, value)) m_In = value; } } // 0x10 (16)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(80), MemberInfoFlag(137), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("TransformModifierEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x50 (80)
		
		protected ModifierAxis m_Left = new ModifierAxis();
		[ContainerField(84), MemberInfoFlag(137), ContainerFieldNameHash(2089021886)]
		public ModifierAxis Left { get { return m_Left; } set { if (OnPropertyChanging("TransformModifierEntityData." + nameof(Left), this, m_Left, value)) m_Left = value; } } // 0x54 (84)
		
		protected ModifierAxis m_Up = new ModifierAxis();
		[ContainerField(88), MemberInfoFlag(137), ContainerFieldNameHash(5862272)]
		public ModifierAxis Up { get { return m_Up; } set { if (OnPropertyChanging("TransformModifierEntityData." + nameof(Up), this, m_Up, value)) m_Up = value; } } // 0x58 (88)
		
		protected ModifierAxis m_Forward = new ModifierAxis();
		[ContainerField(92), MemberInfoFlag(137), ContainerFieldNameHash(1986470206)]
		public ModifierAxis Forward { get { return m_Forward; } set { if (OnPropertyChanging("TransformModifierEntityData." + nameof(Forward), this, m_Forward, value)) m_Forward = value; } } // 0x5C (92)
		
		protected bool m_InvertLeft = new bool();
		[ContainerField(96), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3753810092)]
		public bool InvertLeft { get { return m_InvertLeft; } set { if (OnPropertyChanging("TransformModifierEntityData." + nameof(InvertLeft), this, m_InvertLeft, value)) m_InvertLeft = value; } } // 0x60 (96)
		
		protected bool m_InvertUp = new bool();
		[ContainerField(97), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(58661394)]
		public bool InvertUp { get { return m_InvertUp; } set { if (OnPropertyChanging("TransformModifierEntityData." + nameof(InvertUp), this, m_InvertUp, value)) m_InvertUp = value; } } // 0x61 (97)
		
		protected bool m_InvertForward = new bool();
		[ContainerField(98), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3827158252)]
		public bool InvertForward { get { return m_InvertForward; } set { if (OnPropertyChanging("TransformModifierEntityData." + nameof(InvertForward), this, m_InvertForward, value)) m_InvertForward = value; } } // 0x62 (98)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (LinearTransform) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 2089021886:
					Left = (ModifierAxis) Enum.ToObject(typeof(ModifierAxis), p_Value);
					break;

				case 5862272:
					Up = (ModifierAxis) Enum.ToObject(typeof(ModifierAxis), p_Value);
					break;

				case 1986470206:
					Forward = (ModifierAxis) Enum.ToObject(typeof(ModifierAxis), p_Value);
					break;

				case 3753810092:
					InvertLeft = (bool) p_Value;
					break;

				case 58661394:
					InvertUp = (bool) p_Value;
					break;

				case 3827158252:
					InvertForward = (bool) p_Value;
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
				case 5862146:
					return In;

				case 229961746:
					return Realm;

				case 2089021886:
					return Left;

				case 5862272:
					return Up;

				case 1986470206:
					return Forward;

				case 3753810092:
					return InvertLeft;

				case 58661394:
					return InvertUp;

				case 3827158252:
					return InvertForward;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(TransformModifierEntityData).GetProperty(nameof(In));

				case 229961746:
					return typeof(TransformModifierEntityData).GetProperty(nameof(Realm));

				case 2089021886:
					return typeof(TransformModifierEntityData).GetProperty(nameof(Left));

				case 5862272:
					return typeof(TransformModifierEntityData).GetProperty(nameof(Up));

				case 1986470206:
					return typeof(TransformModifierEntityData).GetProperty(nameof(Forward));

				case 3753810092:
					return typeof(TransformModifierEntityData).GetProperty(nameof(InvertLeft));

				case 58661394:
					return typeof(TransformModifierEntityData).GetProperty(nameof(InvertUp));

				case 3827158252:
					return typeof(TransformModifierEntityData).GetProperty(nameof(InvertForward));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
