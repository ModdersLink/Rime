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
	public class UINodeData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } // 0x8 (8)
		
		[ContainerField(12)]
		public CtrRef<UIGraphAsset> ParentGraph { get; set; } = new CtrRef<UIGraphAsset>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool IsRootNode { get; set; } // 0x10 (16)
		
		[ContainerField(17), LayoutImmutable, Blittable]
		public bool ParentIsScreen { get; set; } // 0x11 (17)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 2657729557:
					ParentGraph = (CtrRef<UIGraphAsset>) p_Value;
					break;

				case 3972191865:
					IsRootNode = (bool) p_Value;
					break;

				case 2101493199:
					ParentIsScreen = (bool) p_Value;
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
				case 2088949890:
					return Name;

				case 2657729557:
					return ParentGraph;

				case 3972191865:
					return IsRootNode;

				case 2101493199:
					return ParentIsScreen;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(UINodeData).GetProperty(nameof(Name));

				case 2657729557:
					return typeof(UINodeData).GetProperty(nameof(ParentGraph));

				case 3972191865:
					return typeof(UINodeData).GetProperty(nameof(IsRootNode));

				case 2101493199:
					return typeof(UINodeData).GetProperty(nameof(ParentIsScreen));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
