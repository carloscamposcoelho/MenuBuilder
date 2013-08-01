using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcAppMenu.Models;
using System.Text;

namespace MvcAppMenu.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            StringBuilder sbMenu = new StringBuilder();

            List<Menu> menuLista = PesquisarDadosMenu();

            //if (menuLista != null && menuLista.Count > 0)
            //    {
            //        foreach (var menuItem in menuLista)
            //        {
            //            if (ChecarRoot(menuItem))
            //            {
            //                CriarMenu(sbMenu, CriarItem(menuItem), null, menuLista);
            //            }
            //        }
            //    }

            return View(menuLista);
        }

        private List<Menu> PesquisarDadosMenu()
        {
            List<Menu> menuLista = new List<Menu>();
            
            menuLista.Add(new Menu(1, "Dicas do Sr. Coelho", string.Empty, 0));
            menuLista.Add(new Menu(2, "Dica1", "srcoelho.com.br/2013/01/11/dica-para-obter-desconto-na-compra-online", 1));
            menuLista.Add(new Menu(3, "Dica2", "srcoelho.com.br/2012/12/23/imagens-no-gmail", 1));
            menuLista.Add(new Menu(4, "Dica3", "srcoelho.com.br/2012/08/26/dicas-transito", 1));
            menuLista.Add(new Menu(5, "Dica4", "srcoelho.com.br/2011/09/10/teste-de-velocidade-de-internet", 1));

            menuLista.Add(new Menu(6, "Artigos do Sr. Coelho", string.Empty, 0));
            menuLista.Add(new Menu(7, "Artigo 1", string.Empty, 6));
            menuLista.Add(new Menu(8, "Artigo 1.1", string.Empty, 7));
            menuLista.Add(new Menu(9, "Artigo 1.1.1", string.Empty, 8));
            menuLista.Add(new Menu(10, "Artigo 1.1.2", string.Empty, 8));
            
            menuLista.Add(new Menu(11, "Artigo 2", string.Empty, 6));
            menuLista.Add(new Menu(12, "Artigo 2.1", string.Empty, 11));
            menuLista.Add(new Menu(13, "Artigo 2.2", string.Empty, 11));
            menuLista.Add(new Menu(14, "Artigo 2.3", string.Empty, 11));
            menuLista.Add(new Menu(15, "Artigo 2.3.1", string.Empty, 14));
            
            return menuLista;
        }

    }
}
