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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 28)]
	public class RandomDelayEntityData : 
		EntityData
	{
		protected float m_MinDelay = new float();
		[ContainerField(Name: "MinDelay", Offset: 12, NameHash: 3350783098, Flags: 49469), LayoutImmutable, Blittable]
		public float MinDelay { get { return m_MinDelay; } set { if (OnPropertyChanging("RandomDelayEntityData." + nameof(MinDelay), this, m_MinDelay, value)) m_MinDelay = value; } } // 0xC (12)
		
		protected float m_MaxDelay = new float();
		[ContainerField(Name: "MaxDelay", Offset: 16, NameHash: 420379940, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxDelay { get { return m_MaxDelay; } set { if (OnPropertyChanging("RandomDelayEntityData." + nameof(MaxDelay), this, m_MaxDelay, value)) m_MaxDelay = value; } } // 0x10 (16)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 20, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("RandomDelayEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x14 (20)
		
		protected bool m_AutoStart = new bool();
		[ContainerField(Name: "AutoStart", Offset: 24, NameHash: 792615882, Flags: 49325), LayoutImmutable, Blittable]
		public bool AutoStart { get { return m_AutoStart; } set { if (OnPropertyChanging("RandomDelayEntityData." + nameof(AutoStart), this, m_AutoStart, value)) m_AutoStart = value; } } // 0x18 (24)
		
		protected bool m_RunOnce = new bool();
		[ContainerField(Name: "RunOnce", Offset: 25, NameHash: 709901739, Flags: 49325), LayoutImmutable, Blittable]
		public bool RunOnce { get { return m_RunOnce; } set { if (OnPropertyChanging("RandomDelayEntityData." + nameof(RunOnce), this, m_RunOnce, value)) m_RunOnce = value; } } // 0x19 (25)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3350783098:
					MinDelay = (float) p_Value;
					break;

				case 420379940:
					MaxDelay = (float) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 792615882:
					AutoStart = (bool) p_Value;
					break;

				case 709901739:
					RunOnce = (bool) p_Value;
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
				case 3350783098:
					return MinDelay;

				case 420379940:
					return MaxDelay;

				case 229961746:
					return Realm;

				case 792615882:
					return AutoStart;

				case 709901739:
					return RunOnce;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3350783098:
					return typeof(RandomDelayEntityData).GetProperty(nameof(MinDelay));

				case 420379940:
					return typeof(RandomDelayEntityData).GetProperty(nameof(MaxDelay));

				case 229961746:
					return typeof(RandomDelayEntityData).GetProperty(nameof(Realm));

				case 792615882:
					return typeof(RandomDelayEntityData).GetProperty(nameof(AutoStart));

				case 709901739:
					return typeof(RandomDelayEntityData).GetProperty(nameof(RunOnce));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
