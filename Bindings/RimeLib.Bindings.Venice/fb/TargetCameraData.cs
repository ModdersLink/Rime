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
	[ContainerType(16)]
	public class TargetCameraData : 
		CameraData
	{
		protected HudData m_Hud = new HudData();
		[ContainerField(80), ContainerFieldNameHash(193458844)]
		public HudData Hud { get { return m_Hud; } set { if (OnPropertyChanging("TargetCameraData." + nameof(Hud), this, m_Hud, value)) m_Hud = value; } } // 0x50 (80)
		
		protected RefArray<UIPartData> m_UIParts = new RefArray<UIPartData>();
		[ContainerField(148), ContainerFieldNameHash(187481405)]
		public RefArray<UIPartData> UIParts { get { return m_UIParts; } set { if (OnPropertyChanging("TargetCameraData." + nameof(UIParts), this, m_UIParts, value)) m_UIParts = value; } } // 0x94 (148)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193458844:
					Hud = (HudData) p_Value;
					break;

				case 187481405:
					UIParts = (RefArray<UIPartData>) p_Value;
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
				case 193458844:
					return Hud;

				case 187481405:
					return UIParts;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193458844:
					return typeof(TargetCameraData).GetProperty(nameof(Hud));

				case 187481405:
					return typeof(TargetCameraData).GetProperty(nameof(UIParts));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
