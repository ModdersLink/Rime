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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 28)]
	public class StopWatchEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 12, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("StopWatchEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected UpdatePass m_UpdatePass = new UpdatePass();
		[ContainerField(Name: "UpdatePass", Offset: 16, NameHash: 2270785669, Flags: 137)]
		public UpdatePass UpdatePass { get { return m_UpdatePass; } set { if (OnPropertyChanging("StopWatchEntityData." + nameof(UpdatePass), this, m_UpdatePass, value)) m_UpdatePass = value; } } // 0x10 (16)
		
		protected float m_Multiplier = new float();
		[ContainerField(Name: "Multiplier", Offset: 20, NameHash: 2037512782, Flags: 49469), LayoutImmutable, Blittable]
		public float Multiplier { get { return m_Multiplier; } set { if (OnPropertyChanging("StopWatchEntityData." + nameof(Multiplier), this, m_Multiplier, value)) m_Multiplier = value; } } // 0x14 (20)
		
		protected float m_TriggerOnTime = new float();
		[ContainerField(Name: "TriggerOnTime", Offset: 24, NameHash: 2068878889, Flags: 49469), LayoutImmutable, Blittable]
		public float TriggerOnTime { get { return m_TriggerOnTime; } set { if (OnPropertyChanging("StopWatchEntityData." + nameof(TriggerOnTime), this, m_TriggerOnTime, value)) m_TriggerOnTime = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 2270785669:
					UpdatePass = (UpdatePass) Enum.ToObject(typeof(UpdatePass), p_Value);
					break;

				case 2037512782:
					Multiplier = (float) p_Value;
					break;

				case 2068878889:
					TriggerOnTime = (float) p_Value;
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

				case 2270785669:
					return UpdatePass;

				case 2037512782:
					return Multiplier;

				case 2068878889:
					return TriggerOnTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(StopWatchEntityData).GetProperty(nameof(Realm));

				case 2270785669:
					return typeof(StopWatchEntityData).GetProperty(nameof(UpdatePass));

				case 2037512782:
					return typeof(StopWatchEntityData).GetProperty(nameof(Multiplier));

				case 2068878889:
					return typeof(StopWatchEntityData).GetProperty(nameof(TriggerOnTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
