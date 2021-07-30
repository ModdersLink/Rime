///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Flags: 137, Size: 4  )]
	public enum EvaluatorType : int
	{
		EtDefault = 0,
		EtBox = 1,
		EtPolynomial = 2,
		EtPolynomialOperator = 3,
		EtRandom = 4,
		EtRandomXYZ = 5,
		EtRotateVector = 6,
		EtSampleTexture = 7,
		EtSphere = 8,
		EtConstant = 9,
		EtPolynomialColorInterp = 10,
		EtCamProx = 11,
		EvaluatorTypeCount = 12
	}

}
