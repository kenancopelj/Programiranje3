﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.Entiteti
{
    [Table("StudentiCovidTestovi")]
    public class StudentiCovidTestovi
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public string Datum { get; set; }
        public string Rezultat { get; set; }
        public bool NalazDostavljen { get; set; }
    }
}
