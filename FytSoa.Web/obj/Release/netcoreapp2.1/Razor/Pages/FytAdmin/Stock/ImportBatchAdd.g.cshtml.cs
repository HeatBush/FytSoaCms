#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\ImportBatchAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f8e9e337d3668b977466ff8244b62d285fc58dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Stock.Pages_FytAdmin_Stock_ImportBatchAdd), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Stock/ImportBatchAdd.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Stock/ImportBatchAdd.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Stock.Pages_FytAdmin_Stock_ImportBatchAdd), null)]
namespace FytSoa.Web.Pages.FytAdmin.Stock
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f8e9e337d3668b977466ff8244b62d285fc58dd", @"/Pages/FytAdmin/Stock/ImportBatchAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Stock_ImportBatchAdd : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("from-app"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/js/modules/vue.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\ImportBatchAdd.cshtml"
  
    ViewData["Title"] = "批量添加入库";
    Layout = "~/Pages/FytAdmin/_Layout.cshtml";

#line default
#line hidden
            BeginContext(158, 236, true);
            WriteLiteral("<style>\r\n    .layui-btn .layui-icon {\r\n        vertical-align: middle;\r\n        top: -2px;\r\n        position: relative;\r\n    }\r\n</style>\r\n<div id=\"app\">\r\n    <div class=\"layui-form list-search\" style=\"margin:0px 12px 0 12px;\">\r\n        ");
            EndContext();
            BeginContext(394, 744, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c25e3eecfc7445e8f028401893f8138", async() => {
                BeginContext(443, 583, true);
                WriteLiteral(@"
            <div class=""layui-inline"">
                <input class=""layui-input"" id=""GoodsSku"" name=""GoodsSku"" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" placeholder=""条形码"">
            </div>
            <div class=""layui-inline"">
                <input class=""layui-input"" id=""GoodsSum"" name=""GoodsSum"" value=""1"" autocomplete=""off"" placeholder=""数量"">
            </div>
            <div class=""layui-inline"">
                <button class=""layui-btn"" lay-submit="""" lay-filter=""submit"">添加商品</button>
                <button type=""button"" class=""layui-btn"" ");
                EndContext();
                BeginContext(1027, 104, true);
                WriteLiteral("@click=\"btnOkSubmit\" style=\"margin-left:100px;\" v-html=\"btnHtml\"></button>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1138, 984, true);
            WriteLiteral(@"
    </div>
    <div class=""layui-row"">
        <div class=""layui-col-xs12 layui-col-sm12 layui-col-md12"">
            <div class=""list-wall"" style=""padding-top:0px; padding-right:6px;"">
                <table class=""layui-table fyt-table"">
                    <thead>
                        <tr>
                            <th width=""40""><span>序号</span></th>
                            <th><span>条形码</span></th>
                            <th width=""100""><span>数量</span></th>
                            <th width=""60""><span>操作</span></th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr v-for=""it,index in tabList"">
                            <td align=""center"">{{index+1}}</td>
                            <td>{{it.GoodsSku}}</td>
                            <td><input type=""number"" v-model=""it.GoodsSum"" class=""layui-input"" style=""height:26px;"" /></td>
                            <td><i ");
            EndContext();
            BeginContext(2123, 247, true);
            WriteLiteral("@click=\"delTableRow(index)\" class=\"layui-icon layui-icon-close\" style=\"cursor:pointer\"></i></td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(2370, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76b46fefbbf242dead36467c00064cb5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2443, 302, true);
            WriteLiteral(@"
<script>
    var cusFun,vm = new Vue({
        el: '#app',
        data: {
            tabList: [
                 //{ 'Code': 'abc','summary':'', 'Count': '1' }
            ],
            btnHtml: '<i class=""layui-icon layui-icon-ok""></i> 提交入库信息',
            parm: {
                guid:'");
            EndContext();
            BeginContext(2746, 25, false);
#line 67 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\ImportBatchAdd.cshtml"
                 Write(Model.InoutModel.PackGuid);

#line default
#line hidden
            EndContext();
            BeginContext(2771, 32, true);
            WriteLiteral("\',\r\n                adminGuid: \'");
            EndContext();
            BeginContext(2804, 26, false);
#line 68 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\ImportBatchAdd.cshtml"
                       Write(Model.InoutModel.AdminGuid);

#line default
#line hidden
            EndContext();
            BeginContext(2830, 2656, true);
            WriteLiteral(@"',
                json:''
            }
        },
        methods: {
            delTableRow: function (index) {
                this.tabList.splice(index,1);
            },
            btnOkSubmit: function () {
                cusFun.submit();
            }
        }
    });
    layui.config({
        base: '/themes/js/modules/'
    }).use(['table','layer', 'jquery', 'common', 'form'], function () {
        var table = layui.table, form = layui.form, $ = layui.$, os = layui.common, resList;
        var index = parent.layer.getFrameIndex(window.name);
        $(""#GoodsSku"").focus();
        cusFun = {
            submit: function () {
                if (vm.tabList.length === 0) {
                    os.error('请添加入库信息~~~');
                    return;
                }
                vm.parm.json = JSON.stringify(vm.tabList);
                console.log(vm.parm);
                os.ajax('api/stock/batchaddinout', vm.parm, function (res) {
                    if (res.statusCode ");
            WriteLiteral(@"=== 200) {
                        parent.layer.close(index);
                    }
                    else {
                        os.error(res.message);
                    }
                });
            }
        };

        //对比提交
        form.on('submit(submit)', function (data) {
            var digIndex = layer.load(1, {
                shade: [0.1, '#fff']
            });
            os.ajax('api/goods/getsku', { code: data.field.GoodsSku }, function (res) {
                layer.close(digIndex);
                if (res.statusCode === 200) {
                    if (!res.data.guid) {
                        $(""#GoodsSku"").val('');
                        $(""#GoodsSku"").focus();
                        os.error('没有找到该商品~'); return;
                    }
                    var isEx = false;
                    for (var i = 0; i < vm.tabList.length; i++) {
                        if (vm.tabList[i].GoodsGuid === res.data.guid) {
                            isEx = true;
   ");
            WriteLiteral(@"                         vm.tabList[i].GoodsSum = parseInt(vm.tabList[i].GoodsSum) + parseInt($(""#GoodsSum"").val());
                        }
                    }
                    if (!isEx) {
                        vm.tabList.push({ GoodsSku: data.field.GoodsSku, 'GoodsGuid': res.data.guid, 'GoodsSum': data.field.GoodsSum });
                    }
                } else {
                    os.error('没有找到该商品信息！');
                }

            });
            $(""#GoodsSku"").val('');
            $(""#GoodsSku"").focus();
            return false;
        });
    });
</script>

");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Stock.ImportBatchAddModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Stock.ImportBatchAddModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Stock.ImportBatchAddModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Stock.ImportBatchAddModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
