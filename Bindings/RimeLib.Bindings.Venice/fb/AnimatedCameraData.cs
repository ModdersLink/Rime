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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(96), ContainerClass]
	public class AnimatedCameraData : 
		CameraData
	{
		protected CtrRef<SkeletonAsset> m_Skeleton = new CtrRef<SkeletonAsset>();
		[ContainerField(80), MemberInfoFlag(53), ContainerFieldNameHash(291024164), ContainerCtrRef]
		public CtrRef<SkeletonAsset> Skeleton { get { return m_Skeleton; } set { if (OnPropertyChanging("AnimatedCameraData." + nameof(Skeleton), this, m_Skeleton, value)) m_Skeleton = value; } } // 0x50 (80)
		
		protected string m_CameraBone = string.Empty;
		[ContainerField(84), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(3220426650)]
		public string CameraBone { get { return m_CameraBone; } set { if (OnPropertyChanging("AnimatedCameraData." + nameof(CameraBone), this, m_CameraBone, value)) m_CameraBone = value; } } // 0x54 (84)
		
		protected string m_FovBone = string.Empty;
		[ContainerField(88), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(1981125884)]
		public string FovBone { get { return m_FovBone; } set { if (OnPropertyChanging("AnimatedCameraData." + nameof(FovBone), this, m_FovBone, value)) m_FovBone = value; } } // 0x58 (88)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 291024164:
					Skeleton = (CtrRef<SkeletonAsset>) p_Value;
					break;

				case 3220426650:
					CameraBone = (string) p_Value;
					break;

				case 1981125884:
					FovBone = (string) p_Value;
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
				case 291024164:
					return Skeleton;

				case 3220426650:
					return CameraBone;

				case 1981125884:
					return FovBone;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 291024164:
					return typeof(AnimatedCameraData).GetProperty(nameof(Skeleton));

				case 3220426650:
					return typeof(AnimatedCameraData).GetProperty(nameof(CameraBone));

				case 1981125884:
					return typeof(AnimatedCameraData).GetProperty(nameof(FovBone));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
