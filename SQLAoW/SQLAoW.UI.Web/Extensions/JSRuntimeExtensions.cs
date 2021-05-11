using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQLAoW.UI.Web.Extensions
{
    public static class JSRuntimeExtensions
    {
        public static ValueTask<bool> Confirm(this IJSRuntime jsRuntime, string message)
        {
            return jsRuntime.InvokeAsync<bool>("confirm", message);
        }

        public static async Task Alert(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("alert", message);
        }
    }
}
