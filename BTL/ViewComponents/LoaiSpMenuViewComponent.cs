using BTL.Models;
using BTL.Repository;
using Microsoft.AspNetCore.Mvc;
namespace BTL.ViewComponents
{
    public class LoaiSpMenuViewComponent : ViewComponent 
    {
        private readonly ILoaiSpRepository _loaiSp;

        public LoaiSpMenuViewComponent(ILoaiSpRepository loaiSPRepository)
        {
            _loaiSp = loaiSPRepository;
        }

        public IViewComponentResult Invoke() // use pthuc "Invoke"
        {
            var loaisp = _loaiSp.GetAllLoaiSp().OrderBy(x => x.Loai);
            return View(loaisp); // return ds loai sp
        }
    }
}
