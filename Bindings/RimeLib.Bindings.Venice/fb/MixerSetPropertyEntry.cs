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
	[ContainerType(4)]
	public class MixerSetPropertyEntry : 
		AudioGraphNodePortGroup
	{
		protected AudioGraphNodePort m_In = new AudioGraphNodePort();
		[ContainerField(8), ContainerFieldNameHash(5862146)]
		public AudioGraphNodePort In { get { return m_In; } set { if (OnPropertyChanging("MixerSetPropertyEntry." + nameof(In), this, m_In, value)) m_In = value; } } // 0x8 (8)
		
		protected uint m_Target = new uint();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(3215022804)]
		public uint Target { get { return m_Target; } set { if (OnPropertyChanging("MixerSetPropertyEntry." + nameof(Target), this, m_Target, value)) m_Target = value; } } // 0x10 (16)
		
		protected CtrRef<MixGroup> m_Group = new CtrRef<MixGroup>();
		[ContainerField(20), ContainerFieldNameHash(208130522)]
		public CtrRef<MixGroup> Group { get { return m_Group; } set { if (OnPropertyChanging("MixerSetPropertyEntry." + nameof(Group), this, m_Group, value)) m_Group = value; } } // 0x14 (20)
		
		protected float m_AttackTime = new float();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(1150936440)]
		public float AttackTime { get { return m_AttackTime; } set { if (OnPropertyChanging("MixerSetPropertyEntry." + nameof(AttackTime), this, m_AttackTime, value)) m_AttackTime = value; } } // 0x18 (24)
		
		protected float m_ReleaseTime = new float();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(892319833)]
		public float ReleaseTime { get { return m_ReleaseTime; } set { if (OnPropertyChanging("MixerSetPropertyEntry." + nameof(ReleaseTime), this, m_ReleaseTime, value)) m_ReleaseTime = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (AudioGraphNodePort) p_Value;
					break;

				case 3215022804:
					Target = (uint) p_Value;
					break;

				case 208130522:
					Group = (CtrRef<MixGroup>) p_Value;
					break;

				case 1150936440:
					AttackTime = (float) p_Value;
					break;

				case 892319833:
					ReleaseTime = (float) p_Value;
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

				case 3215022804:
					return Target;

				case 208130522:
					return Group;

				case 1150936440:
					return AttackTime;

				case 892319833:
					return ReleaseTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(MixerSetPropertyEntry).GetProperty(nameof(In));

				case 3215022804:
					return typeof(MixerSetPropertyEntry).GetProperty(nameof(Target));

				case 208130522:
					return typeof(MixerSetPropertyEntry).GetProperty(nameof(Group));

				case 1150936440:
					return typeof(MixerSetPropertyEntry).GetProperty(nameof(AttackTime));

				case 892319833:
					return typeof(MixerSetPropertyEntry).GetProperty(nameof(ReleaseTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
