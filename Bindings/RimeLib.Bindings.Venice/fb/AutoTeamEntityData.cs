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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(112), ContainerClass]
	public class AutoTeamEntityData : 
		GameEntityData
	{
		protected uint m_TeamDifferenceToAutoBalance = new uint();
		[ContainerField(96), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(113977021)]
		public uint TeamDifferenceToAutoBalance { get { return m_TeamDifferenceToAutoBalance; } set { if (OnPropertyChanging("AutoTeamEntityData." + nameof(TeamDifferenceToAutoBalance), this, m_TeamDifferenceToAutoBalance, value)) m_TeamDifferenceToAutoBalance = value; } } // 0x60 (96)
		
		protected TeamAssignMode m_TeamAssignMode = new TeamAssignMode();
		[ContainerField(100), MemberInfoFlag(137), ContainerFieldNameHash(3887289498)]
		public TeamAssignMode TeamAssignMode { get { return m_TeamAssignMode; } set { if (OnPropertyChanging("AutoTeamEntityData." + nameof(TeamAssignMode), this, m_TeamAssignMode, value)) m_TeamAssignMode = value; } } // 0x64 (100)
		
		protected uint m_PlayerCountNeededToAutoBalance = new uint();
		[ContainerField(104), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(84550380)]
		public uint PlayerCountNeededToAutoBalance { get { return m_PlayerCountNeededToAutoBalance; } set { if (OnPropertyChanging("AutoTeamEntityData." + nameof(PlayerCountNeededToAutoBalance), this, m_PlayerCountNeededToAutoBalance, value)) m_PlayerCountNeededToAutoBalance = value; } } // 0x68 (104)
		
		protected bool m_ForceIntoSquad = new bool();
		[ContainerField(108), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1527339574)]
		public bool ForceIntoSquad { get { return m_ForceIntoSquad; } set { if (OnPropertyChanging("AutoTeamEntityData." + nameof(ForceIntoSquad), this, m_ForceIntoSquad, value)) m_ForceIntoSquad = value; } } // 0x6C (108)
		
		protected bool m_RotateTeamOnNewRound = new bool();
		[ContainerField(109), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3788125566)]
		public bool RotateTeamOnNewRound { get { return m_RotateTeamOnNewRound; } set { if (OnPropertyChanging("AutoTeamEntityData." + nameof(RotateTeamOnNewRound), this, m_RotateTeamOnNewRound, value)) m_RotateTeamOnNewRound = value; } } // 0x6D (109)
		
		protected bool m_AutoBalance = new bool();
		[ContainerField(110), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2626919340)]
		public bool AutoBalance { get { return m_AutoBalance; } set { if (OnPropertyChanging("AutoTeamEntityData." + nameof(AutoBalance), this, m_AutoBalance, value)) m_AutoBalance = value; } } // 0x6E (110)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 113977021:
					TeamDifferenceToAutoBalance = (uint) p_Value;
					break;

				case 3887289498:
					TeamAssignMode = (TeamAssignMode) Enum.ToObject(typeof(TeamAssignMode), p_Value);
					break;

				case 84550380:
					PlayerCountNeededToAutoBalance = (uint) p_Value;
					break;

				case 1527339574:
					ForceIntoSquad = (bool) p_Value;
					break;

				case 3788125566:
					RotateTeamOnNewRound = (bool) p_Value;
					break;

				case 2626919340:
					AutoBalance = (bool) p_Value;
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
				case 113977021:
					return TeamDifferenceToAutoBalance;

				case 3887289498:
					return TeamAssignMode;

				case 84550380:
					return PlayerCountNeededToAutoBalance;

				case 1527339574:
					return ForceIntoSquad;

				case 3788125566:
					return RotateTeamOnNewRound;

				case 2626919340:
					return AutoBalance;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 113977021:
					return typeof(AutoTeamEntityData).GetProperty(nameof(TeamDifferenceToAutoBalance));

				case 3887289498:
					return typeof(AutoTeamEntityData).GetProperty(nameof(TeamAssignMode));

				case 84550380:
					return typeof(AutoTeamEntityData).GetProperty(nameof(PlayerCountNeededToAutoBalance));

				case 1527339574:
					return typeof(AutoTeamEntityData).GetProperty(nameof(ForceIntoSquad));

				case 3788125566:
					return typeof(AutoTeamEntityData).GetProperty(nameof(RotateTeamOnNewRound));

				case 2626919340:
					return typeof(AutoTeamEntityData).GetProperty(nameof(AutoBalance));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
