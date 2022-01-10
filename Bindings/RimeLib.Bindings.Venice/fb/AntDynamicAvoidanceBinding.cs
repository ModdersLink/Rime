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
	[ContainerType(4, 16)]
	public class AntDynamicAvoidanceBinding
	{
		[ContainerField(0)]
		public AntRef TimeUntilCollision { get; set; } = new();
		
		[ContainerField(4)]
		public AntRef DistanceUntilCollision { get; set; } = new();
		
		[ContainerField(8)]
		public AntRef NormalizedVelocity { get; set; } = new();
		
		[ContainerField(12)]
		public AntRef Speed { get; set; } = new();
		
		public static void Deserialize(AntDynamicAvoidanceBinding p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AntRef.Deserialize(p_Instance.TimeUntilCollision, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.DistanceUntilCollision, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.NormalizedVelocity, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.Speed, p_Reader, p_Parser);
		}
	}
}
