using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePatternMoltiplicazione
{
    class Program
    {
      
      
        static void Main(string[] args)
        {
           
            var calcModern = new CalcolatriceModerna();
            calcModern.FaiOperazione(2, 2);

            var calcAntica = new CalcolatriceAntica();
            calcAntica.FaiOperazione(2, 3);
            
        }
    }
    
   
    abstract class Calcolatrice: ICalcolatrice
    {
        protected int valore1;
        protected int valore2;
        protected int result;
 
        protected virtual void Valorizza(int valore1, int valore2)
        {
            this.valore1 = valore1;
            this.valore2 = valore2;
            
        }

        protected abstract void Moltiplica();

        private void Result()
        {

            Console.WriteLine ("risultato moltiplicazione: "+ result);
        }

            
        public void FaiOperazione(int valore1, int valore2)
        {

            Valorizza(valore1, valore2);
            Moltiplica();
            Result();                      
        }

    }
    public interface ICalcolatrice
    {
        void FaiOperazione(int valore1, int valore2);
    }

    
    class CalcolatriceModerna : Calcolatrice
    {
        //calcolo moltiplicazione diretta
        protected override void Moltiplica()
        {
            this.result = this.valore1 * this.valore2;
        }
            
    }

    class CalcolatriceAntica : Calcolatrice
    {
        protected override void Moltiplica()
        {

            //calcolo moltiplicazione con ciclo e somma
            for (int i = 0; i < this.valore2; i++)
            {
                this.result += this.valore1;

            }
        }

    }


}


