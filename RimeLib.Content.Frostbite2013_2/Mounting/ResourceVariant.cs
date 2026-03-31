using System.Diagnostics.CodeAnalysis;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;

namespace RimeLib.Content.Frostbite2013_2.Mounting;

internal class ResourceVariant : ObjectVariant, IResourceVariant
{
	protected ResourceType m_Type;
	protected byte[]? m_Meta;
	protected ResourceRef? m_Id;

	public ResourceVariant(IReadableObjectWithHash p_Readable, ResourceType p_Type, byte[]? p_Meta, string p_ContainedSuperbundle, string? p_ContainedBundle) :
		base(p_Readable, p_ContainedSuperbundle, p_ContainedBundle)
	{
		m_Type = p_Type;
		m_Meta = p_Meta;
	}
	
	public ResourceVariant(IReadableObjectWithHash p_Readable, ResourceType p_Type, byte[]? p_Meta, ulong p_ResId, string p_ContainedSuperbundle, string? p_ContainedBundle) :
		base(p_Readable, p_ContainedSuperbundle, p_ContainedBundle)
	{
		m_Type = p_Type;
		m_Meta = p_Meta;
		m_Id = new ResourceRef(p_ResId);
	}

	public ResourceVariant(IReadableObjectWithHash p_Readable, ResourceType p_Type, byte[]? p_Meta, string p_Name, string p_ContainedSuperbundle, string? p_ContainedBundle) :
		base(p_Readable, p_ContainedSuperbundle, p_ContainedBundle)
	{
		m_Type = p_Type;
		m_Meta = p_Meta;
		m_Id = new ResourceRef(p_Name, p_Readable);
	}

	public ResourceType GetResourceType()
	{
		return m_Type;
	}

	public bool TryGetMeta([NotNullWhen(true)] out byte[]? p_Meta)
	{
		p_Meta = m_Meta;
		return m_Meta != null;
	}

	public ResourceRef GetId(string? p_Name = null)
	{
		if (m_Id is null && p_Name != null)
			m_Id = new ResourceRef(p_Name, this);

		if (m_Id != null)
			return m_Id;

		throw new InvalidOperationException("Resource has no ID.");
	}
}