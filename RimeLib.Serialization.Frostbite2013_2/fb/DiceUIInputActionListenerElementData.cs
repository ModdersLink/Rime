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

using fb.Core;
using fb.UI;
using fb.GameShared;
using fb.Entity;

namespace fb.DiceCommonsShared;

[ContainerType(16, 224)]
public class DiceUIInputActionListenerElementData
	: fb.GameShared.UIElementEntityData
{
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public UIInputAction InputAction { get; set; } = UIInputAction.UIInputAction_NavigateUp;
	
	[ContainerField(0xd4), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
	public bool ConsumeInput { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) InputAction);
		p_Writer.Write(ConsumeInput);
		p_Writer.WriteNullBytes(11);
	}
}

