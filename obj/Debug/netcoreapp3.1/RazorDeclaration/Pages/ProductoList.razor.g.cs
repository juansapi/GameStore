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
#line 11 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\ProductoList.razor"
using WebApplication1.Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\ProductoList.razor"
using WebApplication1.Data.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\ProductoList.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ProductoAdd")]
    public partial class ProductoList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "C:\Users\zeusi\Downloads\WebApplication1\WebApplication1\Pages\ProductoList.razor"
        Productos producto = new Productos();
    IFileListEntry file;

    public string UserName = null;

    protected async Task ProductoInsert()
    {

        await ProductoService.ProductoInsert(producto);

        NavigationManager.NavigateTo("/");
    }

    public bool verificarTipoImagen(string extension)
    {
        string[] typeImages = { ".png", ".jpg", ".jpeg", ".gif" };

        return typeImages.Contains(extension);
    }

    void Cancel()
    {
        NavigationManager.NavigateTo("/");
    }

    async Task SeleccionarArchivo(IFileListEntry[] files)
    {
        file = files.FirstOrDefault();
        if (file != null && verificarTipoImagen(Path.GetExtension(file.Name)))
        {
            producto.Imgn_Prod = "/UploadImage/" + file.Name;
            await fileUpload.UploadAsync(file);
        }
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload fileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductoService ProductoService { get; set; }
    }
}
#pragma warning restore 1591
