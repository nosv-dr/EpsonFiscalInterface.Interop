namespace EpsonFiscalInterface.Interop
{
    /// <summary>
    /// Tipo de comprobante.
    /// </summary>
    public enum ID_TIPO_COMPROBANTE
    {
        /// <summary>
        /// Tique.
        /// </summary>
        /// <remarks>
        /// "83"  Tique
        /// </remarks>
        TIQUET = 1,

        /// <summary>
        /// Tique factura A/B/C/M.
        /// </summary>
        /// <remarks>
        /// "81"  Tique Factura A, "82" Tique Factura B, "111" Tique Factura C, "118" Tique Factura M
        /// </remarks>
        TIQUE_FACTURA = 2,

        /// <summary>
        /// Tique nota de crédito, tique nota crédito A/B/C/M.
        /// </summary>
        /// <remarks>
        /// "110" Tique Nota de Credito, "112" Tique Nota de Credito A, "113" Tique Nota de Credito B, "114" Tique Nota de Credito C, "119" Tique Nota de Credito M
        /// </remarks>
        TIQUE_NOTA_DE_CREDITO = 3,

        /// <summary>
        /// Tique nota de débito A/B/C/M.
        /// </summary>
        /// <remarks>
        /// "115" Tique Nota de Debito A, "116" Tique Nota de Debito B, "117" Tique Nota de Debito C, "120" Tique Nota de Debito M
        /// </remarks>
        TIQUE_NOTA_DE_DEBITO = 4,

        /// <summary>
        /// Documento no fiscal homologado genérico.
        /// </summary>
        /// <remarks>
        /// "910" DNFH Documento Generico 
        /// </remarks>
        DNFH_GENERIC = 21,

        /// <summary>
        /// Documento no fiscal homologado de uso interno. 
        /// </summary>
        /// <remarks>
        /// "950" DNFH Documento de uso interno 
        /// </remarks>
        DNFH_INTERNAL_USE = 22,

        /// <summary>
        /// "91"  DNFH Valorizado Remito R 
        /// </summary>
        DNFH_VALORIZADO_REMITO_R = 51,

        /// <summary>
        /// "901" DNFH Valorizado Remito X 
        /// </summary>
        DNFH_VALORIZADO_REMITO_X = 52,

        /// <summary>
        /// "902" DNFH Valorizado Recibo X 
        /// </summary>
        DNFH_VALORIZADO_RECIBO_X = 53,

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// "903" DNFH Valorizado Presupuesto X 
        /// </remarks>
        DNFH_VALORIZADO_PRESUPUESTO_X = 54,

        /// <summary>
        /// "907" DNFH Valorizado Comprobante 
        /// </summary>
        DNFH_VALORIZADO_DONACION = 55,
    }
}
