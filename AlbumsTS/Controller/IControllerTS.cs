using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlbumsTS.Model;

namespace AlbumsTS.Controller
{
    public interface IControllerTS
    {
        List<TSmodel> GetAlbums();
    }
}
