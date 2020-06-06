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
	public class VoiceOverStructureConnection : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<VoiceOverStructureNode> TargetNode { get; set; } = new CtrRef<VoiceOverStructureNode>(); // 0x8 (8)
		
		[ContainerField(12)]
		public CtrRef<VoiceOverRelationshipInput> TargetInput { get; set; } = new CtrRef<VoiceOverRelationshipInput>(); // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 328873140:
					TargetNode = (CtrRef<VoiceOverStructureNode>) p_Value;
					break;

				case 2268616418:
					TargetInput = (CtrRef<VoiceOverRelationshipInput>) p_Value;
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
				case 328873140:
					return TargetNode;

				case 2268616418:
					return TargetInput;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 328873140:
					return typeof(VoiceOverStructureConnection).GetProperty(nameof(TargetNode));

				case 2268616418:
					return typeof(VoiceOverStructureConnection).GetProperty(nameof(TargetInput));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
