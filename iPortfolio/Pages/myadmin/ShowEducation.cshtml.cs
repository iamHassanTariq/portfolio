using iPortfolio.Data;
using iPortfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Principal;

namespace iPortfolio.Pages.myadmin
{
    public class ShowEducationModel : PageModel
    { 
        AppDbContext db;
        public List<Education> education { get; set; }
        public ShowEducationModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            education = db.tbl_Education.ToList();
        }
       public void OnGetDelete(int id) 
        {
            var ItemToDel = db.tbl_Education.Find(id);
            db.tbl_Education.Remove(ItemToDel);
            db.SaveChanges();
            return RedirectToPage("ShowEducation");
        }
    }

}
