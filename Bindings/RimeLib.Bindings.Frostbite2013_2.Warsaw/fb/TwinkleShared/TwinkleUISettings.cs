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

namespace fb.TwinkleShared;

[ContainerType(8, 160)]
public class TwinkleUISettings
	: fb.Core.SystemSettings
{
	public TwinkleUISettings()
	{
		//SystemSettings
		Name = @"TwinkleUI";
	}
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string JsHost { get; set; } = string.Empty;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public string JsBundle { get; set; } = @"bundle.js";
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string JsBundleProtocol { get; set; } = @"file";
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public string RemoteBindHost { get; set; } = string.Empty;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public int RemoteBindPort { get; set; } = 8081;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public string ScriptEngineBackend { get; set; } = @"duktape";
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float SuspendLingeringTimeout { get; set; } = 1.500f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public string TwinkleWidgetPath { get; set; } = string.Empty;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public string TwinkleScreenPath { get; set; } = string.Empty;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public uint MaxTexturePackingWidth { get; set; } = 800;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public uint MaxTexturePackingHeight { get; set; } = 800;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public uint DynamicAtlasSize { get; set; } = 2048;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public uint StaticAtlasSize { get; set; } = 1024;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public uint MaxSingleTexturesNum { get; set; } = 8;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float DebugMemoryBudgetFrontEnd { get; set; } = 128.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float DebugMemoryBudgetInGame { get; set; } = 64.000f;
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public CtrRef<TwinkleStaticBundlesAsset> StaticBundle { get; set; } = new();
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public bool Enabled { get; set; } = false;
	
	[ContainerField(0x91), LayoutImmutable, Blittable, JsonProperty(Order = 145)]
	public bool UseTwinkleOverlay { get; set; } = false;
	
	[ContainerField(0x92), LayoutImmutable, Blittable, JsonProperty(Order = 146)]
	public bool OperationsGlobeLogicEnabled { get; set; } = false;
	
	[ContainerField(0x93), LayoutImmutable, Blittable, JsonProperty(Order = 147)]
	public bool ResizeRootSurfaceToScreen { get; set; } = false;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public bool UseManifestBundle { get; set; } = false;
	
	[ContainerField(0x95), LayoutImmutable, Blittable, JsonProperty(Order = 149)]
	public bool HttpCacheEnabled { get; set; } = true;
	
	[ContainerField(0x96), LayoutImmutable, Blittable, JsonProperty(Order = 150)]
	public bool HttpCacheWritesEnabled { get; set; } = true;
	
	[ContainerField(0x97), LayoutImmutable, Blittable, JsonProperty(Order = 151)]
	public bool EnableInputConceptsForJS { get; set; } = true;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public bool EnableTwinkleSpecificInputConceptsForJS { get; set; } = true;
	
	[ContainerField(0x99), LayoutImmutable, Blittable, JsonProperty(Order = 153)]
	public bool DisableTextureLoading { get; set; } = false;
	
	[ContainerField(0x9a), LayoutImmutable, Blittable, JsonProperty(Order = 154)]
	public bool DisableFontLoading { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(JsHost));
		p_Writer.Write(p_EbxWriter.WriteString(JsBundle));
		p_Writer.Write(p_EbxWriter.WriteString(JsBundleProtocol));
		p_Writer.Write(p_EbxWriter.WriteString(RemoteBindHost));
		p_Writer.Write(RemoteBindPort);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(ScriptEngineBackend));
		p_Writer.Write(SuspendLingeringTimeout);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(TwinkleWidgetPath));
		p_Writer.Write(p_EbxWriter.WriteString(TwinkleScreenPath));
		p_Writer.Write(MaxTexturePackingWidth);
		p_Writer.Write(MaxTexturePackingHeight);
		p_Writer.Write(DynamicAtlasSize);
		p_Writer.Write(StaticAtlasSize);
		p_Writer.Write(MaxSingleTexturesNum);
		p_Writer.Write(DebugMemoryBudgetFrontEnd);
		p_Writer.Write(DebugMemoryBudgetInGame);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(StaticBundle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Enabled);
		p_Writer.Write(UseTwinkleOverlay);
		p_Writer.Write(OperationsGlobeLogicEnabled);
		p_Writer.Write(ResizeRootSurfaceToScreen);
		p_Writer.Write(UseManifestBundle);
		p_Writer.Write(HttpCacheEnabled);
		p_Writer.Write(HttpCacheWritesEnabled);
		p_Writer.Write(EnableInputConceptsForJS);
		p_Writer.Write(EnableTwinkleSpecificInputConceptsForJS);
		p_Writer.Write(DisableTextureLoading);
		p_Writer.Write(DisableFontLoading);
		p_Writer.WriteNullBytes(5);
	}
}

