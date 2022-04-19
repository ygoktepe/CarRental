using CarRental.Data;
using CarRental.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class HesapController : Controller
    {
        private readonly CarRentalDBContext _context;
        //dep inj. bunun faydası bizim contextimiz ile databasein contexti üretirlir. ve bundan sonra surekli database değil bizim contextimiz ile iş görür.
        //hız için önemlidir. en genel db contextte kullanılır. en yogun kullanılan oldugu icin. insanları bekletmemek için
        //çok sık kullanılan dosyalarda çok fazla kullanıcı istekte bulunduğu zaman  kullanıcıları sıraya sokmamak adına bekleme sürelerini azaltmak adına kullanılır

        public HesapController(CarRentalDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Giris()
        {
            return View();
        }
        public IActionResult Kayit()
        {
            Userr userr = new Userr(); //html kısmında value ya model verdiğimiz için error vermemesi için boş user döndürdük
            return View(userr);
        }
        [HttpPost]
        [ValidateAntiForgeryToken] //data güvenliği için token
        public async Task< IActionResult> Kayit([Bind("UserID", "Emaill", "Passwordd", "PasswordRepeatt", "FullName", "Surname","MobileNO","RoleeID")] Userr userr)
        {
            userr.RoleeID = 1;
            if (ModelState.IsValid)
            {
                await _context.Userrs.AddAsync(userr); //user classına ekledi //userr girilen kullanıcı
                                                       //memoryde db set türündeki usera ekledik
                await _context.SaveChangesAsync(); //şimdi database e gitti
                                                   //asenkron çalışma verimli olarak tüm çekirdekleri kullanma multijob
                return RedirectToAction("Giris","Hesap");
            }
            return View(userr); //form yeniden döndüğünde içerikler silinmeden gelsin
            //task async işlemciye async görevi veriyor 
            //await bekletmektir
        }
        public IActionResult SifreSifirla()
        {
            return View();
        }
        public IActionResult HukumveKosullar()
        {
            return View();
        }
    }
}
