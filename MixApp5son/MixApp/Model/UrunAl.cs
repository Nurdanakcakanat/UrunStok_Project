﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixApp.Model
{
    public class UrunAl:BaseEntity
    {
        public int CariId { get; set; }
        [ForeignKey("CariId")]
        public virtual Cariler Cariler { get; set; }
        public DateTime ATarih { get; set; }
        public int UrunlerId { get; set; }
        [ForeignKey("UrunlerId")]
        public virtual Urunler Urunler { get; set; } //
        public int Adet { get; set; }
        public decimal BirimFiyat { get; set; }
        [StringLength(300)]
        public string Aciklama { get; set; }
        public int UrunAlgrupNo { get; set; }
        public int UrunKodu { get; set; }
    }
}
