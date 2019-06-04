using System;

namespace ejemploHerencia2
{
    /// <summary>
    /// Clase Persona, hereda de la clase EnteConSaldo
    /// </summary>
    public class Persona: EnteConSaldo
    {
        /// <summary>
        /// Propiedad automatica Nombre
        /// </summary>
        public string Nombre { get;  set; }

        /// <summary>
        /// Propiedad automatica CAjaAhorro
        /// </summary>
        public CajaAhorro CajaAhorro { get; set; }

        /// <summary>
        /// Constructor de la clase Persona
        /// </summary>
        /// <param name="unNombre">nombre para la persona</param>
        /// <param name="unSaldo">saldo inicial de la persona</param>
        /// <param name="caja">caja de ahorro para la persona</param>
        public Persona(string unNombre, double unSaldo, CajaAhorro caja)
        {
            Nombre = unNombre;
            Saldo = unSaldo;
            CajaAhorro = caja;
        }

        /// <summary>
        /// Incrementa el dinero de la persona
        /// </summary>
        /// <param name="monto">Monto a sumar al dinero de la persona</param>
        public override void incrementarSaldo(double monto)
        {
            double efectivo = monto * 0.8;
            double dineroParaCaja = monto * 0.2;

            //Uso el metodo de la clase padre
            base.incrementarSaldo(efectivo);
            //Ahora le agrego MI comportamiento
            CajaAhorro.incrementarSaldo(dineroParaCaja);            
        }

        /// <summary>
        /// Redifinicion del metodo base ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{Nombre} - Efectivo: ${Saldo} - Caja: {CajaAhorro.ToString()}";
    }
}
