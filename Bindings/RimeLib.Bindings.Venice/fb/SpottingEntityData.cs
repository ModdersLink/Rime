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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class SpottingEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 12, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("SpottingEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected TeamId m_TeamToSpot = new TeamId();
		[ContainerField(Name: "TeamToSpot", Offset: 16, NameHash: 2742848923, Flags: 137)]
		public TeamId TeamToSpot { get { return m_TeamToSpot; } set { if (OnPropertyChanging("SpottingEntityData." + nameof(TeamToSpot), this, m_TeamToSpot, value)) m_TeamToSpot = value; } } // 0x10 (16)
		
		protected bool m_Enabled = new bool();
		[ContainerField(Name: "Enabled", Offset: 20, NameHash: 2662400, Flags: 49325), LayoutImmutable, Blittable]
		public bool Enabled { get { return m_Enabled; } set { if (OnPropertyChanging("SpottingEntityData." + nameof(Enabled), this, m_Enabled, value)) m_Enabled = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 2742848923:
					TeamToSpot = (TeamId) Enum.ToObject(typeof(TeamId), p_Value);
					break;

				case 2662400:
					Enabled = (bool) p_Value;
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

				case 2742848923:
					return TeamToSpot;

				case 2662400:
					return Enabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(SpottingEntityData).GetProperty(nameof(Realm));

				case 2742848923:
					return typeof(SpottingEntityData).GetProperty(nameof(TeamToSpot));

				case 2662400:
					return typeof(SpottingEntityData).GetProperty(nameof(Enabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
