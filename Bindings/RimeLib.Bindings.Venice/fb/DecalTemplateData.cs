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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(72), ContainerClass]
	public class DecalTemplateData : 
		Asset
	{
		protected float m_Size = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2089429248)]
		public float Size { get { return m_Size; } set { if (OnPropertyChanging("DecalTemplateData." + nameof(Size), this, m_Size, value)) m_Size = value; } } // 0xC (12)
		
		protected float m_RandomSize = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3548218523)]
		public float RandomSize { get { return m_RandomSize; } set { if (OnPropertyChanging("DecalTemplateData." + nameof(RandomSize), this, m_RandomSize, value)) m_RandomSize = value; } } // 0x10 (16)
		
		protected float m_Rotation = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(48673745)]
		public float Rotation { get { return m_Rotation; } set { if (OnPropertyChanging("DecalTemplateData." + nameof(Rotation), this, m_Rotation, value)) m_Rotation = value; } } // 0x14 (20)
		
		protected float m_RandomRotation = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4221673930)]
		public float RandomRotation { get { return m_RandomRotation; } set { if (OnPropertyChanging("DecalTemplateData." + nameof(RandomRotation), this, m_RandomRotation, value)) m_RandomRotation = value; } } // 0x18 (24)
		
		protected float m_ClipAngle = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1632648850)]
		public float ClipAngle { get { return m_ClipAngle; } set { if (OnPropertyChanging("DecalTemplateData." + nameof(ClipAngle), this, m_ClipAngle, value)) m_ClipAngle = value; } } // 0x1C (28)
		
		protected float m_ProximityRadiusFactor = new float();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4036214629)]
		public float ProximityRadiusFactor { get { return m_ProximityRadiusFactor; } set { if (OnPropertyChanging("DecalTemplateData." + nameof(ProximityRadiusFactor), this, m_ProximityRadiusFactor, value)) m_ProximityRadiusFactor = value; } } // 0x20 (32)
		
		protected float m_NormalOffset = new float();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(393006331)]
		public float NormalOffset { get { return m_NormalOffset; } set { if (OnPropertyChanging("DecalTemplateData." + nameof(NormalOffset), this, m_NormalOffset, value)) m_NormalOffset = value; } } // 0x24 (36)
		
		protected CtrRef<SurfaceShaderBaseAsset> m_Shader = new CtrRef<SurfaceShaderBaseAsset>();
		[ContainerField(40), MemberInfoFlag(53), ContainerFieldNameHash(3352909900), ContainerCtrRef]
		public CtrRef<SurfaceShaderBaseAsset> Shader { get { return m_Shader; } set { if (OnPropertyChanging("DecalTemplateData." + nameof(Shader), this, m_Shader, value)) m_Shader = value; } } // 0x28 (40)
		
		protected int m_MeshUVIndex = new int();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(114817035)]
		public int MeshUVIndex { get { return m_MeshUVIndex; } set { if (OnPropertyChanging("DecalTemplateData." + nameof(MeshUVIndex), this, m_MeshUVIndex, value)) m_MeshUVIndex = value; } } // 0x2C (44)
		
		protected DecalAtlasTile m_AtlasTile = new DecalAtlasTile();
		[ContainerField(48), MemberInfoFlag(41), ContainerFieldNameHash(3027817338)]
		public DecalAtlasTile AtlasTile { get { return m_AtlasTile; } set { if (OnPropertyChanging("DecalTemplateData." + nameof(AtlasTile), this, m_AtlasTile, value)) m_AtlasTile = value; } } // 0x30 (48)
		
		protected sbyte m_SortingPriority = new sbyte();
		[ContainerField(68), LayoutImmutable, Blittable, MemberInfoFlag(49341), ContainerFieldNameHash(3523655821)]
		public sbyte SortingPriority { get { return m_SortingPriority; } set { if (OnPropertyChanging("DecalTemplateData." + nameof(SortingPriority), this, m_SortingPriority, value)) m_SortingPriority = value; } } // 0x44 (68)
		
		protected bool m_Projected = new bool();
		[ContainerField(69), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4152361265)]
		public bool Projected { get { return m_Projected; } set { if (OnPropertyChanging("DecalTemplateData." + nameof(Projected), this, m_Projected, value)) m_Projected = value; } } // 0x45 (69)
		
		protected bool m_ProjectMultiple = new bool();
		[ContainerField(70), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4168918560)]
		public bool ProjectMultiple { get { return m_ProjectMultiple; } set { if (OnPropertyChanging("DecalTemplateData." + nameof(ProjectMultiple), this, m_ProjectMultiple, value)) m_ProjectMultiple = value; } } // 0x46 (70)
		
		protected sbyte m_MaterialIndex = new sbyte();
		[ContainerField(71), LayoutImmutable, Blittable, MemberInfoFlag(49341), ContainerFieldNameHash(1001372496)]
		public sbyte MaterialIndex { get { return m_MaterialIndex; } set { if (OnPropertyChanging("DecalTemplateData." + nameof(MaterialIndex), this, m_MaterialIndex, value)) m_MaterialIndex = value; } } // 0x47 (71)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2089429248:
					Size = (float) p_Value;
					break;

				case 3548218523:
					RandomSize = (float) p_Value;
					break;

				case 48673745:
					Rotation = (float) p_Value;
					break;

				case 4221673930:
					RandomRotation = (float) p_Value;
					break;

				case 1632648850:
					ClipAngle = (float) p_Value;
					break;

				case 4036214629:
					ProximityRadiusFactor = (float) p_Value;
					break;

				case 393006331:
					NormalOffset = (float) p_Value;
					break;

				case 3352909900:
					Shader = (CtrRef<SurfaceShaderBaseAsset>) p_Value;
					break;

				case 114817035:
					MeshUVIndex = (int) p_Value;
					break;

				case 3027817338:
					AtlasTile = (DecalAtlasTile) p_Value;
					break;

				case 3523655821:
					SortingPriority = (sbyte) p_Value;
					break;

				case 4152361265:
					Projected = (bool) p_Value;
					break;

				case 4168918560:
					ProjectMultiple = (bool) p_Value;
					break;

				case 1001372496:
					MaterialIndex = (sbyte) p_Value;
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
				case 2089429248:
					return Size;

				case 3548218523:
					return RandomSize;

				case 48673745:
					return Rotation;

				case 4221673930:
					return RandomRotation;

				case 1632648850:
					return ClipAngle;

				case 4036214629:
					return ProximityRadiusFactor;

				case 393006331:
					return NormalOffset;

				case 3352909900:
					return Shader;

				case 114817035:
					return MeshUVIndex;

				case 3027817338:
					return AtlasTile;

				case 3523655821:
					return SortingPriority;

				case 4152361265:
					return Projected;

				case 4168918560:
					return ProjectMultiple;

				case 1001372496:
					return MaterialIndex;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2089429248:
					return typeof(DecalTemplateData).GetProperty(nameof(Size));

				case 3548218523:
					return typeof(DecalTemplateData).GetProperty(nameof(RandomSize));

				case 48673745:
					return typeof(DecalTemplateData).GetProperty(nameof(Rotation));

				case 4221673930:
					return typeof(DecalTemplateData).GetProperty(nameof(RandomRotation));

				case 1632648850:
					return typeof(DecalTemplateData).GetProperty(nameof(ClipAngle));

				case 4036214629:
					return typeof(DecalTemplateData).GetProperty(nameof(ProximityRadiusFactor));

				case 393006331:
					return typeof(DecalTemplateData).GetProperty(nameof(NormalOffset));

				case 3352909900:
					return typeof(DecalTemplateData).GetProperty(nameof(Shader));

				case 114817035:
					return typeof(DecalTemplateData).GetProperty(nameof(MeshUVIndex));

				case 3027817338:
					return typeof(DecalTemplateData).GetProperty(nameof(AtlasTile));

				case 3523655821:
					return typeof(DecalTemplateData).GetProperty(nameof(SortingPriority));

				case 4152361265:
					return typeof(DecalTemplateData).GetProperty(nameof(Projected));

				case 4168918560:
					return typeof(DecalTemplateData).GetProperty(nameof(ProjectMultiple));

				case 1001372496:
					return typeof(DecalTemplateData).GetProperty(nameof(MaterialIndex));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
