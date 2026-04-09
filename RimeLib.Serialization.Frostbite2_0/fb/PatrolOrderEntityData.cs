///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 56)]
	public partial class PatrolOrderEntityData :
		BFOrderEntityData
	{
		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private RouteType _TypeOfRoute = new();

		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private CombatPatrolMode _CombatMode = new();

		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private CtrRef<WaypointData> _StartingWaypoint = new();

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private bool _StartAtGeometricallyClosestWaypoint;

		[ObservableProperty]
		[property: ContainerField(53), LayoutImmutable, Blittable, JsonProperty(Order = 53)]
		private bool _UsePathFinding;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) TypeOfRoute);
			p_Writer.Write((int) CombatMode);
			p_Writer.Write(p_EbxWriter.WriteImport(StartingWaypoint));
			p_Writer.Write(StartAtGeometricallyClosestWaypoint);
			p_Writer.Write(UsePathFinding);
			p_Writer.WriteNullBytes(2);
		}
	}
}
