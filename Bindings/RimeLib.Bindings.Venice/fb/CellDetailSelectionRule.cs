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
	public class CellDetailSelectionRule : 
		PackagingRule
	{
		[ContainerField(48)]
		public PackagingDetailLevel Detail { get; set; } = new PackagingDetailLevel(); // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2594676244:
					Detail = (PackagingDetailLevel) Enum.ToObject(typeof(PackagingDetailLevel), p_Value);
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
				case 2594676244:
					return Detail;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2594676244:
					return typeof(CellDetailSelectionRule).GetProperty(nameof(Detail));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
