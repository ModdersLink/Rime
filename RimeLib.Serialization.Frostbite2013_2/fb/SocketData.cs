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

namespace fb.SoldierShared;

[ContainerType(16, 224)]
public class SocketData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public GUID UnlockAssetGuid { get; set; } = GUID.Empty;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public GUID BelongsToUnlockAssetGuid { get; set; } = GUID.Empty;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string BoneName { get; set; } = string.Empty;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public int BoneId { get; set; } = -1;
	
	[ContainerField(0x40), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public LinearTransform BoneRigidTransform { get; set; } = new()
	{
		trans = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 0.000f,
		},
		up = new()
		{
			z = 0.000f,
			y = 1.000f,
			x = 0.000f,
		},
		forward = new()
		{
			z = 1.000f,
			y = 0.000f,
			x = 0.000f,
		},
		right = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 1.000f,
		},
	};
	
	[ContainerField(0x80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public LinearTransform Transform { get; set; } = new()
	{
		trans = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 0.000f,
		},
		up = new()
		{
			z = 0.000f,
			y = 1.000f,
			x = 0.000f,
		},
		forward = new()
		{
			z = 1.000f,
			y = 0.000f,
			x = 0.000f,
		},
		right = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 1.000f,
		},
	};
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public RefArray<SocketObjectDataBase> AvailableObjects { get; set; } = new();
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public GearSlot GearSlot { get; set; } = fb.GameShared.GearSlot.GearSlot_NotEquipped;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public SocketType SocketType { get; set; } = fb.SoldierShared.SocketType.SocketType_Undefined;
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public bool Excluded { get; set; } = false;
	
	[ContainerField(0xd1), LayoutImmutable, Blittable, JsonProperty(Order = 209)]
	public bool UsesDefaultObject { get; set; } = false;
	
	[ContainerField(0xd2), LayoutImmutable, Blittable, JsonProperty(Order = 210)]
	public bool DefaultEnableSocketEntities { get; set; } = false;
	
	[ContainerField(0xd3), LayoutImmutable, Blittable, JsonProperty(Order = 211)]
	public bool ForceSocketEntitiesEnabled { get; set; } = false;
	
	[ContainerField(0xd4), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
	public bool HideByZoomTransition { get; set; } = false;
	
	[ContainerField(0xd5), LayoutImmutable, Blittable, JsonProperty(Order = 213)]
	public bool HideByLightToggle { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		UnlockAssetGuid.Serialize(p_Writer);
		BelongsToUnlockAssetGuid.Serialize(p_Writer);
		p_Writer.Write(p_EbxWriter.WriteString(BoneName));
		p_Writer.Write(BoneId);
		p_Writer.WriteNullBytes(4);
		BoneRigidTransform.Serialize(p_Writer, p_EbxWriter);
		Transform.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_AvailableObjects = p_EbxWriter.GetArrayWriter(AvailableObjects.GetType(), AvailableObjects.Count);
		p_Writer.Write(s_AvailableObjects.ArrayIndex);
		foreach (var s_Entry in AvailableObjects)
		{
			s_AvailableObjects.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) GearSlot);
		p_Writer.Write((int) SocketType);
		p_Writer.Write(Excluded);
		p_Writer.Write(UsesDefaultObject);
		p_Writer.Write(DefaultEnableSocketEntities);
		p_Writer.Write(ForceSocketEntitiesEnabled);
		p_Writer.Write(HideByZoomTransition);
		p_Writer.Write(HideByLightToggle);
		p_Writer.WriteNullBytes(10);
	}
}

