#pragma checksum "/Users/yasaarbiladama/Documents/Development/CLIENTS/ValfardsstatistikApp/Valfardsstatistik/Views/Home/verktyget.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8083627b51167d8ab99f480a976ddde11e03fda9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_verktyget), @"mvc.1.0.view", @"/Views/Home/verktyget.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8083627b51167d8ab99f480a976ddde11e03fda9", @"/Views/Home/verktyget.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4d40e2f0704a41334eaa1f80671f0ea7391bfd0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_verktyget : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<p dir=""ltr"" style=""color: rgb(34, 34, 34); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; line-height: 1.2; margin-top: 0pt; margin-bottom: 0pt;""><span style=""font-size: 12pt; font-family: Arial; color: rgb(33, 37, 41); background-color: transparent; font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap;"">Vi har tagit fram ett s.k J&auml;mf&ouml;relseverktyg som samk&ouml;r utgifter fr&aring;n stat, kommun och regioner.&nbsp;</span></p>
<p dir=""ltr"" style=""color: rgb(34, 34, 34); font-family: Arial, Helvetica, sans-serif; font-s");
            WriteLiteral(@"ize: small; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; line-height: 1.2; margin-top: 0pt; margin-bottom: 0pt;""><span style=""font-size: 12pt; font-family: Arial; color: rgb(33, 37, 41); background-color: transparent; font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap;"">Uppgifterna i J&auml;mf&ouml;relse Verktyget, d.v.s. cirkeldiagrammet p&aring; f&ouml;rsta sidan, kommer fr&aring;n offentlig statistik som hittas p&aring; SCB (nationalr&auml;kenskaperna) fr&aring;n Sveriges kommuner och Regioner&nbsp;</span><a data-mt-detrack-inspected=""true"" data-saferedirecturl=""https://www.google.com/u");
            WriteLiteral(@"rl?q=http://skr.se/&source=gmail&ust=1628242203107000&usg=AFQjCNH7n0O_igiFtE5sGdjvt5woneWmbQ"" href=""http://skr.se/"" style=""color: rgb(17, 85, 204); text-decoration-line: none;"" target=""_blank""><span style=""font-size: 12pt; font-family: Arial; background-color: transparent; font-variant-numeric: normal; font-variant-east-asian: normal; text-decoration-line: underline; vertical-align: baseline; white-space: pre-wrap;"">skr.se</span></a><span style=""font-size: 12pt; font-family: Arial; color: rgb(33, 37, 41); background-color: transparent; font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap;"">&nbsp;och fr&aring;n Regeringens hemsida.</span></p>
<p dir=""ltr"" style=""color: rgb(34, 34, 34); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: norma");
            WriteLiteral(@"l; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; line-height: 1.2; margin-top: 0pt; margin-bottom: 0pt;"">&nbsp;</p>
<p dir=""ltr"" style=""color: rgb(34, 34, 34); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; line-height: 1.2; margin-top: 0pt; margin-bottom: 0pt;""><span style=""font-size: 12pt; font-family: Arial; color: rgb(33, 37, 41); background-color: transparent; font-variant-numeric: normal; font-variant-east-asian: normal; vertical-al");
            WriteLiteral(@"ign: baseline; white-space: pre-wrap;"">F&ouml;r att g&ouml;ra j&auml;mf&ouml;relser mer inneh&aring;llsrika s&aring; finns b&aring;de hush&aring;llens privata konsumtionsutgifter och vissa k&auml;nda m&auml;nniskors l&ouml;ner/rikedomar med. Genom att j&auml;mf&ouml;ra dem med offentliga utgifter s&aring; blir storleken p&aring; offentliga pengar mera tydlig och &auml;ven att pengar &auml;r samma pengar oavsett det hanteras av offentliga sektorn eller privat konsumtion.</span></p>
<p dir=""ltr"" style=""color: rgb(34, 34, 34); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; line-height: 1.2; m");
            WriteLiteral(@"argin-top: 0pt; margin-bottom: 0pt;"">&nbsp;</p>
<p dir=""ltr"" style=""color: rgb(34, 34, 34); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; line-height: 1.2; margin-top: 0pt; margin-bottom: 0pt;""><span style=""font-size: 12pt; font-family: Arial; color: rgb(33, 37, 41); background-color: transparent; font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap;"">Hush&aring;llens utgifter &auml;r fr&aring;n&nbsp;</span><a data-mt-detrack-inspected=""true"" data-saferedirecturl=""https://www.google.com/url?q=http://scb.se/&source=gmail&ust=1628242");
            WriteLiteral(@"203107000&usg=AFQjCNFYopeEWRjGa1YkSHvYB36PhZmLTQ"" href=""http://scb.se/"" style=""color: rgb(17, 85, 204); text-decoration-line: none;"" target=""_blank""><span style=""font-size: 12pt; font-family: Arial; background-color: transparent; font-variant-numeric: normal; font-variant-east-asian: normal; text-decoration-line: underline; vertical-align: baseline; white-space: pre-wrap;"">scb.se</span></a><span style=""font-size: 12pt; font-family: Arial; color: rgb(33, 37, 41); background-color: transparent; font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap;"">&nbsp;och k&auml;nda m&auml;nniskors fr&aring;n b&aring;de Forbes.com listor och fr&aring;n skatteverket.</span></p>
<p dir=""ltr"" style=""color: rgb(34, 34, 34); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none");
            WriteLiteral(@"; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; line-height: 1.2; margin-top: 0pt; margin-bottom: 0pt;"">&nbsp;</p>
<p dir=""ltr"" style=""color: rgb(34, 34, 34); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; line-height: 1.2; margin-top: 0pt; margin-bottom: 0pt;""><span style=""font-size: 12pt; font-family: Arial; color: rgb(33, 37, 41); background-color: transparent; font-variant-numeric: normal; font-variant-east-asian:");
            WriteLiteral(@" normal; vertical-align: baseline; white-space: pre-wrap;"">Utgifter &auml;r ordnade som i ett sl&auml;kttr&auml;d. H&ouml;gst upp finns Topparna som vi kallar Topp producenter. Toppar utg&ouml;r 9 &rdquo;familjer&rdquo;. Om man vill veta mera om ett omr&aring;de/topp s&aring; g&aring;r man ner&aring;t till Niv&aring; 1 i vald Topp. Niv&aring; 1 &auml;r den f&ouml;rsta undergruppen enligt de uppgifter som registreras i samh&auml;llets offentliga ekonomi. Vi har allts&aring; anpassat s&ouml;kfunktioner och begrepp till de som redan finns.</span></p>
<p dir=""ltr"" style=""color: rgb(34, 34, 34); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration");
            WriteLiteral(@"-style: initial; text-decoration-color: initial; line-height: 1.2; margin-top: 0pt; margin-bottom: 0pt;"">&nbsp;</p>
<p dir=""ltr"" style=""color: rgb(34, 34, 34); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; line-height: 1.2; margin-top: 0pt; margin-bottom: 0pt;""><span style=""font-size: 12pt; font-family: Arial; color: rgb(33, 37, 41); background-color: transparent; font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap;"">Du kan j&auml;mf&ouml;ra allt med varandra, oavsett vilken &rdquo;familj&rdquo; eller niv&aring; du v&auml;ljer. De");
            WriteLiteral(@"tta g&ouml;r J&auml;mf&ouml;relseverktyget unikt. Testa!</span></p>
<p dir=""ltr"" style=""color: rgb(34, 34, 34); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; line-height: 1.2; margin-top: 0pt; margin-bottom: 0pt;"">&nbsp;</p>
<p dir=""ltr"" style=""color: rgb(34, 34, 34); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-w");
            WriteLiteral(@"idth: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; line-height: 1.2; margin-top: 0pt; margin-bottom: 0pt;""><span style=""font-size: 12pt; font-family: Arial; color: rgb(33, 37, 41); background-color: transparent; font-weight: 700; font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap;"">Begr&auml;nsningar</span></p>
<p dir=""ltr"" style=""color: rgb(34, 34, 34); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; line-height: 1.2; margin-top: 0pt;");
            WriteLiteral(@" margin-bottom: 0pt;"">&nbsp;</p>
<p dir=""ltr"" style=""color: rgb(34, 34, 34); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; line-height: 1.2; margin-top: 0pt; margin-bottom: 0pt;""><span style=""font-size: 12pt; font-family: Arial; color: rgb(33, 37, 41); background-color: transparent; font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap;"">Ibland &auml;r det extra kr&aring;ngligt att f&aring; fram exakta icke-v&auml;sentliga uppgifter. D&aring; har vi skippat att vara helt exakta. Detta val p&aring;verkar dock inte syftet med det hela");
            WriteLiteral(@", att ge en god &ouml;versikt &ouml;ver offentlig ekonomi.</span></p>
<p dir=""ltr"" style=""color: rgb(34, 34, 34); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; line-height: 1.2; margin-top: 0pt; margin-bottom: 0pt;"">&nbsp;</p>
<p dir=""ltr"" style=""color: rgb(34, 34, 34); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke");
            WriteLiteral(@"-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; line-height: 1.2; margin-top: 0pt; margin-bottom: 0pt;""><span style=""font-size: 12pt; font-family: Arial; color: rgb(33, 37, 41); background-color: transparent; font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap;"">&Aring;lderspensionen finns inte med i statens budget och d&auml;rf&ouml;r finns dessa siffror inte med h&auml;r. En s&auml;rskild handbok som f&ouml;rklarar det mesta som har med pension att g&ouml;ra kommer att finnas tillg&auml;nglig h&auml;r mars 2022.</span></p>
<p dir=""ltr"" style=""color: rgb(34, 34, 34); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; w");
            WriteLiteral(@"ord-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; line-height: 1.2; margin-top: 0pt; margin-bottom: 0pt;""><span style=""font-size: 12pt; font-family: Arial; color: rgb(33, 37, 41); background-color: transparent; font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap;"">En annan begr&auml;nsning &auml;r att vi &auml;r tvungna att anv&auml;nda oss av de nyckeltal som det f&ouml;rs statistik p&aring;.&nbsp;</span></p>
<p dir=""ltr"" style=""color: rgb(34, 34, 34); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, ");
            WriteLiteral(@"255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; line-height: 1.2; margin-top: 0pt; margin-bottom: 0pt;"">&nbsp;</p>
<p dir=""ltr"" style=""color: rgb(34, 34, 34); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; line-height: 1.2; margin-top: 0pt; margin-bottom: 0pt;""><span style=""font-size: 12pt; font-family: Arial; color: rgb(33, 37, 41); background-color: transparent; font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap;"">Enligt v&aring;r uppfattning &auml;r det en begr&auml;nsni");
            WriteLiteral(@"ng att de offentliga nyckeltalen inte bottnar i en v&auml;sentlighetsanalys utan tycks existera f&ouml;r att politier v&auml;ljer att bygger vidare p&aring; gamla (mycket gamla) kontoplaner/nyckeltal som inte &auml;r anpassade till det samh&auml;lle vi lever i idag.</span></p>
<p dir=""ltr"" style=""color: rgb(34, 34, 34); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; line-height: 1.2; margin-top: 0pt; margin-bottom: 0pt;""><span style=""font-size: 11pt; font-family: Calibri, sans-serif; background-color: transparent; font-variant-numeric: normal; font-variant-east-asian: normal; vertical-alig");
            WriteLiteral(@"n: baseline; white-space: pre-wrap;"">&nbsp;</span></p>
<p dir=""ltr"" style=""color: rgb(34, 34, 34); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; line-height: 1.2; margin-top: 0pt; margin-bottom: 0pt;""><span style=""font-size: 12pt; font-family: Arial; color: rgb(33, 37, 41); background-color: transparent; font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap;"">Fast&auml;n vi utg&aring;r fr&aring;n offentlig statistik s&aring; har vi sannolikt &auml;nd&aring; vridit till det med vissa subjektiva vinklingar. Omr&aring;det som kallas &r");
            WriteLiteral(@"dquo;socialt skydd&rdquo; &auml;r ett omr&aring;de som ligger oss varmt om hj&auml;rtat, social omsorg och sjukv&aring;rd. D&auml;rf&ouml;r har dessa 2 omr&aring;den extra utrymme p&aring; <a data-mt-detrack-inspected=""true"" data-saferedirecturl=""https://www.google.com/url?q=http://offentligekonomi.nu&source=gmail&ust=1628242203107000&usg=AFQjCNHSp6HsraJhe9ZJ0k_YYbKVTphrTw"" href=""http://offentligekonomi.nu/"" style=""color: rgb(17, 85, 204);"" target=""_blank"">offentligekonomi.nu</a></span></p>
<p dir=""ltr"" style=""color: rgb(34, 34, 34); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; line-heig");
            WriteLiteral(@"ht: 1.2; margin-top: 0pt; margin-bottom: 0pt;"">&nbsp;</p>
<p dir=""ltr"" style=""color: rgb(34, 34, 34); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; line-height: 1.2; margin-top: 0pt; margin-bottom: 0pt;""><span style=""font-size: 12pt; font-family: Arial; color: rgb(33, 37, 41); background-color: transparent; font-weight: 700; font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap;"">K&auml;llor och Definition</span></p>
<p dir=""ltr"" style=""color: rgb(34, 34, 34); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style:");
            WriteLiteral(@" normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; line-height: 1.2; margin-top: 0pt; margin-bottom: 0pt;"">&nbsp;</p>
<p dir=""ltr"" style=""color: rgb(34, 34, 34); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; line-height: 1.2; margin-top: 0pt; m");
            WriteLiteral(@"argin-bottom: 0pt;""><span style=""font-size: 12pt; font-family: Arial; color: rgb(33, 37, 41); background-color: transparent; font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap;"">Uppgifterna kommer fr&aring;n offentlig statistik som hittas p&aring; SCB (se nationalr&auml;kenskaperna) fr&aring;n Sveriges kommuner och Regioner&nbsp;</span><a data-mt-detrack-inspected=""true"" data-saferedirecturl=""https://www.google.com/url?q=http://skr.se/&source=gmail&ust=1628242203107000&usg=AFQjCNH7n0O_igiFtE5sGdjvt5woneWmbQ"" href=""http://skr.se/"" style=""color: rgb(17, 85, 204); text-decoration-line: none;"" target=""_blank""><span style=""font-size: 12pt; font-family: Arial; color: rgb(33, 37, 41); background-color: transparent; font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap;"">skr.se</span></a><span style=""font-size: 12pt; font-family: Arial; color: rgb(33, 37, 41); background-color: transparent; font-varian");
            WriteLiteral(@"t-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap;"">&nbsp;och fr&aring;n Regeringens hemsida. Vi anv&auml;nder oss av de begrepp som finns i den statistiken. Ibland kan det vara sv&aring;rt att f&ouml;rst&aring; vad dessa begrepp st&aring;r f&ouml;r. D&auml;rf&ouml;r har vi en Begreppshandbok som kan best&auml;llas. D&auml;r anges definitioner p&aring; alla begrepp.&nbsp;</span></p>
<p dir=""ltr"" style=""color: rgb(34, 34, 34); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; line-height: 1.2; margin-top: 0pt; margin-bottom: 0pt;"">&nbsp;</p>
<");
            WriteLiteral(@"p dir=""ltr"" style=""color: rgb(34, 34, 34); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; line-height: 1.2; margin-top: 0pt; margin-bottom: 0pt;""><span style=""font-size: 12pt; font-family: Arial; color: rgb(33, 37, 41); background-color: transparent; font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap;"">F&ouml;r att g&ouml;ra j&auml;mf&ouml;relser mera inneh&aring;llsrika och roliga s&aring; finns b&aring;de hush&aring;llens privata konsumtionsutgifter och vissa k&auml;nda m&auml;nniskors l&ouml;ner/rikedomar med.</span></p>
<p dir");
            WriteLiteral(@"=""ltr"" style=""color: rgb(34, 34, 34); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; line-height: 1.2; margin-top: 0pt; margin-bottom: 0pt;""><span style=""font-size: 12pt; font-family: Arial; color: rgb(33, 37, 41); background-color: transparent; font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap;"">Hush&aring;llens utgifter &auml;r fr&aring;n&nbsp;</span><a data-mt-detrack-inspected=""true"" data-saferedirecturl=""https://www.google.com/url?q=http://scb.se/&source=gmail&ust=1628242203107000&usg=AFQjCNFYopeEWRjGa1YkSHvYB36PhZmLTQ"" href=");
            WriteLiteral(@"""http://scb.se/"" style=""color: rgb(17, 85, 204); text-decoration-line: none;"" target=""_blank""><span style=""font-size: 12pt; font-family: Arial; color: rgb(33, 37, 41); background-color: transparent; font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap;"">scb.se</span></a><span style=""font-size: 12pt; font-family: Arial; color: rgb(33, 37, 41); background-color: transparent; font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap;"">&nbsp;och k&auml;nda m&auml;nniskors fr&aring;n b&aring;de Forbes.com listor och fr&aring;n&nbsp;</span><a data-mt-detrack-inspected=""true"" data-saferedirecturl=""https://www.google.com/url?q=http://skatteverket.se/&source=gmail&ust=1628242203107000&usg=AFQjCNHlpJ3N-VJSIIMKAIl4Bbt0XqlRHw"" href=""http://skatteverket.se/"" style=""color: rgb(17, 85, 204); text-decoration-line: none;"" target=""_blank""><span style=""font-size: 12pt; font-family: Arial; color: rgb(33, 37, 41); backgr");
            WriteLiteral("ound-color: transparent; font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap;\">skatteverket.se</span></a></p>");
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