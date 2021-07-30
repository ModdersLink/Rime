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
	public class PlayerTakeOverTriggerEntityData : 
		GameEntityData
	{
		protected TeamId m_TeamId = new TeamId();
		[ContainerField(Name: "TeamId", Offset: 96, NameHash: 3220374101, Flags: 137)]
		public TeamId TeamId { get { return m_TeamId; } set { if (OnPropertyChanging("PlayerTakeOverTriggerEntityData." + nameof(TeamId), this, m_TeamId, value)) m_TeamId = value; } } // 0x60 (96)
		
		protected float m_TimeToLoseControl = new float();
		[ContainerField(Name: "TimeToLoseControl", Offset: 100, NameHash: 3830029753, Flags: 49469), LayoutImmutable, Blittable]
		public float TimeToLoseControl { get { return m_TimeToLoseControl; } set { if (OnPropertyChanging("PlayerTakeOverTriggerEntityData." + nameof(TimeToLoseControl), this, m_TimeToLoseControl, value)) m_TimeToLoseControl = value; } } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3220374101:
					TeamId = (TeamId) Enum.ToObject(typeof(TeamId), p_Value);
					break;

				case 3830029753:
					TimeToLoseControl = (float) p_Value;
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
				case 3220374101:
					return TeamId;

				case 3830029753:
					return TimeToLoseControl;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3220374101:
					return typeof(PlayerTakeOverTriggerEntityData).GetProperty(nameof(TeamId));

				case 3830029753:
					return typeof(PlayerTakeOverTriggerEntityData).GetProperty(nameof(TimeToLoseControl));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
