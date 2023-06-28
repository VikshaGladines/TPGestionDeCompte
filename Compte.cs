using System.Collections.Generic;

namespace TP_Gestion_de_compte
{

    public abstract class Compte
    {


        protected List<Compte> listeOperations;

        protected Compte(string utilisateur, double soldeInitial, string devise)
        {
            throw new System.NotImplementedException();
        }

        public string Proprietaire { get; set; }

        public virtual decimal Solde
        {
            get
            {
                decimal total = 0;
                foreach (Compte operation in listeOperations)
                {
                    if (operation.TypeDeMouvement == (object)Mouvement.Credit)
                        total += operation.Montant;
                    else
                        total -= operation.Montant;
                }
                return total;
            }
        }



        public decimal Montant { get; set; }

        public object TypeDeMouvement { get; set; }

        public decimal montant Crediter()
        {
            
        }

        public decimal montant Debiter()
        {

        }

        public decimal Crediter(Compte compteADebiter)
        {

        }

        public decimal Debiter(Compte compteADebiter)
        {

        }

        abstract decimal CalculBenefice()
        {

        }

        public decimal SoldeFinal()
        {

        }

        public string Information(string proprio, int solde, int decouvertOK, string operation)
        {
            this.Proprietaire = proprio;
            this
        }
    }


    public enum Mouvement
    {
        Credit,
        Debit
    }
}

