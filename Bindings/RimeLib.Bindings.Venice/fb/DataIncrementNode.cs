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
	public class DataIncrementNode : 
		UINodeData
	{
		[ContainerField(20)]
		public CtrRef<UINodePort> In { get; set; } = new CtrRef<UINodePort>(); // 0x14 (20)
		
		[ContainerField(24)]
		public CtrRef<UINodePort> Out { get; set; } = new CtrRef<UINodePort>(); // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float Max { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float Min { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float IncrementSize { get; set; } // 0x24 (36)
		
		[ContainerField(40)]
		public UIDataSourceInfo DataSource { get; set; } = new UIDataSourceInfo(); // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (CtrRef<UINodePort>) p_Value;
					break;

				case 193453899:
					Out = (CtrRef<UINodePort>) p_Value;
					break;

				case 193446865:
					Max = (float) p_Value;
					break;

				case 193446607:
					Min = (float) p_Value;
					break;

				case 834119169:
					IncrementSize = (float) p_Value;
					break;

				case 3810860200:
					DataSource = (UIDataSourceInfo) p_Value;
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

				case 193453899:
					return Out;

				case 193446865:
					return Max;

				case 193446607:
					return Min;

				case 834119169:
					return IncrementSize;

				case 3810860200:
					return DataSource;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(DataIncrementNode).GetProperty(nameof(In));

				case 193453899:
					return typeof(DataIncrementNode).GetProperty(nameof(Out));

				case 193446865:
					return typeof(DataIncrementNode).GetProperty(nameof(Max));

				case 193446607:
					return typeof(DataIncrementNode).GetProperty(nameof(Min));

				case 834119169:
					return typeof(DataIncrementNode).GetProperty(nameof(IncrementSize));

				case 3810860200:
					return typeof(DataIncrementNode).GetProperty(nameof(DataSource));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
