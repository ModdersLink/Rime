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
	public class HumanPlayerEntityData : 
		GameEntityData
	{
		protected float m_PlayerKilledDelay = new float();
		[ContainerField(Name: "PlayerKilledDelay", Offset: 96, NameHash: 277093856, Flags: 49469), LayoutImmutable, Blittable]
		public float PlayerKilledDelay { get { return m_PlayerKilledDelay; } set { if (OnPropertyChanging("HumanPlayerEntityData." + nameof(PlayerKilledDelay), this, m_PlayerKilledDelay, value)) m_PlayerKilledDelay = value; } } // 0x60 (96)
		
		protected string m_LastManStandingSid = string.Empty;
		[ContainerField(Name: "LastManStandingSid", Offset: 100, NameHash: 1039359551, Flags: 16509), LayoutImmutable]
		public string LastManStandingSid { get { return m_LastManStandingSid; } set { if (OnPropertyChanging("HumanPlayerEntityData." + nameof(LastManStandingSid), this, m_LastManStandingSid, value)) m_LastManStandingSid = value; } } // 0x64 (100)
		
		protected float m_DisplayTime = new float();
		[ContainerField(Name: "DisplayTime", Offset: 104, NameHash: 1925139498, Flags: 49469), LayoutImmutable, Blittable]
		public float DisplayTime { get { return m_DisplayTime; } set { if (OnPropertyChanging("HumanPlayerEntityData." + nameof(DisplayTime), this, m_DisplayTime, value)) m_DisplayTime = value; } } // 0x68 (104)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 277093856:
					PlayerKilledDelay = (float) p_Value;
					break;

				case 1039359551:
					LastManStandingSid = (string) p_Value;
					break;

				case 1925139498:
					DisplayTime = (float) p_Value;
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
				case 277093856:
					return PlayerKilledDelay;

				case 1039359551:
					return LastManStandingSid;

				case 1925139498:
					return DisplayTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 277093856:
					return typeof(HumanPlayerEntityData).GetProperty(nameof(PlayerKilledDelay));

				case 1039359551:
					return typeof(HumanPlayerEntityData).GetProperty(nameof(LastManStandingSid));

				case 1925139498:
					return typeof(HumanPlayerEntityData).GetProperty(nameof(DisplayTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
