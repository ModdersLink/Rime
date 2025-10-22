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


namespace fb.Terrain;

[ContainerType(1, 4)]
public enum DensityMap_FilterType : int
{
	DensityMapFilter_SecondOrderDifference = 0,
	DensityMapFilter_GaussianCurvature = 1,
	DensityMapFilter_MeanCurvature = 2,
	DensityMapFilter_LaplaceBeltrami = 3,
	DensityMapFilter_LaplaceBeltramiNoVoronoi = 4,
}

