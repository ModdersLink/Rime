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
	public class InstanceOutputNode : 
		UINodeData
	{
		[ContainerField(20)]
		public CtrRef<UINodePort> In { get; set; } = new CtrRef<UINodePort>(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public int Id { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public bool DestroyGraph { get; set; } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (CtrRef<UINodePort>) p_Value;
					break;

				case 5862152:
					Id = (int) p_Value;
					break;

				case 3848224203:
					DestroyGraph = (bool) p_Value;
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

				case 5862152:
					return Id;

				case 3848224203:
					return DestroyGraph;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(InstanceOutputNode).GetProperty(nameof(In));

				case 5862152:
					return typeof(InstanceOutputNode).GetProperty(nameof(Id));

				case 3848224203:
					return typeof(InstanceOutputNode).GetProperty(nameof(DestroyGraph));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
