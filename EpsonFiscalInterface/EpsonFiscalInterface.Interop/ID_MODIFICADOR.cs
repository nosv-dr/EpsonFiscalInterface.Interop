namespace EpsonFiscalInterface.Interop
{
    /// <summary>
    /// Identificador del modificador.
    /// </summary>
    public enum ID_MODIFICADOR
    {
        /// <summary>
        /// Agregar ítem de venta.
        /// </summary>
        AGREGAR_ITEM = 200,
        /// <summary>
        /// Anulación del ítem de venta.
        /// </summary>
        ANULAR_ITEM = 201,
        /// <summary>
        /// Agregar ítem de retorno envases.
        /// </summary>
        AGREGAR_ITEM_RETORNO_ENVASES = 202,
        /// <summary>
        /// Ajuste ítem de retorno envases.
        /// </summary>
        ANULAR_ITEM_RETORNO_ENVASES = 203,
        /// <summary>
        /// Agregar ítem de bonificación.
        /// </summary>
        AGREGAR_ITEM_BONIFICACION = 204,
        /// <summary>
        /// Ajuste ítem de bonificación.
        /// </summary>
        ANULAR_ITEM_BONIFICACION = 205,
        /// <summary>
        /// Agregar ítem de descuento.
        /// </summary>
        AGREGAR_ITEM_DESCUENTO = 206,
        /// <summary>
        /// Ajuste ítem de descuento.
        /// </summary>
        ANULAR_ITEM_DESCUENTO = 207,
        /// <summary>
        /// Agregar ítem de seña-anticipo.
        /// </summary>
        AGREGAR_ITEM_ANTICIPO = 208,
        /// <summary>
        /// Ajuste ítem de seña-anticipo.
        /// </summary>
        ANULAR_ITEM_ANTICIPO = 209,
        /// <summary>
        /// Agregar ítem de descuento de seña-anticipo.
        /// </summary>
        AGREGAR_ITEM_DESCUENTO_ANTICIPO = 210,
        /// <summary>
        /// Ajuste ítem de descuento de seña-anticipo.
        /// </summary>
        ANULAR_ITEM_DESCUENTO_ANTICIPO = 211,
        DESCUENTO = 400,
        AJUSTE = 401,
        AJUSTE_NEGATIVO = 402,
        /// <summary>
        /// Auditoría detallada.
        /// </summary>
        AUDITORIA_DETALLADA = 500,
        /// <summary>
        /// Auditoría resumida.
        /// </summary>
        AUDITORIA_RESUMIDA = 501,
    }
}
