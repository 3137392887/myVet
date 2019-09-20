using Microsoft.AspNetCore.Mvc.Rendering;
using MyVet.Web.Data;
using MyVet.Web.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.WebApp.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _dataContext;

        public CombosHelper(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IEnumerable<SelectListItem> GetComboPetTypes()
        {
            //var list = new List<SelectListItem>();
            //foreach (var petType in _dataContext.PetTypes)
            //{
            //    list.Add(new SelectListItem
            //    {
            //        Text = petType.Name,
            //        Value = $"{petType.Id}"
            //    });
            //}

            var list = _dataContext.PetTypes.Select(pt => new SelectListItem
            {
                Text = pt.Name,
                Value = $"{pt.Id}"
            })
                .OrderBy(pt => pt.Text)
                .ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "[Select a pet type...]",
                Value = "0"
            });

            return list;
        }

        public Task ToPetAsync(PetViewModel model, string path)
        {
            throw new System.NotImplementedException();
        }
    }
}
