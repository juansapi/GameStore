#pragma checksum "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db441dcc9b2850fc5e48bec9f1b83d32d927fd29"
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
#line 3 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
using WebApplication1.Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
using WebApplication1.Data.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/store")]
    public partial class Tienda : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<head>\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0\">\r\n    <link rel=\"stylesheet\" href=\"https://use.fontawesome.com/releases/v5.6.1/css/all.css\" integrity=\"sha384-gfdkjb5BdAXd+lj+gudLWI+BXq4IuLW5IT+brZEZsLFm++aCMlF1V92rMkPaX4PP\" crossorigin=\"anonymous\">\r\n    <style>\r\n        :root {\r\n            --color-inactivo: #5f5050;\r\n            --color-hover: #ffa400;\r\n        }\r\n\r\n        .valoracion {\r\n            display: flex;\r\n            flex-direction: row-reverse;\r\n        }\r\n\r\n            .valoracion button {\r\n                background-color: initial;\r\n                border: 0;\r\n                color: var(--color-inactivo);\r\n                transition: 1s all;\r\n            }\r\n\r\n                .valoracion button:hover {\r\n                    cursor: pointer;\r\n                    color: var(--color-hover);\r\n                    transform: rotate(360deg);\r\n                }\r\n\r\n        button:nth-child(1):hover ~ button {\r\n            color: var(--color-hover);\r\n            transform: rotate(360deg);\r\n        }\r\n\r\n        button:nth-child(2):hover ~ button {\r\n            color: var(--color-hover);\r\n            transform: rotate(360deg);\r\n        }\r\n\r\n        button:nth-child(3):hover ~ button {\r\n            color: var(--color-hover);\r\n            transform: rotate(360deg);\r\n        }\r\n\r\n        button:nth-child(4):hover ~ button {\r\n            color: var(--color-hover);\r\n            transform: rotate(360deg);\r\n        }\r\n\r\n        button:nth-child(5):hover ~ button {\r\n            color: var(--color-hover);\r\n            transform: rotate(360deg);\r\n        }\r\n    </style>\r\n</head>\r\n\r\n\r\n\r\n\r\n");
            __builder.OpenElement(1, "tbody");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.OpenElement(3, "p");
            __builder.AddContent(4, "usuario autenticado ");
            __builder.AddContent(5, 
#nullable restore
#line 80 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
                            codeusuario

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "input-group");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "text");
            __builder.AddAttribute(12, "id", "busqueda");
            __builder.AddAttribute(13, "placeholder", "Buscar Producto");
            __builder.AddAttribute(14, "class", "form-control");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 83 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
                                                busqueda

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => busqueda = __value, busqueda));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "span");
            __builder.AddMarkupContent(19, "\r\n\r\n            ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "type", "submit");
            __builder.AddAttribute(22, "class", "btn btn-default btn-info my-auto p-2");
            __builder.AddAttribute(23, "value", "Buscar");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 86 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
                                                                                                        () => Buscar(busqueda)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(25, "\r\n                <i class=\"fas fa-search\"></i>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n    ");
            __builder.OpenElement(29, "select");
            __builder.AddAttribute(30, "class", "selectpicker");
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 93 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
                                            SeleccionarGenero

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "optgroup");
            __builder.AddAttribute(34, "label", "Genero");
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.OpenElement(36, "option");
            __builder.AddContent(37, "Ninguno");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.OpenElement(39, "option");
            __builder.AddAttribute(40, "value", "Accion");
            __builder.AddContent(41, "Accion");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "option");
            __builder.AddAttribute(44, "value", "Terror");
            __builder.AddContent(45, "Terror");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.OpenElement(47, "option");
            __builder.AddAttribute(48, "value", "Aventura");
            __builder.AddContent(49, "Aventura");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.OpenElement(51, "option");
            __builder.AddAttribute(52, "value", "Plataformas");
            __builder.AddContent(53, "Plataformas");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n            ");
            __builder.OpenElement(55, "option");
            __builder.AddAttribute(56, "value", "Supervivencia");
            __builder.AddContent(57, "Supervivencia");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n\r\n    ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "Fondo_Principal");
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "Fondo_Principal");
            __builder.AddMarkupContent(66, "\r\n\r\n            ");
            __builder.AddMarkupContent(67, "<div class=\"Fondo_Primario\">\r\n\r\n                \r\n                <h1 class=\"Destacados\">Productos</h1>\r\n\r\n            </div>\r\n\r\n            ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "Fondo_Secundario");
            __builder.AddMarkupContent(70, "\r\n\r\n\r\n");
#nullable restore
#line 117 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
                 if (productos != null)
                {

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
                     foreach (var producto in productos)
                    {

                        if (producto.Descuent_Prod == 0)
                        {
                            //flex row-flex column//

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(71, "                            \r\n");
            __builder.AddContent(72, "                            ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "tarjeta_portada");
            __builder.AddMarkupContent(75, "\r\n                                \r\n                                ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "title_portada");
            __builder.AddMarkupContent(78, "\r\n                                    ");
            __builder.AddContent(79, 
#nullable restore
#line 131 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
                                     producto.Name_Prod

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(80, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                                \r\n                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(82);
            __builder.AddAttribute(83, "class", "");
            __builder.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 134 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
                                                            ()=> SeleccionarProducto(producto.Codi_Prod)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(86, "\r\n                                    ");
                __builder2.OpenElement(87, "div");
                __builder2.AddMarkupContent(88, "\r\n                                        ");
                __builder2.OpenElement(89, "img");
                __builder2.AddAttribute(90, "class", "img_portada");
                __builder2.AddAttribute(91, "src", 
#nullable restore
#line 136 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
                                                                       producto.Imgn_Prod

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(94, "\r\n                                \r\n                                ");
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "class", "score_portada");
            __builder.AddMarkupContent(97, "\r\n\r\n                                    ");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "valoracion");
            __builder.AddMarkupContent(100, "\r\n\r\n                                        ");
            __builder.OpenElement(101, "button");
            __builder.AddAttribute(102, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 144 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
                                                          ()=> Calificacion(5, producto.Codi_Prod)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(103, " <i class=\"fas fa-star\"></i> ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                                        ");
            __builder.OpenElement(105, "button");
            __builder.AddAttribute(106, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 145 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
                                                          ()=> Calificacion(4, producto.Codi_Prod)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(107, " <i class=\"fas fa-star\"></i> ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                                        ");
            __builder.OpenElement(109, "button");
            __builder.AddAttribute(110, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 146 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
                                                          ()=> Calificacion(3, producto.Codi_Prod)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(111, " <i class=\"fas fa-star\"></i> ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n                                        ");
            __builder.OpenElement(113, "button");
            __builder.AddAttribute(114, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 147 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
                                                          ()=> Calificacion(2, producto.Codi_Prod)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(115, " <i class=\"fas fa-star\"></i> ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n                                        ");
            __builder.OpenElement(117, "button");
            __builder.AddAttribute(118, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 148 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
                                                          ()=> Calificacion(1, producto.Codi_Prod)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(119, " <i class=\"fas fa-star\"></i> ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n\r\n                                ");
            __builder.OpenElement(123, "div");
            __builder.AddAttribute(124, "class", "precio_portada");
            __builder.AddMarkupContent(125, "\r\n                                    ");
            __builder.OpenElement(126, "p");
            __builder.AddContent(127, "Genero:");
            __builder.AddContent(128, 
#nullable restore
#line 154 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
                                               producto.Genero

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n                                \r\n                                ");
            __builder.OpenElement(131, "div");
            __builder.AddAttribute(132, "class", "precio_portada");
            __builder.AddMarkupContent(133, "\r\n                                    ");
            __builder.OpenElement(134, "p");
            __builder.AddContent(135, "COP: $");
            __builder.AddContent(136, 
#nullable restore
#line 158 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
                                              producto.Pric_Prod

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n");
#nullable restore
#line 161 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"

                        }

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 164 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
                     
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(140, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n    <br>\r\n    <br>\r\n    ");
            __builder.OpenElement(144, "div");
            __builder.AddAttribute(145, "class", "Fondo_Principal");
            __builder.AddMarkupContent(146, "\r\n        ");
            __builder.OpenElement(147, "div");
            __builder.AddAttribute(148, "class", "Fondo_Principal");
            __builder.AddMarkupContent(149, "\r\n\r\n            ");
            __builder.AddMarkupContent(150, "<div class=\"Fondo_Primario\">\r\n\r\n                \r\n                <h1 class=\"Destacados\">Descuentos</h1>\r\n\r\n            </div>\r\n            ");
            __builder.OpenElement(151, "div");
            __builder.AddAttribute(152, "class", "Fondo_Secundario");
            __builder.AddMarkupContent(153, "\r\n\r\n\r\n");
#nullable restore
#line 184 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
                 if (productos != null)
                {
                    foreach (var producto in productos)
                    {

                        if (producto.Descuent_Prod != 0)
                        {


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(154, "                            \r\n");
            __builder.AddContent(155, "                            ");
            __builder.OpenElement(156, "div");
            __builder.AddAttribute(157, "class", "tarjeta_portada");
            __builder.AddMarkupContent(158, "\r\n                                \r\n                                ");
            __builder.OpenElement(159, "div");
            __builder.AddAttribute(160, "class", "title_portada");
            __builder.AddMarkupContent(161, "\r\n                                    ");
            __builder.AddContent(162, 
#nullable restore
#line 197 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
                                     producto.Name_Prod

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(163, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(164, "\r\n                                \r\n                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(165);
            __builder.AddAttribute(166, "class", "");
            __builder.AddAttribute(167, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 200 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
                                                            ()=> SeleccionarProducto(producto.Codi_Prod)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(168, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(169, "\r\n                                    ");
                __builder2.OpenElement(170, "div");
                __builder2.AddMarkupContent(171, "\r\n                                        ");
                __builder2.OpenElement(172, "img");
                __builder2.AddAttribute(173, "class", "img_portada");
                __builder2.AddAttribute(174, "src", 
#nullable restore
#line 202 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
                                                                       producto.Imgn_Prod

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(175, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(176, "\r\n                                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(177, "\r\n                                \r\n                                ");
            __builder.OpenElement(178, "div");
            __builder.AddAttribute(179, "class", "score_portada");
            __builder.AddMarkupContent(180, "\r\n\r\n                                    ");
            __builder.OpenElement(181, "div");
            __builder.AddAttribute(182, "class", "valoracion");
            __builder.AddMarkupContent(183, "\r\n\r\n                                        ");
            __builder.OpenElement(184, "button");
            __builder.AddAttribute(185, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 210 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
                                                          ()=> Calificacion(5, producto.Codi_Prod)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(186, " <i class=\"fas fa-star\"></i> ");
            __builder.CloseElement();
            __builder.AddMarkupContent(187, "\r\n                                        ");
            __builder.OpenElement(188, "button");
            __builder.AddAttribute(189, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 211 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
                                                          ()=> Calificacion(4, producto.Codi_Prod)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(190, " <i class=\"fas fa-star\"></i> ");
            __builder.CloseElement();
            __builder.AddMarkupContent(191, "\r\n                                        ");
            __builder.OpenElement(192, "button");
            __builder.AddAttribute(193, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 212 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
                                                          ()=> Calificacion(3, producto.Codi_Prod)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(194, " <i class=\"fas fa-star\"></i> ");
            __builder.CloseElement();
            __builder.AddMarkupContent(195, "\r\n                                        ");
            __builder.OpenElement(196, "button");
            __builder.AddAttribute(197, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 213 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
                                                          ()=> Calificacion(2, producto.Codi_Prod)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(198, " <i class=\"fas fa-star\"></i> ");
            __builder.CloseElement();
            __builder.AddMarkupContent(199, "\r\n                                        ");
            __builder.OpenElement(200, "button");
            __builder.AddAttribute(201, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 214 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
                                                          ()=> Calificacion(1, producto.Codi_Prod)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(202, " <i class=\"fas fa-star\"></i> ");
            __builder.CloseElement();
            __builder.AddMarkupContent(203, "\r\n\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(204, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(205, "\r\n                                ");
            __builder.OpenElement(206, "div");
            __builder.AddAttribute(207, "class", "precio_portada");
            __builder.AddMarkupContent(208, "\r\n                                    ");
            __builder.OpenElement(209, "p");
            __builder.AddContent(210, "Genero:");
            __builder.AddContent(211, 
#nullable restore
#line 219 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
                                               producto.Genero

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(212, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(213, "\r\n                                \r\n                                ");
            __builder.OpenElement(214, "div");
            __builder.AddAttribute(215, "class", "precio_portada");
            __builder.AddMarkupContent(216, "\r\n                                    ");
            __builder.OpenElement(217, "p");
            __builder.AddContent(218, "AHORA COP: $");
            __builder.AddContent(219, 
#nullable restore
#line 223 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
                                                    producto.Descuent_Prod

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(220, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(221, "\r\n                                ");
            __builder.OpenElement(222, "div");
            __builder.AddAttribute(223, "class", "precio_portada");
            __builder.AddMarkupContent(224, "\r\n                                    ");
            __builder.OpenElement(225, "p");
            __builder.AddContent(226, "ANTES COP: $");
            __builder.AddContent(227, 
#nullable restore
#line 226 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
                                                    producto.Pric_Prod

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(228, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(229, "\r\n\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(230, "\r\n");
#nullable restore
#line 230 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"

                        }



                    }
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(231, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(232, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(233, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(234, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 243 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\Tienda.razor"
       

    IEnumerable<Productos> productos;
    IEnumerable<Productos> filtros;
    Puntuaciones puntuacion = null;

    // [Parameter]
    //public string busqueda { get; set; }
    public string busqueda = "";
    public int Opcion;
    public string codeusuario = "";

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    private string _authMessage;

    private async Task LogUsername()
    {
        var authState = await authenticationStateTask;
        var user = authState.User;

        if (user.Identity.IsAuthenticated)
        {
            _authMessage = $"{user.Identity.Name} is authenticated.";
        }
        else
        {
            _authMessage = "The user is NOT authenticated.";
        }
    }


    protected override async Task OnInitializedAsync()
    {
        //tiendas = await TiendaService.GetTiendas("Zoom", "");|


        if (busqueda == "")
        {
            productos = await ProductoService.GetAllProductos();
        }
        else
        {
            await Buscar(busqueda);
        }

        if (httpContextAccessor.HttpContext.User.Identity.Name != null)
        {
            codeusuario = httpContextAccessor.HttpContext.User.Identity.Name;
        }
        else
        {
            codeusuario = "";
        }
    }

    protected async Task Buscar(string busqueda)
    {

        productos = await ProductoService.Search(busqueda);
        //await JSRuntime.InvokeAsync<bool>


    }

    async Task SeleccionarGenero(ChangeEventArgs args)
    {

        productos = await ProductoService.FiltroAventuraGenero(Convert.ToString(args.Value));

    }

    public void SeleccionarProducto(int id)
    {
        NavigationManager.NavigateTo("/Compra/" + id, true);
    }

    public async Task Calificacion(int cal, int codprod)
    {
        Usuario usuario = new Usuario();
        usuario = await UsuarioService.UsuarioSelect(codeusuario);
        puntuacion = new Puntuaciones();
        puntuacion.Codi_ProdProductos = codprod;
        puntuacion.Scor_Punt = cal;
        puntuacion.Codi_UserUsuarios = usuario.Id;
        await PuntuacionesService.PuntuacionesInsert(puntuacion);

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionCarrito { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUsuarioService UsuarioService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPuntuacionesService PuntuacionesService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductoService ProductoService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591