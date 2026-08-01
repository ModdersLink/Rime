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
	[AntBinding(0x14984cd9)] // BF3 alpha schema (adds PassTagsToChildren + TrackSelectionEnumValue)
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

		// Present only in the pre-release schema and dropped in retail. The parser binds a layout
		// member to the property of the same name, so these have to exist for that schema to parse.
		[AntField(1)]
		public bool PassTagsToChildren { get; set; }

		[AntField(6)]
		public IdRef<AntObject> TrackSelectionEnumValue { get; set; } = new();

	}
}
