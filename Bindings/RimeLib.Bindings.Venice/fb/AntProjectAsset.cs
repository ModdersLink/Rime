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
	[ContainerType(4)]
	public class AntProjectAsset : 
		Asset
	{
		protected RefArray<AntPackageAsset> m_PackageAssets = new RefArray<AntPackageAsset>();
		[ContainerField(12), ContainerFieldNameHash(765658940)]
		public RefArray<AntPackageAsset> PackageAssets { get { return m_PackageAssets; } set { if (OnPropertyChanging("AntProjectAsset." + nameof(PackageAssets), this, m_PackageAssets, value)) m_PackageAssets = value; } } // 0xC (12)
		
		protected string m_AntNativeProjectName = new string();
		[ContainerField(16), LayoutImmutable, ContainerFieldNameHash(3945376013)]
		public string AntNativeProjectName { get { return m_AntNativeProjectName; } set { if (OnPropertyChanging("AntProjectAsset." + nameof(AntNativeProjectName), this, m_AntNativeProjectName, value)) m_AntNativeProjectName = value; } } // 0x10 (16)
		
		protected AntRef m_SceneOp = new AntRef();
		[ContainerField(20), ContainerFieldNameHash(2689985284)]
		public AntRef SceneOp { get { return m_SceneOp; } set { if (OnPropertyChanging("AntProjectAsset." + nameof(SceneOp), this, m_SceneOp, value)) m_SceneOp = value; } } // 0x14 (20)
		
		protected int m_ProjectId = new int();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(4152360413)]
		public int ProjectId { get { return m_ProjectId; } set { if (OnPropertyChanging("AntProjectAsset." + nameof(ProjectId), this, m_ProjectId, value)) m_ProjectId = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 765658940:
					PackageAssets = (RefArray<AntPackageAsset>) p_Value;
					break;

				case 3945376013:
					AntNativeProjectName = (string) p_Value;
					break;

				case 2689985284:
					SceneOp = (AntRef) p_Value;
					break;

				case 4152360413:
					ProjectId = (int) p_Value;
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
				case 765658940:
					return PackageAssets;

				case 3945376013:
					return AntNativeProjectName;

				case 2689985284:
					return SceneOp;

				case 4152360413:
					return ProjectId;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 765658940:
					return typeof(AntProjectAsset).GetProperty(nameof(PackageAssets));

				case 3945376013:
					return typeof(AntProjectAsset).GetProperty(nameof(AntNativeProjectName));

				case 2689985284:
					return typeof(AntProjectAsset).GetProperty(nameof(SceneOp));

				case 4152360413:
					return typeof(AntProjectAsset).GetProperty(nameof(ProjectId));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
