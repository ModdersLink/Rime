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
	public class DebugValueInput : 
		AudioGraphNodePortGroup
	{
		[ContainerField(8)]
		public AudioGraphNodePort V { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16), LayoutImmutable]
		public string Name { get; set; } // 0x10 (16)
		
		[ContainerField(20)]
		public DebugRenderType RenderType { get; set; } = new DebugRenderType(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float Min { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float Max { get; set; } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 177651:
					V = (AudioGraphNodePort) p_Value;
					break;

				case 2088949890:
					Name = (string) p_Value;
					break;

				case 604852279:
					RenderType = (DebugRenderType) Enum.ToObject(typeof(DebugRenderType), p_Value);
					break;

				case 193446607:
					Min = (float) p_Value;
					break;

				case 193446865:
					Max = (float) p_Value;
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
				case 177651:
					return V;

				case 2088949890:
					return Name;

				case 604852279:
					return RenderType;

				case 193446607:
					return Min;

				case 193446865:
					return Max;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 177651:
					return typeof(DebugValueInput).GetProperty(nameof(V));

				case 2088949890:
					return typeof(DebugValueInput).GetProperty(nameof(Name));

				case 604852279:
					return typeof(DebugValueInput).GetProperty(nameof(RenderType));

				case 193446607:
					return typeof(DebugValueInput).GetProperty(nameof(Min));

				case 193446865:
					return typeof(DebugValueInput).GetProperty(nameof(Max));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
