using System.Runtime.InteropServices;
using System.Text;

namespace EpsonFiscalInterface.Interop
{
    internal class EpsonFiscalInterfaceImport
    {
        private const string dllName = "EpsonFiscalInterface.dll";

        /* Connection */

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ConfigurarVelocidad(int velocidad);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ConfigurarPuerto(string puerto);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int Conectar();

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int Desconectar();

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int Cancelar();

        /* Log */

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ComenzarLog(bool incluir_tramas);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int DetenerLog();

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int PausarLog();

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ReanudarLog();

        /* Queries */

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ConsultarUltimoError();

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ConsultarDescripcionDeError(int numero_de_error, StringBuilder respuesta_descripcion, int respuesta_descripcion_largo_maximo);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ConsultarEstadoDeConexion(); /* Obsolete, and undocumented. */

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ConsultarVersionDll(StringBuilder respuesta_descripcion, int respuesta_descripcion_largo_maximo, out int respuesta_mayor, out int respuesta_menor);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ConsultarVersionEquipo(StringBuilder respuesta_descripcion, int respuesta_descripcion_largo_maximo, out int respuesta_mayor, out int respuesta_menor);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ConsultarNumeroPuntoDeVenta(StringBuilder respuesta, int respuesta_largo_maximo);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ConsultarTipoResponsabilidadAnteElIVA(StringBuilder respuesta, int respuesta_largo_maximo);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ConsultarTipoHabilitacion(StringBuilder respuesta, int respuesta_largo_maximo);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ConsultarNumeroComprobanteUltimo(string tipo_de_comprobante, StringBuilder respuesta, int respuesta_largo_maximo);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ConsultarNumeroComprobanteActual(StringBuilder respuesta, int respuesta_largo_maximo);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ConsultarTipoComprobanteActual(StringBuilder respuesta, int respuesta_largo_maximo);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ConsultarSubTotalBrutoComprobanteActual(StringBuilder respuesta, int respuesta_largo_maximo);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ConsultarSubTotalNetoComprobanteActual(StringBuilder respuesta, int respuesta_largo_maximo);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ConsultarEstado(int id_consulta, out int respuesta);

        /* Set/Get Settings */

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int EstablecerEncabezado(int numero_encabezado, string descripcion);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ConsultarEncabezado(int numero_encabezado, StringBuilder respuesta, int respuesta_largo_maximo);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int EstablecerCola(int numero_cola, string descripcion);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ConsultarCola(int numero_cola, StringBuilder respuesta, int respuesta_largo_maximo);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int EstablecerFechaHora(string fecha_hora);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ConsultarFechaHora(StringBuilder respuesta, int respuesta_largo_maximo);

        /* Audit/Download */

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ImprimirAuditoria(int id_modificador, string desde, string hasta);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int Descargar(string desde, string hasta, string directorio_de_descarga);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int DescargarPeriodoPendiente(string directorio_de_descarga);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ConfirmarDescarga(string hasta);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ConsultarFechaPrimerJornadaPendiente(StringBuilder respuesta_fecha_pendiente, int respuesta_fecha_pendiente_largo_maximo);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ConsultarDescargasSinConfirmar(StringBuilder respuesta_fecha, int respuesta_fecha_largo_maximo, StringBuilder respuesta_cierre_z, int respuesta_cierre_z_largo_maximo);


        /* Sales */

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int CargarDatosCliente(string nombre_o_razon_social1, string nombre_o_razon_social2, string domicilio1, string domicilio2, string domicilio3, int id_tipo_documento, string numero_documento, int id_responsabilidad_iva);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int CargarComprobanteAsociado(string descripcion);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int AbrirComprobante(int id_tipo_documento);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int CargarTextoExtra(string descripcion);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ImprimirItem(int id_modificador, string descripcion, string cantidad, string precio, int id_tasa_iva, int ii_id, string ii_valor, int id_codigo, string codigo, string codigo_unidad_matrix, int codigo_unidad_medida);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ImprimirTextoLibre(string descripcion);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int CargarAjuste(int id_modificador, string descripcion, string monto, int id_tasa_iva, string codigo_interno);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int CargarOtrosTributos(int codigo_otros_tributos, string descripcion, string monto, int id_tasa_iva);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int CargarPago(int id_modificador, int codigo_forma_pago, int cantidad_cuotas, string monto, string descripcion_de_cupones, string descripcion, string descripcion_extra1, string descripcion_extra2);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ImprimirSubTotal();

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int CerrarComprobante();

        /* Journal */

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ImprimirCierreX();

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ImprimirCierreZ();

        /* User logo */

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int CargarLogo(string nombre_de_archivo);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int EliminarLogo();

        /* Configuration */

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ConfigurarRetardoAlEnviarComando(int milisegundos);    /*     *** undocumented ***      */
                                                                                        /*  The value is in miliseconds. */
                                                                                        /*        -1  is disables.       */
                                                                                        /*      1000  is one second.     */


        /* Generic (low level extended protocol) */

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int EnviarComando(string comando);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ObtenerRespuesta(StringBuilder buffer_salida, int largo_buffer_salida, out int largo_final_buffer_salida);

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ObtenerCodigoRetorno();

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ObtenerEstadoFiscal();

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ObtenerEstadoImpresora();

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ObtenerCantidadCamposRespuestaExtendida();

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ObtenerRespuestaExtendida(int numero_campo, StringBuilder buffer_salida, int largo_buffer_salida, out int largo_final_buffer_salida);

        /* Test --- for future implementation */

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int IsEInvoiceSupported();

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int IstEscPosSupported();

        /* Backward compatibility (Obsolete, and undocumented) */

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ConfimarDescarga(string hasta); /* Obsolete, and undocumented. */

        [DllImport(dllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ImprimirSubtotal();
    }
}
