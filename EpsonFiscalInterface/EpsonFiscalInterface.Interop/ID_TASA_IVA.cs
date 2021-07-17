namespace EpsonFiscalInterface.Interop
{
    /// <summary>
    /// Código predefinido de tasas de I.V.A.
    /// </summary>
    public enum ID_TASA_IVA
    {
        /// <summary>
        /// Sin tasa de I.V.A.
        /// </summary>
        NINGUNO = 0,
        /// <summary>
        /// I.V.A. exento.
        /// </summary>
        EXENTO = 1,
        /// <summary>
        /// No gravado.
        /// </summary>
        NO_GRAVADO = 2,
        /// <summary>
        /// Gravado al 00,00%
        /// </summary>
        GRAVADO_0_0 = 3,
        /// <summary>
        /// Gravado al 10,50%
        /// </summary>
        GRAVADO_10_50 = 4,
        /// <summary>
        /// Gravado al 21,00%
        /// </summary>
        GRAVADO_21_00 = 5,
        /// <summary>
        /// Gravado al 27,00%
        /// </summary>
        GRAVADO_27_00 = 6,
    }
}
