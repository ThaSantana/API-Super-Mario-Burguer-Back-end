using Microsoft.AspNetCore.Mvc;
using WebApplicationSuperMarioBurguer.Data;
using WebApplicationSuperMarioBurguer.Models;


namespace WebApplicationSuperMarioBurguer.Controllers
{
    [Route("/fornecedor")]
    [ApiController]
    public class FornecedorController : Controller
    {
        //Somente para leitura dos dados
        readonly private AppConnection _db;

        public FornecedorController(AppConnection db) 
        {
            _db = db;
        }
        [HttpGet]
        [Route("")]
        public List<FornecedorModel> fornecedor()
        {
            return FornecedorModel.Todos();
        }
        public IActionResult Index()
        {

            return View();
        }

        /*[HttpPost]
        [Route("")]
        public Fornecedor Criar([FromBody] Fornecedor fornecedor)
        {
            return Fornecedor.Salvar();
        }*/
    }
}
