#pragma checksum "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05c5fa04461d202e7dbfc4173c0813fa215825d2"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05c5fa04461d202e7dbfc4173c0813fa215825d2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4d40e2f0704a41334eaa1f80671f0ea7391bfd0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("TopProducerOptionId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Nivå1OptionId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Nivå2OptionId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05c5fa04461d202e7dbfc4173c0813fa215825d25597", async() => {
                WriteLiteral(@"
  <script src=""https://cdn.jsdelivr.net/npm/chart.js@2.8.0""></script>

  <title>Välfärdsstatistik</title>
  <img width=""35%""
    src=""https://valfardstatistik.files.wordpress.com/2020/06/cropped-loggavacc88lfacc88rdstatistik.png?w=750&h=334""><img>


  <style>
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
        display:none;
      }

      /*----- Menu -----*/
    
        .menu {
          width:100%;
          padding:10px 18px;
          box-shadow:0px 1px 1px rgba(0,0,0,0.15);
          border-radius:3px;
");
                WriteLiteral(@"        }
      

      .menu ul {
        display:inline-block;
      }

      .menu li {
        margin:0px 50px 0px 0px;
        float:left;
        list-style:none;
        font-size:17px;
      }

      .menu li:last-child {
        margin-right:0px;
      }

      .menu a {
        text-shadow:0px 1px 0px rgba(0,0,0,0.5);
        color:#777;
        transition:color linear 0.15s;
      }

      .menu a:hover, .menu .current-item a {
        text-decoration:none;
        color:#66a992;
      }
      /*----- Responsive -----*/
      .wrap {
          width:90%;
        }
      

    .search-form input {
          width:120px;
        }
      

       .menu {
          position:relative;
          display:inline-block;
        }

        .menu ul.active {
          display:none;
        }

        .menu ul {
          width:100%;
          position:absolute;
          top:120%;
          left:0px;
          padding:10px 18px;
          box-shadow:0px 1p");
                WriteLiteral(@"x 1px rgba(0,0,0,0.15);
          border-radius:3px;
          background:#303030; 
        }

        .menu ul:after {
          width:0px;
          height:0px;
          position:absolute;
          top:0%;
          left:22px;
          content:'';
          transform:translate(0%, -100%);
          border-left:7px solid transparent;
          border-right:7px solid transparent;
          border-bottom:7px solid #303030;
        }

        .menu li {
          margin:5px 0px 5px 0px;
          float:none;
          display:block;
        }

        .menu a {
          display:block;
        }

        .toggle-nav {
          padding:20px;
          float:left;
          display:inline-block;
          box-shadow:0px 1px 1px rgba(0,0,0,0.15);
          border-radius:3px;
          background:#303030;
          text-shadow:0px 1px 0px rgba(0,0,0,0.5);
          color:#777;
          font-size:20px;
          transition:color linear 0.15s;
        }

        .toggle-n");
                WriteLiteral(@"av:hover, .toggle-nav.active {
          text-decoration:none;
          color:#66a992;
        }

        .search-form {
          margin:12px 0px 0px 20px;
          float:left;
        }

        .search-form input {
          box-shadow:-1px 1px 2px rgba(0,0,0,0.1);
        }

}
  </style>
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05c5fa04461d202e7dbfc4173c0813fa215825d29778", async() => {
                WriteLiteral("\r\n\r\n  <div class=\"flex-container\">\r\n    <div>\r\n\r\n\r\n      <div class=\"form-group\">\r\n\r\n");
                WriteLiteral("        <select class=\"form-control\" id=\"TopProducerSelectList\">\r\n\r\n          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05c5fa04461d202e7dbfc4173c0813fa215825d210255", async() => {
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
#line 176 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
           foreach (var item in mainTable.ToppProducent)
          {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05c5fa04461d202e7dbfc4173c0813fa215825d212452", async() => {
#nullable restore
#line 179 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
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
#line 179 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
                 WriteLiteral(item.Belopp);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </tr>\r\n");
#nullable restore
#line 181 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
          }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </select>\r\n        <button type=\"button\" id=\"AddBtnTopp\" class=\"btn btn-success\">Lägg till Topp producent</button>\r\n\r\n");
                WriteLiteral("        <select class=\"form-control\" id=\"Nivå1SelectList\">\r\n          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05c5fa04461d202e7dbfc4173c0813fa215825d214967", async() => {
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
#line 189 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
           foreach (var item in mainTable.Nivå1)
          {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05c5fa04461d202e7dbfc4173c0813fa215825d217156", async() => {
#nullable restore
#line 192 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
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
#line 192 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
                 WriteLiteral(item.Belopp);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 192 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 4321, item.Nivå_1, 4321, 12, false);

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
#line 194 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
          }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n        <button type=\"button\" id=\"AddBtnNivå1\" class=\"btn btn-success\">Lägg till Nivå 1</button>\r\n");
                WriteLiteral("        <select class=\"form-control\" id=\"Nivå2SelectList\">\r\n          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05c5fa04461d202e7dbfc4173c0813fa215825d220167", async() => {
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
#line 200 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
           foreach (var item in mainTable.Nivå2)
          {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05c5fa04461d202e7dbfc4173c0813fa215825d222356", async() => {
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
#line 203 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
                 WriteLiteral(item.Belopp);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 203 "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 4873, item.Nivå_2, 4873, 12, false);

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
                WriteLiteral(@"        </select>
        <button type=""button"" id=""AddBtnNivå2"" class=""btn btn-success"">Lägg till nivå 2</button>
        <button type=""button"" id=""ClearBtn"" class=""btn btn-warning"">Rensa</button>

      </div>
    </div>





    <canvas id=""myChart""></canvas>
    <div>
Om oss
Källor,Definitioner,Begränsningar
Definitioner begrepp
Beställ tjänster
 <nav class=""menu"">
      <ul class=""active"">
        <li class=""current-item""><a href=""#"">Om oss</a></li>
        <li><a href=""#"">Källor</a></li>
        <li><a href=""#"">Definitioner Me</a></li>
        <li><a href=""#"">Begränsningar
Definitioner begrepp</a></li>
        <li><a href=""#"">Beställ tjänster</a></li>
      </ul>

      <a class=""toggle-nav"" href=""#"">&#9776;</a>
    </nav>
      <h1>Välfärdsstatistik</h1>
      <p contenteditable=""true"">Sveriges välfärdstjänster är fördelade mellan staten, kommunerna och regionerna. Dessa aktörer har skilda
        verksamhetsområden och redovisningssystem. Exempel på välfärdstjänster är ä");
                WriteLiteral(@"ldreomsorg och sjukvård.
        Välfärd statistik sammanställer samtliga offentliga utgifter på en och samma plattform med syfte att ge
        en sammanhängande och förståelig helhetsbild av Sveriges offentliga utgifter. </p>
    </div>

  </div>


  </div>
  </div>
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05c5fa04461d202e7dbfc4173c0813fa215825d227201", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>

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
  ");
            WriteLiteral(@"        ""DarkTurquoise"",
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
     ");
            WriteLiteral(@"     ""LightSteelBlue"",
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
  ");
            WriteLiteral(@"        ""RoyalBlue"",
          ""SaddleBrown"",
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
      labels: ['Välfärdsstatistik'


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
          text: 'Välfärdsstatistik'
        },
      },
      animation: {
        animateScale: true,
        animateRotate: true
      }
    }
  });


  // Filt");
            WriteLiteral(@"er based on selected value in Topproducers

  document.getElementById(""TopProducerSelectList"").addEventListener(""change"", selectedValueChange);
  document.getElementById(""Nivå1SelectList"").addEventListener(""change"", selectedValueChange);
  document.getElementById(""Nivå2SelectList"").addEventListener(""change"", selectedValueChange);

  document.getElementById(""AddBtnTopp"").addEventListener(""click"", AddValueTopp);
  document.getElementById(""AddBtnNivå1"").addEventListener(""click"", AddValueNivå1);
  document.getElementById(""AddBtnNivå2"").addEventListener(""click"", AddValueNivå2);
  document.getElementById(""ClearBtn"").addEventListener(""click"", ClearValue);

  // On Change
  function selectedValueChange() {
");
            WriteLiteral(@"

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

  function AddValueNivå2() {

    if ($('#Nivå2SelectList').find("":selected"").attr('value') !== """") {

      myDoughnutChart.data.labels.push($('#Nivå2SelectList').find("":selected"").text())
      myDoughnutChart.data.datasets[0].d");
            WriteLiteral("ata.push(parseInt($(\'#Nivå2SelectList\').find(\":selected\").attr(\'value\')))\r\n\r\n\r\n    }\r\n\r\n    myDoughnutChart.update()\r\n  }\r\n\r\n\r\n\r\n  // On Clear\r\n\r\n  function ClearValue() {\r\n");
            WriteLiteral(@"
      myDoughnutChart.data.labels =[""Välfärdsstatistik""];
    myDoughnutChart.data.datasets[0].data = [0];

    myDoughnutChart.update()
  }


jQuery(document).ready(function() {
        jQuery('.toggle-nav').click(function(e) {
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
