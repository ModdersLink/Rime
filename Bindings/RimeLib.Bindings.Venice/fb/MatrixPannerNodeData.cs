///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class MatrixPannerNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort In { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort FrontLeft { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24)]
		public AudioGraphNodePort Center { get; set; } = new AudioGraphNodePort(); // 0x18 (24)
		
		[ContainerField(32)]
		public AudioGraphNodePort FrontRight { get; set; } = new AudioGraphNodePort(); // 0x20 (32)
		
		[ContainerField(40)]
		public AudioGraphNodePort RearLeft { get; set; } = new AudioGraphNodePort(); // 0x28 (40)
		
		[ContainerField(48)]
		public AudioGraphNodePort Lfe { get; set; } = new AudioGraphNodePort(); // 0x30 (48)
		
		[ContainerField(56)]
		public AudioGraphNodePort RearRight { get; set; } = new AudioGraphNodePort(); // 0x38 (56)
		
		[ContainerField(64)]
		public AudioGraphNodePort FarRearLeft { get; set; } = new AudioGraphNodePort(); // 0x40 (64)
		
		[ContainerField(72)]
		public AudioGraphNodePort FarRearRight { get; set; } = new AudioGraphNodePort(); // 0x48 (72)
		
		[ContainerField(80)]
		public AudioGraphNodePort Out { get; set; } = new AudioGraphNodePort(); // 0x50 (80)
		
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
