
namespace PdC_04_Iterator
{
    public abstract class Collection
    {
        public abstract IteratorEjemplo CreateIterator();
        public abstract void Agregar(Item _item);
        public abstract Item Index(int _index);
        public abstract int Count();
        public abstract int Posicion();
    }
}