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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class TargetCameraEntityData : 
		CameraEntityBaseData
	{
		protected CtrRef<TargetCameraData> m_Camera = new CtrRef<TargetCameraData>();
		[ContainerField(Name: "Camera", Offset: 96, NameHash: 2716359356, Flags: 53)]
		public CtrRef<TargetCameraData> Camera { get { return m_Camera; } set { if (OnPropertyChanging("TargetCameraEntityData." + nameof(Camera), this, m_Camera, value)) m_Camera = value; } } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2716359356:
					Camera = (CtrRef<TargetCameraData>) p_Value;
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
				case 2716359356:
					return Camera;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2716359356:
					return typeof(TargetCameraEntityData).GetProperty(nameof(Camera));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
