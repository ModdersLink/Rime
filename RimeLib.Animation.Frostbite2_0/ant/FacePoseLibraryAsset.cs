///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// As type schemas dont contain full information, modifying  //
// can be done to fix information thats wrong or missing.    //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using RimeLib.Animation.EA.Attributes;
using RimeLib.Animation.EA.Types;

namespace ant
{

	[AntBinding(0x9cea05e1)]
	public class FacePoseLibraryAsset
		: AntObject
	{
		[AntField(0)]
		public List<DofNameEntry?> ScaleDofNameList { get; set; } = new();

		[AntField(1)]
		public List<DofNameEntry?> QuaternionDofNameList { get; set; } = new();

		[AntField(2)]
		public List<DofNameEntry?> TranslationDofNameList { get; set; } = new();

		[AntField(3)]
		public List<AntVector3> BindPoseScaleList { get; set; } = new();

		[AntField(4)]
		public List<AntQuaternion> BindPoseQuaternionList { get; set; } = new();

		[AntField(5)]
		public List<AntVector3> BindPoseTranslationList { get; set; } = new();

		[AntField(6)]
		public uint FacePoseNumPoses { get; set; }

		[AntField(7)]
		public List<AntVector3> FacePoseScaleList { get; set; } = new();

		[AntField(8)]
		public List<ushort> FacePoseScaleDofIndexList { get; set; } = new();

		[AntField(9)]
		public List<ushort> FacePoseScalePoseOffsetList { get; set; } = new();

		[AntField(10)]
		public List<AntQuaternion> FacePoseQuaternionList { get; set; } = new();

		[AntField(11)]
		public List<ushort> FacePoseQuaternionDofIndexList { get; set; } = new();

		[AntField(12)]
		public List<ushort> FacePoseQuaternionPoseOffsetList { get; set; } = new();

		[AntField(13)]
		public List<AntVector3> FacePoseTranslationList { get; set; } = new();

		[AntField(14)]
		public List<ushort> FacePoseTranslationDofIndexList { get; set; } = new();

		[AntField(15)]
		public List<ushort> FacePoseTranslationPoseOffsetList { get; set; } = new();

	}
}
