using System;
using System.Collections.Generic;

namespace PdC_04_Iterator
{
    public partial class Form1
    {
        public Form1()
        {
            _iterador = _collection.CreateIterator();
            InitializeComponent();
        }

        private Collection _collection = new ConcreteCollection();
        private IteratorEjemplo _iterador;

        private void Listar()
        {
            listBox1.Items.Clear();
            _iterador.First();
            Item i = _iterador.CurrentItem();
            if (i != null) listBox1.Items.Add(i);
            while (!_iterador.IsDone())
            {
                _iterador.Siguiente();
                listBox1.Items.Add(_iterador.CurrentItem());
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Item _item = new Item(TextBox1.Text);
            _collection.Agregar(_item);
            Listar();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            _iterador.First();
            txtPrimero.Text = _iterador.CurrentItem().Nombre;
            TextBox2.Text = _iterador.CurrentItem().Nombre;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (_iterador.IsDone() == false)
            {
                _iterador.Siguiente();
                TextBox2.Text = _iterador.CurrentItem().Nombre;
            }
        }
    }
}