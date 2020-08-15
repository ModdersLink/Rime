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
	public class MatrixPannerNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_In = new AudioGraphNodePort();
		[ContainerField(8), ContainerFieldNameHash(5862146)]
		public AudioGraphNodePort In { get { return m_In; } set { if (OnPropertyChanging("MatrixPannerNodeData." + nameof(In), this, m_In, value)) m_In = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_FrontLeft = new AudioGraphNodePort();
		[ContainerField(16), ContainerFieldNameHash(3661933983)]
		public AudioGraphNodePort FrontLeft { get { return m_FrontLeft; } set { if (OnPropertyChanging("MatrixPannerNodeData." + nameof(FrontLeft), this, m_FrontLeft, value)) m_FrontLeft = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_Center = new AudioGraphNodePort();
		[ContainerField(24), ContainerFieldNameHash(2711667502)]
		public AudioGraphNodePort Center { get { return m_Center; } set { if (OnPropertyChanging("MatrixPannerNodeData." + nameof(Center), this, m_Center, value)) m_Center = value; } } // 0x18 (24)
		
		protected AudioGraphNodePort m_FrontRight = new AudioGraphNodePort();
		[ContainerField(32), ContainerFieldNameHash(596883716)]
		public AudioGraphNodePort FrontRight { get { return m_FrontRight; } set { if (OnPropertyChanging("MatrixPannerNodeData." + nameof(FrontRight), this, m_FrontRight, value)) m_FrontRight = value; } } // 0x20 (32)
		
		protected AudioGraphNodePort m_RearLeft = new AudioGraphNodePort();
		[ContainerField(40), ContainerFieldNameHash(589355322)]
		public AudioGraphNodePort RearLeft { get { return m_RearLeft; } set { if (OnPropertyChanging("MatrixPannerNodeData." + nameof(RearLeft), this, m_RearLeft, value)) m_RearLeft = value; } } // 0x28 (40)
		
		protected AudioGraphNodePort m_Lfe = new AudioGraphNodePort();
		[ContainerField(48), ContainerFieldNameHash(193454378)]
		public AudioGraphNodePort Lfe { get { return m_Lfe; } set { if (OnPropertyChanging("MatrixPannerNodeData." + nameof(Lfe), this, m_Lfe, value)) m_Lfe = value; } } // 0x30 (48)
		
		protected AudioGraphNodePort m_RearRight = new AudioGraphNodePort();
		[ContainerField(56), ContainerFieldNameHash(2271801345)]
		public AudioGraphNodePort RearRight { get { return m_RearRight; } set { if (OnPropertyChanging("MatrixPannerNodeData." + nameof(RearRight), this, m_RearRight, value)) m_RearRight = value; } } // 0x38 (56)
		
		protected AudioGraphNodePort m_FarRearLeft = new AudioGraphNodePort();
		[ContainerField(64), ContainerFieldNameHash(2476281583)]
		public AudioGraphNodePort FarRearLeft { get { return m_FarRearLeft; } set { if (OnPropertyChanging("MatrixPannerNodeData." + nameof(FarRearLeft), this, m_FarRearLeft, value)) m_FarRearLeft = value; } } // 0x40 (64)
		
		protected AudioGraphNodePort m_FarRearRight = new AudioGraphNodePort();
		[ContainerField(72), ContainerFieldNameHash(96303284)]
		public AudioGraphNodePort FarRearRight { get { return m_FarRearRight; } set { if (OnPropertyChanging("MatrixPannerNodeData." + nameof(FarRearRight), this, m_FarRearRight, value)) m_FarRearRight = value; } } // 0x48 (72)
		
		protected AudioGraphNodePort m_Out = new AudioGraphNodePort();
		[ContainerField(80), ContainerFieldNameHash(193453899)]
		public AudioGraphNodePort Out { get { return m_Out; } set { if (OnPropertyChanging("MatrixPannerNodeData." + nameof(Out), this, m_Out, value)) m_Out = value; } } // 0x50 (80)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (AudioGraphNodePort) p_Value;
					break;

				case 3661933983:
					FrontLeft = (AudioGraphNodePort) p_Value;
					break;

				case 2711667502:
					Center = (AudioGraphNodePort) p_Value;
					break;

				case 596883716:
					FrontRight = (AudioGraphNodePort) p_Value;
					break;

				case 589355322:
					RearLeft = (AudioGraphNodePort) p_Value;
					break;

				case 193454378:
					Lfe = (AudioGraphNodePort) p_Value;
					break;

				case 2271801345:
					RearRight = (AudioGraphNodePort) p_Value;
					break;

				case 2476281583:
					FarRearLeft = (AudioGraphNodePort) p_Value;
					break;

				case 96303284:
					FarRearRight = (AudioGraphNodePort) p_Value;
					break;

				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
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
				case 5862146:
					return In;

				case 3661933983:
					return FrontLeft;

				case 2711667502:
					return Center;

				case 596883716:
					return FrontRight;

				case 589355322:
					return RearLeft;

				case 193454378:
					return Lfe;

				case 2271801345:
					return RearRight;

				case 2476281583:
					return FarRearLeft;

				case 96303284:
					return FarRearRight;

				case 193453899:
					return Out;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(MatrixPannerNodeData).GetProperty(nameof(In));

				case 3661933983:
					return typeof(MatrixPannerNodeData).GetProperty(nameof(FrontLeft));

				case 2711667502:
					return typeof(MatrixPannerNodeData).GetProperty(nameof(Center));

				case 596883716:
					return typeof(MatrixPannerNodeData).GetProperty(nameof(FrontRight));

				case 589355322:
					return typeof(MatrixPannerNodeData).GetProperty(nameof(RearLeft));

				case 193454378:
					return typeof(MatrixPannerNodeData).GetProperty(nameof(Lfe));

				case 2271801345:
					return typeof(MatrixPannerNodeData).GetProperty(nameof(RearRight));

				case 2476281583:
					return typeof(MatrixPannerNodeData).GetProperty(nameof(FarRearLeft));

				case 96303284:
					return typeof(MatrixPannerNodeData).GetProperty(nameof(FarRearRight));

				case 193453899:
					return typeof(MatrixPannerNodeData).GetProperty(nameof(Out));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
