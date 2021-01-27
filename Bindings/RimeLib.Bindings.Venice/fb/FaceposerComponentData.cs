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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 128)]
	public class FaceposerComponentData : 
		ComponentData
	{
		protected AntRef m_FacePoserEnabled = new AntRef();
		[ContainerField(Name: "FacePoserEnabled", Offset: 96, NameHash: 3981181402, Flags: 41)]
		public AntRef FacePoserEnabled { get { return m_FacePoserEnabled; } set { if (OnPropertyChanging("FaceposerComponentData." + nameof(FacePoserEnabled), this, m_FacePoserEnabled, value)) m_FacePoserEnabled = value; } } // 0x60 (96)
		
		protected float m_LodDistance = new float();
		[ContainerField(Name: "LodDistance", Offset: 100, NameHash: 3054638721, Flags: 49469), LayoutImmutable, Blittable]
		public float LodDistance { get { return m_LodDistance; } set { if (OnPropertyChanging("FaceposerComponentData." + nameof(LodDistance), this, m_LodDistance, value)) m_LodDistance = value; } } // 0x64 (100)
		
		protected AntRef m_FacePoseLibraryReference = new AntRef();
		[ContainerField(Name: "FacePoseLibraryReference", Offset: 104, NameHash: 3854286233, Flags: 41)]
		public AntRef FacePoseLibraryReference { get { return m_FacePoseLibraryReference; } set { if (OnPropertyChanging("FaceposerComponentData." + nameof(FacePoseLibraryReference), this, m_FacePoseLibraryReference, value)) m_FacePoseLibraryReference = value; } } // 0x68 (104)
		
		protected List<AntRef> m_FacePoseLibrary = new List<AntRef>();
		[ContainerField(Name: "FacePoseLibrary", Offset: 108, NameHash: 2634820946, Flags: 65)]
		public List<AntRef> FacePoseLibrary { get { return m_FacePoseLibrary; } set { if (OnPropertyChanging("FaceposerComponentData." + nameof(FacePoseLibrary), this, m_FacePoseLibrary, value)) m_FacePoseLibrary = value; } } // 0x6C (108)
		
		protected string m_FacePoserDofSetName = string.Empty;
		[ContainerField(Name: "FacePoserDofSetName", Offset: 112, NameHash: 691847159, Flags: 16509), LayoutImmutable]
		public string FacePoserDofSetName { get { return m_FacePoserDofSetName; } set { if (OnPropertyChanging("FaceposerComponentData." + nameof(FacePoserDofSetName), this, m_FacePoserDofSetName, value)) m_FacePoserDofSetName = value; } } // 0x70 (112)
		
		protected List<string> m_ShaderExposedValues = new List<string>();
		[ContainerField(Name: "ShaderExposedValues", Offset: 116, NameHash: 777076420, Flags: 65)]
		public List<string> ShaderExposedValues { get { return m_ShaderExposedValues; } set { if (OnPropertyChanging("FaceposerComponentData." + nameof(ShaderExposedValues), this, m_ShaderExposedValues, value)) m_ShaderExposedValues = value; } } // 0x74 (116)
		
		protected int m_FacePoseLibraryIndex = new int();
		[ContainerField(Name: "FacePoseLibraryIndex", Offset: 120, NameHash: 1630333484, Flags: 49405), LayoutImmutable, Blittable]
		public int FacePoseLibraryIndex { get { return m_FacePoseLibraryIndex; } set { if (OnPropertyChanging("FaceposerComponentData." + nameof(FacePoseLibraryIndex), this, m_FacePoseLibraryIndex, value)) m_FacePoseLibraryIndex = value; } } // 0x78 (120)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3981181402:
					FacePoserEnabled = (AntRef) p_Value;
					break;

				case 3054638721:
					LodDistance = (float) p_Value;
					break;

				case 3854286233:
					FacePoseLibraryReference = (AntRef) p_Value;
					break;

				case 2634820946:
					FacePoseLibrary = (List<AntRef>) p_Value;
					break;

				case 691847159:
					FacePoserDofSetName = (string) p_Value;
					break;

				case 777076420:
					ShaderExposedValues = (List<string>) p_Value;
					break;

				case 1630333484:
					FacePoseLibraryIndex = (int) p_Value;
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
				case 3981181402:
					return FacePoserEnabled;

				case 3054638721:
					return LodDistance;

				case 3854286233:
					return FacePoseLibraryReference;

				case 2634820946:
					return FacePoseLibrary;

				case 691847159:
					return FacePoserDofSetName;

				case 777076420:
					return ShaderExposedValues;

				case 1630333484:
					return FacePoseLibraryIndex;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3981181402:
					return typeof(FaceposerComponentData).GetProperty(nameof(FacePoserEnabled));

				case 3054638721:
					return typeof(FaceposerComponentData).GetProperty(nameof(LodDistance));

				case 3854286233:
					return typeof(FaceposerComponentData).GetProperty(nameof(FacePoseLibraryReference));

				case 2634820946:
					return typeof(FaceposerComponentData).GetProperty(nameof(FacePoseLibrary));

				case 691847159:
					return typeof(FaceposerComponentData).GetProperty(nameof(FacePoserDofSetName));

				case 777076420:
					return typeof(FaceposerComponentData).GetProperty(nameof(ShaderExposedValues));

				case 1630333484:
					return typeof(FaceposerComponentData).GetProperty(nameof(FacePoseLibraryIndex));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
