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
	[ContainerType(16, 528)]
	public class SpecialMovesComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public SpecialMoveStateData VaultOverHighState { get; set; } = new();

		[ContainerField(156)]
		public SpecialMoveStateData VaultUpHighState { get; set; } = new();

		[ContainerField(216)]
		public SpecialMoveStateData VaultOverLowState { get; set; } = new();

		[ContainerField(276)]
		public SpecialMoveStateData SprintToProneState { get; set; } = new();

		[ContainerField(336)]
		public SpecialMoveStateData DeathState { get; set; } = new();

		[ContainerField(396)]
		public SpecialMoveStateData SpecialAnimationState { get; set; } = new();

		[ContainerField(456)]
		public List<SpecialMoveStateData> IndexedDeathStates { get; set; } = new();

		[ContainerField(460)]
		public List<SpecialMoveStateData> IndexedSpecialAnimationStates { get; set; } = new();

		[ContainerField(464)]
		public List<SpecialMoveVaultStateCriteria> IndexedVaultOverHighStates { get; set; } = new();

		[ContainerField(468)]
		public List<SpecialMoveVaultStateCriteria> IndexedVaultUpStates { get; set; } = new();

		[ContainerField(472)]
		public List<SpecialMoveVaultStateCriteria> IndexedVaultOverLowStates { get; set; } = new();

		[ContainerField(476)]
		public SpecialMovesBinding Binding { get; set; } = new();

	}
}
