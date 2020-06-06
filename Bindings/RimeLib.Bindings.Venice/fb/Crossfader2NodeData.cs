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
	public class Crossfader2NodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort Ctrl { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort CtrlOut1 { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24)]
		public AudioGraphNodePort CtrlOut2 { get; set; } = new AudioGraphNodePort(); // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088859916:
					Ctrl = (AudioGraphNodePort) p_Value;
					break;

				case 1670261395:
					CtrlOut1 = (AudioGraphNodePort) p_Value;
					break;

				case 1670261392:
					CtrlOut2 = (AudioGraphNodePort) p_Value;
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
				case 2088859916:
					return Ctrl;

				case 1670261395:
					return CtrlOut1;

				case 1670261392:
					return CtrlOut2;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088859916:
					return typeof(Crossfader2NodeData).GetProperty(nameof(Ctrl));

				case 1670261395:
					return typeof(Crossfader2NodeData).GetProperty(nameof(CtrlOut1));

				case 1670261392:
					return typeof(Crossfader2NodeData).GetProperty(nameof(CtrlOut2));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
