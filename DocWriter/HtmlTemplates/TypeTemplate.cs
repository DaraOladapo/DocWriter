#pragma warning disable 1591
// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace DocWriter
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


[System.CodeDom.Compiler.GeneratedCodeAttribute("RazorTemplatePreprocessor", "2.6.0.0")]
public partial class TypeTemplate : TypeTemplateBase
{

#line hidden

#line 1 "TypeTemplate.cshtml"
public DocType Model { get; set; }

#line default
#line hidden


public override void Execute()
{
WriteLiteral("<html>\n<head>\n  <script");

WriteLiteral(" src=\"http://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js\"");

WriteLiteral("></script>\n  <script");

WriteLiteral(" src=\"web/editor.js\"");

WriteLiteral("></script>\n\n  <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" href=\"web/style.css\"");

WriteLiteral(">\n\n</head>\n<body>\n  <div");

WriteLiteral(" class=\"caption\"");

WriteLiteral(">");


#line 11 "TypeTemplate.cshtml"
                  Write(Model.Name);


#line default
#line hidden
WriteLiteral("</div>\n  <div");

WriteLiteral(" class=\"title\"");

WriteLiteral(">Summary:<span");

WriteLiteral(" id=\"summary-status\"");

WriteLiteral("></span></div>\n  <div");

WriteLiteral(" class=\'edit\'");

WriteLiteral(" id=\'summary\'");

WriteLiteral(" contenteditable=\'true\'");

WriteLiteral(">");


#line 13 "TypeTemplate.cshtml"
                                                          WriteLiteral (Model.SummaryHtml);

#line default
#line hidden
WriteLiteral("</div>\n");


#line 14 "TypeTemplate.cshtml"
  

#line default
#line hidden

#line 14 "TypeTemplate.cshtml"
   if (Model.Params.Count () > 0){


#line default
#line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"title\"");

WriteLiteral(">Parameters:</div>\n");


#line 16 "TypeTemplate.cshtml"
  	foreach (var p in Model.Params){ 
  	   var name = p.Attribute ("name").Value; var paramid = "param-" + name;


#line default
#line hidden
WriteLiteral("  \t   <div");

WriteLiteral(" class=\"parameter-name\"");

WriteLiteral(">");


#line 18 "TypeTemplate.cshtml"
                             Write(name);


#line default
#line hidden
WriteLiteral("<span");

WriteAttribute ("id", " id=\"", "\""

#line 18 "TypeTemplate.cshtml"
          , Tuple.Create<string,object,bool> ("", paramid

#line default
#line hidden
, false)
, Tuple.Create<string,object,bool> ("", "-status", true)
);
WriteLiteral("></span></div>\n");

WriteLiteral("  \t   <div");

WriteLiteral(" class=\"edit parameter-doc\"");

WriteLiteral(" contenteditable=\'true\'");

WriteAttribute ("id", " id=\"", "\""

#line 19 "TypeTemplate.cshtml"
                          , Tuple.Create<string,object,bool> ("", paramid

#line default
#line hidden
, false)
);
WriteLiteral(">\n");


#line 20 "TypeTemplate.cshtml"
  	   

#line default
#line hidden

#line 20 "TypeTemplate.cshtml"
        WriteLiteral (Model.ToHtml (p));

#line default
#line hidden
WriteLiteral("\n  \t   </div>\n");


#line 22 "TypeTemplate.cshtml"
  	}
  }


#line default
#line hidden
WriteLiteral("  <div");

WriteLiteral(" class=\"title\"");

WriteLiteral(">Remarks:<span");

WriteLiteral(" id=\"remarks-status\"");

WriteLiteral("></span></div>\n  <div");

WriteLiteral(" class=\"edit\"");

WriteLiteral(" id=\'remarks\'");

WriteLiteral(" contenteditable=\'true\'");

WriteLiteral(">");


#line 25 "TypeTemplate.cshtml"
                                                          WriteLiteral (Model.RemarksHtml);

#line default
#line hidden
WriteLiteral("</div>\n  <div");

WriteLiteral(" class=\'caption\'");

WriteLiteral(">Members</div>\n");


#line 27 "TypeTemplate.cshtml"
  

#line default
#line hidden

#line 27 "TypeTemplate.cshtml"
   for (int n = 0; n < Model.NodeCount; n++){


#line default
#line hidden
WriteLiteral("  \t<div");

WriteLiteral(" class=\"title title-code\"");

WriteLiteral(">");


#line 28 "TypeTemplate.cshtml"
                            Write(Model[n].SignatureHtml);


#line default
#line hidden
WriteLiteral("<span");

WriteAttribute ("id", " id=\"", "\""
, Tuple.Create<string,object,bool> ("", "summary-", true)

#line 28 "TypeTemplate.cshtml"
                                   , Tuple.Create<string,object,bool> ("", n

#line default
#line hidden
, false)
, Tuple.Create<string,object,bool> ("", "-status", true)
);
WriteLiteral("></span></div>\n");

WriteLiteral("  \t<div");

WriteLiteral(" class=\"edit\"");

WriteAttribute ("id", " id=\"", "\""
, Tuple.Create<string,object,bool> ("", "summary-", true)

#line 29 "TypeTemplate.cshtml"
, Tuple.Create<string,object,bool> ("", n

#line default
#line hidden
, false)
);
WriteLiteral(" contenteditable=\'true\'");

WriteLiteral(">");


#line 29 "TypeTemplate.cshtml"
                                                              WriteLiteral (Model [n].SummaryHtml);

#line default
#line hidden
WriteLiteral("</div>\n");


#line 30 "TypeTemplate.cshtml"
  }


#line default
#line hidden
WriteLiteral("\n\n</body>\n</html>");

}
}

// NOTE: this is the default generated helper class. You may choose to extract it to a separate file 
// in order to customize it or share it between multiple templates, and specify the template's base 
// class via the @inherits directive.
public abstract class TypeTemplateBase
{

		// This field is OPTIONAL, but used by the default implementation of Generate, Write, WriteAttribute and WriteLiteral
		//
		System.IO.TextWriter __razor_writer;

		// This method is OPTIONAL
		//
		/// <summary>Executes the template and returns the output as a string.</summary>
		/// <returns>The template output.</returns>
		public string GenerateString ()
		{
			using (var sw = new System.IO.StringWriter ()) {
				Generate (sw);
				return sw.ToString ();
			}
		}

		// This method is OPTIONAL, you may choose to implement Write and WriteLiteral without use of __razor_writer
		// and provide another means of invoking Execute.
		//
		/// <summary>Executes the template, writing to the provided text writer.</summary>
		/// <param name="writer">The TextWriter to which to write the template output.</param>
		public void Generate (System.IO.TextWriter writer)
		{
			__razor_writer = writer;
			Execute ();
			__razor_writer = null;
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>Writes a literal value to the template output without HTML escaping it.</summary>
		/// <param name="value">The literal value.</param>
		protected void WriteLiteral (string value)
		{
			__razor_writer.Write (value);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>Writes a literal value to the TextWriter without HTML escaping it.</summary>
		/// <param name="writer">The TextWriter to which to write the literal.</param>
		/// <param name="value">The literal value.</param>
		protected static void WriteLiteralTo (System.IO.TextWriter writer, string value)
		{
			writer.Write (value);
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>Writes a value to the template output, HTML escaping it if necessary.</summary>
		/// <param name="value">The value.</param>
		/// <remarks>The value may be a Action<System.IO.TextWriter>, as returned by Razor helpers.</remarks>
		protected void Write (object value)
		{
			WriteTo (__razor_writer, value);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>Writes an object value to the TextWriter, HTML escaping it if necessary.</summary>
		/// <param name="writer">The TextWriter to which to write the value.</param>
		/// <param name="value">The value.</param>
		/// <remarks>The value may be a Action<System.IO.TextWriter>, as returned by Razor helpers.</remarks>
		protected static void WriteTo (System.IO.TextWriter writer, object value)
		{
			if (value == null)
				return;

			var write = value as Action<System.IO.TextWriter>;
			if (write != null) {
				write (writer);
				return;
			}

			//NOTE: a more sophisticated implementation would write safe and pre-escaped values directly to the
			//instead of double-escaping. See System.Web.IHtmlString in ASP.NET 4.0 for an example of this.
			writer.Write(System.Net.WebUtility.HtmlEncode (value.ToString ()));
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>
		/// Conditionally writes an attribute to the template output.
		/// </summary>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="prefix">The prefix of the attribute.</param>
		/// <param name="suffix">The suffix of the attribute.</param>
		/// <param name="values">Attribute values, each specifying a prefix, value and whether it's a literal.</param>
		protected void WriteAttribute (string name, string prefix, string suffix, params Tuple<string,object,bool>[] values)
		{
			WriteAttributeTo (__razor_writer, name, prefix, suffix, values);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>
		/// Conditionally writes an attribute to a TextWriter.
		/// </summary>
		/// <param name="writer">The TextWriter to which to write the attribute.</param>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="prefix">The prefix of the attribute.</param>
		/// <param name="suffix">The suffix of the attribute.</param>
		/// <param name="values">Attribute values, each specifying a prefix, value and whether it's a literal.</param>
		///<remarks>Used by Razor helpers to write attributes.</remarks>
		protected static void WriteAttributeTo (System.IO.TextWriter writer, string name, string prefix, string suffix, params Tuple<string,object,bool>[] values)
		{
			// this is based on System.Web.WebPages.WebPageExecutingBase
			// Copyright (c) Microsoft Open Technologies, Inc.
			// Licensed under the Apache License, Version 2.0
			if (values.Length == 0) {
				// Explicitly empty attribute, so write the prefix and suffix
				writer.Write (prefix);
				writer.Write (suffix);
				return;
			}

			bool first = true;
			bool wroteSomething = false;

			for (int i = 0; i < values.Length; i++) {
				Tuple<string,object,bool> attrVal = values [i];
				string attPrefix = attrVal.Item1;
				object value = attrVal.Item2;
				bool isLiteral = attrVal.Item3;

				if (value == null) {
					// Nothing to write
					continue;
				}

				// The special cases here are that the value we're writing might already be a string, or that the 
				// value might be a bool. If the value is the bool 'true' we want to write the attribute name instead
				// of the string 'true'. If the value is the bool 'false' we don't want to write anything.
				//
				// Otherwise the value is another object (perhaps an IHtmlString), and we'll ask it to format itself.
				string stringValue;
				bool? boolValue = value as bool?;
				if (boolValue == true) {
					stringValue = name;
				} else if (boolValue == false) {
					continue;
				} else {
					stringValue = value as string;
				}

				if (first) {
					writer.Write (prefix);
					first = false;
				} else {
					writer.Write (attPrefix);
				}

				if (isLiteral) {
					writer.Write (stringValue ?? value);
				} else {
					WriteTo (writer, stringValue ?? value);
				}
				wroteSomething = true;
			}
			if (wroteSomething) {
				writer.Write (suffix);
			}
		}
		// This method is REQUIRED. The generated Razor subclass will override it with the generated code.
		//
		///<summary>Executes the template, writing output to the Write and WriteLiteral methods.</summary>.
		///<remarks>Not intended to be called directly. Call the Generate method instead.</remarks>
		public abstract void Execute ();

}
}
#pragma warning restore 1591
