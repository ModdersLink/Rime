///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class TransformModifierEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform In { get; set; } = new LinearTransform(); // 0x10 (16)
		
		[ContainerField(80)]
		public Realm Realm { get; set; } = new Realm(); // 0x50 (80)
		
		[ContainerField(84)]
		public ModifierAxis Left { get; set; } = new ModifierAxis(); // 0x54 (84)
		
		[ContainerField(88)]
		public ModifierAxis Up { get; set; } = new ModifierAxis(); // 0x58 (88)
		
		[ContainerField(92)]
		public ModifierAxis Forward { get; set; } = new ModifierAxis(); // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public bool InvertLeft { get; set; } // 0x60 (96)
		
		[ContainerField(97), LayoutImmutable, Blittable]
		public bool InvertUp { get; set; } // 0x61 (97)
		
		[ContainerField(98), LayoutImmutable, Blittable]
		public bool InvertForward { get; set; } // 0x62 (98)
		
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
