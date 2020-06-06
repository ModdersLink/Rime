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
	public class JoypadNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort LeftAnalogX { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort LeftAnalogY { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24)]
		public AudioGraphNodePort RightAnalogX { get; set; } = new AudioGraphNodePort(); // 0x18 (24)
		
		[ContainerField(32)]
		public AudioGraphNodePort RightAnalogY { get; set; } = new AudioGraphNodePort(); // 0x20 (32)
		
		[ContainerField(40)]
		public AudioGraphNodePort AButton { get; set; } = new AudioGraphNodePort(); // 0x28 (40)
		
		[ContainerField(48)]
		public AudioGraphNodePort BButton { get; set; } = new AudioGraphNodePort(); // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 295917164:
					LeftAnalogX = (AudioGraphNodePort) p_Value;
					break;

				case 295917165:
					LeftAnalogY = (AudioGraphNodePort) p_Value;
					break;

				case 3320326391:
					RightAnalogX = (AudioGraphNodePort) p_Value;
					break;

				case 3320326390:
					RightAnalogY = (AudioGraphNodePort) p_Value;
					break;

				case 1587158770:
					AButton = (AudioGraphNodePort) p_Value;
					break;

				case 1161921521:
					BButton = (AudioGraphNodePort) p_Value;
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
				case 295917164:
					return LeftAnalogX;

				case 295917165:
					return LeftAnalogY;

				case 3320326391:
					return RightAnalogX;

				case 3320326390:
					return RightAnalogY;

				case 1587158770:
					return AButton;

				case 1161921521:
					return BButton;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 295917164:
					return typeof(JoypadNodeData).GetProperty(nameof(LeftAnalogX));

				case 295917165:
					return typeof(JoypadNodeData).GetProperty(nameof(LeftAnalogY));

				case 3320326391:
					return typeof(JoypadNodeData).GetProperty(nameof(RightAnalogX));

				case 3320326390:
					return typeof(JoypadNodeData).GetProperty(nameof(RightAnalogY));

				case 1587158770:
					return typeof(JoypadNodeData).GetProperty(nameof(AButton));

				case 1161921521:
					return typeof(JoypadNodeData).GetProperty(nameof(BButton));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
