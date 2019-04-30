using colorcom.DAL;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace colorcom.Controllers.Item
{
    public class ItemController : Controller
    {
        public ItemController()
        {
            _context = new colorcomContext();
        }

        private colorcomContext db = new colorcomContext();

        private colorcomContext _context;

        // GET: Item
        public ActionResult Index()
        {
            var itens = _context.itens
                .Include(i => i.categoria)
                .Include(i => i.unidadeMedida)
                .ToList();
            return View(itens);
        }
    }
}