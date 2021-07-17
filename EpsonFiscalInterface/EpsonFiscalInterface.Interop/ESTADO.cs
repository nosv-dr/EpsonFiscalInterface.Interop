namespace EpsonFiscalInterface.Interop
{
    public enum ESTADO
    {
        /// <summary>
        /// Documento en progreso.
        /// </summary>
        DOC_EN_PROGRESO = 1003,
        /// <summary>
        /// Subestados.
        /// </summary>
        SUBESTADOS = 1006,
        /// <summary>
        /// Jornada fiscal.
        /// </summary>
        JORNADA_FISCAL = 1007,
        /// <summary>
        /// Estado de memoria de transacciones.
        /// </summary>
        MEM_TRANSACCIONES = 1009,
        /// <summary>
        /// Estado de memoria fiscal.
        /// </summary>
        MEM_FISCAL = 1011,
        /// <summary>
        /// Modo técnico.
        /// </summary>
        MODO_TECNICO = 1012,
        /// <summary>
        /// Estado de los certificados digitales.
        /// </summary>
        CERTIFICADOS_DIGITALES = 1013,
        /// <summary>
        /// Modo de funcionamiento del equipo.
        /// </summary>
        MODO_FUNCIONAMIENTO_EQUIPO = 1015,
        /// <summary>
        /// Estado de la estación de Recibos.
        /// </summary>
        ESTACION_RECIBOS = 7001,
        /// <summary>
        /// Estado de la estación Journal.
        /// </summary>
        ESTACION_JOURNAL = 7003,
        /// <summary>
        /// Estación Slip – Sensor de validación de papel.
        /// </summary>
        ESTACION_SLIP_SENSOR_VALIDACION = 7004,
        /// <summary>
        /// Estación Slip – Sensor de fin de carga de papel (TOF).
        /// </summary>
        ESTACION_SLIP_SENSOR_TOF = 7005,
        /// <summary>
        /// Estación Slip – Sensor de inicio de carga de papel (BOF).
        /// </summary>
        ESTACION_SLIP_SENSOR_BOF = 7006,
        /// <summary>
        /// Estación Slip/Validación – Sensor de espera de carga o remoción.
        /// </summary>
        ESTACION_SLIP_VALIDACION_SENSOR_ESPERA = 7008,
        /// <summary>
        /// Estación de impresión seleccionada.
        /// </summary>
        ESTACION_SELECCIONADA = 7010,
        /// <summary>
        /// Cajon de dinero.
        /// </summary>
        CAJON_DINERO = 7012,
        /// <summary>
        /// Estado de la tapa de la impresora.
        /// </summary>
        TAPA = 7013,
        /// <summary>
        /// Impresora con error.
        /// </summary>
        IMPRESORA_CON_ERROR = 7014,
        /// <summary>
        /// Impresora en línea.
        /// </summary>
        IMPRESORA_EN_LINEA = 7015,
        /// <summary>
        /// Estado de la conexión.
        /// </summary>
        CONEXION = 9003,
    }
}
