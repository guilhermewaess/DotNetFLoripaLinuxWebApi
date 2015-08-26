using System.Collections.Generic;
using dotnetfln.Models;
using Microsoft.AspNet.Mvc;
using MiniBiggy;

namespace dotnetfln
{
	[Route("api/[controller]")]
	public class MensagensController : Controller
	{
		public IEnumerable<Mensagem> Get()
        {
            return PersistentList.Create<Mensagem>();
        }
		
		[HttpPost]
        public void Post([FromBody]Mensagem mensagem)
        {
			var list = PersistentList.Create<Mensagem>();
			list.Add(mensagem);
			list.Save();
        }
	}
}