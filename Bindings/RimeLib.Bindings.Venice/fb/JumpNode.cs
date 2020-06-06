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
	public class JumpNode : 
		UINodeData
	{
		[ContainerField(20)]
		public CtrRef<UINodePort> In { get; set; } = new CtrRef<UINodePort>(); // 0x14 (20)
		
		[ContainerField(24)]
		public CtrRef<UINodeData> TargetNode { get; set; } = new CtrRef<UINodeData>(); // 0x18 (24)
		
		[ContainerField(28)]
		public CtrRef<UINodePort> TargetPort { get; set; } = new CtrRef<UINodePort>(); // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (CtrRef<UINodePort>) p_Value;
					break;

				case 328873140:
					TargetNode = (CtrRef<UINodeData>) p_Value;
					break;

				case 328235565:
					TargetPort = (CtrRef<UINodePort>) p_Value;
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

				case 328873140:
					return TargetNode;

				case 328235565:
					return TargetPort;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(JumpNode).GetProperty(nameof(In));

				case 328873140:
					return typeof(JumpNode).GetProperty(nameof(TargetNode));

				case 328235565:
					return typeof(JumpNode).GetProperty(nameof(TargetPort));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
