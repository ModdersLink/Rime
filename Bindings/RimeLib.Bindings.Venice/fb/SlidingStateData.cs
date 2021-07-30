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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class SlidingStateData : 
		CharacterStateData
	{
		protected float m_HorizontalInputScale = new float();
		[ContainerField(Name: "HorizontalInputScale", Offset: 12, NameHash: 770027349, Flags: 49469), LayoutImmutable, Blittable]
		public float HorizontalInputScale { get { return m_HorizontalInputScale; } set { if (OnPropertyChanging("SlidingStateData." + nameof(HorizontalInputScale), this, m_HorizontalInputScale, value)) m_HorizontalInputScale = value; } } // 0xC (12)
		
		protected float m_GravityScale = new float();
		[ContainerField(Name: "GravityScale", Offset: 16, NameHash: 1341716283, Flags: 49469), LayoutImmutable, Blittable]
		public float GravityScale { get { return m_GravityScale; } set { if (OnPropertyChanging("SlidingStateData." + nameof(GravityScale), this, m_GravityScale, value)) m_GravityScale = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 770027349:
					HorizontalInputScale = (float) p_Value;
					break;

				case 1341716283:
					GravityScale = (float) p_Value;
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
				case 770027349:
					return HorizontalInputScale;

				case 1341716283:
					return GravityScale;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 770027349:
					return typeof(SlidingStateData).GetProperty(nameof(HorizontalInputScale));

				case 1341716283:
					return typeof(SlidingStateData).GetProperty(nameof(GravityScale));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
