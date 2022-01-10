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
	[ContainerType(16, 176)]
	public class AIProximityReactionsComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public AIProximityReactionsBinding Binding { get; set; } = new();

		[ContainerField(152), LayoutImmutable, Blittable]
		public float MinExplosionImpulseForce { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable]
		public float MaxExplosionLookDistance { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable]
		public float FireReactionDistance { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public bool Enabled { get; set; }

		public static void Deserialize(AIProximityReactionsComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AIProximityReactionsBinding.Deserialize(p_Instance.Binding, p_Reader, p_Parser);
			p_Instance.MinExplosionImpulseForce = p_Reader.ReadSingle();
			p_Instance.MaxExplosionLookDistance = p_Reader.ReadSingle();
			p_Instance.FireReactionDistance = p_Reader.ReadSingle();
			p_Instance.Enabled = p_Reader.ReadBool();
			p_Reader.Seek(11, SeekOrigin.Current);
		}

	}
}
