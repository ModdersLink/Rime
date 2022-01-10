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
	[ContainerType(4, 20)]
	public class DecisionConstantData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float NewEnemyDecideMaxDistance { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public bool AllowEmergencyGoalInterrupt { get; set; }

		[ContainerField(17), LayoutImmutable, Blittable]
		public bool AllowUninterruptibleBehaviours { get; set; }

		public static void Deserialize(DecisionConstantData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.NewEnemyDecideMaxDistance = p_Reader.ReadSingle();
			p_Instance.AllowEmergencyGoalInterrupt = p_Reader.ReadBool();
			p_Instance.AllowUninterruptibleBehaviours = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
