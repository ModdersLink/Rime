///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(16, 112)]
	public partial class EffectEntityData :
		SpatialEntityData
	{
		[ObservableProperty]
		[property: ContainerField(80), JsonProperty(Order = 80)]
		private RefArray<GameObjectData> _Components = new();

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private uint _MaxInstanceCount;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private float _CullDistance;

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private float _StartDelay;

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private bool _HighEndPc;

		[ObservableProperty]
		[property: ContainerField(97), LayoutImmutable, Blittable, JsonProperty(Order = 97)]
		private bool _MediumPc;

		[ObservableProperty]
		[property: ContainerField(98), LayoutImmutable, Blittable, JsonProperty(Order = 98)]
		private bool _LowEndPc;

		[ObservableProperty]
		[property: ContainerField(99), LayoutImmutable, Blittable, JsonProperty(Order = 99)]
		private bool _ResetInstanceWhenStarted;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Components = p_EbxWriter.GetArrayWriter(Components.GetType(), Components.Count);
			p_Writer.Write(s_Components.ArrayIndex);
			foreach (var s_Entry in Components)
			{
				s_Components.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(MaxInstanceCount);
			p_Writer.Write(CullDistance);
			p_Writer.Write(StartDelay);
			p_Writer.Write(HighEndPc);
			p_Writer.Write(MediumPc);
			p_Writer.Write(LowEndPc);
			p_Writer.Write(ResetInstanceWhenStarted);
			p_Writer.WriteNullBytes(12);
		}
	}
}
