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
public enum EmittableField : int
{
	EfZero = 0,
	EfOne = 1,
	EfNormTime = 2,
	EfNormSpeed = 3,
	EfNormWindSpeed = 4,
	EfNormMicroVariation = 5,
	EfEmitterNormTime = 6,
	EfEmitterNormWindSpeed = 7,
	EfEmitterNormMicroVariation = 8,
	EfNone = 9,
	EfCount = 10,
	EfSpawnAnimationSpeed = 11,
	EfSpawnAnimationFrameIndex = 12,
	EfVelocity = 13,
	EfParameters = 14,
	EfRotation = 15,
	EfSpeed = 16,
	EfUserDefined = 17,
	EfConstantFloat = 18,
	EfConstantVec = 19,
}

