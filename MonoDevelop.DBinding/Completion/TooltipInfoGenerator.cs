﻿using D_Parser.Dom;
using D_Parser.Parser;
using D_Parser.Resolver;
using D_Parser.Resolver.TypeResolution;
using MonoDevelop.Ide.CodeCompletion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoDevelop.D.Completion
{
	class TooltipInfoGenerator
	{
		public static TooltipInformation Generate(AbstractType t, int currentParameter = -1, bool isInTemplateArgInsight = false)
		{
			var ms = t as MemberSymbol;
			if (ms != null)
			{
				if (ms.Definition is DVariable)
				{
					var bt = DResolver.StripAliasSymbol(ms.Base);
					if (bt is DelegateType)
						return TooltipInfoGenerator.Generate(bt as DelegateType, currentParameter);
				}
				else if (ms.Definition is DMethod)
					return TooltipInfoGenerator.Generate(ms.Definition as DMethod, isInTemplateArgInsight, currentParameter);
			}
			else if (t is TemplateIntermediateType)
				return Generate(t as TemplateIntermediateType, currentParameter);

			return new TooltipInformation();
		}

		public static TooltipInformation Generate(DelegateType dt, int currentParam = -1)
		{
			var dd = dt.TypeDeclarationOf as DelegateDeclaration;
			if (dd != null)
				return Generate(dd, currentParam);

			return new TooltipInformation();
		}

		public static TooltipInformation Generate(DelegateDeclaration dd, int currentParam = -1)
		{
			var sb = new StringBuilder("<i>(Delegate)</i> ");

			if (dd.ReturnType != null)
				sb.Append(dd.ReturnType.ToString(true)).Append(' ');

			if (dd.IsFunction)
				sb.Append("function");
			else
				sb.Append("delegate");

			sb.Append('(');
			if (dd.Parameters != null && dd.Parameters.Count != 0)
			{
				for (int i = 0; i < dd.Parameters.Count; i++)
				{
					var p = dd.Parameters[i] as DNode;
					if (i == currentParam)
					{
						sb.Append("<u>");
						sb.Append(p.ToString(false));
						sb.Append("</u>,");
					}
					else
						sb.Append(p.ToString(false)).Append(',');
				}

				sb.Remove(sb.Length - 1, 1);
			}
			sb.Append(')');

			var tti = new TooltipInformation();
			tti.SignatureMarkup = sb.ToString();

			return tti;
		}

		public static TooltipInformation Generate(DMethod dm, bool isTemplateParamInsight=false, int currentParam=-1)
		{
			var tti = new TooltipInformation();
			var sb = new StringBuilder("<i>(");

			string name;
			switch (dm.SpecialType)
			{
				case DMethod.MethodType.Constructor:
					sb.Append("Constructor");
					name = dm.Parent.Name;
					break;
				case DMethod.MethodType.Destructor:
					sb.Append("Destructor"); name = dm.Parent.Name;
					break;
				case DMethod.MethodType.Allocator:
					sb.Append("Allocator"); name = dm.Parent.Name;
					break;
				default:
					sb.Append("Method");
					name = dm.Name;
					break;
			}
			sb.Append(")</i> ");

			if (dm.Type != null)
			{
				sb.Append(dm.Type.ToString(true));
				sb.Append(" ");
			}
			else if (dm.Attributes != null && dm.Attributes.Count != 0)
			{
				foreach (var attr in dm.Attributes)
				{
					var m = attr as Modifier;
					if (m != null && DTokens.StorageClass[m.Token])
					{
						sb.Append(DTokens.GetTokenString(m.Token));
						sb.Append(" ");
						break;
					}
				}
			}

			sb.Append(name);

			/*TODO: Show attributes?
			if (dm.Attributes != null && dm.Attributes.Count > 0)
				s = dm.AttributeString + ' ';
			*/

			// Template parameters
			if (dm.TemplateParameters != null && dm.TemplateParameters.Length > 0)
			{
				sb.Append("(");

				for (int i = 0; i < dm.TemplateParameters.Length; i++)
				{
					var p = dm.TemplateParameters[i];
					if (isTemplateParamInsight && i == currentParam)
					{
						sb.Append("<u>");
						tti.AddCategory(p.Name, p.ToString());
						sb.Append(p.ToString());
						sb.Append("</u>");
					}
					else
						sb.Append(p.ToString());

					if (i < dm.TemplateParameters.Length - 1)
						sb.Append(",");
				}

				sb.Append(")");
			}

			// Parameters
			sb.Append("(");

			for (int i = 0; i < dm.Parameters.Count; i++)
			{
				var p = dm.Parameters[i] as DNode;
				if (!isTemplateParamInsight && i == currentParam)
				{
					sb.Append("<u>");
					if (!string.IsNullOrEmpty(p.Description))
						tti.AddCategory(p.Name, p.Description);
					sb.Append(p.ToString(true, false));
					sb.Append("</u>");
				}
				else
					sb.Append(p.ToString(true, false));

				if (i < dm.Parameters.Count - 1)
					sb.Append(",");
			}

			sb.Append(")");
			tti.SignatureMarkup = sb.ToString();

			tti.SummaryMarkup = dm.Description;
			tti.FooterMarkup = dm.ToString();
			return tti;
		}

		public static TooltipInformation Generate(TemplateIntermediateType tit, int currentParam = -1)
		{
			var sb = new StringBuilder("(");

			if (tit is ClassType)
				sb.Append("Class");
			else if (tit is InterfaceType)
				sb.Append("Interface");
			else if (tit is TemplateType)
				sb.Append("Template");
			else if (tit is StructType)
				sb.Append("Struct");
			else if (tit is UnionType)
				sb.Append("Union");

			sb.Append(") ").Append(tit.Name);
			var dc =tit.Definition;
			if (dc.TemplateParameters != null && dc.TemplateParameters.Length != 0)
			{
				sb.Append('(');
				for (int i = 0; i < dc.TemplateParameters.Length; i++)
				{
					if (i == currentParam)
						sb.Append("<i>");

					sb.Append(dc.TemplateParameters[i].ToString());

					if (i == currentParam)
						sb.Append("</i>");
					sb.Append(',');
				}
				sb.Remove(sb.Length -1, 1).Append(')');
			}

			var tti = new TooltipInformation { 
				SignatureMarkup = sb.ToString(),
				SummaryMarkup = dc.Description,
				FooterMarkup = dc.ToString(false)
			};

			return tti;
		}
	}
}
