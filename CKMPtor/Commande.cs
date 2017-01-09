using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CKMPtor
{
    public class Commande : ICommand
    {
        public bool Exécution { get; set; }

        private Action fonction;

        public Commande(Action uneFonction, bool uneExécution = true)
        {
            fonction = uneFonction;
            Exécution = uneExécution;
        }
        
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return Exécution;
        }

        public void Execute(object parameter)
        {
            fonction();
        }
    }
}
