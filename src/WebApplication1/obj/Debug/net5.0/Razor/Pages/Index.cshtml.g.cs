#pragma checksum "C:\Users\milke\Desktop\ProjetoGPS\WebApplication1\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dd7ae7a52f8648ac533e2548414bf8b63827c8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication1.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\milke\Desktop\ProjetoGPS\WebApplication1\Pages\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dd7ae7a52f8648ac533e2548414bf8b63827c8d", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd66e6c0b2d0593b97c0d67f6f506054866fe040", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 10%; margin-left: 5px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "UpdateApplication", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-action", "accept", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-action", "reject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\milke\Desktop\ProjetoGPS\WebApplication1\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
<!-- TABS START -->
	<ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
		<li class=""nav-item"" role=""presentation"">
			<button class=""nav-link active"" id=""pendentes-tab"" data-bs-toggle=""tab"" data-bs-target=""#pendentes"" type=""button"" role=""tab"" aria-controls=""home"" aria-selected=""true"">⏰ Pendentes (");
#nullable restore
#line 11 "C:\Users\milke\Desktop\ProjetoGPS\WebApplication1\Pages\Index.cshtml"
                                                                                                                                                                                           Write(Model.apps.Length);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")</button>
		</li>
		<li class=""nav-item"" role=""presentation"">
			<button class=""nav-link"" id=""aceites-tab"" data-bs-toggle=""tab"" data-bs-target=""#aceites"" type=""button"" role=""tab"" aria-controls=""profile"" aria-selected=""false"">✔️ Aceites (<% =Accepted.Length %>)</button>
		</li>
		<li class=""nav-item"" role=""presentation"">
			<button class=""nav-link"" id=""recusadas-tab"" data-bs-toggle=""tab"" data-bs-target=""#recusadas"" type=""button"" role=""tab"" aria-controls=""contact"" aria-selected=""false"">❌ Recusadas (<% =Rejected.Length %>)</button>
		</li>
	</ul>
	<!-- TABS END -->
	<!-- APPLICATIONS START -->
	<div class=""tab-content"" id=""myTabContent"">
		<!-- CANDIDATURAS PENDENTES -->
		<div class=""tab-pane fade show active margin"" id=""pendentes"" role=""tabpanel"" aria-labelledby=""pendentes-tab"">
			<h3>⏰ Candidaturas Pendentes</h3>
");
#nullable restore
#line 26 "C:\Users\milke\Desktop\ProjetoGPS\WebApplication1\Pages\Index.cshtml"
             if (Model.apps.Length == 0)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<a>Não há candidaturas pendentes.</a>\r\n");
#nullable restore
#line 29 "C:\Users\milke\Desktop\ProjetoGPS\WebApplication1\Pages\Index.cshtml"
			}
			else
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div style=\"margin-top: 2%\">\r\n");
#nullable restore
#line 33 "C:\Users\milke\Desktop\ProjetoGPS\WebApplication1\Pages\Index.cshtml"
                     foreach (var app in Model.apps)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div class=\"card\" style=\"margin-top: 3%; background-color: #f8f8f8\">\r\n\t\t\t\t\t\t\t<div class=\"container margin\" style=\"margin-bottom: 1%\">\r\n\t\t\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"col-sm\">\r\n\t\t\t\t\t\t\t\t\t\t<a>Nome:</a>\r\n\t\t\t\t\t\t\t\t\t\t<h5>");
#nullable restore
#line 40 "C:\Users\milke\Desktop\ProjetoGPS\WebApplication1\Pages\Index.cshtml"
                                       Write(app.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 40 "C:\Users\milke\Desktop\ProjetoGPS\WebApplication1\Pages\Index.cshtml"
                                                 Write(app.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"col-sm\">\r\n\t\t\t\t\t\t\t\t\t\t<a>Cidade:</a>\r\n\t\t\t\t\t\t\t\t\t\t<h5>");
#nullable restore
#line 44 "C:\Users\milke\Desktop\ProjetoGPS\WebApplication1\Pages\Index.cshtml"
                                       Write(app.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"col-sm\">\r\n\t\t\t\t\t\t\t\t\t\t<a>Email:</a>\r\n\t\t\t\t\t\t\t\t\t\t<h5><a");
            BeginWriteAttribute("href", " href=\"", 1886, "\"", 1911, 2);
            WriteAttributeValue("", 1893, "mailto:", 1893, 7, true);
#nullable restore
#line 48 "C:\Users\milke\Desktop\ProjetoGPS\WebApplication1\Pages\Index.cshtml"
WriteAttributeValue(" ", 1900, app.Email, 1901, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 48 "C:\Users\milke\Desktop\ProjetoGPS\WebApplication1\Pages\Index.cshtml"
                                                                    Write(app.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div style=\"margin-top: 1%\">\r\n\t\t\t\t\t\t\t\t\t<hr />\r\n\t\t\t\t\t\t\t\t\t<a>Detalhes:</a>\r\n\t\t\t\t\t\t\t\t\t<h6>");
#nullable restore
#line 54 "C:\Users\milke\Desktop\ProjetoGPS\WebApplication1\Pages\Index.cshtml"
                                   Write(app.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 54 "C:\Users\milke\Desktop\ProjetoGPS\WebApplication1\Pages\Index.cshtml"
                                                Write(app.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div style=\"margin-left: 1%; margin-bottom: 1%\">\r\n\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dd7ae7a52f8648ac533e2548414bf8b63827c8d11579", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dd7ae7a52f8648ac533e2548414bf8b63827c8d11856", async() => {
                    WriteLiteral("Aceitar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-action", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["action"] = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-app_id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\milke\Desktop\ProjetoGPS\WebApplication1\Pages\Index.cshtml"
                                                                                                                                                                                            WriteLiteral(app.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["app_id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-app_id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["app_id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dd7ae7a52f8648ac533e2548414bf8b63827c8d15131", async() => {
                    WriteLiteral("Recusar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-action", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["action"] = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-app_id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\milke\Desktop\ProjetoGPS\WebApplication1\Pages\Index.cshtml"
                                                                                                                                                                                           WriteLiteral(app.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["app_id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-app_id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["app_id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 64 "C:\Users\milke\Desktop\ProjetoGPS\WebApplication1\Pages\Index.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t</div>\r\n");
#nullable restore
#line 66 "C:\Users\milke\Desktop\ProjetoGPS\WebApplication1\Pages\Index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"		</div>
		<!-- CANDIDATURAS ACEITES -->
		<div class=""tab-pane fade margin"" id=""aceites"" role=""tabpanel"" aria-labelledby=""aceites-tab"">
			<h3>✔️ Candidaturas Aceites</h3>
			<asp:Label ID=""label_semAceites"" Visible=""false"" runat=""server"">Não há candidaturas aceites.</asp:Label>
			<div style=""margin-top: 2%"">
				<asp:Repeater ID=""repeater_accepted"" runat=""server"" OnItemCommand=""repeater_ItemCommand"">
					<ItemTemplate>
						<div class=""card"" style=""margin-top: 3%; background-color: #f8f8f8"">
							<div class=""container margin"" style=""margin-bottom: 1%"">
								<div class=""row"">
									<div class=""col-sm"">
										<a>Nome:</a>
										<h5><%# Eval(""Name"") %> <%# Eval(""Surname"") %></h5>
									</div>
									<div class=""col-sm"">
										<a>Cidade:</a>
										<h5><%# Eval(""City"") %></h5>
									</div>
									<div class=""col-sm"">
										<a>Email:</a>
										<h5><a href=""mailto: <%# Eval(""Email"") %>""><%# Eval(""Email"") %></a></h5>
									</div>
								</div>
            WriteLiteral(@"
								<div style=""margin-top: 1%"">
									<hr />
									<a>Detalhes:</a>
									<h6><%# Eval(""Message"") %> <%# Eval(""State"") %></h6>
								</div>
							</div>
							<div style=""margin-left: 1%; margin-bottom: 1%"">
								<asp:Button runat=""server"" Text=""Rejeitar"" class=""btn btn-danger"" Style=""width: 10%; margin-left: 5px"" CommandArgument='<%# Eval(""ID"") %>' CommandName=""reject"" />
								<asp:Button runat=""server"" Text=""Restaurar"" class=""btn btn-secondary"" Style=""width: 10%; margin-left: 5px"" CommandArgument='<%# Eval(""ID"") %>' CommandName=""restore"" />
							</div>
						</div>
					</ItemTemplate>
				</asp:Repeater>
			</div>
		</div>
		<!-- CANDIDATURAS RECUSADAS -->
		<div class=""tab-pane fade margin"" id=""recusadas"" role=""tabpanel"" aria-labelledby=""recusadas-tab"">
			<h3>❌ Candidaturas Recusadas</h3>
			<asp:Label ID=""label_semRejeitadas"" Visible=""false"" runat=""server"">Não há candidaturas rejeitadas.</asp:Label>
			<div style=""margin-top: 2%"">
				<asp:Repeater ID=""repe");
            WriteLiteral(@"ater_rejected"" runat=""server"" OnItemCommand=""repeater_ItemCommand"">
					<ItemTemplate>
						<div class=""card"" style=""margin-top: 3%; background-color: #f8f8f8"">
							<div class=""container margin"" style=""margin-bottom: 1%"">
								<div class=""row"">
									<div class=""col-sm"">
										<a>Nome:</a>
										<h5><%# Eval(""Name"") %> <%# Eval(""Surname"") %></h5>
									</div>
									<div class=""col-sm"">
										<a>Cidade:</a>
										<h5><%# Eval(""City"") %></h5>
									</div>
									<div class=""col-sm"">
										<a>Email:</a>
										<h5><a href=""mailto: <%# Eval(""Email"") %>""><%# Eval(""Email"") %></a></h5>
									</div>
								</div>
								<div style=""margin-top: 1%"">
									<hr />
									<a>Detalhes:</a>
									<h6><%# Eval(""Message"") %> <%# Eval(""State"") %></h6>
								</div>
							</div>
							<div style=""margin-left: 1%; margin-bottom: 1%"">
								<asp:Button runat=""server"" Text=""Aceitar"" class=""btn btn-success"" Style=""width: 10%; margin-left: 5px"" ");
            WriteLiteral(@"CommandArgument='<%# Eval(""ID"") %>' CommandName=""accept"" />
								<asp:Button runat=""server"" Text=""Restaurar"" class=""btn btn-secondary"" Style=""width: 10%; margin-left: 5px"" CommandArgument='<%# Eval(""ID"") %>' CommandName=""restore"" />
							</div>
						</div>
					</ItemTemplate>
				</asp:Repeater>
			</div>
		</div>
	</div>
	<!-- APPLICATIONS END -->
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591