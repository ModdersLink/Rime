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
	[ContainerType(4, 40)]
	public partial class SoldierSprintSettingsData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private float _Fov;

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _FovInDelay;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _FovInTime;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _FovOutDelay;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _FovOutTime;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _RecoverTime;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _SprintToProneRecoverTime;

		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private List<EntryInputActionEnum> _InterruptingActions = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			p_Writer.Write(Fov);
			p_Writer.Write(FovInDelay);
			p_Writer.Write(FovInTime);
			p_Writer.Write(FovOutDelay);
			p_Writer.Write(FovOutTime);
			p_Writer.Write(RecoverTime);
			p_Writer.Write(SprintToProneRecoverTime);
			(RimeWriter Writer, uint ArrayIndex) s_InterruptingActions = p_EbxWriter.GetArrayWriter(InterruptingActions.GetType(), InterruptingActions.Count);
			p_Writer.Write(s_InterruptingActions.ArrayIndex);
			foreach (var s_Entry in InterruptingActions)
			{
				s_InterruptingActions.Writer.Write((int) s_Entry);
			}
		}
	}
}
