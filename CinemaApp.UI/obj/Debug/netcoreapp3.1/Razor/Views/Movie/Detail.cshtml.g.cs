#pragma checksum "C:\Users\Rovshan Jafarli\Desktop\CinemaApp\CinemaApp.UI\Views\Movie\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40a059a8d5759e144f31cf366f31d09db6d62af7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Detail), @"mvc.1.0.view", @"/Views/Movie/Detail.cshtml")]
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
#line 1 "C:\Users\Rovshan Jafarli\Desktop\CinemaApp\CinemaApp.UI\Views\_ViewImports.cshtml"
using CinemaApp.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rovshan Jafarli\Desktop\CinemaApp\CinemaApp.UI\Views\_ViewImports.cshtml"
using CinemaApp.Business.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Rovshan Jafarli\Desktop\CinemaApp\CinemaApp.UI\Views\_ViewImports.cshtml"
using CinemaApp.Entity.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Rovshan Jafarli\Desktop\CinemaApp\CinemaApp.UI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40a059a8d5759e144f31cf366f31d09db6d62af7", @"/Views/Movie/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5358c61fa6329958e0ac68f05ca1ac581d4321e0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movie_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CommentPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form comment__form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Rovshan Jafarli\Desktop\CinemaApp\CinemaApp.UI\Views\Movie\Detail.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Main start -->\r\n<main>\r\n\r\n    <section id=\"movie_hero\">\r\n        <div class=\"movie_hero_image\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "40a059a8d5759e144f31cf366f31d09db6d62af75590", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 181, "~/assets/image/", 181, 15, true);
#nullable restore
#line 11 "C:\Users\Rovshan Jafarli\Desktop\CinemaApp\CinemaApp.UI\Views\Movie\Detail.cshtml"
AddHtmlAttributeValue("", 196, Model.BackgroundImgUrl, 196, 23, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>


    </section>

    <section id=""movie_about"">

        <div class=""tab_header"">
            <a href=""#about"" class=""active btn"" id=""about"" rel=""schedule"">About</a>

        </div>


        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-6 col-md-6 col-sm-12"">
                    <div class=""trailer_player"">
                        ");
#nullable restore
#line 29 "C:\Users\Rovshan Jafarli\Desktop\CinemaApp\CinemaApp.UI\Views\Movie\Detail.cshtml"
                   Write(Html.Raw(Model.TrailerUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-6 col-md-6 col-sm-12\">\r\n\r\n                    <div class=\"movie_about_content\">\r\n                        <h3> ");
#nullable restore
#line 35 "C:\Users\Rovshan Jafarli\Desktop\CinemaApp\CinemaApp.UI\Views\Movie\Detail.cshtml"
                        Write(Model.MovieName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h3>



                        <ul class=""list"">
                            <li>
                                <span>IMDB : </span>
                                <div class=""list-detail"">
                                    <svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 24 24""><path d=""M22,9.67A1,1,0,0,0,21.14,9l-5.69-.83L12.9,3a1,1,0,0,0-1.8,0L8.55,8.16,2.86,9a1,1,0,0,0-.81.68,1,1,0,0,0,.25,1l4.13,4-1,5.68A1,1,0,0,0,6.9,21.44L12,18.77l5.1,2.67a.93.93,0,0,0,.46.12,1,1,0,0,0,.59-.19,1,1,0,0,0,.4-1l-1-5.68,4.13-4A1,1,0,0,0,22,9.67Zm-6.15,4a1,1,0,0,0-.29.88l.72,4.2-3.76-2a1.06,1.06,0,0,0-.94,0l-3.76,2,.72-4.2a1,1,0,0,0-.29-.88l-3-3,4.21-.61a1,1,0,0,0,.76-.55L12,5.7l1.88,3.82a1,1,0,0,0,.76.55l4.21.61Z""></path></svg>
                                    ");
#nullable restore
#line 44 "C:\Users\Rovshan Jafarli\Desktop\CinemaApp\CinemaApp.UI\Views\Movie\Detail.cshtml"
                               Write(Model.ImdbPoint);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </li>\r\n                            <li>\r\n                                <span>Janr : </span>\r\n");
#nullable restore
#line 49 "C:\Users\Rovshan Jafarli\Desktop\CinemaApp\CinemaApp.UI\Views\Movie\Detail.cshtml"
                                 foreach (var category in Model.MovieCategories)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"list-detail\">\r\n                                        ");
#nullable restore
#line 52 "C:\Users\Rovshan Jafarli\Desktop\CinemaApp\CinemaApp.UI\Views\Movie\Detail.cshtml"
                                   Write(category.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n");
#nullable restore
#line 54 "C:\Users\Rovshan Jafarli\Desktop\CinemaApp\CinemaApp.UI\Views\Movie\Detail.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n                            <li>\r\n                                <span>Olke : </span>\r\n                                <div class=\"list-detail\">");
#nullable restore
#line 59 "C:\Users\Rovshan Jafarli\Desktop\CinemaApp\CinemaApp.UI\Views\Movie\Detail.cshtml"
                                                    Write(Model.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </li>\r\n                            <li>\r\n                                <span>Muddet : </span>\r\n                                <div class=\"list-detail\">");
#nullable restore
#line 63 "C:\Users\Rovshan Jafarli\Desktop\CinemaApp\CinemaApp.UI\Views\Movie\Detail.cshtml"
                                                    Write(Model.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" deqiqe</div>\r\n                            </li>\r\n                            <li>\r\n                                <span>Yas heddi : </span>\r\n                                <div class=\"list-detail\">");
#nullable restore
#line 67 "C:\Users\Rovshan Jafarli\Desktop\CinemaApp\CinemaApp.UI\Views\Movie\Detail.cshtml"
                                                    Write(Model.AgeLimit);

#line default
#line hidden
#nullable disable
            WriteLiteral(" +</div>\r\n                            </li>\r\n                        </ul>\r\n\r\n                        <p>\r\n                            ");
#nullable restore
#line 72 "C:\Users\Rovshan Jafarli\Desktop\CinemaApp\CinemaApp.UI\Views\Movie\Detail.cshtml"
                       Write(Model.AboutContent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </p>

                    </div>

                </div>
            </div>
        </div>
    </section>


    <!-- tab start -->
    <!--<section id=""tabs"">
        <div class=""tab_header"">
            <a href=""#Session"" class=""active btn"" id=""session"" rel=""session"">Seanslar</a>

        </div>

        <div class=""tab_body"">

            <div class=""session_list tab_list"">

                <div class=""container"">

                    <div class=""filter_blocks"">


                        <div class=""filter_block"">

                            <select class=""form-control selected"" id=""exampleFormControlSelect1"">
                                <option>03.03.2022</option>
                                <option>04.03.2022</option>
                                <option>05.03.2022</option>
                                <option>06.03.2022</option>
                                <option>07.03.2022</option>
                            </select>
    ");
            WriteLiteral(@"                    </div>

                        <div class=""filter_block"">
                            <select class=""form-control selected"" id=""exampleFormControlSelect1"">
                                <option>Kinoteatrlar</option>
                                <option>Kinoteatrlar</option>
                                <option>28 Mall</option>
                                <option>Ganjlik Mall</option>
                                <option>Deniz Mall</option>
                                <option>Azerbaijan Cinema</option>
                                <option>Amburan Mall</option>
                                <option>Sumqayıt</option>
                                <option>Khamsa Park (Ganja)</option>
                                <option>Ganja Mall (Ganja)</option>
                                <option>Şamaxı</option>
                            </select>
                        </div>

                        <div class=""filter_block"">
                        ");
            WriteLiteral(@"    <select class=""form-control selected"" id=""exampleFormControlSelect1"">
                                <option>Filmin dili</option>
                                <option>Bütün dillərdə</option>
                                <option>Azərbaycanca</option>
                                <option>Ha pyccкoм</option>
                                <option>In English</option>
                                <option>Türkçe</option>
                            </select>
                        </div>
                    </div>

                    <div class=""table-responsive"">
                        <table class=""table table-hover table-dark"">
                            <thead>
                                <tr>
                                    <th scope=""col"">Film</th>
                                    <th scope=""col"">Seans</th>
                                    <th scope=""col"">Kinoteatr</th>
                                    <th scope=""col"">Zal</th>
                         ");
            WriteLiteral(@"           <th scope=""col"">Format</th>
                                    <th scope=""col"">Qiymet</th>
                                    <th scope=""col"">Almaq</th>


                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <th>");
#nullable restore
#line 155 "C:\Users\Rovshan Jafarli\Desktop\CinemaApp\CinemaApp.UI\Views\Movie\Detail.cshtml"
                                   Write(Model.MovieName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                                    <td>17 : 00</td>
                                    <td>Ganjlik Mall</td>
                                    <td>Zal1</td>
                                    <td>
                                        <img style=""width:55px;height: 50px;"" src=""./assets/image/ni_tur.png"" alt="""">
                                        <img style=""width:55px;height: 50px;"" src=""./assets/image/ni_twod.png"" alt="""">
                                    </td>
                                    <td>8.00 AZN</td>
                                    <td>bos</td>

                                </tr>

                                <tr>
                                    <th>SpiderMan</th>
                                    <td>17 : 00</td>
                                    <td>
                                        <a class=""table_link"" href=""./cinema.html"">Ganjlik Mall</a>
                                    </td>
                                    <td>Zal1</t");
            WriteLiteral(@"d>
                                    <td>
                                        <img style=""width:55px;height: 50px;"" src=""./assets/image/ni_tur.png"" alt="""">
                                        <img style=""width:55px;height: 50px;"" src=""./assets/image/ni_twod.png"" alt="""">
                                    </td>
                                    <td>8.00 AZN</td>
                                    <td>bos</td>

                                </tr>

                                <tr>
                                    <th>SpiderMan</th>
                                    <td>17 : 00</td>
                                    <td>
                                        <a class=""table_link"" href=""./cinema.html"">Ganjlik Mall</a>
                                    </td>
                                    <td>Zal1</td>
                                    <td>
                                        <img style=""width:55px;height: 50px;"" src=""./assets/image/ni_tur.png"" alt="""">
  ");
            WriteLiteral(@"                                      <img style=""width:55px;height: 50px;"" src=""./assets/image/ni_twod.png"" alt="""">
                                    </td>
                                    <td>8.00 AZN</td>
                                    <td>bos</td>

                                </tr>

                                <tr>
                                    <th>SpiderMan</th>
                                    <td>17 : 00</td>
                                    <td>
                                        <a class=""table_link"" href=""./cinema.html"">Ganjlik Mall</a>
                                    </td>
                                    <td>Zal1</td>
                                    <td>
                                        <img style=""width:55px;height: 50px;"" src=""./assets/image/ni_tur.png"" alt="""">
                                        <img style=""width:55px;height: 50px;"" src=""./assets/image/ni_twod.png"" alt="""">
                                    </td>
      ");
            WriteLiteral(@"                              <td>8.00 AZN</td>
                                    <td>bos</td>

                                </tr>

                                <tr>
                                    <th>SpiderMan</th>
                                    <td>17 : 00</td>
                                    <td>
                                        <a class=""table_link"" href=""./cinema.html"">Ganjlik Mall</a>
                                    </td>
                                    <td>Zal1</td>
                                    <td>
                                        <img style=""width:55px;height: 50px;"" src=""./assets/image/ni_tur.png"" alt="""">
                                        <img style=""width:55px;height: 50px;"" src=""./assets/image/ni_twod.png"" alt="""">
                                    </td>
                                    <td>8.00 AZN</td>
                                    <td>bos</td>

                                </tr>

                         ");
            WriteLiteral(@"   </tbody>
                        </table>
                    </div>

                </div>

            </div>

        </div>
    </section>-->
    <!-- tab end -->

    <!-- movie comment start -->
    <section id=""movie_comment"">
        <div class=""container"">
            <h3 style=""color: #fff;"" class=""section_title mb-5"">
                Comments
            </h3>

            <div class=""row"">
                <div class=""col-lg-8 col-md-12"">
                    <div class=""comments"" data-id=""");
#nullable restore
#line 253 "C:\Users\Rovshan Jafarli\Desktop\CinemaApp\CinemaApp.UI\Views\Movie\Detail.cshtml"
                                              Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <ul id=\"comment__list\" class=\"comments__list\">\r\n");
#nullable restore
#line 255 "C:\Users\Rovshan Jafarli\Desktop\CinemaApp\CinemaApp.UI\Views\Movie\Detail.cshtml"
                             foreach (var comment in Model.Comments)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "40a059a8d5759e144f31cf366f31d09db6d62af721660", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 257 "C:\Users\Rovshan Jafarli\Desktop\CinemaApp\CinemaApp.UI\Views\Movie\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = comment;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 258 "C:\Users\Rovshan Jafarli\Desktop\CinemaApp\CinemaApp.UI\Views\Movie\Detail.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n");
#nullable restore
#line 261 "C:\Users\Rovshan Jafarli\Desktop\CinemaApp\CinemaApp.UI\Views\Movie\Detail.cshtml"
                         if (User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40a059a8d5759e144f31cf366f31d09db6d62af723805", async() => {
                WriteLiteral("\r\n                                <textarea id=\"text\" class=\"form__textarea\" placeholder=\"Add comment\"></textarea>\r\n                                <button type=\"submit\" class=\"form__btn comment__btn\">Send</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 267 "C:\Users\Rovshan Jafarli\Desktop\CinemaApp\CinemaApp.UI\Views\Movie\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        \r\n    </section>\r\n    <!-- movie comment end -->\r\n\r\n\r\n</main>\r\n<!-- Main end -->\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
