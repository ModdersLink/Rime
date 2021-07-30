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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 48)]
	public class SoundTestTransformTask : 
		SoundTestTaskSpec
	{
		protected Vec3 m_InitialPosition = new Vec3();
		[ContainerField(Name: "InitialPosition", Offset: 16, NameHash: 3791803234, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InitialPosition { get { return m_InitialPosition; } set { if (OnPropertyChanging("SoundTestTransformTask." + nameof(InitialPosition), this, m_InitialPosition, value)) m_InitialPosition = value; } } // 0x10 (16)
		
		protected SoundTestTransformBehavior m_Behavior = new SoundTestTransformBehavior();
		[ContainerField(Name: "Behavior", Offset: 32, NameHash: 1967808137, Flags: 137)]
		public SoundTestTransformBehavior Behavior { get { return m_Behavior; } set { if (OnPropertyChanging("SoundTestTransformTask." + nameof(Behavior), this, m_Behavior, value)) m_Behavior = value; } } // 0x20 (32)
		
		protected bool m_RelativeListener = new bool();
		[ContainerField(Name: "RelativeListener", Offset: 36, NameHash: 2476645295, Flags: 49325), LayoutImmutable, Blittable]
		public bool RelativeListener { get { return m_RelativeListener; } set { if (OnPropertyChanging("SoundTestTransformTask." + nameof(RelativeListener), this, m_RelativeListener, value)) m_RelativeListener = value; } } // 0x24 (36)
		
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
