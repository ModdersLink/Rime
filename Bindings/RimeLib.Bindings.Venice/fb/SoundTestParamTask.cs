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
	[ContainerType(4)]
	public class SoundTestParamTask : 
		SoundTestTaskSpec
	{
		protected string m_ParamName = new string();
		[ContainerField(16), LayoutImmutable, ContainerFieldNameHash(2964687917)]
		public string ParamName { get { return m_ParamName; } set { if (OnPropertyChanging("SoundTestParamTask." + nameof(ParamName), this, m_ParamName, value)) m_ParamName = value; } } // 0x10 (16)
		
		protected SoundTestParamBehavior m_Behavior = new SoundTestParamBehavior();
		[ContainerField(20), ContainerFieldNameHash(1967808137)]
		public SoundTestParamBehavior Behavior { get { return m_Behavior; } set { if (OnPropertyChanging("SoundTestParamTask." + nameof(Behavior), this, m_Behavior, value)) m_Behavior = value; } } // 0x14 (20)
		
		protected float m_RangeMin = new float();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(1752513616)]
		public float RangeMin { get { return m_RangeMin; } set { if (OnPropertyChanging("SoundTestParamTask." + nameof(RangeMin), this, m_RangeMin, value)) m_RangeMin = value; } } // 0x18 (24)
		
		protected float m_RangeMax = new float();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(1752513358)]
		public float RangeMax { get { return m_RangeMax; } set { if (OnPropertyChanging("SoundTestParamTask." + nameof(RangeMax), this, m_RangeMax, value)) m_RangeMax = value; } } // 0x1C (28)
		
		protected float m_InitialValue = new float();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(3684126256)]
		public float InitialValue { get { return m_InitialValue; } set { if (OnPropertyChanging("SoundTestParamTask." + nameof(InitialValue), this, m_InitialValue, value)) m_InitialValue = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2964687917:
					ParamName = (string) p_Value;
					break;

				case 1967808137:
					Behavior = (SoundTestParamBehavior) Enum.ToObject(typeof(SoundTestParamBehavior), p_Value);
					break;

				case 1752513616:
					RangeMin = (float) p_Value;
					break;

				case 1752513358:
					RangeMax = (float) p_Value;
					break;

				case 3684126256:
					InitialValue = (float) p_Value;
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
				case 2964687917:
					return ParamName;

				case 1967808137:
					return Behavior;

				case 1752513616:
					return RangeMin;

				case 1752513358:
					return RangeMax;

				case 3684126256:
					return InitialValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2964687917:
					return typeof(SoundTestParamTask).GetProperty(nameof(ParamName));

				case 1967808137:
					return typeof(SoundTestParamTask).GetProperty(nameof(Behavior));

				case 1752513616:
					return typeof(SoundTestParamTask).GetProperty(nameof(RangeMin));

				case 1752513358:
					return typeof(SoundTestParamTask).GetProperty(nameof(RangeMax));

				case 3684126256:
					return typeof(SoundTestParamTask).GetProperty(nameof(InitialValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
