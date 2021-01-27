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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class TransformModifierEntityData : 
		EntityData
	{
		protected LinearTransform m_In = new LinearTransform();
		[ContainerField(Name: "In", Offset: 16, NameHash: 5862146, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform In { get { return m_In; } set { if (OnPropertyChanging("TransformModifierEntityData." + nameof(In), this, m_In, value)) m_In = value; } } // 0x10 (16)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 80, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("TransformModifierEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x50 (80)
		
		protected ModifierAxis m_Left = new ModifierAxis();
		[ContainerField(Name: "Left", Offset: 84, NameHash: 2089021886, Flags: 137)]
		public ModifierAxis Left { get { return m_Left; } set { if (OnPropertyChanging("TransformModifierEntityData." + nameof(Left), this, m_Left, value)) m_Left = value; } } // 0x54 (84)
		
		protected ModifierAxis m_Up = new ModifierAxis();
		[ContainerField(Name: "Up", Offset: 88, NameHash: 5862272, Flags: 137)]
		public ModifierAxis Up { get { return m_Up; } set { if (OnPropertyChanging("TransformModifierEntityData." + nameof(Up), this, m_Up, value)) m_Up = value; } } // 0x58 (88)
		
		protected ModifierAxis m_Forward = new ModifierAxis();
		[ContainerField(Name: "Forward", Offset: 92, NameHash: 1986470206, Flags: 137)]
		public ModifierAxis Forward { get { return m_Forward; } set { if (OnPropertyChanging("TransformModifierEntityData." + nameof(Forward), this, m_Forward, value)) m_Forward = value; } } // 0x5C (92)
		
		protected bool m_InvertLeft = new bool();
		[ContainerField(Name: "InvertLeft", Offset: 96, NameHash: 3753810092, Flags: 49325), LayoutImmutable, Blittable]
		public bool InvertLeft { get { return m_InvertLeft; } set { if (OnPropertyChanging("TransformModifierEntityData." + nameof(InvertLeft), this, m_InvertLeft, value)) m_InvertLeft = value; } } // 0x60 (96)
		
		protected bool m_InvertUp = new bool();
		[ContainerField(Name: "InvertUp", Offset: 97, NameHash: 58661394, Flags: 49325), LayoutImmutable, Blittable]
		public bool InvertUp { get { return m_InvertUp; } set { if (OnPropertyChanging("TransformModifierEntityData." + nameof(InvertUp), this, m_InvertUp, value)) m_InvertUp = value; } } // 0x61 (97)
		
		protected bool m_InvertForward = new bool();
		[ContainerField(Name: "InvertForward", Offset: 98, NameHash: 3827158252, Flags: 49325), LayoutImmutable, Blittable]
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
