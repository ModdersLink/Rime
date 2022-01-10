///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 4)]
	public enum EmittableField : int
	{
		EfZero = 0,
		EfOne = 1,
		EfNormTime = 2,
		EfEmitterNormTime = 3,
		EfSpawnAnimationSpeed = 4,
		EfSpawnAnimationFrameIndex = 5,
		EfVelocity = 6,
		EfParameters = 7,
		EfRotation = 8,
		EfSpeed = 9,
		EfUserDefined = 10,
		EfConstantFloat = 11,
		EfConstantVec = 12,
		EfNone = 13
	}

}
