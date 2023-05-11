
namespace PdC_04_Iterator
{
    public class Item
    {
      
        public string Nombre { get; set; }

        public Item(string _nom)
        {
            Nombre = _nom;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}