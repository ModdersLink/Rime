using System.Text.RegularExpressions;

namespace FBCC.Containers
{
	class ContainerStringAttributeParam : ContainerAttributeParam<string>
	{
		protected string m_Value;

		public ContainerStringAttributeParam(string p_Value) :
			base(ContainerAttributeParamType.StringAttribute)
		{
			m_Value = p_Value;
		}

		protected override string AsString()
		{
			return "\"" + Regex.Escape(m_Value) + "\"";
		}

		public override string GetValue()
		{
			return m_Value;
		}
	}
}
