using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class CProxy
    {
        public interface ISujeto
        {
            void Peticion(int pOpcion);
        }
        public class ProxySencillo : ISujeto
        {
            private CCocina cocina;
            public void Peticion(int pOpcion)
            {
                if (cocina == null)
                {
                    Console.WriteLine("Activando sujeto");
                    cocina = new CCocina();
                }
                if (pOpcion == 1)
                {
                    cocina.RecetaSecreta();
                }
                if (pOpcion == 2)
                {
                    cocina.Cocinar(5);
                }
            }
        }
        public class ProxySeguro : ISujeto
        {
            private CCocina cocina;
            public void Peticion(int pOpcion)
            {
                string password;
                Console.WriteLine("Dame el password:");
                password = Console.ReadLine();
                if (password == "1234")
                {
                    if (cocina == null)
                    {
                        Console.WriteLine("Activando sujeto");
                        cocina = new CCocina();
                    }
                    if (pOpcion == 1)
                    {
                        cocina.RecetaSecreta();
                    }
                    if (pOpcion == 2)
                    {
                        cocina.Cocinar(5);
                    }
                }
                else
                {
                    Console.WriteLine("Acceso denegado");
                }
            }
        }
        private class CCocina
        {
            public void RecetaSecreta()
            {
                Console.WriteLine("Pan-Aceite de oliva-Especias-Jamon-Queso");
            }
            public void Cocinar(int n)
            {
                Console.WriteLine("Cocinando {0} recetas", n);
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
