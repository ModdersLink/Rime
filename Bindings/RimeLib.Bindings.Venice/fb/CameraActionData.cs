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
    [ContainerType(4)]
	public class CameraActionData : 
		SimpleMovementActionBaseData
	{
		[ContainerField(24)]
		public CameraMovementActionMode ActionMode { get; set; } = new CameraMovementActionMode(); // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1115046008:
					ActionMode = (CameraMovementActionMode) Enum.ToObject(typeof(CameraMovementActionMode), p_Value);
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
				case 1115046008:
					return ActionMode;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1115046008:
					return typeof(CameraActionData).GetProperty(nameof(ActionMode));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
