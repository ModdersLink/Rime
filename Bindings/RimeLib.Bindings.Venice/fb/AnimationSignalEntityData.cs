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
    [ContainerType(4)]
	public class AnimationSignalEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new Realm(); // 0xC (12)
		
		[ContainerField(16)]
		public AntRef Signal { get; set; } = new AntRef(); // 0x10 (16)
		
		[ContainerField(20)]
		public AntRef IntGameState { get; set; } = new AntRef(); // 0x14 (20)
		
		[ContainerField(24)]
		public AntRef FloatGameState { get; set; } = new AntRef(); // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public int ValueInt { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float ValueFloat { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public bool Reset { get; set; } // 0x24 (36)
		
		[ContainerField(37), LayoutImmutable, Blittable]
		public bool Continuous { get; set; } // 0x25 (37)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 3351504027:
					Signal = (AntRef) p_Value;
					break;

				case 1230275407:
					IntGameState = (AntRef) p_Value;
					break;

				case 4256423628:
					FloatGameState = (AntRef) p_Value;
					break;

				case 3291173693:
					ValueInt = (int) p_Value;
					break;

				case 2084221214:
					ValueFloat = (float) p_Value;
					break;

				case 229946160:
					Reset = (bool) p_Value;
					break;

				case 2748037352:
					Continuous = (bool) p_Value;
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

				case 3351504027:
					return Signal;

				case 1230275407:
					return IntGameState;

				case 4256423628:
					return FloatGameState;

				case 3291173693:
					return ValueInt;

				case 2084221214:
					return ValueFloat;

				case 229946160:
					return Reset;

				case 2748037352:
					return Continuous;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(AnimationSignalEntityData).GetProperty(nameof(Realm));

				case 3351504027:
					return typeof(AnimationSignalEntityData).GetProperty(nameof(Signal));

				case 1230275407:
					return typeof(AnimationSignalEntityData).GetProperty(nameof(IntGameState));

				case 4256423628:
					return typeof(AnimationSignalEntityData).GetProperty(nameof(FloatGameState));

				case 3291173693:
					return typeof(AnimationSignalEntityData).GetProperty(nameof(ValueInt));

				case 2084221214:
					return typeof(AnimationSignalEntityData).GetProperty(nameof(ValueFloat));

				case 229946160:
					return typeof(AnimationSignalEntityData).GetProperty(nameof(Reset));

				case 2748037352:
					return typeof(AnimationSignalEntityData).GetProperty(nameof(Continuous));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
