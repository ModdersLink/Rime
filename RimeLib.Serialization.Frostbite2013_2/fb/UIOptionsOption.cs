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

using fb.GameShared;
using fb.Core;

namespace fb.VeniceShared;

[ContainerType(8, 120)]
public class UIOptionsOption
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public CtrRef<ProfileOptionData> OptionData { get; set; } = new();
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public string PlayerShownName { get; set; } = string.Empty;
	
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public string Description { get; set; } = string.Empty;
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public UIElementInclusionSettings Inclusion { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string VisibilityPropertyName { get; set; } = string.Empty;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public UIOptionsSpecialCase SpecialCase { get; set; } = UIOptionsSpecialCase.UIOptionsSpecialCase_Normal;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public string OnLabel { get; set; } = string.Empty;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public string OffLabel { get; set; } = string.Empty;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public string EventName { get; set; } = string.Empty;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public string SelectedEventName { get; set; } = string.Empty;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public UIOptionsSliderDisplay SliderDisplayMode { get; set; } = UIOptionsSliderDisplay.UIOptionsSliderDisplay_PercentOfMax;
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<CustomOptionData> CustomData { get; set; } = new();
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public bool IsButton { get; set; } = false;
	
	[ContainerField(0x71), LayoutImmutable, Blittable, JsonProperty(Order = 113)]
	public bool ApplyOnChange { get; set; } = false;
	
}

