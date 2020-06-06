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
	public class DataSetNode : 
		UINodeData
	{
		[ContainerField(20)]
		public CtrRef<UINodePort> In { get; set; } = new CtrRef<UINodePort>(); // 0x14 (20)
		
		[ContainerField(24)]
		public CtrRef<UINodePort> Out { get; set; } = new CtrRef<UINodePort>(); // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable]
		public string Param { get; set; } // 0x1C (28)
		
		[ContainerField(32)]
		public UIDataSourceInfo DataSource { get; set; } = new UIDataSourceInfo(); // 0x20 (32)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public bool SetToEmptyString { get; set; } // 0x30 (48)
		
		[ContainerField(49), LayoutImmutable, Blittable]
		public bool ForceUpdate { get; set; } // 0x31 (49)
		
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

				case 232319210:
					Param = (string) p_Value;
					break;

				case 3810860200:
					DataSource = (UIDataSourceInfo) p_Value;
					break;

				case 2535912156:
					SetToEmptyString = (bool) p_Value;
					break;

				case 4101084969:
					ForceUpdate = (bool) p_Value;
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

				case 232319210:
					return Param;

				case 3810860200:
					return DataSource;

				case 2535912156:
					return SetToEmptyString;

				case 4101084969:
					return ForceUpdate;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(DataSetNode).GetProperty(nameof(In));

				case 193453899:
					return typeof(DataSetNode).GetProperty(nameof(Out));

				case 232319210:
					return typeof(DataSetNode).GetProperty(nameof(Param));

				case 3810860200:
					return typeof(DataSetNode).GetProperty(nameof(DataSource));

				case 2535912156:
					return typeof(DataSetNode).GetProperty(nameof(SetToEmptyString));

				case 4101084969:
					return typeof(DataSetNode).GetProperty(nameof(ForceUpdate));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
