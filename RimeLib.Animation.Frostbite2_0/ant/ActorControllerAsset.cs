///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// As type schemas dont contain full information, modifying  //
// can be done to fix information thats wrong or missing.    //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using RimeLib.Animation.EA.Attributes;
using RimeLib.Animation.EA.Types;

namespace ant
{

	[AntBinding(0xbffc183)]
	public class ActorControllerAsset
		: ControllerAsset
	{
		[AntField(0)]
		public ActorControllerInitParams? DefaultInitParam { get; set; } = null;

		[AntField(1)]
		public float Length { get; set; }

		[AntField(2)]
		public ushort NumTracks { get; set; }

		[AntField(3)]
		public List<SequenceAnimTrack?> Tracks { get; set; } = new();

		[AntField(4)]
		public SequenceTrajectoryState? TrajectoryState { get; set; } = null;

		[AntField(5)]
		public uint ActorContentFlags { get; set; }

	}
}
