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

namespace fb.Physics;

[ContainerType(8, 104)]
public class WingPhysicsData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float Lift { get; set; } = 10.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float FlapLift { get; set; } = 1.000f;
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<Curve2D> LiftCoefficient { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float Drag { get; set; } = 0.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float FlapDrag { get; set; } = 0.000f;
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<Curve2D> DragCoefficient { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float AngularVelocityLiftModifier { get; set; } = 0.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float DragRotationModifier { get; set; } = 1.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float BaseAngleOfAttack { get; set; } = 0.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public int InputForFlap { get; set; } = 0;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float FlapTurnSpeed { get; set; } = 1.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float VisualFlapTurnSpeed { get; set; } = 1.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float VisualFlapAngleLimit { get; set; } = 90.000f;
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public CtrRef<Curve2D> MaxFlapAngleScaleFactor { get; set; } = new();
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float LandingFlapLift { get; set; } = 0.000f;
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public CtrRef<LandingFlapData> LandingFlapLogic { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Lift);
		p_Writer.Write(FlapLift);
		p_Writer.Write(p_EbxWriter.WriteImport(LiftCoefficient));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Drag);
		p_Writer.Write(FlapDrag);
		p_Writer.Write(p_EbxWriter.WriteImport(DragCoefficient));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(AngularVelocityLiftModifier);
		p_Writer.Write(DragRotationModifier);
		p_Writer.Write(BaseAngleOfAttack);
		p_Writer.Write(InputForFlap);
		p_Writer.Write(FlapTurnSpeed);
		p_Writer.Write(VisualFlapTurnSpeed);
		p_Writer.Write(VisualFlapAngleLimit);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(MaxFlapAngleScaleFactor));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(LandingFlapLift);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(LandingFlapLogic));
		p_Writer.WriteNullBytes(4);
	}
}

