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
	public class BlazeServerBackendData : 
		ServerBackendData
	{
		[ContainerField(16)]
		public BlazeCreateGameParameters CreateParameters { get; set; } = new BlazeCreateGameParameters(); // 0x10 (16)
		
		[ContainerField(48)]
		public OnlineEnvironmentConsoleUrl ConfigUrl { get; set; } = new OnlineEnvironmentConsoleUrl(); // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4233299195:
					CreateParameters = (BlazeCreateGameParameters) p_Value;
					break;

				case 1873884036:
					ConfigUrl = (OnlineEnvironmentConsoleUrl) p_Value;
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
				case 4233299195:
					return CreateParameters;

				case 1873884036:
					return ConfigUrl;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4233299195:
					return typeof(BlazeServerBackendData).GetProperty(nameof(CreateParameters));

				case 1873884036:
					return typeof(BlazeServerBackendData).GetProperty(nameof(ConfigUrl));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
