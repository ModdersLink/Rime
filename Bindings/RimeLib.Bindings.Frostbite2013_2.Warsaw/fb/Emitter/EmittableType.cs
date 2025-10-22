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
public enum EmittableType : int
{
	EmittableType_Point = 0,
	EmittableType_Quad = 100,
	EmittableType_Mesh = 200,
	EmittableType_Ribbon = 300,
	Point = 301,
	Quad = 302,
	ScreenAlignedQuad = 303,
	DirectionAlignedQuad = 304,
	WorldAlignedQuad = 305,
	ParticleMesh = 306,
	Ribbon = 307,
	Trail = 308,
}

