///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class FaceposerComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public AntRef FacePoserEnabled { get; set; } = new AntRef(); // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float LodDistance { get; set; } // 0x64 (100)
		
		[ContainerField(104)]
		public AntRef FacePoseLibraryReference { get; set; } = new AntRef(); // 0x68 (104)
		
		[ContainerField(108)]
		public List<AntRef> FacePoseLibrary { get; set; } = new List<AntRef>(); // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable]
		public string FacePoserDofSetName { get; set; } // 0x70 (112)
		
		[ContainerField(116)]
		public List<string> ShaderExposedValues { get; set; } = new List<string>(); // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public int FacePoseLibraryIndex { get; set; } // 0x78 (120)
		
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
