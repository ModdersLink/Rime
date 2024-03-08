using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite2013_2.Mounting;

internal interface IReadableObjectWithHash : IReadableObject, IObjectWithHash {}

internal class ObjectVariant : IObjectVariant
{
	protected IReadableObjectWithHash m_Readable;
	protected string m_ContainedSuperbundle;
	protected string? m_ContainedBundle;

	public ObjectVariant(IReadableObjectWithHash p_Readable, string p_ContainedSuperbundle, string? p_ContainedBundle)
	{
		m_Readable = p_Readable;
		m_ContainedSuperbundle = p_ContainedSuperbundle;
		m_ContainedBundle = p_ContainedBundle;
	}

	public RimeReader GetReader()
	{
		return m_Readable.GetReader();
	}

	public long GetSize()
	{
		return m_Readable.GetSize();
	}

	public string GetContainedSuperbundle()
	{
		return m_ContainedSuperbundle;
	}

	public string? GetContainedBundle()
	{
		return m_ContainedBundle;
	}

	public Sha1? GetSha1()
	{
		return m_Readable.GetSha1();
	}
}