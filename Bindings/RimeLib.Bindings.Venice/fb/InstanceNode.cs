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
	public class InstanceNode : 
		UINodeData
	{
		[ContainerField(20)]
		public CtrRef<UIGraphAsset> UIGraph { get; set; } = new CtrRef<UIGraphAsset>(); // 0x14 (20)
		
		[ContainerField(24)]
		public RefArray<UINodePort> Inputs { get; set; } = new RefArray<UINodePort>(); // 0x18 (24)
		
		[ContainerField(28)]
		public RefArray<UINodePort> Outputs { get; set; } = new RefArray<UINodePort>(); // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 209526997:
					UIGraph = (CtrRef<UIGraphAsset>) p_Value;
					break;

				case 2784267136:
					Inputs = (RefArray<UINodePort>) p_Value;
					break;

				case 1070022089:
					Outputs = (RefArray<UINodePort>) p_Value;
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
				case 209526997:
					return UIGraph;

				case 2784267136:
					return Inputs;

				case 1070022089:
					return Outputs;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 209526997:
					return typeof(InstanceNode).GetProperty(nameof(UIGraph));

				case 2784267136:
					return typeof(InstanceNode).GetProperty(nameof(Inputs));

				case 1070022089:
					return typeof(InstanceNode).GetProperty(nameof(Outputs));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
