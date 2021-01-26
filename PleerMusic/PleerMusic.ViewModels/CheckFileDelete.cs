using PleerMusic.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace PleerMusic.ViewModels
{
    public class CheckFileDelete
    {
        public async static Task DeleteAddressesFromDb()
        {
            await Task.Run(() =>
             {
                 using (uowPleerMusic db = new uowPleerMusic())
                 {
                     foreach (var item in db.pMusic.GetAll())
                     {
                         if (!File.Exists(item.MusicAddress))
                         {
                             db.pMusic.Delete(item);
                         }
                     }
                     db.Save();
                 }
             });
        }

    }
}
