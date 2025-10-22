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
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 256)]
public class UIScreenRenderEntityData
	: fb.Entity.LogicReferenceObjectData
{
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public CtrRef<UICppScreenData> ScreenData { get; set; } = new();
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float Scale { get; set; } = 0.001f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public UIScreenProjectionMode ProjectionMode { get; set; } = UIScreenProjectionMode.UIScreenProjectionMode_Default;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public UIScreenRenderingPass RenderPass { get; set; } = UIScreenRenderingPass.UIScreenRenderingPass_BelowFlash;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public int UpdateOrder { get; set; } = 0;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public int RenderToRootView { get; set; } = 0;
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public List<string> InputEvents { get; set; } = new();
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
	public List<string> OutputEvents { get; set; } = new();
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public List<string> InputFloatProperties { get; set; } = new();
	
	[ContainerField(0xc8), JsonProperty(Order = 200)]
	public List<string> InputIntProperties { get; set; } = new();
	
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public List<string> InputBoolProperties { get; set; } = new();
	
	[ContainerField(0xd8), JsonProperty(Order = 216)]
	public List<string> InputStringProperties { get; set; } = new();
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public List<string> InputTransformProperties { get; set; } = new();
	
	[ContainerField(0xe8), JsonProperty(Order = 232)]
	public List<string> InputVec3Properties { get; set; } = new();
	
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public List<string> InputVec4Properties { get; set; } = new();
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public bool UseGameViewProjection { get; set; } = false;
	
	[ContainerField(0xf9), LayoutImmutable, Blittable, JsonProperty(Order = 249)]
	public bool EnableDepthCulling { get; set; } = false;
	
	[ContainerField(0xfa), LayoutImmutable, Blittable, JsonProperty(Order = 250)]
	public bool CenterScreen { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(ScreenData));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Scale);
		p_Writer.Write((int) ProjectionMode);
		p_Writer.Write((int) RenderPass);
		p_Writer.Write(UpdateOrder);
		p_Writer.Write(RenderToRootView);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_InputEvents = p_EbxWriter.GetArrayWriter(InputEvents.GetType(), InputEvents.Count);
		p_Writer.Write(s_InputEvents.ArrayIndex);
		foreach (var s_Entry in InputEvents)
		{
			s_InputEvents.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_OutputEvents = p_EbxWriter.GetArrayWriter(OutputEvents.GetType(), OutputEvents.Count);
		p_Writer.Write(s_OutputEvents.ArrayIndex);
		foreach (var s_Entry in OutputEvents)
		{
			s_OutputEvents.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_InputFloatProperties = p_EbxWriter.GetArrayWriter(InputFloatProperties.GetType(), InputFloatProperties.Count);
		p_Writer.Write(s_InputFloatProperties.ArrayIndex);
		foreach (var s_Entry in InputFloatProperties)
		{
			s_InputFloatProperties.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_InputIntProperties = p_EbxWriter.GetArrayWriter(InputIntProperties.GetType(), InputIntProperties.Count);
		p_Writer.Write(s_InputIntProperties.ArrayIndex);
		foreach (var s_Entry in InputIntProperties)
		{
			s_InputIntProperties.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_InputBoolProperties = p_EbxWriter.GetArrayWriter(InputBoolProperties.GetType(), InputBoolProperties.Count);
		p_Writer.Write(s_InputBoolProperties.ArrayIndex);
		foreach (var s_Entry in InputBoolProperties)
		{
			s_InputBoolProperties.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_InputStringProperties = p_EbxWriter.GetArrayWriter(InputStringProperties.GetType(), InputStringProperties.Count);
		p_Writer.Write(s_InputStringProperties.ArrayIndex);
		foreach (var s_Entry in InputStringProperties)
		{
			s_InputStringProperties.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_InputTransformProperties = p_EbxWriter.GetArrayWriter(InputTransformProperties.GetType(), InputTransformProperties.Count);
		p_Writer.Write(s_InputTransformProperties.ArrayIndex);
		foreach (var s_Entry in InputTransformProperties)
		{
			s_InputTransformProperties.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_InputVec3Properties = p_EbxWriter.GetArrayWriter(InputVec3Properties.GetType(), InputVec3Properties.Count);
		p_Writer.Write(s_InputVec3Properties.ArrayIndex);
		foreach (var s_Entry in InputVec3Properties)
		{
			s_InputVec3Properties.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_InputVec4Properties = p_EbxWriter.GetArrayWriter(InputVec4Properties.GetType(), InputVec4Properties.Count);
		p_Writer.Write(s_InputVec4Properties.ArrayIndex);
		foreach (var s_Entry in InputVec4Properties)
		{
			s_InputVec4Properties.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(UseGameViewProjection);
		p_Writer.Write(EnableDepthCulling);
		p_Writer.Write(CenterScreen);
		p_Writer.WriteNullBytes(5);
	}
}

