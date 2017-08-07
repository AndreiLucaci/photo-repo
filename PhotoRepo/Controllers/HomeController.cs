using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PhotoRepo.Models;

namespace PhotoRepo.Controllers
{
	public class HomeController : Controller
    {
	    private readonly IOptions<FoldersConfigurationModel> _foldersModel;

	    public HomeController(IOptions<FoldersConfigurationModel> foldersModel)
	    {
		    _foldersModel = foldersModel;
	    }

        public IActionResult Index()
        {
            return View(_foldersModel.Value);
        }
    }
}