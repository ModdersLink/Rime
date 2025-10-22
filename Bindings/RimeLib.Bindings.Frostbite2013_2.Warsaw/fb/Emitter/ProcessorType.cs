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


namespace fb.Emitter;

[ContainerType(1, 4)]
public enum ProcessorType : int
{
	PtBaseEmitter = 0,
	PtPreRoll = 1,
	PtSpawnRate = 2,
	PtSpawnRibbonRate = 3,
	PtSpawnPointCloud = 4,
	PtSpawnSpeed = 5,
	PtSpawnPosition = 6,
	PtSpawnDirection = 7,
	PtSpawnSize = 8,
	PtSpawnAnimation = 9,
	PtSpawnAnimationFrame = 10,
	PtSpawnRotation = 11,
	PtSpawnOrientation = 12,
	PtSpawnRotationSpeed = 13,
	PtSpawnColorRandom = 14,
	PtUpdatePosition = 15,
	PtUpdateAge = 16,
	PtTurbulance = 17,
	PtGravity = 18,
	PtLocalForce = 19,
	PtAirResistance = 20,
	PtUpdateLinearVelocity = 21,
	PtUpdateOrientation = 22,
	PtEmitter = 23,
	PtUpdateColor = 24,
	PtUpdateColorLeaf = 25,
	PtUpdateTransparency = 26,
	PtUpdateTextureCoords = 27,
	PtUpdateRotation = 28,
	PtUpdateSizeX = 29,
	PtUpdateSizeY = 30,
	PtUpdateSizeZ = 31,
	PtUpdateSize = 32,
	PtUpdateAlphaLevelMin = 33,
	PtUpdateAlphaLevelMax = 34,
	PtUpdateAlphaLevelScale = 35,
	PtUpdateClipScale = 36,
	PtUpdateCameraProximity = 37,
	PtUpdateRibbonFade = 38,
	PtUpdateRibbonTexture = 39,
	PtWorldWind = 40,
	PtWorldForces = 41,
	PtUpdateCollision = 42,
	PtUpdateQuadBendingAngle = 43,
	PtUpdateShaderParam01 = 44,
	PtUpdateShaderParam02 = 45,
	PtUpdateShaderParam03 = 46,
	PtUpdateShaderParam04 = 47,
	PtUpdateShaderParam05 = 48,
	PtUpdateShaderParam06 = 49,
	PtUpdateShaderParam07 = 50,
	PtUpdateShaderParam08 = 51,
	PtUpdateShaderParam09 = 52,
	PtUpdateShaderParam10 = 53,
	PtUpdateShaderParam11 = 54,
	PtUpdateShaderParam12 = 55,
	ProcessorTypeCount = 56,
}

