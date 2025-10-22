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

namespace fb.Entity;

[ContainerType(8, 80)]
public class ForceManagerSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float VectorFieldNormValue { get; set; } = 50.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float VectorFieldCellSize { get; set; } = 1.000f;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float VectorFieldPlanarHeightPosition { get; set; } = 64.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float VectorFieldSizeX { get; set; } = 100.000f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float VectorFieldSizeY { get; set; } = 1.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float VectorFieldSizeZ { get; set; } = 100.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float VectorFieldCenterX { get; set; } = 0.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float VectorFieldCenterY { get; set; } = 30.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float VectorFieldCenterZ { get; set; } = 0.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float VectorFieldPointSize { get; set; } = 2.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public bool WindEnable { get; set; } = true;
	
	[ContainerField(0x39), LayoutImmutable, Blittable, JsonProperty(Order = 57)]
	public bool ForcesEnable { get; set; } = true;
	
	[ContainerField(0x3a), LayoutImmutable, Blittable, JsonProperty(Order = 58)]
	public bool DrawStats { get; set; } = false;
	
	[ContainerField(0x3b), LayoutImmutable, Blittable, JsonProperty(Order = 59)]
	public bool DrawWindGraph { get; set; } = false;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public bool DrawBoundingVolumes { get; set; } = false;
	
	[ContainerField(0x3d), LayoutImmutable, Blittable, JsonProperty(Order = 61)]
	public bool DrawSelectionBoundingVolumes { get; set; } = false;
	
	[ContainerField(0x3e), LayoutImmutable, Blittable, JsonProperty(Order = 62)]
	public bool DrawSelectionVectorField { get; set; } = false;
	
	[ContainerField(0x3f), LayoutImmutable, Blittable, JsonProperty(Order = 63)]
	public bool DrawSelectionForceVectorField { get; set; } = false;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public bool DrawPlanarVectorField { get; set; } = false;
	
	[ContainerField(0x41), LayoutImmutable, Blittable, JsonProperty(Order = 65)]
	public bool DrawExternalVectorField { get; set; } = false;
	
	[ContainerField(0x42), LayoutImmutable, Blittable, JsonProperty(Order = 66)]
	public bool VectorFieldEnableWind { get; set; } = true;
	
	[ContainerField(0x43), LayoutImmutable, Blittable, JsonProperty(Order = 67)]
	public bool VectorFieldEnableSphere { get; set; } = true;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public bool VectorFieldEnableCone { get; set; } = true;
	
	[ContainerField(0x45), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
	public bool VectorFieldEnableBaked { get; set; } = true;
	
	[ContainerField(0x46), LayoutImmutable, Blittable, JsonProperty(Order = 70)]
	public bool VectorFieldCameraCentered { get; set; } = true;
	
	[ContainerField(0x47), LayoutImmutable, Blittable, JsonProperty(Order = 71)]
	public bool VectorFieldArrow { get; set; } = true;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public bool VectorFieldLockSelection { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(VectorFieldNormValue);
		p_Writer.Write(VectorFieldCellSize);
		p_Writer.Write(VectorFieldPlanarHeightPosition);
		p_Writer.Write(VectorFieldSizeX);
		p_Writer.Write(VectorFieldSizeY);
		p_Writer.Write(VectorFieldSizeZ);
		p_Writer.Write(VectorFieldCenterX);
		p_Writer.Write(VectorFieldCenterY);
		p_Writer.Write(VectorFieldCenterZ);
		p_Writer.Write(VectorFieldPointSize);
		p_Writer.Write(WindEnable);
		p_Writer.Write(ForcesEnable);
		p_Writer.Write(DrawStats);
		p_Writer.Write(DrawWindGraph);
		p_Writer.Write(DrawBoundingVolumes);
		p_Writer.Write(DrawSelectionBoundingVolumes);
		p_Writer.Write(DrawSelectionVectorField);
		p_Writer.Write(DrawSelectionForceVectorField);
		p_Writer.Write(DrawPlanarVectorField);
		p_Writer.Write(DrawExternalVectorField);
		p_Writer.Write(VectorFieldEnableWind);
		p_Writer.Write(VectorFieldEnableSphere);
		p_Writer.Write(VectorFieldEnableCone);
		p_Writer.Write(VectorFieldEnableBaked);
		p_Writer.Write(VectorFieldCameraCentered);
		p_Writer.Write(VectorFieldArrow);
		p_Writer.Write(VectorFieldLockSelection);
		p_Writer.WriteNullBytes(7);
	}
}

