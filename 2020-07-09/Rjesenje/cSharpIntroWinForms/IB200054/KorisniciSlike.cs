﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.IB200054
{
    [Table("KorisniciSlike")]
    public class KorisniciSlike
    {
        public int Id { get; set; }
        public virtual Slika Slika { get; set; }
        public virtual Korisnik Korisnik { get; set; }
    }
}
