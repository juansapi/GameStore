// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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