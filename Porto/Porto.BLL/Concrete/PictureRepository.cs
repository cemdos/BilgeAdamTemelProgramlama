using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Porto.BLL.Interfaces;
using Porto.MODEL;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoredProcedureEFCore;
using Porto.MODEL.ViewModel;
using Porto.BLL.Common;

namespace Porto.BLL.Concrete
{
    public class PictureRepository : BaseRepository<Picture>, IPictureRepository
    {
    }
}
