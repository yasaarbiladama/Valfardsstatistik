#pragma checksum "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98647b8ff4a14acaa9a278cd049a946ff4c592f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
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
#line 1 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/_ViewImports.cshtml"
using Valfardsstatistik;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/_ViewImports.cshtml"
using Valfardsstatistik.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98647b8ff4a14acaa9a278cd049a946ff4c592f8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4d40e2f0704a41334eaa1f80671f0ea7391bfd0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
  
  ViewData["Title"] = "Index";

  MainTable mainTable = (MainTable)ViewData["MainTable"];



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98647b8ff4a14acaa9a278cd049a946ff4c592f84544", async() => {
                WriteLiteral(@"
  <script src=""https://cdn.jsdelivr.net/npm/chart.js@2.8.0""></script>

  <title>Offentlig ekonomi</title>
  <img width=""200px; height"" height=""200px"" src=""https://i.postimg.cc/HkK5PhTG/logooffekonomi.png""><img>


  <style>
    .myChart {
      margin: 0;
    }

    .container {
      margin: 0;
    }

    .flex-container {
      display: flex;
      flex-wrap: nowrap;

    }

    .flex-container>div {


      text-align: left !important;

    }

    .form-control {
      width: 280px;
    }

    /*----- Toggle Button -----*/
    .toggle-nav {
      display: none;
    }

    /*----- Menu -----*/

    .menu {
      width: 100%;
      padding: 10px 18px;
      box-shadow: 0px 1px 1px rgba(0, 0, 0, 0.15);
      border-radius: 3px;
");
                WriteLiteral(@"    }


    .menu ul {
      display: inline-block;
    }

    .menu li {
      margin: 0px 50px 0px 0px;
      float: left;
      list-style: none;
      font-size: 17px;
    }

    .menu li:last-child {
      margin-right: 0px;
    }

    .menu a {
      text-shadow: 0px 1px 0px rgba(0, 0, 0, 0.5);
      color: #777;
      transition: color linear 0.15s;
    }

    .menu a:hover,
    .menu .current-item a {
      text-decoration: none;
      color: #66a992;
    }

    /*----- Responsive -----*/
    .wrap {
      width: 90%;
    }


    .search-form input {
      width: 120px;
    }


    .menu {
      position: relative;
      display: inline-block;
    }

    .menu ul.active {
      display: none;
    }

    .menu ul {
      width: 100%;
      position: absolute;
      top: 120%;
      left: 0px;
      padding: 10px 18px;
      box-shadow: 0px 1px 1px rgba(0, 0, 0, 0.15);
      border-radius: 3px;
      background: #303030;
    }

    .menu ul:af");
                WriteLiteral(@"ter {
      width: 0px;
      height: 0px;
      position: absolute;
      top: 0%;
      left: 22px;
      content: '';
      transform: translate(0%, -100%);
      border-left: 7px solid transparent;
      border-right: 7px solid transparent;
      border-bottom: 7px solid #303030;
    }

    .menu li {
      margin: 5px 0px 5px 0px;
      float: none;
      display: block;
    }

    .menu a {
      display: block;
    }

    .toggle-nav {
      padding: 20px;
      float: left;
      display: inline-block;
      box-shadow: 0px 1px 1px rgba(0, 0, 0, 0.15);
      border-radius: 3px;
      background: #303030;
      text-shadow: 0px 1px 0px rgba(0, 0, 0, 0.5);
      color: #777;
      font-size: 20px;
      transition: color linear 0.15s;
    }

    .toggle-nav:hover,
    .toggle-nav.active {
      text-decoration: none;
      color: #66a992;
    }

    .search-form {
      margin: 12px 0px 0px 20px;
      float: left;
    }

    .search-form input {
      box");
                WriteLiteral("-shadow: -1px 1px 2px rgba(0, 0, 0, 0.1);\r\n    }\r\n\r\n    }\r\n  </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98647b8ff4a14acaa9a278cd049a946ff4c592f88521", async() => {
                WriteLiteral("\r\n\r\n  <div class=\"flex-container\">\r\n    <div>\r\n\r\n\r\n      <div class=\"form-group\">\r\n\r\n");
                WriteLiteral("        <select class=\"form-control\" id=\"TopProducerSelectList\">\r\n\r\n          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98647b8ff4a14acaa9a278cd049a946ff4c592f88998", async() => {
                    WriteLiteral(" -- Jämför alternativ -- ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 186 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
           foreach (var item in mainTable.ToppProducent)
          {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98647b8ff4a14acaa9a278cd049a946ff4c592f811194", async() => {
#nullable restore
#line 189 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
                                                    Write(item.Namn);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 189 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
                 WriteLiteral(item.Belopp);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 189 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 3530, item.ID, 3530, 8, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </tr>\r\n");
#nullable restore
#line 191 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
          }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </select>\r\n        <button type=\"button\" id=\"AddBtnTopp\" class=\"btn btn-success\">Lägg till Kontogrupp</button>\r\n\r\n");
                WriteLiteral("        <select class=\"form-control\" id=\"Nivå1SelectList\">\r\n          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98647b8ff4a14acaa9a278cd049a946ff4c592f814096", async() => {
                    WriteLiteral(" -- Jämför alternativ -- ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 199 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
           foreach (var item in mainTable.Nivå1)
          {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98647b8ff4a14acaa9a278cd049a946ff4c592f816285", async() => {
                    WriteLiteral("\r\n                ");
#nullable restore
#line 203 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
           Write(item.Namn);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 202 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
                 WriteLiteral(item.Belopp);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 202 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 4063, item.ID, 4063, 8, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "relatedToppid", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 202 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 4088, item.Kontogr_id, 4088, 16, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 202 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 4113, item.Nivå_1, 4113, 12, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </tr>\r\n");
#nullable restore
#line 205 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
          }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n        <button type=\"button\" id=\"AddBtnNivå1\" class=\"btn btn-success\">Lägg till Huvudkonto</button>\r\n");
                WriteLiteral("        <select class=\"form-control\" id=\"Nivå2SelectList\">\r\n          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98647b8ff4a14acaa9a278cd049a946ff4c592f820201", async() => {
                    WriteLiteral(" -- Jämför alternativ -- ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 211 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
           foreach (var item in mainTable.Nivå2)
          {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98647b8ff4a14acaa9a278cd049a946ff4c592f822390", async() => {
                    WriteLiteral("\r\n                ");
#nullable restore
#line 215 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
           Write(item.Namn);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 214 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
                 WriteLiteral(item.Belopp);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 214 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 4665, item.ID, 4665, 8, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "relatedNivå1id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 214 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 4691, item.Underkonto_id, 4691, 19, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 214 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 4719, item.Nivå_2, 4719, 12, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </tr>\r\n");
#nullable restore
#line 217 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
          }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </select>
        <button type=""button"" id=""AddBtnNivå2"" class=""btn btn-success"">Lägg till Underkonto</button>
        <button type=""button"" id=""ClearBtn"" class=""btn btn-warning"">Rensa</button>

      </div>
    </div>





    <canvas id=""myChart"">

    </canvas>
    <div>

      <nav class=""menu"">
        <ul class=""active"">
          <li class=""current-item""><a href=""/home/omoss"">Om oss</a></li>
          <li><a href=""/home/kalla"">Källor</a></li>
          <li><a href=""/home/definitioner"">Definitioner Me</a></li>
          <li><a href=""/home/bestallatjanster"">Beställ tjänster</a></li>
        </ul>

        <a class=""toggle-nav"" href=""#"">&#9776;</a>
      </nav>
      <h1>Offentlig ekonomi</h1>
      <p>Sveriges välfärdstjänster är fördelade mellan staten, kommunerna och regionerna. Dessa
        aktörer har skilda
        verksamhetsområden och redovisningssystem. Exempel på välfärdstjänster är äldreomsorg och sjukvård.
        Välfärd statistik sammanställer samtliga");
                WriteLiteral(" offentliga utgifter på en och samma plattform med syfte att ge\r\n        en sammanhängande och förståelig helhetsbild av Sveriges offentliga utgifter. </p>\r\n    </div>\r\n\r\n  </div>\r\n\r\n\r\n  </div>\r\n  </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98647b8ff4a14acaa9a278cd049a946ff4c592f828079", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script>\r\n");
            WriteLiteral(@"

  var doughnutLabelNameArray = '';
  var doughnutValueArray = '';

  // Logic 



  // Start Initiate loaded Chart

  var ctx = document.getElementById('myChart').getContext('2d');
  // And for a doughnut chart
  var myDoughnutChart = new Chart(ctx, {
    type: 'doughnut',
    data: {
      datasets: [{
        data: [1],
        backgroundColor: [
          ""yellow"",
          ""blue"",
          ""red"",
          ""orange"",

          ""green"",

          ""CornflowerBlue"",
          ""Cornsilk"",
          ""Crimson"",
          ""Cyan"",
          ""DarkBlue"",
          ""DarkCyan"",
          ""DarkGoldenRod"",
          ""DarkGray"",
          ""DarkGrey"",
          ""DarkGreen"",
          ""DarkKhaki"",
          ""DarkMagenta"",
          ""DarkOliveGreen"",
          ""DarkOrange"",
          ""DarkOrchid"",
          ""DarkRed"",
          ""DarkSalmon"",
          ""DarkSeaGreen"",
          ""DarkSlateBlue"",
          ""DarkSlateGray"",
          ""DarkSlateGrey"",
          ""DarkTurquoise""");
            WriteLiteral(@",
          ""DarkViolet"",
          ""DeepPink"",
          ""DeepSkyBlue"",
          ""DimGray"",
          ""DimGrey"",
          ""DodgerBlue"",
          ""FireBrick"",
          ""FloralWhite"",
          ""ForestGreen"",
          ""Fuchsia"",
          ""Gainsboro"",
          ""GhostWhite"",
          ""Gold"",
          ""GoldenRod"",
          ""Gray"",
          ""Grey"",
          ""Green"",
          ""GreenYellow"",
          ""HoneyDew"",
          ""HotPink"",
          ""IndianRed"",
          ""Indigo"",
          ""Ivory"",
          ""Khaki"",
          ""Lavender"",
          ""LavenderBlush"",
          ""LawnGreen"",
          ""LemonChiffon"",
          ""LightBlue"",
          ""LightCoral"",
          ""LightCyan"",
          ""LightGoldenRodYellow"",
          ""LightGray"",
          ""LightGrey"",
          ""LightGreen"",
          ""LightPink"",
          ""LightSalmon"",
          ""LightSeaGreen"",
          ""LightSkyBlue"",
          ""LightSlateGray"",
          ""LightSlateGrey"",
          ""LightSteelBlue"",");
            WriteLiteral(@"
          ""LightYellow"",
          ""Lime"",
          ""LimeGreen"",
          ""Linen"",
          ""Magenta"",
          ""Maroon"",
          ""MediumAquaMarine"",
          ""MediumBlue"",
          ""MediumOrchid"",
          ""MediumPurple"",
          ""MediumSeaGreen"",
          ""MediumSlateBlue"",
          ""MediumSpringGreen"",
          ""MediumTurquoise"",
          ""MediumVioletRed"",
          ""MidnightBlue"",
          ""MintCream"",
          ""MistyRose"",
          ""Moccasin"",
          ""NavajoWhite"",
          ""Navy"",
          ""OldLace"",
          ""Olive"",
          ""OliveDrab"",
          ""Orange"",
          ""OrangeRed"",
          ""Orchid"",
          ""PaleGoldenRod"",
          ""PaleGreen"",
          ""PaleTurquoise"",
          ""PaleVioletRed"",
          ""PapayaWhip"",
          ""PeachPuff"",
          ""Peru"",
          ""Pink"",
          ""Plum"",
          ""PowderBlue"",
          ""Purple"",
          ""RebeccaPurple"",
          ""Red"",
          ""RosyBrown"",
          ""RoyalBlue"",
 ");
            WriteLiteral(@"         ""SaddleBrown"",
          ""Salmon"",
          ""SandyBrown"",
          ""SeaGreen"",
          ""SeaShell"",
          ""Sienna"",
          ""Silver"",
          ""SkyBlue"",
          ""SlateBlue"",
          ""SlateGray"",
          ""SlateGrey"",
          ""Snow"",
          ""SpringGreen"",
          ""SteelBlue"",
          ""Tan"",
          ""Teal"",
          ""Thistle"",
          ""Tomato"",
          ""Turquoise"",
          ""Violet"",
          ""Wheat"",
          ""White"",
          ""WhiteSmoke"",
          ""Yellow"",
          ""YellowGreen""
        ],
        label: 'Dataset 1'
      }],
      labels: ['Offentlig ekonomi'


      ]
    },
    options: {
      responsive: true,
      plugins: {
        legend: {
          position: 'top',
        },
        title: {
          display: true,
          text: 'Offentlig ekonomi'
        },
      },
      animation: {
        animateScale: true,
        animateRotate: true
      }
    }
  });


  // Filter based on selected va");
            WriteLiteral("lue in Topproducers\r\n\r\n  document.getElementById(\"TopProducerSelectList\").addEventListener(\"change\", selectedValueChangeTop);\r\n  document.getElementById(\"Nivå1SelectList\").addEventListener(\"change\", selectedValueChangeNiva1);\r\n");
            WriteLiteral(@"
  document.getElementById(""AddBtnTopp"").addEventListener(""click"", AddValueTopp);
  document.getElementById(""AddBtnNivå1"").addEventListener(""click"", AddValueNivå1);
  document.getElementById(""AddBtnNivå2"").addEventListener(""click"", AddValueNivå2);
  document.getElementById(""ClearBtn"").addEventListener(""click"", ClearValue);

  // On Change
  function selectedValueChangeTop() {


    // If related nivå1 contains selectedTopID show else hide

    var selectedTopID = $('#TopProducerSelectList').find("":selected"").attr('id');


    $(""#Nivå1SelectList > option"").each(function () {


      if ($(this).attr('relatedToppid') == selectedTopID) {


        $(this).show();

      }
      else {
        $(this).hide();
      }

    });

    myDoughnutChart.update()
  }
  // On Change
  function selectedValueChangeNiva1() {
    // If related nivå1 contains selectedTopID show else hide

    var selectedNivå1ID = $('#Nivå1SelectList').find("":selected"").attr('id');


    $(""#Nivå2SelectL");
            WriteLiteral(@"ist > option"").each(function () {

   

      if ($(this).attr('relatedNivå1id') == selectedNivå1ID) {



        $(this).show();

      }
      else {
        $(this).hide();
      }

    });



    myDoughnutChart.update()
  }


  // On Add

  function AddValueTopp() {

    if ($('#TopProducerSelectList').find("":selected"").attr('value') !== """") {

      myDoughnutChart.data.labels.push($('#TopProducerSelectList').find("":selected"").text())
      myDoughnutChart.data.datasets[0].data.push(parseInt($('#TopProducerSelectList').find("":selected"").attr('value')))

    }

    myDoughnutChart.update()
  }

  function AddValueNivå1() {

    if ($('#Nivå1SelectList').find("":selected"").attr('value') !== """") {

      myDoughnutChart.data.labels.push($('#Nivå1SelectList').find("":selected"").text())
      myDoughnutChart.data.datasets[0].data.push(parseInt($('#Nivå1SelectList').find("":selected"").attr('value')))
    }

    myDoughnutChart.update()
  }

  function AddValueNivå2");
            WriteLiteral(@"() {

    if ($('#Nivå2SelectList').find("":selected"").attr('value') !== """") {

      myDoughnutChart.data.labels.push($('#Nivå2SelectList').find("":selected"").text())
      myDoughnutChart.data.datasets[0].data.push(parseInt($('#Nivå2SelectList').find("":selected"").attr('value')))
      
      // Reset selctlists
      document.getElementById(""TopProducerSelectList"").selectedIndex = 0;
      document.getElementById(""Nivå1SelectList"").selectedIndex = 0;
      document.getElementById(""Nivå2SelectList"").selectedIndex = 0;

    }

    myDoughnutChart.update()
  }



  // On Clear

  function ClearValue() {
");
            WriteLiteral(@"
      myDoughnutChart.data.labels =[""Offentlig ekonomi""];
    myDoughnutChart.data.datasets[0].data = [0];

    myDoughnutChart.update()
  }


  jQuery(document).ready(function () {
    jQuery('.toggle-nav').click(function (e) {
      jQuery(this).toggleClass('active');
      jQuery('.menu ul').toggleClass('active');

      e.preventDefault();
    });
  });


</script>

</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
