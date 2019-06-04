namespace ejemploHerencia2
{
    /// <summary>
    /// Caja de ahorro, hereda de la clase EnteConSaldo
    /// </summary>
    public class CajaAhorro: EnteConSaldo
    {
        /// <summary>
        /// Propiedad para leer y asignar el cbu
        /// </summary>
        public uint Cbu { get; set; }

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="unCbu"></param>
        public CajaAhorro(uint unCbu)
        {
            Cbu = unCbu;
        }

        /// <summary>
        /// Redefinicion del metodo base ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"CBU: {Cbu} - ${Saldo}";
        }        
    }
}