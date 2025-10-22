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

namespace fb.GameShared;

[ContainerType(8, 112)]
public class UIFlowCppScreenData
	: fb.UI.UIViewAsset
{
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public UIScreenRenderingPass RenderPass { get; set; } = UIScreenRenderingPass.UIScreenRenderingPass_BelowFlash;
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public CtrRef<UICppScreenData> ScreenData { get; set; } = new();
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public CtrRef<UIWidgetBlueprint> RootWidget { get; set; } = new();
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public bool RenderTarget { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) RenderPass);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ScreenData));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(RootWidget));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(RenderTarget);
		p_Writer.WriteNullBytes(7);
	}
}

