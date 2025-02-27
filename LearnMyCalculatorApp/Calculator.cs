namespace LearnMyCalculatorApp
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int? Divide(int x, int y)
        {
            try { 
                return x / y;
            }catch (Exception e)
            {
                return null;
            }
        }


    }


    public interface IFruta
    {
        string ObtenerColor();
    }
    public class ManzanaRoja:IFruta
    {
        public string ObtenerColor()
        {
            return "Manzana Roja";
        }
    }

    public class ManzanaVerde : IFruta
    {
        public string ObtenerColor()
        {
            return "Manzana Verde";
        }
    }

    public class Frutero
    {
        private readonly IFruta fruta;

        public Frutero(IFruta fruta)
        {
            this.fruta = fruta;
        }

        public string ObternerColorFruta()
        {
            return fruta.ObtenerColor();
        }
    }

}

