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
	[ContainerType(4, 28)]
	public class WeaponAnimationConfigurationModifier : 
		WeaponModifierBase
	{
		[ContainerField(8)]
		public List<float> ZoomInOutMeshTransitionFactors { get; set; } = new();

		[ContainerField(12)]
		public AnimationConfigurationData AnimationConfiguration { get; set; } = new();

		[ContainerField(24)]
		public AnimatedFireEnum AnimatedFireType { get; set; } = new();

		public static void Deserialize(WeaponAnimationConfigurationModifier p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ZoomInOutMeshTransitionFactors.Clear();
			(RimeReader Reader, uint Count) s_ZoomInOutMeshTransitionFactors = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ZoomInOutMeshTransitionFactors.Count; ++i)
			{
				var s_Value = s_ZoomInOutMeshTransitionFactors.Reader.ReadSingle();
				p_Instance.ZoomInOutMeshTransitionFactors.Add(s_Value);
			}
			
			s_ZoomInOutMeshTransitionFactors.Reader.Dispose();
			fb.AnimationConfigurationData.Deserialize(p_Instance.AnimationConfiguration, p_Reader, p_Parser);
			p_Instance.AnimatedFireType = (AnimatedFireEnum) p_Reader.ReadInt32();
		}

	}
}
