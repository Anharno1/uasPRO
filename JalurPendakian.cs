using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemBookingJalurPendakian
{
    public abstract class JalurPendakian
    {
        public abstract string GetInformasiJalur();
    }

    public class GunungMerapi : JalurPendakian
    {
        public override string GetInformasiJalur()
        {
            return "Gunung Merapi - Jalur Selo";
        }
    }
}

