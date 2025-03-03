using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> LogicLayerPersonelListesi()
        {
            return DALPersonel.PersonelListesi();
        }

        public static int LogicLayerPersonelEkle(EntityPersonel p)
        {
            if(p.Ad!="" && p.Soyad!="" && p.Maaş >= 3500)
            {
                return DALPersonel.PersonelEkle(p);
            }
            else
            {
                return -1;
            }
            
        }

        public static int LogicLayerPersonelSil(EntityPersonel p)
        {
            if(p.Id>0)
            {
                return DALPersonel.PersonelSil(p);
            }
            else
            {
                return -1;
            }
        }

        public static int LogicLayerPersonelGüncelle(EntityPersonel p)
        {
            if(p.Id>0 && p.Ad!="" && p.Soyad!="" && p.Gorev!="" && p.Maaş>3500 && p.Sehir!="")
            {
                return DALPersonel.PersonelGüncelle(p);
            }
            else
            {
                return -1;
            }
        }
    }

   
}
