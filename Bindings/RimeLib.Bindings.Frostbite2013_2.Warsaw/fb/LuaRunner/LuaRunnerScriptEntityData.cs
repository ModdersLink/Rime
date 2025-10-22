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

namespace fb.LuaRunner;

[ContainerType(8, 176)]
public class LuaRunnerScriptEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string Script { get; set; } = string.Empty;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<string> InputEvents { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<string> OutputEvents { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<string> InputFloatProperties { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public List<string> OutputFloatProperties { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public List<string> InputIntProperties { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public List<string> OutputIntProperties { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public List<string> InputBoolProperties { get; set; } = new();
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public List<string> OutputBoolProperties { get; set; } = new();
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public List<string> InputStringProperties { get; set; } = new();
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public List<string> OutputStringProperties { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public List<string> InputTransformProperties { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public List<string> OutputTransformProperties { get; set; } = new();
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public List<string> InputVec3Properties { get; set; } = new();
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public List<string> OutputVec3Properties { get; set; } = new();
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public ExecuteOnPropertyChangeType ExecuteOnPropertyChange { get; set; } = ExecuteOnPropertyChangeType.ExecuteOnPropertyChangeType_DontExecute;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public int PriorityForExecutingPerFrame { get; set; } = 0;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Client;
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public CtrRef<LuaRunnerCompiledLua> CompiledLua { get; set; } = new();
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public bool AutoStartExecutingPerFrame { get; set; } = false;
	
	[ContainerField(0xa9), LayoutImmutable, Blittable, JsonProperty(Order = 169)]
	public bool AutoStartForInitialization { get; set; } = false;
	
	[ContainerField(0xaa), LayoutImmutable, Blittable, JsonProperty(Order = 170)]
	public bool RunOnPropertyChange { get; set; } = false;
	
	[ContainerField(0xab), LayoutImmutable, Blittable, JsonProperty(Order = 171)]
	public bool AddToDebugDisplay { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(Script));
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
		(RimeWriter Writer, uint ArrayIndex) s_OutputFloatProperties = p_EbxWriter.GetArrayWriter(OutputFloatProperties.GetType(), OutputFloatProperties.Count);
		p_Writer.Write(s_OutputFloatProperties.ArrayIndex);
		foreach (var s_Entry in OutputFloatProperties)
		{
			s_OutputFloatProperties.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_InputIntProperties = p_EbxWriter.GetArrayWriter(InputIntProperties.GetType(), InputIntProperties.Count);
		p_Writer.Write(s_InputIntProperties.ArrayIndex);
		foreach (var s_Entry in InputIntProperties)
		{
			s_InputIntProperties.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_OutputIntProperties = p_EbxWriter.GetArrayWriter(OutputIntProperties.GetType(), OutputIntProperties.Count);
		p_Writer.Write(s_OutputIntProperties.ArrayIndex);
		foreach (var s_Entry in OutputIntProperties)
		{
			s_OutputIntProperties.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_InputBoolProperties = p_EbxWriter.GetArrayWriter(InputBoolProperties.GetType(), InputBoolProperties.Count);
		p_Writer.Write(s_InputBoolProperties.ArrayIndex);
		foreach (var s_Entry in InputBoolProperties)
		{
			s_InputBoolProperties.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_OutputBoolProperties = p_EbxWriter.GetArrayWriter(OutputBoolProperties.GetType(), OutputBoolProperties.Count);
		p_Writer.Write(s_OutputBoolProperties.ArrayIndex);
		foreach (var s_Entry in OutputBoolProperties)
		{
			s_OutputBoolProperties.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_InputStringProperties = p_EbxWriter.GetArrayWriter(InputStringProperties.GetType(), InputStringProperties.Count);
		p_Writer.Write(s_InputStringProperties.ArrayIndex);
		foreach (var s_Entry in InputStringProperties)
		{
			s_InputStringProperties.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_OutputStringProperties = p_EbxWriter.GetArrayWriter(OutputStringProperties.GetType(), OutputStringProperties.Count);
		p_Writer.Write(s_OutputStringProperties.ArrayIndex);
		foreach (var s_Entry in OutputStringProperties)
		{
			s_OutputStringProperties.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_InputTransformProperties = p_EbxWriter.GetArrayWriter(InputTransformProperties.GetType(), InputTransformProperties.Count);
		p_Writer.Write(s_InputTransformProperties.ArrayIndex);
		foreach (var s_Entry in InputTransformProperties)
		{
			s_InputTransformProperties.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_OutputTransformProperties = p_EbxWriter.GetArrayWriter(OutputTransformProperties.GetType(), OutputTransformProperties.Count);
		p_Writer.Write(s_OutputTransformProperties.ArrayIndex);
		foreach (var s_Entry in OutputTransformProperties)
		{
			s_OutputTransformProperties.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_InputVec3Properties = p_EbxWriter.GetArrayWriter(InputVec3Properties.GetType(), InputVec3Properties.Count);
		p_Writer.Write(s_InputVec3Properties.ArrayIndex);
		foreach (var s_Entry in InputVec3Properties)
		{
			s_InputVec3Properties.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_OutputVec3Properties = p_EbxWriter.GetArrayWriter(OutputVec3Properties.GetType(), OutputVec3Properties.Count);
		p_Writer.Write(s_OutputVec3Properties.ArrayIndex);
		foreach (var s_Entry in OutputVec3Properties)
		{
			s_OutputVec3Properties.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) ExecuteOnPropertyChange);
		p_Writer.Write(PriorityForExecutingPerFrame);
		p_Writer.Write((int) Realm);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(CompiledLua));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(AutoStartExecutingPerFrame);
		p_Writer.Write(AutoStartForInitialization);
		p_Writer.Write(RunOnPropertyChange);
		p_Writer.Write(AddToDebugDisplay);
		p_Writer.WriteNullBytes(4);
	}
}

