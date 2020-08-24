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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class AnimationSignalEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(12), MemberInfoFlag(137), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("AnimationSignalEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected AntRef m_Signal = new AntRef();
		[ContainerField(16), MemberInfoFlag(41), ContainerFieldNameHash(3351504027)]
		public AntRef Signal { get { return m_Signal; } set { if (OnPropertyChanging("AnimationSignalEntityData." + nameof(Signal), this, m_Signal, value)) m_Signal = value; } } // 0x10 (16)
		
		protected AntRef m_IntGameState = new AntRef();
		[ContainerField(20), MemberInfoFlag(41), ContainerFieldNameHash(1230275407)]
		public AntRef IntGameState { get { return m_IntGameState; } set { if (OnPropertyChanging("AnimationSignalEntityData." + nameof(IntGameState), this, m_IntGameState, value)) m_IntGameState = value; } } // 0x14 (20)
		
		protected AntRef m_FloatGameState = new AntRef();
		[ContainerField(24), MemberInfoFlag(41), ContainerFieldNameHash(4256423628)]
		public AntRef FloatGameState { get { return m_FloatGameState; } set { if (OnPropertyChanging("AnimationSignalEntityData." + nameof(FloatGameState), this, m_FloatGameState, value)) m_FloatGameState = value; } } // 0x18 (24)
		
		protected int m_ValueInt = new int();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3291173693)]
		public int ValueInt { get { return m_ValueInt; } set { if (OnPropertyChanging("AnimationSignalEntityData." + nameof(ValueInt), this, m_ValueInt, value)) m_ValueInt = value; } } // 0x1C (28)
		
		protected float m_ValueFloat = new float();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2084221214)]
		public float ValueFloat { get { return m_ValueFloat; } set { if (OnPropertyChanging("AnimationSignalEntityData." + nameof(ValueFloat), this, m_ValueFloat, value)) m_ValueFloat = value; } } // 0x20 (32)
		
		protected bool m_Reset = new bool();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(229946160)]
		public bool Reset { get { return m_Reset; } set { if (OnPropertyChanging("AnimationSignalEntityData." + nameof(Reset), this, m_Reset, value)) m_Reset = value; } } // 0x24 (36)
		
		protected bool m_Continuous = new bool();
		[ContainerField(37), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2748037352)]
		public bool Continuous { get { return m_Continuous; } set { if (OnPropertyChanging("AnimationSignalEntityData." + nameof(Continuous), this, m_Continuous, value)) m_Continuous = value; } } // 0x25 (37)
		
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
