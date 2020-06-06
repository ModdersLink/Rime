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
	public class SoundTestTransformTask : 
		SoundTestTaskSpec
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InitialPosition { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32)]
		public SoundTestTransformBehavior Behavior { get; set; } = new SoundTestTransformBehavior(); // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public bool RelativeListener { get; set; } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3791803234:
					InitialPosition = (Vec3) p_Value;
					break;

				case 1967808137:
					Behavior = (SoundTestTransformBehavior) Enum.ToObject(typeof(SoundTestTransformBehavior), p_Value);
					break;

				case 2476645295:
					RelativeListener = (bool) p_Value;
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
				case 3791803234:
					return InitialPosition;

				case 1967808137:
					return Behavior;

				case 2476645295:
					return RelativeListener;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3791803234:
					return typeof(SoundTestTransformTask).GetProperty(nameof(InitialPosition));

				case 1967808137:
					return typeof(SoundTestTransformTask).GetProperty(nameof(Behavior));

				case 2476645295:
					return typeof(SoundTestTransformTask).GetProperty(nameof(RelativeListener));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
