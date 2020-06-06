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
    [ContainerType(4)]
	public class FaceAnimationWaveMappings : 
		DataContainer
	{
		[ContainerField(8)]
		public AntRef AntAsset { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(12)]
		public AntRef OnStartedTalking { get; set; } = new AntRef(); // 0xC (12)
		
		[ContainerField(16)]
		public List<FaceAnimationWaveMapping> Mappings { get; set; } = new List<FaceAnimationWaveMapping>(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1873036974:
					AntAsset = (AntRef) p_Value;
					break;

				case 2148011415:
					OnStartedTalking = (AntRef) p_Value;
					break;

				case 673881690:
					Mappings = (List<FaceAnimationWaveMapping>) p_Value;
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
				case 1873036974:
					return AntAsset;

				case 2148011415:
					return OnStartedTalking;

				case 673881690:
					return Mappings;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1873036974:
					return typeof(FaceAnimationWaveMappings).GetProperty(nameof(AntAsset));

				case 2148011415:
					return typeof(FaceAnimationWaveMappings).GetProperty(nameof(OnStartedTalking));

				case 673881690:
					return typeof(FaceAnimationWaveMappings).GetProperty(nameof(Mappings));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
