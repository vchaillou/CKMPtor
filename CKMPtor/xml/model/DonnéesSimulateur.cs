using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKMPtor.model;
using CKMPtor.xml.model.fourmiliere;
using CKMPtor.xml.model.jeuDeLaVie;

namespace CKMPtor.xml.model
{
    class DonnéesSimulateur
    {
        public Fourmiliere Fourmiliere { get; set; }
        public Immeuble Immeuble { get; set; }
        public JeuDeLaVie JeuDeLaVie { get; set; }
    }
}
