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
using fb.GameShared;

namespace fb.VeniceShared;

[ContainerType(8, 88)]
public class BFLockingTypeAsset
	: fb.GameShared.LockingTypeAsset
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string LockingIconName { get; set; } = @"locking.brackets";
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float LockingBlinkInterval { get; set; } = 0.175f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public string TargetIconName { get; set; } = @"locking.brackets";
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string ChevronIconName { get; set; } = @"locking.square";
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public uint LockingQuadSpacingStart { get; set; } = 0;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public uint LockedQuadSpacing { get; set; } = 0;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public string LockedText { get; set; } = @"SHOOT";
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public string LockedGuidingText { get; set; } = @"HOLD";
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public string NotLockedGuidingText { get; set; } = @"LOST";
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(LockingIconName));
		p_Writer.Write(LockingBlinkInterval);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(TargetIconName));
		p_Writer.Write(p_EbxWriter.WriteString(ChevronIconName));
		p_Writer.Write(LockingQuadSpacingStart);
		p_Writer.Write(LockedQuadSpacing);
		p_Writer.Write(p_EbxWriter.WriteString(LockedText));
		p_Writer.Write(p_EbxWriter.WriteString(LockedGuidingText));
		p_Writer.Write(p_EbxWriter.WriteString(NotLockedGuidingText));
	}
}

