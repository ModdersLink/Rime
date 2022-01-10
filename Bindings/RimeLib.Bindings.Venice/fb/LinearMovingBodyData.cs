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
	[ContainerType(16, 80)]
	public class LinearMovingBodyData : 
		MovingBodyData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Axis { get; set; } = new();

		[ContainerField(32)]
		public EndPointData Start { get; set; } = new();

		[ContainerField(52)]
		public EndPointData End { get; set; } = new();

		public static void Deserialize(LinearMovingBodyData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.Axis, p_Reader, p_Parser);
			fb.EndPointData.Deserialize(p_Instance.Start, p_Reader, p_Parser);
			fb.EndPointData.Deserialize(p_Instance.End, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
