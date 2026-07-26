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

	[AntBinding(0xeae58e8d)]
	[AntBinding(0xe7b923f5)] // BF3 alpha schema (adds TrackSelectionGameStateEnum)
	public class SequenceContainerAsset
		: ControllerAsset
	{
		[AntField(0)]
		public IdRefArray<ActorControllerAsset> ActorAssets { get; set; } = new();

		// BF3-alpha-only field (dropped in retail; slot per the alpha reflection table).
		[AntField(1)]
		public IdRef<AntObject> TrackSelectionGameStateEnum { get; set; } = new();

	}
}
