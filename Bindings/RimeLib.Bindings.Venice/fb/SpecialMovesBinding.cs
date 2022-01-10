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
	[ContainerType(4, 48)]
	public class SpecialMovesBinding
	{
		[ContainerField(0)]
		public AntRef TriggerHighVault { get; set; } = new();
		
		[ContainerField(4)]
		public AntRef TriggerUpVault { get; set; } = new();
		
		[ContainerField(8)]
		public AntRef TriggerLowVault { get; set; } = new();
		
		[ContainerField(12)]
		public AntRef TriggerSlideIntoProne { get; set; } = new();
		
		[ContainerField(16)]
		public AntRef TriggerSpecialAnimation { get; set; } = new();
		
		[ContainerField(20)]
		public AntRef SpecialAnimationIndex { get; set; } = new();
		
		[ContainerField(24)]
		public AntRef ObjectHeight { get; set; } = new();
		
		[ContainerField(28)]
		public AntRef ObjectDistance { get; set; } = new();
		
		[ContainerField(32)]
		public AntRef StartObjectDistanceTimer { get; set; } = new();
		
		[ContainerField(36)]
		public AntRef VaultObjectPositionX { get; set; } = new();
		
		[ContainerField(40)]
		public AntRef VaultObjectPositionZ { get; set; } = new();
		
		[ContainerField(44)]
		public AntRef CancelAnimation { get; set; } = new();
		
		public static void Deserialize(SpecialMovesBinding p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AntRef.Deserialize(p_Instance.TriggerHighVault, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.TriggerUpVault, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.TriggerLowVault, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.TriggerSlideIntoProne, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.TriggerSpecialAnimation, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.SpecialAnimationIndex, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.ObjectHeight, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.ObjectDistance, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.StartObjectDistanceTimer, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.VaultObjectPositionX, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.VaultObjectPositionZ, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.CancelAnimation, p_Reader, p_Parser);
		}
	}
}
