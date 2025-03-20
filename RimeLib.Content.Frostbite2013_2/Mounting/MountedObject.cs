using RimeLib.Content.Mounting;

namespace RimeLib.Content.Frostbite2013_2.Mounting;

internal class MountedObject<T> : IMountedObject<T> where T : IObjectVariant
{
	public IEnumerable<T> Variants => m_Variants;
	public T FirstVariant => m_Variants.First();
	public string OriginalName { get; }

	protected List<T> m_Variants = new List<T>();

	internal MountedObject(T p_Variant, string p_OriginalName)
	{
		m_Variants.Add(p_Variant);
		OriginalName = p_OriginalName;
	}

	internal void AddVariant(T p_Variant)
	{
		m_Variants.Add(p_Variant);
	}

	internal void RemoveVariant(T p_Variant)
	{
		m_Variants.RemoveAll(p_OtherVariant => p_OtherVariant.Equals(p_Variant));
	}
}

internal class MountedObject : IMountedObject
{
	public IEnumerable<IObjectVariant> Variants => m_Variants;
	public IObjectVariant FirstVariant => m_Variants.First();
	public string OriginalName { get; }

	protected List<IObjectVariant> m_Variants = new List<IObjectVariant>();

	internal MountedObject(IObjectVariant p_Variant, string p_OriginalName)
	{
		m_Variants.Add(p_Variant);
		OriginalName = p_OriginalName;
	}

	internal void AddVariant(IObjectVariant p_Variant)
	{
		m_Variants.Add(p_Variant);
	}

	internal void RemoveVariant(IObjectVariant p_Variant)
	{
		m_Variants.RemoveAll(p_OtherVariant => p_OtherVariant.Equals(p_Variant));
	}
}