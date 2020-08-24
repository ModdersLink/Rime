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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class ScaleClampNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_In = new AudioGraphNodePort();
		[ContainerField(8), MemberInfoFlag(41), ContainerFieldNameHash(5862146)]
		public AudioGraphNodePort In { get { return m_In; } set { if (OnPropertyChanging("ScaleClampNodeData." + nameof(In), this, m_In, value)) m_In = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_InMin = new AudioGraphNodePort();
		[ContainerField(16), MemberInfoFlag(41), ContainerFieldNameHash(214484264)]
		public AudioGraphNodePort InMin { get { return m_InMin; } set { if (OnPropertyChanging("ScaleClampNodeData." + nameof(InMin), this, m_InMin, value)) m_InMin = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_InMax = new AudioGraphNodePort();
		[ContainerField(24), MemberInfoFlag(41), ContainerFieldNameHash(214484534)]
		public AudioGraphNodePort InMax { get { return m_InMax; } set { if (OnPropertyChanging("ScaleClampNodeData." + nameof(InMax), this, m_InMax, value)) m_InMax = value; } } // 0x18 (24)
		
		protected AudioGraphNodePort m_OutMin = new AudioGraphNodePort();
		[ContainerField(32), MemberInfoFlag(41), ContainerFieldNameHash(2895749057)]
		public AudioGraphNodePort OutMin { get { return m_OutMin; } set { if (OnPropertyChanging("ScaleClampNodeData." + nameof(OutMin), this, m_OutMin, value)) m_OutMin = value; } } // 0x20 (32)
		
		protected AudioGraphNodePort m_OutMax = new AudioGraphNodePort();
		[ContainerField(40), MemberInfoFlag(41), ContainerFieldNameHash(2895748831)]
		public AudioGraphNodePort OutMax { get { return m_OutMax; } set { if (OnPropertyChanging("ScaleClampNodeData." + nameof(OutMax), this, m_OutMax, value)) m_OutMax = value; } } // 0x28 (40)
		
		protected AudioGraphNodePort m_Out = new AudioGraphNodePort();
		[ContainerField(48), MemberInfoFlag(41), ContainerFieldNameHash(193453899)]
		public AudioGraphNodePort Out { get { return m_Out; } set { if (OnPropertyChanging("ScaleClampNodeData." + nameof(Out), this, m_Out, value)) m_Out = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (AudioGraphNodePort) p_Value;
					break;

				case 214484264:
					InMin = (AudioGraphNodePort) p_Value;
					break;

				case 214484534:
					InMax = (AudioGraphNodePort) p_Value;
					break;

				case 2895749057:
					OutMin = (AudioGraphNodePort) p_Value;
					break;

				case 2895748831:
					OutMax = (AudioGraphNodePort) p_Value;
					break;

				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
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
				case 5862146:
					return In;

				case 214484264:
					return InMin;

				case 214484534:
					return InMax;

				case 2895749057:
					return OutMin;

				case 2895748831:
					return OutMax;

				case 193453899:
					return Out;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(ScaleClampNodeData).GetProperty(nameof(In));

				case 214484264:
					return typeof(ScaleClampNodeData).GetProperty(nameof(InMin));

				case 214484534:
					return typeof(ScaleClampNodeData).GetProperty(nameof(InMax));

				case 2895749057:
					return typeof(ScaleClampNodeData).GetProperty(nameof(OutMin));

				case 2895748831:
					return typeof(ScaleClampNodeData).GetProperty(nameof(OutMax));

				case 193453899:
					return typeof(ScaleClampNodeData).GetProperty(nameof(Out));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
