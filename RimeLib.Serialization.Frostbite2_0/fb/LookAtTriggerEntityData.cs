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
	[ContainerType(16, 144)]
	public partial class LookAtTriggerEntityData :
		TriggerEventEntityData
	{
		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _FOV;

		[ObservableProperty]
		[property: ContainerField(116), JsonProperty(Order = 116)]
		private CtrRef<SoldierWeaponBlueprint> _Weapon = new();

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private uint _ZoomLevel;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private float _MinDistanceToObject;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private float _MaxDistanceToObject;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private bool _StartTriggerLookingAt;

		[ObservableProperty]
		[property: ContainerField(133), LayoutImmutable, Blittable, JsonProperty(Order = 133)]
		private bool _CheckOcclusion;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(FOV);
			p_Writer.Write(p_EbxWriter.WriteImport(Weapon));
			p_Writer.Write(ZoomLevel);
			p_Writer.Write(MinDistanceToObject);
			p_Writer.Write(MaxDistanceToObject);
			p_Writer.Write(StartTriggerLookingAt);
			p_Writer.Write(CheckOcclusion);
			p_Writer.WriteNullBytes(10);
		}
	}
}
