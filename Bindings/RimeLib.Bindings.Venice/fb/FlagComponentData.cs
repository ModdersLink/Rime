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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class FlagComponentData : 
		ComponentData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 96, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("FlagComponentData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x60 (96)
		
		protected CtrRef<ObjectBlueprint> m_Flag_Team1 = new CtrRef<ObjectBlueprint>();
		[ContainerField(Name: "Flag_Team1", Offset: 100, NameHash: 1681649722, Flags: 53)]
		public CtrRef<ObjectBlueprint> Flag_Team1 { get { return m_Flag_Team1; } set { if (OnPropertyChanging("FlagComponentData." + nameof(Flag_Team1), this, m_Flag_Team1, value)) m_Flag_Team1 = value; } } // 0x64 (100)
		
		protected CtrRef<ObjectBlueprint> m_Flag_Team2 = new CtrRef<ObjectBlueprint>();
		[ContainerField(Name: "Flag_Team2", Offset: 104, NameHash: 1681649721, Flags: 53)]
		public CtrRef<ObjectBlueprint> Flag_Team2 { get { return m_Flag_Team2; } set { if (OnPropertyChanging("FlagComponentData." + nameof(Flag_Team2), this, m_Flag_Team2, value)) m_Flag_Team2 = value; } } // 0x68 (104)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 1681649722:
					Flag_Team1 = (CtrRef<ObjectBlueprint>) p_Value;
					break;

				case 1681649721:
					Flag_Team2 = (CtrRef<ObjectBlueprint>) p_Value;
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

				case 1681649722:
					return Flag_Team1;

				case 1681649721:
					return Flag_Team2;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(FlagComponentData).GetProperty(nameof(Realm));

				case 1681649722:
					return typeof(FlagComponentData).GetProperty(nameof(Flag_Team1));

				case 1681649721:
					return typeof(FlagComponentData).GetProperty(nameof(Flag_Team2));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
