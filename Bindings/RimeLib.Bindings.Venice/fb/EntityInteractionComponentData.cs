///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 144)]
	public class EntityInteractionComponentData : 
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float PickupRadius { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float MaxAmmoPickupTimer { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float MaxAmmoCrateTimer { get; set; }

		[ContainerField(108)]
		public InteractionTypesData InteractWithTypes { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable]
		public float MaxLookAtAngle { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public float SoldierInteractRadius { get; set; }

		[ContainerField(124)]
		public EntryInputActionEnum SoldierInteractInputAction { get; set; } = new();

		[ContainerField(128), LayoutImmutable, Blittable]
		public bool AllowInteractionWithSoldiers { get; set; }

		[ContainerField(129), LayoutImmutable, Blittable]
		public bool OnlyAllowInteractionWithManDownSoldiers { get; set; }

		public static void Deserialize(EntityInteractionComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.PickupRadius = p_Reader.ReadSingle();
			p_Instance.MaxAmmoPickupTimer = p_Reader.ReadSingle();
			p_Instance.MaxAmmoCrateTimer = p_Reader.ReadSingle();
			fb.InteractionTypesData.Deserialize(p_Instance.InteractWithTypes, p_Reader, p_Parser);
			p_Reader.Seek(2, SeekOrigin.Current);
			p_Instance.MaxLookAtAngle = p_Reader.ReadSingle();
			p_Reader.Seek(2, SeekOrigin.Current);
			p_Instance.SoldierInteractRadius = p_Reader.ReadSingle();
			p_Reader.Seek(2, SeekOrigin.Current);
			p_Instance.SoldierInteractInputAction = (EntryInputActionEnum) p_Reader.ReadInt32();
			p_Reader.Seek(2, SeekOrigin.Current);
			p_Instance.AllowInteractionWithSoldiers = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
			p_Instance.OnlyAllowInteractionWithManDownSoldiers = p_Reader.ReadBool();
			p_Reader.Seek(16, SeekOrigin.Current);
		}

	}
}
