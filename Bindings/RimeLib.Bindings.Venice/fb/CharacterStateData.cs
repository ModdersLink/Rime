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
	public class CharacterStateData : 
		DataContainer
	{
		protected RefArray<CharacterStatePoseInfo> m_PoseInfo = new RefArray<CharacterStatePoseInfo>();
		[ContainerField(Name: "PoseInfo", Offset: 8, NameHash: 3414686146, Flags: 65)]
		public RefArray<CharacterStatePoseInfo> PoseInfo { get { return m_PoseInfo; } set { if (OnPropertyChanging("CharacterStateData." + nameof(PoseInfo), this, m_PoseInfo, value)) m_PoseInfo = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3414686146:
					PoseInfo = (RefArray<CharacterStatePoseInfo>) p_Value;
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
				case 3414686146:
					return PoseInfo;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3414686146:
					return typeof(CharacterStateData).GetProperty(nameof(PoseInfo));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
