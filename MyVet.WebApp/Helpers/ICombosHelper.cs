using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyVet.Web.Models;

namespace MyVet.WebApp.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboPetTypes();
        Task ToPetAsync(PetViewModel model, string path);
    }
}