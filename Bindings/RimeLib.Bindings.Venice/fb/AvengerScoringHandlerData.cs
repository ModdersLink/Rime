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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 12)]
	public class AvengerScoringHandlerData : 
		ScoringHandlerData
	{
		protected float m_AvengerKillTimeout = new float();
		[ContainerField(Name: "AvengerKillTimeout", Offset: 8, NameHash: 4253323024, Flags: 49469), LayoutImmutable, Blittable]
		public float AvengerKillTimeout { get { return m_AvengerKillTimeout; } set { if (OnPropertyChanging("AvengerScoringHandlerData." + nameof(AvengerKillTimeout), this, m_AvengerKillTimeout, value)) m_AvengerKillTimeout = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4253323024:
					AvengerKillTimeout = (float) p_Value;
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
				case 4253323024:
					return AvengerKillTimeout;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4253323024:
					return typeof(AvengerScoringHandlerData).GetProperty(nameof(AvengerKillTimeout));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
