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
	[ContainerType(Flags: 137, Size: 4  )]
	public enum ShooterInfo : int
	{
		ShooterInfoInVehicle = 1,
		ShooterInfoInLandVehicle = 2,
		ShooterInfoInAerialVehicle = 4,
		ShooterInfoDrivingVehicle = 8,
		ShooterInfoInStationaryWeapon = 16,
		ShooterInfoInLightArmoredVehicle = 32,
		ShooterInfoInMediumArmoredVehicle = 64,
		ShooterInfoInHeavyArmoredVehicle = 128,
		ShooterInfoInBoat = 256,
		ShooterInfoUsedGrenade = 512,
		ShooterInfoUsedArtilleryStrike = 1024,
		ShooterInfoUsedLaserDesignator = 2048,
		ShooterInfoUsedMortarStrike = 4096,
		ShooterInfoUsedStingerMissile = 8192,
		ShooterInfoNoTeamKillPenalty = 16384
	}

}
