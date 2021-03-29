using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using DotVVM.Framework.Hosting;
using DotVVMRepeater.Model;

namespace DotVVMRepeater.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {
		public List<CityModel> Cities { get; set; } = new List<CityModel>();

		public DefaultViewModel()
		{
			Cities.Add(new CityModel { Id = 1, Name = "Salzburg", Country = "Austria", PhotoLink = "https://www.lavanguardia.com/files/content_image_intermediate_filter/uploads/2019/12/13/5fa53b24e141d.jpeg" });
			Cities.Add(new CityModel { Id = 9, Name = "Dubai", Country = "United Arab Emirates", PhotoLink = "https://www.lavanguardia.com/files/content_image_intermediate_filter/uploads/2019/12/13/5fa52ffb6f83e.jpeg" });
			Cities.Add(new CityModel { Id = 4, Name = "Vancouver", Country = "Canada", PhotoLink = "https://www.lavanguardia.com/files/content_image_intermediate_filter/uploads/2019/12/13/5fa53b8a8af9c.jpeg" });
			Cities.Add(new CityModel { Id = 5, Name = "La Paz", Country = "Bolivia", PhotoLink = "https://www.lavanguardia.com/files/content_image_intermediate_filter/uploads/2019/12/13/5fa532a79aed1.jpeg" });
			Cities.Add(new CityModel { Id = 7, Name = "Bonn", Country = "Germany", PhotoLink = "https://www.lavanguardia.com/files/content_image_intermediate_filter/uploads/2019/12/13/5fa581be23079.jpeg" });
			Cities.Add(new CityModel { Id = 10, Name = "Denver", Country = "United States", PhotoLink = "https://www.lavanguardia.com/files/content_image_intermediate_filter/uploads/2019/12/13/5fa53e1180ffb.jpeg" });
			Cities.Add(new CityModel { Id = 8, Name = "Kochi ", Country = "India", PhotoLink = "https://www.lavanguardia.com/files/content_image_intermediate_filter/uploads/2019/12/13/5fa53048c8aa9.jpeg" });
			Cities.Add(new CityModel { Id = 3, Name = "El Cairo", Country = "Egypt", PhotoLink = "https://www.lavanguardia.com/files/content_image_intermediate_filter/uploads/2019/12/13/5fa58199aa226.jpeg" });
			Cities.Add(new CityModel { Id = 2, Name = "Washington", Country = "United States", PhotoLink = "https://www.lavanguardia.com/files/content_image_intermediate_filter/uploads/2019/12/13/5fa5359b83255.jpeg" });
		}
    }
}
