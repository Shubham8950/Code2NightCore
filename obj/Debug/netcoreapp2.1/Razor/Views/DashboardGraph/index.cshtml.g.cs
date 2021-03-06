#pragma checksum "F:\Code2NightCore\Code2Night\Code2NightCore\Views\DashboardGraph\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae4e2adc9280697dd75777ae0848b9801513d738"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DashboardGraph_index), @"mvc.1.0.view", @"/Views/DashboardGraph/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DashboardGraph/index.cshtml", typeof(AspNetCore.Views_DashboardGraph_index))]
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
#line 1 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 2 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 5 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\_ViewImports.cshtml"
using Code2Night;

#line default
#line hidden
#line 6 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\_ViewImports.cshtml"
using Code2Night.Models;

#line default
#line hidden
#line 7 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\_ViewImports.cshtml"
using Code2Night.DAL.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae4e2adc9280697dd75777ae0848b9801513d738", @"/Views/DashboardGraph/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d4a46e63756f73e413e4d4164f7aecef7ed145", @"/Views/_ViewImports.cshtml")]
    public class Views_DashboardGraph_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Code2Night.DAL.Common.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ToDo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\DashboardGraph\index.cshtml"
  
    ViewBag.Title = "Dashboard";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(137, 541, true);
            WriteLiteral(@"<style>
    div#textboxbutton #Additemtextbox {
        height: 38px;
        padding: 5px 10px;
        border-radius: 6px;
        border: 1px solid #f4f6f9;
    }
</style>
<section class=""content"">
    <div class=""container-fluid"" style=""width:1060px"">
        <!-- Small boxes (Stat box) -->
        <div class=""row"">
            <div class=""col-lg-3 col-12 col-sm-12"">
                <!-- small box -->
                <div class=""small-box bg-info"">
                    <div class=""inner"">
                        <h3>");
            EndContext();
            BeginContext(679, 30, false);
#line 22 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\DashboardGraph\index.cshtml"
                       Write(Model.DashBoardItem.TotalUsers);

#line default
#line hidden
            EndContext();
            BeginContext(709, 233, true);
            WriteLiteral("</h3>\r\n\r\n                        <p>Total Users</p>\r\n                    </div>\r\n                    <div class=\"icon\">\r\n                        <i class=\"ion ion-person-add\"></i>\r\n\r\n                    </div>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 942, "\'", 978, 1);
#line 30 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\DashboardGraph\index.cshtml"
WriteAttributeValue("", 949, Url.Action("Listing","Blog"), 949, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(979, 365, true);
            WriteLiteral(@" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
                </div>
            </div>
            <!-- ./col -->
            <div class=""col-lg-3 col-12 col-sm-12"">
                <!-- small box -->
                <div class=""small-box bg-success"">
                    <div class=""inner"">
                        <h3>");
            EndContext();
            BeginContext(1345, 30, false);
#line 38 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\DashboardGraph\index.cshtml"
                       Write(Model.DashBoardItem.TotalBlogs);

#line default
#line hidden
            EndContext();
            BeginContext(1375, 230, true);
            WriteLiteral("</h3>\r\n                        <p>Total Blogs</p>\r\n                    </div>\r\n                    <div class=\"icon\">\r\n                        <i class=\"ion ion-clipboard\"></i>\r\n\r\n                    </div>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1605, "\'", 1641, 1);
#line 45 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\DashboardGraph\index.cshtml"
WriteAttributeValue("", 1612, Url.Action("Listing","Blog"), 1612, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1642, 365, true);
            WriteLiteral(@" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
                </div>
            </div>
            <!-- ./col -->
            <div class=""col-lg-3 col-12 col-sm-12"">
                <!-- small box -->
                <div class=""small-box bg-warning"">
                    <div class=""inner"">
                        <h3>");
            EndContext();
            BeginContext(2009, 155, false);
#line 53 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\DashboardGraph\index.cshtml"
                        Write(Model.DashBoardItem.LifeTimeViews>1000? ((decimal)Model.DashBoardItem.LifeTimeViews/1000).ToString("0.0")+"k": Model.DashBoardItem.LifeTimeViews.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(2165, 606, true);
            WriteLiteral(@"</h3>
                        <p>Life Time Views</p>
                    </div>
                    <div class=""icon"">
                        <i class=""ion ion-stats-bars""></i>
                    </div>
                    <a href=""#"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
                </div>
            </div>
            <!-- ./col -->
            <div class=""col-lg-3 col-12 col-sm-12"">
                <!-- small box -->
                <div class=""small-box bg-danger"">
                    <div class=""inner"">
                        <h3>");
            EndContext();
            BeginContext(2773, 152, false);
#line 67 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\DashboardGraph\index.cshtml"
                        Write(Model.DashBoardItem.MonthlyViews>1000? ((decimal)Model.DashBoardItem.MonthlyViews/1000).ToString("0.0")+"k": Model.DashBoardItem.MonthlyViews.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(2926, 1115, true);
            WriteLiteral(@"</h3>
                        <p>This Month</p>
                    </div>
                    <div class=""icon"">
                        <i class=""ion ion-pie-graph""></i>
                    </div>
                    <a href=""#"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
                </div>
            </div>
            <!-- ./col -->
        </div>
        <!-- /.row -->
        <!-- Main row -->
        <div class=""row"">
            <!-- Left col -->
            <section class=""col-lg-7 col-12 col-sm-12 connectedSortable"">
               <div class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">
                            <i class=""ion ion-clipboard mr-1""></i>
                            To Do List
                        </h3>
                    </div>
                    <!-- /.card-header -->
                    <div class=""card-body"">
                        <ul class=""todo-list"" ");
            WriteLiteral("data-widget=\"todo-list\" id=\"Todolist\" style=\"height: 284px;\">\r\n                            ");
            EndContext();
            BeginContext(4041, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ae4e2adc9280697dd75777ae0848b9801513d73810273", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 93 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\DashboardGraph\index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4078, 209, true);
            WriteLiteral("\r\n                        </ul>\r\n                    </div>\r\n                    <!-- /.card-body -->\r\n                    <div class=\"card-footer clearfix\">\r\n                        <div id=\"textboxbutton\">\r\n");
            EndContext();
            BeginContext(4495, 2378, true);
            WriteLiteral(@"                            <button type=""button"" class=""btn btn-info float-right"" onclick=""Additembutton()""><i class=""fas fa-plus""></i>  Add item</button>
                            <input type=""text"" placeholder=""Enter Item"" id=""Additemtextbox"" />
                        </div>
                    </div>
                </div>
                <!-- /.card -->
            </section>
            <!-- /.Left col -->
            <!-- right col (We are only adding the ID to make the widgets sortable)-->
            <section class=""col-lg-5 col-12 col-sm-12 connectedSortable"">

                <!-- Map card -->
                <!-- /.card -->
                <!-- solid sales graph -->
                <div class=""card bg-gradient-info"">
                    <div class=""card-header border-0"">
                        <h3 class=""card-title"">
                            <i class=""fas fa-th mr-1""></i>
                            Weekly Users Visit Chart
                        </h3>

               ");
            WriteLiteral(@"         <div class=""card-tools"">
                            <button type=""button"" class=""btn bg-info btn-sm"" data-card-widget=""collapse"">
                                <i class=""fas fa-minus""></i>
                            </button>
                            <button type=""button"" class=""btn bg-info btn-sm"" data-card-widget=""remove"">
                                <i class=""fas fa-times""></i>
                            </button>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <canvas class=""chart"" id=""line-chart"" style=""min-height: 250px; height: 250px; max-height: 250px; max-width: 100%;""></canvas>
                    </div>
                    <!-- /.card-body -->
                    <div class=""card-footer bg-transparent"">
                        <div class=""row"">

                            <!-- ./col -->
                        </div>
                        <!-- /.row -->
                    </div>");
            WriteLiteral(@"
                    <!-- /.card-footer -->
                </div>
                <!-- /.card -->
                <!-- Calendar -->
                <!-- /.card -->
            </section>
            <!-- right col -->
        </div>
        <!-- /.row (main row) -->
    </div><!-- /.container-fluid -->
</section>

");
            EndContext();
            BeginContext(8131, 388, true);
            WriteLiteral(@"<script>
    function LoadPartialView(url, elem, postData) {
        ShowLoader();
        $.post(url, postData, function (result, status) {
            $(""#"" + elem).html('');
            $(""#"" + elem).html(result);
            HideLoader();

        });

    }
    // Sales graph chart
    debugger;

    var Refresh = function()
        {
             LoadPartialView('");
            EndContext();
            BeginContext(8520, 39, false);
#line 208 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\DashboardGraph\index.cshtml"
                         Write(Url.Action("BindToDo","DashBoardGraph"));

#line default
#line hidden
            EndContext();
            BeginContext(8559, 259, true);
            WriteLiteral(@"', ""Todolist"", {});
        }
    window.onload = function () {
        var salesGraphChartCanvas = $('#line-chart').get(0).getContext('2d')
        // $('#revenue-chart').get(0).getContext('2d');
        var labeldata = [];
        var userdata = [];
");
            EndContext();
#line 215 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\DashboardGraph\index.cshtml"
      foreach( var item in Model.EmployeeDashboardList)
                {

#line default
#line hidden
            BeginContext(8894, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(8916, 16, true);
            WriteLiteral("labeldata.push(\'");
            EndContext();
            BeginContext(8933, 37, false);
#line 217 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\DashboardGraph\index.cshtml"
                                 Write(item.ViewDate.ToString("dd-MMM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(8970, 28, true);
            WriteLiteral("\');\r\n                       ");
            EndContext();
            BeginContext(9000, 15, true);
            WriteLiteral("userdata.push(\'");
            EndContext();
            BeginContext(9016, 14, false);
#line 218 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\DashboardGraph\index.cshtml"
                                   Write(item.TotalView);

#line default
#line hidden
            EndContext();
            BeginContext(9030, 5, true);
            WriteLiteral("\');\r\n");
            EndContext();
#line 219 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\DashboardGraph\index.cshtml"
                }

#line default
#line hidden
            BeginContext(9054, 1988, true);
            WriteLiteral(@"        var salesGraphChartData = {
            labels: labeldata,
            datasets: [
                {
                    label: 'Weekly Traffic Rate',
                    fill: false,
                    borderWidth: 2,
                    lineTension: 0,
                    spanGaps: true,
                    borderColor: '#efefef',
                    pointRadius: 3,
                    pointHoverRadius: 7,
                    pointColor: '#efefef',
                    pointBackgroundColor: '#efefef',
                    data: userdata
                }
            ]
        }

        var salesGraphChartOptions = {
            maintainAspectRatio: false,
            responsive: true,
            legend: {
                display: false
            },
            scales: {
                xAxes: [{
                    ticks: {
                        fontColor: '#efefef'
                    },
                    gridLines: {
                        display: false,
  ");
            WriteLiteral(@"                      color: '#efefef',
                        drawBorder: false
                    }
                }],
                yAxes: [{
                    ticks: {

                        fontColor: '#efefef'
                    },
                    gridLines: {
                        display: true,
                        color: '#efefef',
                        drawBorder: false
                    }
                }]
            }
        }

        // This will get the first returned node in the jQuery collection.
        // eslint-disable-next-line no-unused-vars
        var salesGraphChart = new Chart(salesGraphChartCanvas, {
            type: 'line',
            data: salesGraphChartData,
            options: salesGraphChartOptions
        })
    }

    //Additembutton, DivShow, Additemtextbox

    var Additembutton = function () {
        debugger;
        var promises = GetAjaxDataPromise('");
            EndContext();
            BeginContext(11043, 40, false);
#line 283 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\DashboardGraph\index.cshtml"
                                      Write(Url.Action("Additems", "DashboardGraph"));

#line default
#line hidden
            EndContext();
            BeginContext(11083, 913, true);
            WriteLiteral(@"', { TaskName: $(""#Additemtextbox"").val() });
        promises.done(function (response) {
            console.log(response);
            console.log();
            $(""#Additemtextbox"").val("""");
            if (response.data == 0) {
            }
            else {
                Refresh();
                Swal.fire({
                    position: 'top-end',
                    type: 'success',
                    title: ""Item Inserted Successfully"",
                    showConfirmButton: false,
                    timer: 3000
                });

            }
        }).fail(function (response) {

            console.log(response);
        });
    }

    var SaveUpdateItem = function (elem,ids) {
        debugger;
        console.log($(""#"" + elem).is("":checked""));
        console.log($("".checkboxgetset"").prop(""checked"", true));
        var promises = GetAjaxDataPromise('");
            EndContext();
            BeginContext(11997, 46, false);
#line 311 "F:\Code2NightCore\Code2Night\Code2NightCore\Views\DashboardGraph\index.cshtml"
                                      Write(Url.Action("SaveUpdateItem", "DashboardGraph"));

#line default
#line hidden
            EndContext();
            BeginContext(12043, 639, true);
            WriteLiteral(@"', { IsCompleted: $(""#"" + elem).is("":checked""), Id: ids});
        promises.done(function (response) {
            Refresh();
            debugger;
            if (response.data == 0) {
            }
            //else {
            //    Swal.fire({
            //        position: 'top-end',
            //        type: 'success',
            //        title: ""Item Inserted Successfully"",
            //        showConfirmButton: false,
            //        timer: 3000
            //    });

            //}
        }).fail(function (response) {

            console.log(response);
        });


    }
</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Code2Night.DAL.Common.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
