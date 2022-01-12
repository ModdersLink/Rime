///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 128)]
	public class WeaponEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public List<WeaponStateData> WeaponStates { get; set; } = new();

		[ContainerField(100)]
		public WeaponClassEnum WeaponClass { get; set; } = new();

		[ContainerField(104)]
		public CtrRef<GameAIWeaponData> AIData { get; set; } = new();

		[ContainerField(108)]
		public CtrRef<WeaponFiringData> WeaponFiring { get; set; } = new();

		[ContainerField(112)]
		public CtrRef<WeaponData> CustomWeaponType { get; set; } = new();

	}
}
