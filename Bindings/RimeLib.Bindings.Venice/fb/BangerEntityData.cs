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
	[ContainerType(16, 144)]
	public class BangerEntityData : 
		DynamicGamePhysicsEntityData
	{
		[ContainerField(112)]
		public List<float> Scales { get; set; } = new();

		[ContainerField(116)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new();

		[ContainerField(120)]
		public CtrRef<ExplosionEntityData> Explosion { get; set; } = new();

		[ContainerField(124), LayoutImmutable, Blittable]
		public float TimeToLive { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public uint DestructiblePartCount { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public bool UseVariableNetworkFrequency { get; set; }

	}
}
