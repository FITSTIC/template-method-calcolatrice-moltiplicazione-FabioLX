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
            //ULTIMO STEP in classe main creo gli oggetti
            var calcModern = new CalcolatriceModerna();
            calcModern.FaiOperazione(2, 2);

            var calcAntica = new CalcolatriceAntica();
            calcAntica.FaiOperazione(2, 3);



        }
    }


    // creare una classe PADRE di comportamento, che i figli dovranno definire e implementare
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

    

        //creo metodo pubblico visibile al figlio
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


    //creo documento FIGLIO A
    class CalcolatriceModerna : Calcolatrice
    {
        protected override void Moltiplica()
        {
            this.result = this.valore1 * this.valore2;
        }
            
    }

    class CalcolatriceAntica : Calcolatrice
    {
        protected override void Moltiplica()
        {
           
            for (int i = 0; i < this.valore2; i++)
            {
                this.result += this.valore1;

            }
        }

    }


}


