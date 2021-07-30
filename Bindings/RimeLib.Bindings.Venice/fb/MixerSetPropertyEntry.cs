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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 32)]
	public class MixerSetPropertyEntry : 
		AudioGraphNodePortGroup
	{
		protected AudioGraphNodePort m_In = new AudioGraphNodePort();
		[ContainerField(Name: "In", Offset: 8, NameHash: 5862146, Flags: 41)]
		public AudioGraphNodePort In { get { return m_In; } set { if (OnPropertyChanging("MixerSetPropertyEntry." + nameof(In), this, m_In, value)) m_In = value; } } // 0x8 (8)
		
		protected uint m_Target = new uint();
		[ContainerField(Name: "Target", Offset: 16, NameHash: 3215022804, Flags: 49421), LayoutImmutable, Blittable]
		public uint Target { get { return m_Target; } set { if (OnPropertyChanging("MixerSetPropertyEntry." + nameof(Target), this, m_Target, value)) m_Target = value; } } // 0x10 (16)
		
		protected CtrRef<MixGroup> m_Group = new CtrRef<MixGroup>();
		[ContainerField(Name: "Group", Offset: 20, NameHash: 208130522, Flags: 53)]
		public CtrRef<MixGroup> Group { get { return m_Group; } set { if (OnPropertyChanging("MixerSetPropertyEntry." + nameof(Group), this, m_Group, value)) m_Group = value; } } // 0x14 (20)
		
		protected float m_AttackTime = new float();
		[ContainerField(Name: "AttackTime", Offset: 24, NameHash: 1150936440, Flags: 49469), LayoutImmutable, Blittable]
		public float AttackTime { get { return m_AttackTime; } set { if (OnPropertyChanging("MixerSetPropertyEntry." + nameof(AttackTime), this, m_AttackTime, value)) m_AttackTime = value; } } // 0x18 (24)
		
		protected float m_ReleaseTime = new float();
		[ContainerField(Name: "ReleaseTime", Offset: 28, NameHash: 892319833, Flags: 49469), LayoutImmutable, Blittable]
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
