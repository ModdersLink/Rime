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
	public class AntAnimatableData
	{
		[ContainerField(0)]
		public AntRef Actor { get; set; } = new();
		
		[ContainerField(4)]
		public CtrRef<ProceduralAwarenessAntRefs> ProceduralAwareness { get; set; } = new();
		
		[ContainerField(8)]
		public AntRef RightHandEffectorDisableOverride { get; set; } = new();
		
		[ContainerField(12)]
		public AntRef LeftHandEffectorDisableOverride { get; set; } = new();
		
		[ContainerField(16)]
		public CtrRef<MasterSkeletonAsset> MasterSkeletonAsset { get; set; } = new();
		
		public static void Deserialize(AntAnimatableData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AntRef.Deserialize(p_Instance.Actor, p_Reader, p_Parser);
			p_Instance.ProceduralAwareness.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			fb.AntRef.Deserialize(p_Instance.RightHandEffectorDisableOverride, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.LeftHandEffectorDisableOverride, p_Reader, p_Parser);
			p_Instance.MasterSkeletonAsset.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}
	}
}
