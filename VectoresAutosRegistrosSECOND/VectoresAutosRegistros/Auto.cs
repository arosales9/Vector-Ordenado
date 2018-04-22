using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectoresAutosRegistros
{
	class Auto
	{
		private string _Placa;
		private string _Marca;
		private string _Modelo;
		private string _Telefono;
		private string _Año;

		public string placa
		{
			get { return _Placa; }
		}
		public string marca
		{
			get { return _Marca; }
		}
		public string modelo
		{
			get { return _Modelo; }
		}
		public string telefono
		{
			get { return _Telefono; }
		}
		public string year
		{
			get { return _Año; }
		}


		public Auto(string placa, string marca, string modelo, string telefono, string year)
		{
			_Placa = placa;
			_Marca = marca;
			_Modelo = modelo;
			_Año = year;
            _Telefono = telefono;
        }

		public override string ToString()
		{
            return "Placa: " + _Placa + Environment.NewLine
                + "Marca: " + _Marca + Environment.NewLine
                + "Modelo: " + _Modelo + Environment.NewLine
                + "Año: " + _Año + Environment.NewLine
                + "Telefono: " + _Telefono + Environment.NewLine;
		}
	}
}
