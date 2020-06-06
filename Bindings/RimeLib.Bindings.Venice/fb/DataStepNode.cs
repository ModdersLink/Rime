///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class DataStepNode : 
		UINodeData
	{
		[ContainerField(20)]
		public CtrRef<UINodePort> In { get; set; } = new CtrRef<UINodePort>(); // 0x14 (20)
		
		[ContainerField(24)]
		public CtrRef<UINodePort> Out { get; set; } = new CtrRef<UINodePort>(); // 0x18 (24)
		
		[ContainerField(28)]
		public List<float> Steps { get; set; } = new List<float>(); // 0x1C (28)
		
		[ContainerField(32)]
		public UIDataSourceInfo CurrentStepDataSource { get; set; } = new UIDataSourceInfo(); // 0x20 (32)
		
		[ContainerField(48)]
		public UIDataSourceInfo DataSource { get; set; } = new UIDataSourceInfo(); // 0x30 (48)
		
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

				case 230752612:
					Steps = (List<float>) p_Value;
					break;

				case 3729599635:
					CurrentStepDataSource = (UIDataSourceInfo) p_Value;
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

				case 230752612:
					return Steps;

				case 3729599635:
					return CurrentStepDataSource;

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
					return typeof(DataStepNode).GetProperty(nameof(In));

				case 193453899:
					return typeof(DataStepNode).GetProperty(nameof(Out));

				case 230752612:
					return typeof(DataStepNode).GetProperty(nameof(Steps));

				case 3729599635:
					return typeof(DataStepNode).GetProperty(nameof(CurrentStepDataSource));

				case 3810860200:
					return typeof(DataStepNode).GetProperty(nameof(DataSource));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
