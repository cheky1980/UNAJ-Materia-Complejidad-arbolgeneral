using System;
using System.Collections.Generic;

namespace juegoIA
{
	/// <summary>
	/// Description of NodoGeneral.
	/// </summary>
	public class NodoGeneral<T>
	{
		private T dato;
		private List<NodoGeneral<T>> hijos;
		public int cuantasVecesPerdio;
		public int perdioUsuario;
		
		public int PerdioUsuario
		{
			get
			{
				return perdioUsuario;
			}
			set
			{
				perdioUsuario = 0;
			}
		}
		
		public int CuantasVecesPerdio
		{
			get
			{
				return cuantasVecesPerdio;
			}
			set
			{
				cuantasVecesPerdio = value;
			}
		}
	
		public NodoGeneral(T dato){		
			this.dato = dato;
			this.hijos = new List<NodoGeneral<T>>();
		}
	
		public T getDato(){		
			return this.dato; 
		}
		
		public List<NodoGeneral<T>> getHijos(){		
			return this.hijos;
		}

		public void setDato(T dato){		
			this.dato = dato;
		}
		
		public void setHijos(NodoGeneral<T> Hijo){
			this.hijos.Add(Hijo);
		}
	
	}
}
