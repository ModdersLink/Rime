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
	[ContainerType(16)]
	public class FaceposerComponentData : 
		ComponentData
	{
		protected AntRef m_FacePoserEnabled = new AntRef();
		[ContainerField(96), ContainerFieldNameHash(3981181402)]
		public AntRef FacePoserEnabled { get { return m_FacePoserEnabled; } set { if (OnPropertyChanging("FaceposerComponentData." + nameof(FacePoserEnabled), this, m_FacePoserEnabled, value)) m_FacePoserEnabled = value; } } // 0x60 (96)
		
		protected float m_LodDistance = new float();
		[ContainerField(100), LayoutImmutable, Blittable, ContainerFieldNameHash(3054638721)]
		public float LodDistance { get { return m_LodDistance; } set { if (OnPropertyChanging("FaceposerComponentData." + nameof(LodDistance), this, m_LodDistance, value)) m_LodDistance = value; } } // 0x64 (100)
		
		protected AntRef m_FacePoseLibraryReference = new AntRef();
		[ContainerField(104), ContainerFieldNameHash(3854286233)]
		public AntRef FacePoseLibraryReference { get { return m_FacePoseLibraryReference; } set { if (OnPropertyChanging("FaceposerComponentData." + nameof(FacePoseLibraryReference), this, m_FacePoseLibraryReference, value)) m_FacePoseLibraryReference = value; } } // 0x68 (104)
		
		protected List<AntRef> m_FacePoseLibrary = new List<AntRef>();
		[ContainerField(108), ContainerFieldNameHash(2634820946)]
		public List<AntRef> FacePoseLibrary { get { return m_FacePoseLibrary; } set { if (OnPropertyChanging("FaceposerComponentData." + nameof(FacePoseLibrary), this, m_FacePoseLibrary, value)) m_FacePoseLibrary = value; } } // 0x6C (108)
		
		protected string m_FacePoserDofSetName = new string();
		[ContainerField(112), LayoutImmutable, ContainerFieldNameHash(691847159)]
		public string FacePoserDofSetName { get { return m_FacePoserDofSetName; } set { if (OnPropertyChanging("FaceposerComponentData." + nameof(FacePoserDofSetName), this, m_FacePoserDofSetName, value)) m_FacePoserDofSetName = value; } } // 0x70 (112)
		
		protected List<string> m_ShaderExposedValues = new List<string>();
		[ContainerField(116), ContainerFieldNameHash(777076420)]
		public List<string> ShaderExposedValues { get { return m_ShaderExposedValues; } set { if (OnPropertyChanging("FaceposerComponentData." + nameof(ShaderExposedValues), this, m_ShaderExposedValues, value)) m_ShaderExposedValues = value; } } // 0x74 (116)
		
		protected int m_FacePoseLibraryIndex = new int();
		[ContainerField(120), LayoutImmutable, Blittable, ContainerFieldNameHash(1630333484)]
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
