namespace EpsonFiscalInterface.Interop
{
    public enum ID_TIPO_COMPROBANTE
    {
        /// <summary>
        /// "83"  Tique
        /// </summary>
        TIQUET = 1,

        /// <summary>
        /// "81"  Tique Factura A, "82" Tique Factura B, "111" Tique Factura C, "118" Tique Factura M
        /// </summary>
        TIQUE_FACTURA = 2,

        /// <summary>
        /// "110" Tique Nota de Credito, "112" Tique Nota de Credito A, "113" Tique Nota de Credito B, "114" Tique Nota de Credito C, "119" Tique Nota de Credito M
        /// </summary>
        TIQUE_NOTA_DE_CREDITO = 3,

        /// <summary>
        /// "115" Tique Nota de Debito A, "116" Tique Nota de Debito B, "117" Tique Nota de Debito C, "120" Tique Nota de Debito M
        /// </summary>
        TIQUE_NOTA_DE_DEBITO = 4,

        /// <summary>
        /// "910" DNFH Documento Generico 
        /// </summary>
        DNFH_GENERIC = 21,

        /// <summary>
        /// "950" DNFH Documento de uso interno 
        /// </summary>
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
        /// "903" DNFH Valorizado Presupuesto X 
        /// </summary>
        DNFH_VALORIZADO_PRESUPUESTO_X = 54,

        /// <summary>
        /// "907" DNFH Valorizado Comprobante 
        /// </summary>
        DNFH_VALORIZADO_DONACION = 55,
    }
}
