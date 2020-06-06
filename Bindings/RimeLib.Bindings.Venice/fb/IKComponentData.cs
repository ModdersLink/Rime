///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class IKComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public IKEffectorEnum IKEffector { get; set; } = new IKEffectorEnum(); // 0x60 (96)
		
		[ContainerField(100)]
		public HIKData IKData { get; set; } = new HIKData(); // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4088955053:
					IKEffector = (IKEffectorEnum) Enum.ToObject(typeof(IKEffectorEnum), p_Value);
					break;

				case 2831034455:
					IKData = (HIKData) p_Value;
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
				case 4088955053:
					return IKEffector;

				case 2831034455:
					return IKData;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4088955053:
					return typeof(IKComponentData).GetProperty(nameof(IKEffector));

				case 2831034455:
					return typeof(IKComponentData).GetProperty(nameof(IKData));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
