using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityDepartman
    {
        private int id;
        private string ad;
        private string açıklama;

        public int Id { get => id; set => id = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Açıklama { get => açıklama; set => açıklama = value; }
    }
}
