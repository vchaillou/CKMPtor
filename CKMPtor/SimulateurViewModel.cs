using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKMPtor
{
    class SimulateurViewModel
    {
        public Commande CestPartiMonKiki { get; }

        public ObservableCollection<FabriqueAbstraite> Simulations { get; }
        public FabriqueAbstraite SimulationChoisie { private get; set; }

        public SimulateurViewModel()
        {
            CestPartiMonKiki = new Commande(lancerSimulation);
            Simulations = new ObservableCollection<FabriqueAbstraite>()
            {
                new JdlVFabrique()
            };
        }

        private void lancerSimulation()
        {
            SimulationChoisie.CréerSimulateur();
        }
    }
}
