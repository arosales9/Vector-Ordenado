using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectoresAutosRegistros
{
	class Registro
	{
        private Auto[] _vecRegistros;
		private short _autos = 0;
        //public Auto carrito;

        public Registro()
        {
            _vecRegistros = new Auto[15];
        }

        public void Agregar(Auto carrito) //agregar de forma acomodada, no ordenar luego de agregar
        {
            bool rep = false;
            if (_autos>0)
            {
                for (short i = 0; i < _autos; i++)
                {
                    if (carrito.placa == _vecRegistros[i].placa)
                    {
                        rep = true;
                    }
                }
            }

            if (rep==false)
            {
                /*for (short i = _autos; i < _autos+1; i++)
                {
                    _vecRegistros[i] = carrito;
                }*/
                Ordenado(carrito);
                _autos++;
            }
            else
            {
                MessageBox.Show("Placa Existente");
            }
		}

        public void Ordenado(Auto carrito)
        {
            short cont = 0;
            while (cont <= _autos)
            {
                if (_vecRegistros[cont] != null)
                {

                    if (carrito.placa.CompareTo(_vecRegistros[cont].placa) < 0)
                    {
                        for (int l = _autos; l > cont; l--)
                        {
                            _vecRegistros[l] = _vecRegistros[l - 1];

                        }
                        _vecRegistros[cont] = carrito;
                        cont = _autos;
                    }
                }
                else
                {
                    _vecRegistros[cont] = carrito;
                }
                cont++;
            }
        }

        public void Buscar(string placa)
		{
			string Search = "";
			for(int i=0; i < _autos; i++)
			{
				if (_vecRegistros[i].placa.ToString()==placa)
				{
					Search = _vecRegistros[i].ToString();
                    MessageBox.Show("Registro encontrado " + Search);
				}
				else
				{
					Search = "Registrto no encontrado";
                    MessageBox.Show(Search);
                }
			}
		}

		public void Eliminar(int posicion)
		{
            if (_vecRegistros[posicion - 1] != null)
            {
                for (int i = posicion - 1; i < posicion; i++)
                {
                    //_vecRegistros[i] = _vecRegistros[i+1];
                    MessageBox.Show("Dato eliminado");
                    _autos--;
                }
            }
        }

		public string Listar()
		{
			string show = "";
			for(int i = 0; i < _autos; i++)
			{
				show += "Auto " + i 
                    + Environment.NewLine + _vecRegistros[i] 
                    + Environment.NewLine;
			}
			return show;
		}

        public void Insertar(int posicion, Auto objeto)
        {
            Auto temp;
            for (int i = posicion; i <= _vecRegistros.Length; i++)
            {
                temp = _vecRegistros[i];
                _vecRegistros[i] = objeto;
                _vecRegistros[i + 1] = temp;
            }
        }
    }
}
