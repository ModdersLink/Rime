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
	public class CameraShakeNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort Pitch { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort Yaw { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24)]
		public AudioGraphNodePort Roll { get; set; } = new AudioGraphNodePort(); // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 232604323:
					Pitch = (AudioGraphNodePort) p_Value;
					break;

				case 193468618:
					Yaw = (AudioGraphNodePort) p_Value;
					break;

				case 2089387576:
					Roll = (AudioGraphNodePort) p_Value;
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
				case 232604323:
					return Pitch;

				case 193468618:
					return Yaw;

				case 2089387576:
					return Roll;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 232604323:
					return typeof(CameraShakeNodeData).GetProperty(nameof(Pitch));

				case 193468618:
					return typeof(CameraShakeNodeData).GetProperty(nameof(Yaw));

				case 2089387576:
					return typeof(CameraShakeNodeData).GetProperty(nameof(Roll));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
