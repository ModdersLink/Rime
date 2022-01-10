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
	[ContainerType(16, 96)]
	public class AnimatedCameraData : 
		CameraData
	{
		[ContainerField(80)]
		public CtrRef<SkeletonAsset> Skeleton { get; set; } = new();

		[ContainerField(84), LayoutImmutable]
		public string CameraBone { get; set; } = string.Empty;

		[ContainerField(88), LayoutImmutable]
		public string FovBone { get; set; } = string.Empty;

		public static void Deserialize(AnimatedCameraData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Skeleton.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.CameraBone = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.FovBone = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
