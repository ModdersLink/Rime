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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(24), ContainerClass]
	public class RandomMultiEventEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(12), MemberInfoFlag(137), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("RandomMultiEventEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected List<float> m_RandomEventWeight = new List<float>();
		[ContainerField(16), MemberInfoFlag(65), ContainerFieldNameHash(2700434098), ContainerArray]
		public List<float> RandomEventWeight { get { return m_RandomEventWeight; } set { if (OnPropertyChanging("RandomMultiEventEntityData." + nameof(RandomEventWeight), this, m_RandomEventWeight, value)) m_RandomEventWeight = value; } } // 0x10 (16)
		
		protected bool m_UniformDistribution = new bool();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3070004891)]
		public bool UniformDistribution { get { return m_UniformDistribution; } set { if (OnPropertyChanging("RandomMultiEventEntityData." + nameof(UniformDistribution), this, m_UniformDistribution, value)) m_UniformDistribution = value; } } // 0x14 (20)
		
		protected bool m_ResetOutputsWhenAllHasTriggered = new bool();
		[ContainerField(21), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(386838442)]
		public bool ResetOutputsWhenAllHasTriggered { get { return m_ResetOutputsWhenAllHasTriggered; } set { if (OnPropertyChanging("RandomMultiEventEntityData." + nameof(ResetOutputsWhenAllHasTriggered), this, m_ResetOutputsWhenAllHasTriggered, value)) m_ResetOutputsWhenAllHasTriggered = value; } } // 0x15 (21)
		
		protected bool m_DisableOutputOnTrigger = new bool();
		[ContainerField(22), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1250184567)]
		public bool DisableOutputOnTrigger { get { return m_DisableOutputOnTrigger; } set { if (OnPropertyChanging("RandomMultiEventEntityData." + nameof(DisableOutputOnTrigger), this, m_DisableOutputOnTrigger, value)) m_DisableOutputOnTrigger = value; } } // 0x16 (22)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 2700434098:
					RandomEventWeight = (List<float>) p_Value;
					break;

				case 3070004891:
					UniformDistribution = (bool) p_Value;
					break;

				case 386838442:
					ResetOutputsWhenAllHasTriggered = (bool) p_Value;
					break;

				case 1250184567:
					DisableOutputOnTrigger = (bool) p_Value;
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

				case 2700434098:
					return RandomEventWeight;

				case 3070004891:
					return UniformDistribution;

				case 386838442:
					return ResetOutputsWhenAllHasTriggered;

				case 1250184567:
					return DisableOutputOnTrigger;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(RandomMultiEventEntityData).GetProperty(nameof(Realm));

				case 2700434098:
					return typeof(RandomMultiEventEntityData).GetProperty(nameof(RandomEventWeight));

				case 3070004891:
					return typeof(RandomMultiEventEntityData).GetProperty(nameof(UniformDistribution));

				case 386838442:
					return typeof(RandomMultiEventEntityData).GetProperty(nameof(ResetOutputsWhenAllHasTriggered));

				case 1250184567:
					return typeof(RandomMultiEventEntityData).GetProperty(nameof(DisableOutputOnTrigger));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
