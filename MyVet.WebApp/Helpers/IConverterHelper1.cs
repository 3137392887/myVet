using System.Threading.Tasks;
using MyVet.Web.Data.Entities;
using MyVet.Web.Models;

namespace MyVet.WebApp.Helpers
{
    public interface IConverterHelper1
    {
        Task<Pet> ToPetAsync(PetViewModel model, string path);
    }
}