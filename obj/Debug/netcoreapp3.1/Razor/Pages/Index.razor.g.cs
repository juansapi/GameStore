#pragma checksum "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97b2b33d4a6d9127d155c2b1a5e5e0bc6eeda212"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\_Imports.razor"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Index.razor"
using WebApplication1.Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Index.razor"
using WebApplication1.Data.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Index.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Index.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<head>\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0\">\r\n    <link rel=\"stylesheet\" href=\"https://use.fontawesome.com/releases/v5.6.1/css/all.css\" integrity=\"sha384-gfdkjb5BdAXd+lj+gudLWI+BXq4IuLW5IT+brZEZsLFm++aCMlF1V92rMkPaX4PP\" crossorigin=\"anonymous\">\r\n    <style>\r\n        :root {\r\n            --color-inactivo: #5f5050;\r\n            --color-hover: #ffa400;\r\n        }\r\n\r\n        .valoracion {\r\n            display: flex;\r\n            flex-direction: row-reverse;\r\n        }\r\n\r\n            .valoracion button {\r\n                background-color: initial;\r\n                border: 0;\r\n                color: var(--color-inactivo);\r\n                transition: 1s all;\r\n            }\r\n\r\n                .valoracion button:hover {\r\n                    cursor: pointer;\r\n                    color: var(--color-hover);\r\n                    transform: rotate(360deg);\r\n                }\r\n\r\n        button:nth-child(1):hover ~ button {\r\n            color: var(--color-hover);\r\n            transform: rotate(360deg);\r\n        }\r\n\r\n        button:nth-child(2):hover ~ button {\r\n            color: var(--color-hover);\r\n            transform: rotate(360deg);\r\n        }\r\n\r\n        button:nth-child(3):hover ~ button {\r\n            color: var(--color-hover);\r\n            transform: rotate(360deg);\r\n        }\r\n\r\n        button:nth-child(4):hover ~ button {\r\n            color: var(--color-hover);\r\n            transform: rotate(360deg);\r\n        }\r\n\r\n        button:nth-child(5):hover ~ button {\r\n            color: var(--color-hover);\r\n            transform: rotate(360deg);\r\n        }\r\n    </style>\r\n</head>\r\n\r\n\r\n\r\n\r\n");
            __builder.OpenElement(1, "tbody");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "Fondo_Principal");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "Fondo_Principal");
            __builder.AddMarkupContent(8, "\r\n\r\n            ");
            __builder.AddMarkupContent(9, "<div class=\"Fondo_Primario\">\r\n\r\n                \r\n                <h1 class=\"Destacados\">Descuentos</h1>\r\n\r\n            </div>\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "Fondo_Secundario");
            __builder.AddMarkupContent(12, "\r\n\r\n\r\n");
#nullable restore
#line 87 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Index.razor"
                 if (productos != null)
                {
                    foreach (var producto in productos)
                    {

                        if (producto.Descuent_Prod != 0)
                        {


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "                            \r\n");
            __builder.AddContent(14, "                            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "tarjeta_portada");
            __builder.AddMarkupContent(17, "\r\n                                \r\n                                ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "title_portada");
            __builder.AddMarkupContent(20, "\r\n                                    ");
            __builder.AddContent(21, 
#nullable restore
#line 100 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Index.razor"
                                     producto.Name_Prod

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(22, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                                \r\n                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(24);
            __builder.AddAttribute(25, "class", "");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 103 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Index.razor"
                                                            ()=> SeleccionarProducto(producto.Codi_Prod)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(28, "\r\n                                    ");
                __builder2.OpenElement(29, "div");
                __builder2.AddMarkupContent(30, "\r\n                                        ");
                __builder2.OpenElement(31, "img");
                __builder2.AddAttribute(32, "class", "img_portada");
                __builder2.AddAttribute(33, "src", 
#nullable restore
#line 105 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Index.razor"
                                                                       producto.Imgn_Prod

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(36, "\r\n                                \r\n                                ");
            __builder.AddMarkupContent(37, @"<div class=""score_portada"">

                                    <div class=""valoracion"">

                                        <button> <i class=""fas fa-star""></i> </button>
                                        <button> <i class=""fas fa-star""></i> </button>
                                        <button> <i class=""fas fa-star""></i> </button>
                                        <button> <i class=""fas fa-star""></i> </button>
                                        <button> <i class=""fas fa-star""></i> </button>

                                    </div>
                                </div>
                                
                                ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "precio_portada");
            __builder.AddMarkupContent(40, "\r\n                                    ");
            __builder.OpenElement(41, "p");
            __builder.AddContent(42, "AHORA COP: $");
            __builder.AddContent(43, 
#nullable restore
#line 123 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Index.razor"
                                                    producto.Descuent_Prod

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                                ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "precio_portada");
            __builder.AddMarkupContent(48, "\r\n                                    ");
            __builder.OpenElement(49, "p");
            __builder.AddContent(50, "ANTES COP: $");
            __builder.AddContent(51, 
#nullable restore
#line 126 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Index.razor"
                                                    producto.Pric_Prod

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 130 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Index.razor"

                        }



                    }
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 147 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Index.razor"
        IEnumerable<Productos> productos;

    protected override async Task OnInitializedAsync()
    {
        productos = await ProductoService.GetAllProductos();
        //tiendas = await TiendaService.GetTiendas("Zoom", "");
    }

    public void SeleccionarProducto(int id)
    {
        NavigationManager.NavigateTo("/Compra/" + id);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionCarrito { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductoService ProductoService { get; set; }
    }
}
#pragma warning restore 1591
