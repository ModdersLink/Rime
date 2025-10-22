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
public enum EvaluatorType : int
{
	EtNone = 0,
	EtDefault = 1,
	EtBox = 2,
	EtPolynomial = 3,
	EtPolynomialOperator = 4,
	EtSpline = 5,
	EtRandom = 6,
	EtRandomXYZ = 7,
	EtRotateVector = 8,
	EtSampleTexture = 9,
	EtSphere = 10,
	EtSuperSphere = 11,
	EtConstant = 12,
	EtPolynomialColorInterp = 13,
	EtCamProx = 14,
	EvaluatorTypeCount = 15,
}

