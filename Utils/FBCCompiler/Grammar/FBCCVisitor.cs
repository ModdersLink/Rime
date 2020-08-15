using System.Globalization;
using System.Text.RegularExpressions;
using FBCC.Containers;

namespace FBCC.Grammar
{
    internal class FBCCVisitor : FBCBaseVisitor<int>
    {
        public FrostbiteContainer Container { get; private set; }

        private IContainerDefinition m_CurrentDefinition;

        private ContainerMember m_CurrentMember;

        private ContainerEnumValue m_CurrentEnumValue;
		
        public FBCCVisitor(string p_FilePath)
        {
            Container = new FrostbiteContainer(p_FilePath);
        }

        public override int VisitFbc(FBCParser.FbcContext p_Context)
        {
            return VisitChildren(p_Context);
        }

        public override int VisitAccessModifier(FBCParser.AccessModifierContext p_Context)
        {
            ContainerAccess s_Access = ContainerAccess.Public;

            if (p_Context.PUBLIC() != null)
                s_Access = ContainerAccess.Public;
            else if (p_Context.PRIVATE() != null)
                s_Access = ContainerAccess.Private;
            else if (p_Context.PROTECTED() != null)
                s_Access = ContainerAccess.Protected;

            m_CurrentMember.Access = s_Access;

            return VisitChildren(p_Context);
        }

        public override int VisitMemberType(FBCParser.MemberTypeContext p_Context)
        {
            ContainerMemberType s_Type;

            if (p_Context.FLOAT() != null)
                s_Type = ContainerMemberType.Float;
            else if (p_Context.DOUBLE() != null)
                s_Type = ContainerMemberType.Double;
            else if (p_Context.BOOL() != null)
                s_Type = ContainerMemberType.Bool;
            else if (p_Context.STRING() != null)
                s_Type = ContainerMemberType.String;
            else if (p_Context.GUID() != null)
                s_Type = ContainerMemberType.GUID;
            else if (p_Context.SHA1() != null)
                s_Type = ContainerMemberType.SHA1;
            else if (p_Context.INT64() != null)
                s_Type = ContainerMemberType.Int64;
            else if (p_Context.UINT64() != null)
                s_Type = ContainerMemberType.UInt64;
            else if (p_Context.INT32() != null)
                s_Type = ContainerMemberType.Int32;
            else if (p_Context.UINT32() != null)
                s_Type = ContainerMemberType.UInt32;
            else if (p_Context.INT16() != null)
                s_Type = ContainerMemberType.Int16;
            else if (p_Context.UINT16() != null)
                s_Type = ContainerMemberType.UInt16;
            else if (p_Context.INT8() != null)
                s_Type = ContainerMemberType.Int8;
            else if (p_Context.UINT8() != null)
                s_Type = ContainerMemberType.UInt8;
            else
                s_Type = ContainerMemberType.Container;

            m_CurrentMember.MemberType = s_Type;

            if (s_Type == ContainerMemberType.Container)
                m_CurrentMember.SetContainerType(p_Context.namespaceString().GetText());

            return VisitChildren(p_Context);
        }

        public override int VisitFileInclude(FBCParser.FileIncludeContext p_Context)
        {
            Container.AddInclude(p_Context.ANGLE_STRING().GetText());
            return VisitChildren(p_Context);
        }

        public override int VisitNamespaceBlock(FBCParser.NamespaceBlockContext p_Context)
        {
            if (p_Context.@namespace() != null)
                Container.SetNamespace(p_Context.@namespace().namespaceString().GetText());

            return VisitChildren(p_Context);
        }

        public override int VisitTypeMember(FBCParser.TypeMemberContext p_Context)
        {
            var s_Member = new ContainerMember(p_Context.IDENTIFIER().GetText());
			
            s_Member.Offset = ParseUInt64(p_Context.INTEGER().GetText());
            s_Member.Array = p_Context.arrayModifier() != null;

            m_CurrentMember = s_Member;

            var s_Result = VisitChildren(p_Context);

            if (m_CurrentDefinition.DefinitionType == ContainerDefinitionType.Class)
                ((ContainerClass) m_CurrentDefinition).AddMember(m_CurrentMember);
            else
                ((ContainerStruct) m_CurrentDefinition).AddMember(m_CurrentMember);

            m_CurrentMember = null;

            return s_Result;
        }

	    public override int VisitAttributeBlock(FBCParser.AttributeBlockContext p_Context)
	    {
			foreach (var s_ParsedAttribute in p_Context.attribute())
		    {
			    var s_Attribute = new ContainerAttribute(s_ParsedAttribute.IDENTIFIER().GetText());

			    foreach (var s_ParsedParam in s_ParsedAttribute.attributeParam())
			    {
				    if (s_ParsedParam.INTEGER() != null)
				    {
					    var s_Value = ParseInt64(s_ParsedParam.INTEGER().GetText());

					    if (s_ParsedParam.DASH() != null)
						    s_Value *= -1;

						s_Attribute.Parameters.Add(new ContainerIntegerAttributeParam(s_Value));

						continue;
				    }

					if (s_ParsedParam.FLOAT_NUMBER() != null)
					{
						var s_Value = double.Parse(s_ParsedParam.FLOAT_NUMBER().GetText());

						if (s_ParsedParam.DASH() != null)
							s_Value *= -1.0;

						s_Attribute.Parameters.Add(new ContainerFloatAttributeParam(s_Value));

						continue;
					}

					if (s_ParsedParam.TRUE() != null || 
						s_ParsedParam.FALSE() != null)
					{
						s_Attribute.Parameters.Add(new ContainerBooleanAttributeParam(s_ParsedParam.TRUE() != null));
						continue;
					}

					if (s_ParsedParam.QUOTED_STRING() != null)
					{
						var s_Value = s_ParsedParam.QUOTED_STRING().GetText();
						s_Value = s_Value.Substring(1, s_Value.Length - 2);
						s_Value = Regex.Unescape(s_Value);

						s_Attribute.Parameters.Add(new ContainerStringAttributeParam(s_Value));
						continue;
					}
				}

				if (m_CurrentEnumValue != null)
					m_CurrentEnumValue.AddAttribute(s_Attribute);
				else if (m_CurrentMember != null)
					m_CurrentMember.AddAttribute(s_Attribute);
				else
					m_CurrentDefinition?.AddAttribute(s_Attribute);
		    }

		    return 0;
	    }

		public override int VisitTypeEvent(FBCParser.TypeEventContext p_Context)
        {
            // TODO: Support for events.
            return VisitChildren(p_Context);
        }

        public override int VisitTypeNativeFunction(FBCParser.TypeNativeFunctionContext p_Context)
        {
            // TODO: Support for native functions.
            return VisitChildren(p_Context);
        }

        public override int VisitTypeManagedFunction(FBCParser.TypeManagedFunctionContext p_Context)
        {
            // TODO: Support for managed functions.
            return VisitChildren(p_Context);
        }

        public override int VisitClassBlock(FBCParser.ClassBlockContext p_Context)
        {
            var s_Definition = new ContainerClass(p_Context.IDENTIFIER().GetText());
            
            m_CurrentDefinition = s_Definition;

            var s_Result = VisitChildren(p_Context);

            s_Definition.CloseClass();

            Container.AddDefinition(m_CurrentDefinition);
            m_CurrentDefinition = null;

            return s_Result;
        }

        public override int VisitClassInheritance(FBCParser.ClassInheritanceContext p_Context)
        {
            foreach (var s_Class in p_Context.namespaceString())
                ((ContainerClass) m_CurrentDefinition).AddInheritedClass(s_Class.GetText());

            return VisitChildren(p_Context);
        }

        public override int VisitStructBlock(FBCParser.StructBlockContext p_Context)
        {
            var s_Definition = new ContainerStruct(p_Context.IDENTIFIER().GetText());
			
            m_CurrentDefinition = s_Definition;

            var s_Result = VisitChildren(p_Context);

            s_Definition.CloseStruct();

            Container.AddDefinition(m_CurrentDefinition);
            m_CurrentDefinition = null;

            return s_Result;
        }

        public override int VisitEnumBlock(FBCParser.EnumBlockContext p_Context)
        {
            var s_Definition = new ContainerEnum(p_Context.IDENTIFIER().GetText());
			
            m_CurrentDefinition = s_Definition;

            var s_Result = VisitChildren(p_Context);

            s_Definition.CloseEnum();

            Container.AddDefinition(m_CurrentDefinition);
            m_CurrentDefinition = null;

            return s_Result;
        }

        public override int VisitEnumDataType(FBCParser.EnumDataTypeContext p_Context)
        {
            var s_Type = ContainerEnumType.Int32;

            if (p_Context.integerType().INT64() != null)
                s_Type = ContainerEnumType.Int64;
            else if (p_Context.integerType().UINT64() != null)
                s_Type = ContainerEnumType.UInt64;
            else if (p_Context.integerType().INT32() != null)
                s_Type = ContainerEnumType.Int32;
            else if (p_Context.integerType().UINT32() != null)
                s_Type = ContainerEnumType.UInt32;
            else if (p_Context.integerType().INT16() != null)
                s_Type = ContainerEnumType.Int16;
            else if (p_Context.integerType().UINT16() != null)
                s_Type = ContainerEnumType.UInt16;
            else if (p_Context.integerType().INT8() != null)
                s_Type = ContainerEnumType.Int8;
            else if (p_Context.integerType().UINT8() != null)
                s_Type = ContainerEnumType.UInt8;

            ((ContainerEnum) m_CurrentDefinition).EnumType = s_Type;

            return VisitChildren(p_Context);
        }

        public override int VisitEnumValue(FBCParser.EnumValueContext p_Context)
        {
            var s_Value = new ContainerEnumValue(p_Context.IDENTIFIER().GetText());
			
            m_CurrentEnumValue = s_Value;

            var s_Result = VisitChildren(p_Context);

            ((ContainerEnum) m_CurrentDefinition).AddValue(m_CurrentEnumValue);
            m_CurrentEnumValue = null;

            return s_Result;
        }

        public override int VisitEnumLastMember(FBCParser.EnumLastMemberContext p_Context)
        {
            var s_Value = new ContainerEnumValue(p_Context.IDENTIFIER().GetText());
			
            m_CurrentEnumValue = s_Value;

            var s_Result = VisitChildren(p_Context);

            ((ContainerEnum) m_CurrentDefinition).AddValue(m_CurrentEnumValue);
            m_CurrentEnumValue = null;

            return s_Result;
        }

        public override int VisitEnumMemberValue(FBCParser.EnumMemberValueContext p_Context)
        {
            if (p_Context.DASH() != null)
                m_CurrentEnumValue.Value = -ParseInt64(p_Context.INTEGER().GetText());
            else
                m_CurrentEnumValue.Value = ParseInt64(p_Context.INTEGER().GetText());

            return VisitChildren(p_Context);
        }

        public override int VisitTypeAlignment(FBCParser.TypeAlignmentContext p_Context)
        {
            var s_Alignment = ParseUInt16(p_Context.INTEGER().GetText());

            if (m_CurrentDefinition.DefinitionType == ContainerDefinitionType.Class)
                ((ContainerClass) m_CurrentDefinition).Alignment = s_Alignment;
            else
                ((ContainerStruct) m_CurrentDefinition).Alignment = s_Alignment;

            return VisitChildren(p_Context);
        }

        private static ulong ParseUInt64(string p_String) 
        {
            var s_String = p_String.ToLowerInvariant();
            var s_Hex = s_String.StartsWith("0x");

            if (s_Hex)
                s_String = s_String.Substring(2);

            return ulong.Parse(s_String, s_Hex ? NumberStyles.HexNumber : NumberStyles.Integer);
        }

        private static long ParseInt64(string p_String)
        {
            var s_String = p_String.ToLowerInvariant();
            var s_Hex = s_String.StartsWith("0x");

            if (s_Hex)
                s_String = s_String.Substring(2);

            return long.Parse(s_String, s_Hex ? NumberStyles.HexNumber : NumberStyles.Integer);
        }

        private static ushort ParseUInt16(string p_String)
        {
            var s_String = p_String.ToLowerInvariant();
            var s_Hex = s_String.StartsWith("0x");

            if (s_Hex)
                s_String = s_String.Substring(2);

            return ushort.Parse(s_String, s_Hex ? NumberStyles.HexNumber : NumberStyles.Integer);
        }
    }
}

