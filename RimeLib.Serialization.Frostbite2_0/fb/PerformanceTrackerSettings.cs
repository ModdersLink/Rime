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
	[ContainerType(4, 20)]
	public partial class PerformanceTrackerSettings :
		SystemSettings
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _Interval;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private bool _Enabled;

		[ObservableProperty]
		[property: ContainerField(17), LayoutImmutable, Blittable, JsonProperty(Order = 17)]
		private bool _SupressPerformanceStatsOnIdle;

		[ObservableProperty]
		[property: ContainerField(18), LayoutImmutable, Blittable, JsonProperty(Order = 18)]
		private bool _SupressPerformanceStatsUntilSpawned;

		[ObservableProperty]
		[property: ContainerField(19), LayoutImmutable, Blittable, JsonProperty(Order = 19)]
		private bool _JuiceLogPerformance;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(Interval);
			p_Writer.Write(Enabled);
			p_Writer.Write(SupressPerformanceStatsOnIdle);
			p_Writer.Write(SupressPerformanceStatsUntilSpawned);
			p_Writer.Write(JuiceLogPerformance);
		}
	}
}
