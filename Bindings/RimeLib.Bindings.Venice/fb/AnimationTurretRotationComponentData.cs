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
	[ContainerType(16, 112)]
	public class AnimationTurretRotationComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public List<TurretRotationInfo> Rotations { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public int SoldierBaseIndex { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public bool UseVehicleWorldTransform { get; set; }

		[ContainerField(105), LayoutImmutable, Blittable]
		public bool OutputWorldTransform { get; set; }

		public static void Deserialize(AnimationTurretRotationComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Rotations.Clear();
			(RimeReader Reader, uint Count) s_Rotations = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Rotations.Count; ++i)
			{
				var s_Value = new TurretRotationInfo();
				fb.TurretRotationInfo.Deserialize(s_Value, s_Rotations.Reader, p_Parser);
				p_Instance.Rotations.Add(s_Value);
			}
			
			s_Rotations.Reader.Dispose();
			p_Instance.SoldierBaseIndex = p_Reader.ReadInt32();
			p_Instance.UseVehicleWorldTransform = p_Reader.ReadBool();
			p_Instance.OutputWorldTransform = p_Reader.ReadBool();
			p_Reader.Seek(6, SeekOrigin.Current);
		}

	}
}
