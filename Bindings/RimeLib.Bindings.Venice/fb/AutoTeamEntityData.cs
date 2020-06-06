///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class AutoTeamEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public uint TeamDifferenceToAutoBalance { get; set; } // 0x60 (96)
		
		[ContainerField(100)]
		public TeamAssignMode TeamAssignMode { get; set; } = new TeamAssignMode(); // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public uint PlayerCountNeededToAutoBalance { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public bool ForceIntoSquad { get; set; } // 0x6C (108)
		
		[ContainerField(109), LayoutImmutable, Blittable]
		public bool RotateTeamOnNewRound { get; set; } // 0x6D (109)
		
		[ContainerField(110), LayoutImmutable, Blittable]
		public bool AutoBalance { get; set; } // 0x6E (110)
		
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
