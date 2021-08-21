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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 16,  Flags: 53, Size: 144)]
	public class HitReactionComponentData : 
		ComponentData
	{
		protected HitReactionComponentBinding m_HitReactionBinding = new HitReactionComponentBinding();
		[ContainerField(Name: "HitReactionBinding", Offset: 96, NameHash: 738313592, Flags: 41)]
		public HitReactionComponentBinding HitReactionBinding { get { return m_HitReactionBinding; } set { if (OnPropertyChanging("HitReactionComponentData." + nameof(HitReactionBinding), this, m_HitReactionBinding, value)) m_HitReactionBinding = value; } } // 0x60 (96)
		
		protected bool m_Enabled = new bool();
		[ContainerField(Name: "Enabled", Offset: 128, NameHash: 2662400, Flags: 49325), LayoutImmutable, Blittable]
		public bool Enabled { get { return m_Enabled; } set { if (OnPropertyChanging("HitReactionComponentData." + nameof(Enabled), this, m_Enabled, value)) m_Enabled = value; } } // 0x80 (128)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 738313592:
					HitReactionBinding = (HitReactionComponentBinding) p_Value;
					break;

				case 2662400:
					Enabled = (bool) p_Value;
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
				case 738313592:
					return HitReactionBinding;

				case 2662400:
					return Enabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 738313592:
					return typeof(HitReactionComponentData).GetProperty(nameof(HitReactionBinding));

				case 2662400:
					return typeof(HitReactionComponentData).GetProperty(nameof(Enabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
