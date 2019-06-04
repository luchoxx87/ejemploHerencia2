namespace ejemploHerencia2
{
    /// <summary>
    /// Clase Abstracta de entidades que posee saldo y pueden incrementarlo
    /// </summary>
    public abstract class EnteConSaldo
    {
        /// <summary>
        /// Propiedad Automatica, con getter y setter
        /// </summary>
        public double Saldo { get; set; }

        /// <summary>
        /// Metodo virtual (puede ser redefinido) para incrementar el saldo
        /// </summary>
        /// <param name="monto">monto para incrementar el saldo</param>
        public virtual void incrementarSaldo(double monto)
        {
            Saldo += monto;
        }
    }
}