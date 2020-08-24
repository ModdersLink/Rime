///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4), MemberInfoFlag(41), ContainerStruct]
	public class AntAnimationHandlerData : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(41)]
		public AntAnimatableData Animatable { get; set; } = new AntAnimatableData(); // 0x0 (0)
		
		[ContainerField(20), MemberInfoFlag(41)]
		public AntRef RootController { get; set; } = new AntRef(); // 0x14 (20)
		
		[ContainerField(24), MemberInfoFlag(41)]
		public LodBinding LodBinding { get; set; } = new LodBinding(); // 0x18 (24)
		
		[ContainerField(36), MemberInfoFlag(65), ContainerRefArray]
		public RefArray<AntPackageAsset> AntPackageData { get; set; } = new RefArray<AntPackageAsset>(); // 0x24 (36)
		
		[ContainerField(40), MemberInfoFlag(65), ContainerArray]
		public List<GameplayBone> BonesToMirror { get; set; } = new List<GameplayBone>(); // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool ReportBackFromAnt { get; set; } // 0x2C (44)
		
		[ContainerField(45), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool EnableMasterSlaveCopy { get; set; } // 0x2D (45)
		
		[ContainerField(46), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool IsProp { get; set; } // 0x2E (46)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3208693873:
					Animatable = (AntAnimatableData) p_Value;
					break;

				case 3403232383:
					RootController = (AntRef) p_Value;
					break;

				case 3718483171:
					LodBinding = (LodBinding) p_Value;
					break;

				case 1530906868:
					AntPackageData = (RefArray<AntPackageAsset>) p_Value;
					break;

				case 4237573170:
					BonesToMirror = (List<GameplayBone>) p_Value;
					break;

				case 3577562349:
					ReportBackFromAnt = (bool) p_Value;
					break;

				case 4006836336:
					EnableMasterSlaveCopy = (bool) p_Value;
					break;

				case 2816600898:
					IsProp = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3208693873:
					return Animatable;

				case 3403232383:
					return RootController;

				case 3718483171:
					return LodBinding;

				case 1530906868:
					return AntPackageData;

				case 4237573170:
					return BonesToMirror;

				case 3577562349:
					return ReportBackFromAnt;

				case 4006836336:
					return EnableMasterSlaveCopy;

				case 2816600898:
					return IsProp;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3208693873:
					return typeof(AntAnimationHandlerData).GetProperty(nameof(Animatable));

				case 3403232383:
					return typeof(AntAnimationHandlerData).GetProperty(nameof(RootController));

				case 3718483171:
					return typeof(AntAnimationHandlerData).GetProperty(nameof(LodBinding));

				case 1530906868:
					return typeof(AntAnimationHandlerData).GetProperty(nameof(AntPackageData));

				case 4237573170:
					return typeof(AntAnimationHandlerData).GetProperty(nameof(BonesToMirror));

				case 3577562349:
					return typeof(AntAnimationHandlerData).GetProperty(nameof(ReportBackFromAnt));

				case 4006836336:
					return typeof(AntAnimationHandlerData).GetProperty(nameof(EnableMasterSlaveCopy));

				case 2816600898:
					return typeof(AntAnimationHandlerData).GetProperty(nameof(IsProp));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
