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
	[ContainerType(16, 256)]
	public partial class MultipleActorScenarioEntityData :
		SpatialEntityData
	{
		[ObservableProperty]
		[property: ContainerField(80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private LinearTransform _WorldSpaceConnectTransform = new();

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private int _Actor5Part;

		[ObservableProperty]
		[property: ContainerField(148), JsonProperty(Order = 148)]
		private AntRef _ScenarioAntRef = new();

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private int _LevelChoice;

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private int _ScenarioChoice;

		[ObservableProperty]
		[property: ContainerField(160), JsonProperty(Order = 160)]
		private Realm _Realm = new();

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private int _Actor6Part;

		[ObservableProperty]
		[property: ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		private int _Actor1;

		[ObservableProperty]
		[property: ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		private int _Actor1Part;

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private int _Actor1SecondPart;

		[ObservableProperty]
		[property: ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		private int _Actor2;

		[ObservableProperty]
		[property: ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		private int _Actor2Part;

		[ObservableProperty]
		[property: ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		private int _Actor2SecondPart;

		[ObservableProperty]
		[property: ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		private int _Actor3;

		[ObservableProperty]
		[property: ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		private int _Actor3Part;

		[ObservableProperty]
		[property: ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		private int _Actor3SecondPart;

		[ObservableProperty]
		[property: ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		private int _Actor4;

		[ObservableProperty]
		[property: ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		private int _Actor4Part;

		[ObservableProperty]
		[property: ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		private int _Actor4SecondPart;

		[ObservableProperty]
		[property: ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		private int _Actor5;

		[ObservableProperty]
		[property: ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		private int _Actor5SecondPart;

		[ObservableProperty]
		[property: ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		private int _Actor6SecondPart;

		[ObservableProperty]
		[property: ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		private int _Actor6;

		[ObservableProperty]
		[property: ContainerField(232), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
		private float _ExternalTime;

		[ObservableProperty]
		[property: ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		private bool _AligningEnabled;

		[ObservableProperty]
		[property: ContainerField(237), LayoutImmutable, Blittable, JsonProperty(Order = 237)]
		private bool _ScenarioActive;

		[ObservableProperty]
		[property: ContainerField(238), LayoutImmutable, Blittable, JsonProperty(Order = 238)]
		private bool _Actor1Prepared;

		[ObservableProperty]
		[property: ContainerField(239), LayoutImmutable, Blittable, JsonProperty(Order = 239)]
		private bool _Actor2Prepared;

		[ObservableProperty]
		[property: ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		private bool _Actor3Prepared;

		[ObservableProperty]
		[property: ContainerField(241), LayoutImmutable, Blittable, JsonProperty(Order = 241)]
		private bool _Actor4Prepared;

		[ObservableProperty]
		[property: ContainerField(242), LayoutImmutable, Blittable, JsonProperty(Order = 242)]
		private bool _Actor5Prepared;

		[ObservableProperty]
		[property: ContainerField(243), LayoutImmutable, Blittable, JsonProperty(Order = 243)]
		private bool _Actor6Prepared;

		[ObservableProperty]
		[property: ContainerField(244), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
		private bool _CheckActor1Finished;

		[ObservableProperty]
		[property: ContainerField(245), LayoutImmutable, Blittable, JsonProperty(Order = 245)]
		private bool _CheckActor2Finished;

		[ObservableProperty]
		[property: ContainerField(246), LayoutImmutable, Blittable, JsonProperty(Order = 246)]
		private bool _CheckActor3Finished;

		[ObservableProperty]
		[property: ContainerField(247), LayoutImmutable, Blittable, JsonProperty(Order = 247)]
		private bool _CheckActor4Finished;

		[ObservableProperty]
		[property: ContainerField(248), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
		private bool _CheckActor5Finished;

		[ObservableProperty]
		[property: ContainerField(249), LayoutImmutable, Blittable, JsonProperty(Order = 249)]
		private bool _CheckActor6Finished;

		[ObservableProperty]
		[property: ContainerField(250), LayoutImmutable, Blittable, JsonProperty(Order = 250)]
		private bool _UseInputEventPlayerAsPlayer1;

		[ObservableProperty]
		[property: ContainerField(251), LayoutImmutable, Blittable, JsonProperty(Order = 251)]
		private bool _UseExternalTime;

		[ObservableProperty]
		[property: ContainerField(252), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
		private bool _WorldSpace;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			WorldSpaceConnectTransform.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(Actor5Part);
			ScenarioAntRef.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(LevelChoice);
			p_Writer.Write(ScenarioChoice);
			p_Writer.Write((int) Realm);
			p_Writer.Write(Actor6Part);
			p_Writer.Write(Actor1);
			p_Writer.Write(Actor1Part);
			p_Writer.Write(Actor1SecondPart);
			p_Writer.Write(Actor2);
			p_Writer.Write(Actor2Part);
			p_Writer.Write(Actor2SecondPart);
			p_Writer.Write(Actor3);
			p_Writer.Write(Actor3Part);
			p_Writer.Write(Actor3SecondPart);
			p_Writer.Write(Actor4);
			p_Writer.Write(Actor4Part);
			p_Writer.Write(Actor4SecondPart);
			p_Writer.Write(Actor5);
			p_Writer.Write(Actor5SecondPart);
			p_Writer.Write(Actor6SecondPart);
			p_Writer.Write(Actor6);
			p_Writer.Write(ExternalTime);
			p_Writer.Write(AligningEnabled);
			p_Writer.Write(ScenarioActive);
			p_Writer.Write(Actor1Prepared);
			p_Writer.Write(Actor2Prepared);
			p_Writer.Write(Actor3Prepared);
			p_Writer.Write(Actor4Prepared);
			p_Writer.Write(Actor5Prepared);
			p_Writer.Write(Actor6Prepared);
			p_Writer.Write(CheckActor1Finished);
			p_Writer.Write(CheckActor2Finished);
			p_Writer.Write(CheckActor3Finished);
			p_Writer.Write(CheckActor4Finished);
			p_Writer.Write(CheckActor5Finished);
			p_Writer.Write(CheckActor6Finished);
			p_Writer.Write(UseInputEventPlayerAsPlayer1);
			p_Writer.Write(UseExternalTime);
			p_Writer.Write(WorldSpace);
			p_Writer.WriteNullBytes(3);
		}
	}
}
