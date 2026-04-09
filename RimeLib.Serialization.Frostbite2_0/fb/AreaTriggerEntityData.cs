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
	[ContainerType(16, 208)]
	public partial class AreaTriggerEntityData :
		TriggerEntityData
	{
		[ObservableProperty]
		[property: ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private LinearTransform _GeometryTransform = new();

		[ObservableProperty]
		[property: ContainerField(176), JsonProperty(Order = 176)]
		private AreaTriggerInclude _Include = new();

		[ObservableProperty]
		[property: ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		private float _InsideAreaEventRepeatTime;

		[ObservableProperty]
		[property: ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		private float _Radius;

		[ObservableProperty]
		[property: ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		private bool _UseCharacterEntity;

		[ObservableProperty]
		[property: ContainerField(189), LayoutImmutable, Blittable, JsonProperty(Order = 189)]
		private bool _OneInsideAreaEventPerSoldier;

		[ObservableProperty]
		[property: ContainerField(190), LayoutImmutable, Blittable, JsonProperty(Order = 190)]
		private bool _TriggerOnlyOnLeave;

		[ObservableProperty]
		[property: ContainerField(191), LayoutImmutable, Blittable, JsonProperty(Order = 191)]
		private bool _ResetOnEnable;

		[ObservableProperty]
		[property: ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		private bool _TriggerOnLeaveOnDeath;

		[ObservableProperty]
		[property: ContainerField(193), LayoutImmutable, Blittable, JsonProperty(Order = 193)]
		private bool _TriggerOnLeaveOnDisable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			GeometryTransform.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Include);
			p_Writer.Write(InsideAreaEventRepeatTime);
			p_Writer.Write(Radius);
			p_Writer.Write(UseCharacterEntity);
			p_Writer.Write(OneInsideAreaEventPerSoldier);
			p_Writer.Write(TriggerOnlyOnLeave);
			p_Writer.Write(ResetOnEnable);
			p_Writer.Write(TriggerOnLeaveOnDeath);
			p_Writer.Write(TriggerOnLeaveOnDisable);
			p_Writer.WriteNullBytes(14);
		}
	}
}
