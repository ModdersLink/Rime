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
	public class AntAnimationHandlerData
	{
		[ContainerField(0)]
		public AntAnimatableData Animatable { get; set; } = new();
		
		[ContainerField(20)]
		public AntRef RootController { get; set; } = new();
		
		[ContainerField(24)]
		public LodBinding LodBinding { get; set; } = new();
		
		[ContainerField(36)]
		public List<CtrRef<AntPackageAsset>> AntPackageData { get; set; } = new();
		
		[ContainerField(40)]
		public List<GameplayBone> BonesToMirror { get; set; } = new();
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public bool ReportBackFromAnt { get; set; }
		
		[ContainerField(45), LayoutImmutable, Blittable]
		public bool EnableMasterSlaveCopy { get; set; }
		
		[ContainerField(46), LayoutImmutable, Blittable]
		public bool IsProp { get; set; }
		
		public static void Deserialize(AntAnimationHandlerData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AntAnimatableData.Deserialize(p_Instance.Animatable, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.RootController, p_Reader, p_Parser);
			fb.LodBinding.Deserialize(p_Instance.LodBinding, p_Reader, p_Parser);
			p_Instance.AntPackageData.Clear();
			(RimeReader Reader, uint Count) s_AntPackageData = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_AntPackageData.Count; ++i)
			{
				var s_CtrRef = new CtrRef<AntPackageAsset>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_AntPackageData.Reader.ReadUInt32()));
				p_Instance.AntPackageData.Add(s_CtrRef);
			}
			
			s_AntPackageData.Reader.Dispose();
			p_Instance.BonesToMirror.Clear();
			(RimeReader Reader, uint Count) s_BonesToMirror = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_BonesToMirror.Count; ++i)
			{
				var s_Value = new GameplayBone();
				fb.GameplayBone.Deserialize(s_Value, s_BonesToMirror.Reader, p_Parser);
				p_Instance.BonesToMirror.Add(s_Value);
			}
			
			s_BonesToMirror.Reader.Dispose();
			p_Instance.ReportBackFromAnt = p_Reader.ReadBool();
			p_Instance.EnableMasterSlaveCopy = p_Reader.ReadBool();
			p_Instance.IsProp = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}
	}
}
