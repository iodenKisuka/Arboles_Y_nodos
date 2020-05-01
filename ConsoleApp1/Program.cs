using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        }

		class Nodo
		{
			int dato = 0;
			List<Nodo> hijos = new List<Nodo>();

			public Nodo(int dato)
			{
				this.dato = dato;
			}

			public bool esHoja()
			{
				return hijos.Count == 0;
			}

			public void preOrden()
			{
				Console.WriteLine(this.dato);
				foreach (Nodo hijo in this.hijos)
				{
					hijo.preOrden();
				}
			}

			public void inOrden()
			{
				if (this.hijos.Count > 0)
				{
					this.hijos[0].inOrden();
				}
				Console.WriteLine(this.dato);
				for (int i = 1; i < this.hijos.Count; i++)
				{
					this.hijos[i].inOrden();
				}
			}

			public void postOrden()
			{
				foreach (Nodo hijo in this.hijos)
				{
					hijo.postOrden();
				}
				Console.WriteLine(this.dato);
			}

			public void POr_niveles(){
				Console.WriteLine(this.dato);
				foreach (Nodo hijo in this.hijos)
				{
					hijo.POr_niveles();
				}

				/** hecho por el profesor
				 * foreach(Nodo hijo in this.hijos){
   cola.push(hijo);
}
				 **/

			}


			public void por_Niveles_Profe()
			{
				//public void porNiveles(){
				Queue<Nodo> cola = new Queue<Nodo>();
				cola.Enqueue(this);
				while (cola.Count > 0)
				{
					Nodo elementoActual = cola.Dequeue();
					Console.WriteLine(elementoActual.dato);
					foreach (Nodo hijoElementoActual in elementoActual.hijos)
					{
						cola.Enqueue(hijoElementoActual);
					}

				}
			}

		}
	}
}
