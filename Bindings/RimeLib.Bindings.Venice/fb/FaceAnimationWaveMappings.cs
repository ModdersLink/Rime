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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class FaceAnimationWaveMappings : 
		DataContainer
	{
		protected AntRef m_AntAsset = new AntRef();
		[ContainerField(Name: "AntAsset", Offset: 8, NameHash: 1873036974, Flags: 41)]
		public AntRef AntAsset { get { return m_AntAsset; } set { if (OnPropertyChanging("FaceAnimationWaveMappings." + nameof(AntAsset), this, m_AntAsset, value)) m_AntAsset = value; } } // 0x8 (8)
		
		protected AntRef m_OnStartedTalking = new AntRef();
		[ContainerField(Name: "OnStartedTalking", Offset: 12, NameHash: 2148011415, Flags: 41)]
		public AntRef OnStartedTalking { get { return m_OnStartedTalking; } set { if (OnPropertyChanging("FaceAnimationWaveMappings." + nameof(OnStartedTalking), this, m_OnStartedTalking, value)) m_OnStartedTalking = value; } } // 0xC (12)
		
		protected List<FaceAnimationWaveMapping> m_Mappings = new List<FaceAnimationWaveMapping>();
		[ContainerField(Name: "Mappings", Offset: 16, NameHash: 673881690, Flags: 65)]
		public List<FaceAnimationWaveMapping> Mappings { get { return m_Mappings; } set { if (OnPropertyChanging("FaceAnimationWaveMappings." + nameof(Mappings), this, m_Mappings, value)) m_Mappings = value; } } // 0x10 (16)
		
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
