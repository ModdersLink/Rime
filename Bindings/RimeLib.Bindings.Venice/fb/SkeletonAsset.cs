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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 44)]
	public class SkeletonAsset : 
		BaseSkeletonAsset
	{
		protected List<string> m_BoneNames = new List<string>();
		[ContainerField(Name: "BoneNames", Offset: 12, NameHash: 951771351, Flags: 65)]
		public List<string> BoneNames { get { return m_BoneNames; } set { if (OnPropertyChanging("SkeletonAsset." + nameof(BoneNames), this, m_BoneNames, value)) m_BoneNames = value; } } // 0xC (12)
		
		protected List<int> m_Hierarchy = new List<int>();
		[ContainerField(Name: "Hierarchy", Offset: 16, NameHash: 2981249554, Flags: 65)]
		public List<int> Hierarchy { get { return m_Hierarchy; } set { if (OnPropertyChanging("SkeletonAsset." + nameof(Hierarchy), this, m_Hierarchy, value)) m_Hierarchy = value; } } // 0x10 (16)
		
		protected List<LinearTransform> m_LocalPose = new List<LinearTransform>();
		[ContainerField(Name: "LocalPose", Offset: 20, NameHash: 773169313, Flags: 65)]
		public List<LinearTransform> LocalPose { get { return m_LocalPose; } set { if (OnPropertyChanging("SkeletonAsset." + nameof(LocalPose), this, m_LocalPose, value)) m_LocalPose = value; } } // 0x14 (20)
		
		protected List<LinearTransform> m_ModelPose = new List<LinearTransform>();
		[ContainerField(Name: "ModelPose", Offset: 24, NameHash: 4243999587, Flags: 65)]
		public List<LinearTransform> ModelPose { get { return m_ModelPose; } set { if (OnPropertyChanging("SkeletonAsset." + nameof(ModelPose), this, m_ModelPose, value)) m_ModelPose = value; } } // 0x18 (24)
		
		protected string m_WeaponBoneName = string.Empty;
		[ContainerField(Name: "WeaponBoneName", Offset: 28, NameHash: 4180015014, Flags: 16509), LayoutImmutable]
		public string WeaponBoneName { get { return m_WeaponBoneName; } set { if (OnPropertyChanging("SkeletonAsset." + nameof(WeaponBoneName), this, m_WeaponBoneName, value)) m_WeaponBoneName = value; } } // 0x1C (28)
		
		protected string m_HeadBoneName = string.Empty;
		[ContainerField(Name: "HeadBoneName", Offset: 32, NameHash: 3359050476, Flags: 16509), LayoutImmutable]
		public string HeadBoneName { get { return m_HeadBoneName; } set { if (OnPropertyChanging("SkeletonAsset." + nameof(HeadBoneName), this, m_HeadBoneName, value)) m_HeadBoneName = value; } } // 0x20 (32)
		
		protected string m_HipBoneName = string.Empty;
		[ContainerField(Name: "HipBoneName", Offset: 36, NameHash: 3967379317, Flags: 16509), LayoutImmutable]
		public string HipBoneName { get { return m_HipBoneName; } set { if (OnPropertyChanging("SkeletonAsset." + nameof(HipBoneName), this, m_HipBoneName, value)) m_HipBoneName = value; } } // 0x24 (36)
		
		protected string m_CameraBoneName = string.Empty;
		[ContainerField(Name: "CameraBoneName", Offset: 40, NameHash: 771838749, Flags: 16509), LayoutImmutable]
		public string CameraBoneName { get { return m_CameraBoneName; } set { if (OnPropertyChanging("SkeletonAsset." + nameof(CameraBoneName), this, m_CameraBoneName, value)) m_CameraBoneName = value; } } // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 951771351:
					BoneNames = (List<string>) p_Value;
					break;

				case 2981249554:
					Hierarchy = (List<int>) p_Value;
					break;

				case 773169313:
					LocalPose = (List<LinearTransform>) p_Value;
					break;

				case 4243999587:
					ModelPose = (List<LinearTransform>) p_Value;
					break;

				case 4180015014:
					WeaponBoneName = (string) p_Value;
					break;

				case 3359050476:
					HeadBoneName = (string) p_Value;
					break;

				case 3967379317:
					HipBoneName = (string) p_Value;
					break;

				case 771838749:
					CameraBoneName = (string) p_Value;
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
				case 951771351:
					return BoneNames;

				case 2981249554:
					return Hierarchy;

				case 773169313:
					return LocalPose;

				case 4243999587:
					return ModelPose;

				case 4180015014:
					return WeaponBoneName;

				case 3359050476:
					return HeadBoneName;

				case 3967379317:
					return HipBoneName;

				case 771838749:
					return CameraBoneName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 951771351:
					return typeof(SkeletonAsset).GetProperty(nameof(BoneNames));

				case 2981249554:
					return typeof(SkeletonAsset).GetProperty(nameof(Hierarchy));

				case 773169313:
					return typeof(SkeletonAsset).GetProperty(nameof(LocalPose));

				case 4243999587:
					return typeof(SkeletonAsset).GetProperty(nameof(ModelPose));

				case 4180015014:
					return typeof(SkeletonAsset).GetProperty(nameof(WeaponBoneName));

				case 3359050476:
					return typeof(SkeletonAsset).GetProperty(nameof(HeadBoneName));

				case 3967379317:
					return typeof(SkeletonAsset).GetProperty(nameof(HipBoneName));

				case 771838749:
					return typeof(SkeletonAsset).GetProperty(nameof(CameraBoneName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
