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
	public class OrientationNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort ListenerRelativeYaw { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort ListenerRelativePitch { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24)]
		public AudioGraphNodePort ListenerRelativeRoll { get; set; } = new AudioGraphNodePort(); // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3524495584:
					ListenerRelativeYaw = (AudioGraphNodePort) p_Value;
					break;

				case 2777770313:
					ListenerRelativePitch = (AudioGraphNodePort) p_Value;
					break;

				case 344546642:
					ListenerRelativeRoll = (AudioGraphNodePort) p_Value;
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
				case 3524495584:
					return ListenerRelativeYaw;

				case 2777770313:
					return ListenerRelativePitch;

				case 344546642:
					return ListenerRelativeRoll;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3524495584:
					return typeof(OrientationNodeData).GetProperty(nameof(ListenerRelativeYaw));

				case 2777770313:
					return typeof(OrientationNodeData).GetProperty(nameof(ListenerRelativePitch));

				case 344546642:
					return typeof(OrientationNodeData).GetProperty(nameof(ListenerRelativeRoll));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
