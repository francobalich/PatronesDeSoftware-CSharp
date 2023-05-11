
namespace PdC_04_Iterator
{
    public class Client
    {
        public Client()
        {
            _iterator = new ConcreteIterator(_aggregate);
            _iterator.First();
            _iterator.Siguiente();
            _iterator.Current();
            _iterator.IsDone();
        }

        private Aggregate _aggregate = new ConcreteAggregate();
        private Iterator _iterator;
    }
}