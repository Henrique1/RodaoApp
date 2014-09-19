using Aplicacao2;
using Dominio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RodãoAcessorios.Controllers
{
    public class ProdutosController : Controller
    {
        public ActionResult BuscarPorNome(string nome)
        {
            var appRodao = new RodaoAplicacao();
            var listaDePedidos = appRodao.BuscarPorNome(nome);
            return View(listaDePedidos);

        }
       
        public ActionResult Index()
        {
            var appPedidos = new RodaoAplicacao();
            var listaDePedidos = appPedidos.ListarTodos();
            return View(listaDePedidos);
        }
        public ActionResult Cadastrar()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(Pedidos pedidos)
        {
            if (ModelState.IsValid)
            {
                var appPedidos = new RodaoAplicacao();
                appPedidos.Salvar(pedidos);
                return RedirectToAction("PedidoComSucesso");
            }
                return View(pedidos);
            }
            public ActionResult PedidoComSucesso()
            {
                return View();
            }
        public ActionResult Editar(int id)
        {
            var appPedidos = new RodaoAplicacao();
            var pedidos = appPedidos.ListarPorId(id);

            if (pedidos == null)

                return HttpNotFound();

            return View(pedidos);

        }
        [HttpPost]
        public ActionResult Editar(Pedidos pedidos)
        {
            if (ModelState.IsValid)
            {
                var appPedidos = new RodaoAplicacao();
                appPedidos.Salvar(pedidos);
                return RedirectToAction("Index");
            }
            return View(pedidos);
        }
        public ActionResult Detalhes(int id)
        {
            var appPedidos = new RodaoAplicacao();
            var pedidos = appPedidos.ListarPorId(id);

            if (pedidos == null)

                return HttpNotFound();

            return View(pedidos);
        }
        public ActionResult Excluir(int id)
        {
            var appPedidos = new RodaoAplicacao();
            var pedidos = appPedidos.ListarPorId(id);

            if (pedidos == null)

                return HttpNotFound();

            return View(pedidos);
        }
        [HttpPost, ActionName("Excluir")]
        public ActionResult ExcluirConfirmado(int id)
        {
            var appPedidos = new RodaoAplicacao();
            appPedidos.Excluir(id);
            return RedirectToAction("Index");

        }
      
	}
}