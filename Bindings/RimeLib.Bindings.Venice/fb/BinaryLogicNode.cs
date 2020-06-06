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
	public class BinaryLogicNode : 
		UINodeData
	{
		[ContainerField(20)]
		public CtrRef<UINodePort> In { get; set; } = new CtrRef<UINodePort>(); // 0x14 (20)
		
		[ContainerField(24)]
		public CtrRef<UINodePort> True { get; set; } = new CtrRef<UINodePort>(); // 0x18 (24)
		
		[ContainerField(28)]
		public CtrRef<UINodePort> False { get; set; } = new CtrRef<UINodePort>(); // 0x1C (28)
		
		[ContainerField(32)]
		public UIDataSourceInfo DataSourceInfo { get; set; } = new UIDataSourceInfo(); // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (CtrRef<UINodePort>) p_Value;
					break;

				case 2089293587:
					True = (CtrRef<UINodePort>) p_Value;
					break;

				case 206401336:
					False = (CtrRef<UINodePort>) p_Value;
					break;

				case 4099162406:
					DataSourceInfo = (UIDataSourceInfo) p_Value;
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

				case 2089293587:
					return True;

				case 206401336:
					return False;

				case 4099162406:
					return DataSourceInfo;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(BinaryLogicNode).GetProperty(nameof(In));

				case 2089293587:
					return typeof(BinaryLogicNode).GetProperty(nameof(True));

				case 206401336:
					return typeof(BinaryLogicNode).GetProperty(nameof(False));

				case 4099162406:
					return typeof(BinaryLogicNode).GetProperty(nameof(DataSourceInfo));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
