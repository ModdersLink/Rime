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
	[ContainerType(4)]
	public class AntDynamicAvoidanceBinding : FrostbiteContainer
	{
		[ContainerField(0)]
		public AntRef TimeUntilCollision { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(4)]
		public AntRef DistanceUntilCollision { get; set; } = new AntRef(); // 0x4 (4)
		
		[ContainerField(8)]
		public AntRef NormalizedVelocity { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(12)]
		public AntRef Speed { get; set; } = new AntRef(); // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3142481924:
					TimeUntilCollision = (AntRef) p_Value;
					break;

				case 1945583762:
					DistanceUntilCollision = (AntRef) p_Value;
					break;

				case 113203091:
					NormalizedVelocity = (AntRef) p_Value;
					break;

				case 230887042:
					Speed = (AntRef) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3142481924:
					return TimeUntilCollision;

				case 1945583762:
					return DistanceUntilCollision;

				case 113203091:
					return NormalizedVelocity;

				case 230887042:
					return Speed;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3142481924:
					return typeof(AntDynamicAvoidanceBinding).GetProperty(nameof(TimeUntilCollision));

				case 1945583762:
					return typeof(AntDynamicAvoidanceBinding).GetProperty(nameof(DistanceUntilCollision));

				case 113203091:
					return typeof(AntDynamicAvoidanceBinding).GetProperty(nameof(NormalizedVelocity));

				case 230887042:
					return typeof(AntDynamicAvoidanceBinding).GetProperty(nameof(Speed));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
