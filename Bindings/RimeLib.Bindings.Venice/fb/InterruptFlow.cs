///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(8), ContainerStruct]
	public class InterruptFlow : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(137)]
		public UIInterruptID interruptEnum { get; set; } = new UIInterruptID(); // 0x0 (0)
		
		[ContainerField(4), MemberInfoFlag(53), ContainerCtrRef]
		public CtrRef<UIGraphAsset> interruptFlow { get; set; } = new CtrRef<UIGraphAsset>(); // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3295085585:
						interruptEnum = (UIInterruptID) Enum.ToObject(typeof(UIInterruptID), p_Value);
					break;

				case 3294905584:
					interruptFlow = (CtrRef<UIGraphAsset>) p_Value;
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
				case 3295085585:
					return interruptEnum;

				case 3294905584:
					return interruptFlow;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3295085585:
					return typeof(InterruptFlow).GetProperty(nameof(interruptEnum));

				case 3294905584:
					return typeof(InterruptFlow).GetProperty(nameof(interruptFlow));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
