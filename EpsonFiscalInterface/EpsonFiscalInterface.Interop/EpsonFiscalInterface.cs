using System;
using System.Text;

namespace EpsonFiscalInterface.Interop
{
    public class EpsonFiscalInterface
    {
        private const int BufferSize = 1024;

        /* Connection */

        public static void ConfigurarVelocidad(int velocidad)
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.ConfigurarVelocidad(velocidad));
        }

        public static void ConfigurarPuerto(string puerto)
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.ConfigurarPuerto(puerto));
        }

        public static void Conectar()
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.Conectar());
        }

        public static void Desconectar()
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.Desconectar());
        }

        public static void Cancelar()
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.Cancelar());
        }

        /* Log */

        public static void ComenzarLog(bool incluir_tramas)
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.ComenzarLog(incluir_tramas));
        }

        public static void DetenerLog()
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.DetenerLog());
        }

        public static void PausarLog()
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.PausarLog());
        }

        public static void ReanudarLog()
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.ReanudarLog());
        }

        /* Queries */

        public static int ConsultarUltimoError()
        {
            return EpsonFiscalInterfaceImport.ConsultarUltimoError();
        }

        public static string ConsultarDescripcionDeError(int numero_de_error)
        {
            StringBuilder buffer = new StringBuilder(BufferSize);

            int result = EpsonFiscalInterfaceImport.ConsultarDescripcionDeError(numero_de_error, buffer, buffer.Capacity);

            if (result == 0)
            {
                return buffer.ToString();
            }

            throw new EpsonFiscalInterfaceException(result.ToString());
        }

        public static int ConsultarEstadoDeConexion()
        {
            return EpsonFiscalInterfaceImport.ConsultarEstadoDeConexion();
        }

        public static string ConsultarVersionDll(out int respuesta_mayor, out int respuesta_menor)
        {
            StringBuilder buffer = new StringBuilder(BufferSize);

            int result = EpsonFiscalInterfaceImport.ConsultarVersionDll(buffer, buffer.Capacity, out respuesta_mayor, out respuesta_menor);

            if (result == 0)
            {
                return buffer.ToString();
            }

            string description = ConsultarDescripcionDeError(result);

            throw new EpsonFiscalInterfaceException(description);
        }

        public static string ConsultarVersionEquipo(out int respuesta_mayor, out int respuesta_menor)
        {
            StringBuilder buffer = new StringBuilder(BufferSize);

            int result = EpsonFiscalInterfaceImport.ConsultarVersionEquipo(buffer, buffer.Capacity, out respuesta_mayor, out respuesta_menor);

            if (result == 0)
            {
                return buffer.ToString();
            }

            string description = ConsultarDescripcionDeError(result);

            throw new EpsonFiscalInterfaceException(description);
        }

        public static string ConsultarNumeroPuntoDeVenta()
        {
            StringBuilder buffer = new StringBuilder(BufferSize);

            CallWithCheck(() => EpsonFiscalInterfaceImport.ConsultarNumeroPuntoDeVenta(buffer, buffer.Capacity));

            return buffer.ToString();
        }

        public static string ConsultarTipoResponsabilidadAnteElIVA()
        {
            StringBuilder buffer = new StringBuilder(BufferSize);

            CallWithCheck(() => EpsonFiscalInterfaceImport.ConsultarTipoResponsabilidadAnteElIVA(buffer, buffer.Capacity));

            return buffer.ToString();
        }

        public static string ConsultarTipoHabilitacion()
        {
            StringBuilder buffer = new StringBuilder(BufferSize);

            CallWithCheck(() => EpsonFiscalInterfaceImport.ConsultarTipoHabilitacion(buffer, buffer.Capacity));

            return buffer.ToString();
        }

        public static string ConsultarNumeroComprobanteUltimo(string tipo_de_comprobante)
        {
            StringBuilder buffer = new StringBuilder(BufferSize);

            CallWithCheck(() => EpsonFiscalInterfaceImport.ConsultarNumeroComprobanteUltimo(tipo_de_comprobante, buffer, buffer.Capacity));

            return buffer.ToString();
        }

        public static string ConsultarNumeroComprobanteActual()
        {
            StringBuilder buffer = new StringBuilder(BufferSize);

            CallWithCheck(() => EpsonFiscalInterfaceImport.ConsultarNumeroComprobanteActual(buffer, buffer.Capacity));

            return buffer.ToString();
        }

        public static string ConsultarTipoComprobanteActual()
        {
            StringBuilder buffer = new StringBuilder(BufferSize);

            CallWithCheck(() => EpsonFiscalInterfaceImport.ConsultarTipoComprobanteActual(buffer, buffer.Capacity));

            return buffer.ToString();
        }

        public static string ConsultarSubTotalBrutoComprobanteActual()
        {
            StringBuilder buffer = new StringBuilder(BufferSize);

            CallWithCheck(() => EpsonFiscalInterfaceImport.ConsultarSubTotalBrutoComprobanteActual(buffer, buffer.Capacity));

            return buffer.ToString();
        }

        public static string ConsultarSubTotalNetoComprobanteActual()
        {
            StringBuilder buffer = new StringBuilder(BufferSize);

            CallWithCheck(() => EpsonFiscalInterfaceImport.ConsultarSubTotalNetoComprobanteActual(buffer, buffer.Capacity));

            return buffer.ToString();
        }

        public static int ConsultarEstado(int id_consulta, out int respuesta)
        {
            return EpsonFiscalInterfaceImport.ConsultarEstado(id_consulta, out respuesta);
        }

        /* Set/Get Settings */

        public static int EstablecerEncabezado(int numero_encabezado, string descripcion)
        {
            return EpsonFiscalInterfaceImport.EstablecerEncabezado(numero_encabezado, descripcion);
        }

        public static string ConsultarEncabezado(int numero_encabezado)
        {
            StringBuilder buffer = new StringBuilder(BufferSize);

            CallWithCheck(() => EpsonFiscalInterfaceImport.ConsultarEncabezado(numero_encabezado, buffer, buffer.Capacity));

            return buffer.ToString();
        }

        public static int EstablecerCola(int numero_cola, string descripcion)
        {
            return EpsonFiscalInterfaceImport.EstablecerCola(numero_cola, descripcion);
        }

        public static string ConsultarCola(int numero_cola)
        {
            StringBuilder buffer = new StringBuilder(BufferSize);

            CallWithCheck(() => EpsonFiscalInterfaceImport.ConsultarCola(numero_cola, buffer, buffer.Capacity));

            return buffer.ToString();
        }

        public static int EstablecerFechaHora(string fecha_hora)
        {
            return EpsonFiscalInterfaceImport.EstablecerFechaHora(fecha_hora);
        }

        public static string ConsultarFechaHora()
        {
            StringBuilder buffer = new StringBuilder(BufferSize);

            CallWithCheck(() => EpsonFiscalInterfaceImport.ConsultarFechaHora(buffer, buffer.Capacity));

            return buffer.ToString();
        }

        /* Audit/Download */

        public static void ImprimirAuditoria(int id_modificador, string desde, string hasta)
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.ImprimirAuditoria(id_modificador, desde, hasta));
        }

        public static void Descargar(string desde, string hasta, string directorio_de_descarga)
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.Descargar(desde, hasta, directorio_de_descarga));
        }

        public static void DescargarPeriodoPendiente(string directorio_de_descarga)
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.DescargarPeriodoPendiente(directorio_de_descarga));
        }

        public static void ConfirmarDescarga(string hasta)
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.ConfirmarDescarga(hasta));
        }

        public static string ConsultarFechaPrimerJornadaPendiente()
        {
            StringBuilder buffer = new StringBuilder(BufferSize);

            CallWithCheck(() => EpsonFiscalInterfaceImport.ConsultarFechaPrimerJornadaPendiente(buffer, buffer.Capacity));

            return buffer.ToString();
        }

        public static void ConsultarDescargasSinConfirmar(out string respuesta_fecha, out string respuesta_cierre_z)
        {
            StringBuilder buffer1 = new StringBuilder(BufferSize);
            StringBuilder buffer2 = new StringBuilder(BufferSize);

            CallWithCheck(() => EpsonFiscalInterfaceImport.ConsultarDescargasSinConfirmar(buffer1, buffer1.Capacity, buffer2, buffer2.Capacity));

            respuesta_fecha = buffer1.ToString();
            respuesta_cierre_z = buffer2.ToString();
        }

        /* Sales */

        public static void CargarDatosCliente(string nombre_o_razon_social1, string nombre_o_razon_social2, string domicilio1, string domicilio2, string domicilio3, int id_tipo_documento, string numero_documento, int id_responsabilidad_iva)
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.CargarDatosCliente(nombre_o_razon_social1, nombre_o_razon_social2, domicilio1, domicilio2, domicilio3, id_tipo_documento, numero_documento, id_responsabilidad_iva));
        }

        public static void CargarComprobanteAsociado(string descripcion)
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.CargarComprobanteAsociado(descripcion));
        }

        public static void AbrirComprobante(int id_tipo_documento)
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.AbrirComprobante(id_tipo_documento));
        }

        public static void CargarTextoExtra(string descripcion)
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.CargarTextoExtra(descripcion));
        }

        public static void ImprimirItem(int id_modificador, string descripcion, string cantidad, string precio, int id_tasa_iva, int ii_id, string ii_valor, int id_codigo, string codigo, string codigo_unidad_matrix, int codigo_unidad_medida)
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.ImprimirItem(id_modificador, descripcion, cantidad, precio, id_tasa_iva, ii_id, ii_valor, id_codigo, codigo, codigo_unidad_matrix, codigo_unidad_medida));
        }

        public static void ImprimirTextoLibre(string descripcion)
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.ImprimirTextoLibre(descripcion));
        }

        public static void CargarAjuste(int id_modificador, string descripcion, string monto, int id_tasa_iva, string codigo_interno)
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.CargarAjuste(id_modificador, descripcion, monto, id_tasa_iva, codigo_interno));
        }

        public static void CargarOtrosTributos(int codigo_otros_tributos, string descripcion, string monto, int id_tasa_iva)
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.CargarOtrosTributos(codigo_otros_tributos, descripcion, monto, id_tasa_iva));
        }

        public static void CargarPago(int id_modificador, int codigo_forma_pago, int cantidad_cuotas, string monto, string descripcion_de_cupones, string descripcion, string descripcion_extra1, string descripcion_extra2)
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.CargarPago(id_modificador, codigo_forma_pago, cantidad_cuotas, monto, descripcion_de_cupones, descripcion, descripcion_extra1, descripcion_extra2));
        }

        public static void ImprimirSubTotal()
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.ImprimirSubTotal());
        }

        public static void CerrarComprobante()
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.CerrarComprobante());
        }

        /* Journal */

        public static void ImprimirCierreX()
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.ImprimirCierreX());
        }

        public static void ImprimirCierreZ()
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.ImprimirCierreZ());
        }

        /* User logo */

        public static void CargarLogo(string nombre_de_archivo)
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.CargarLogo(nombre_de_archivo));
        }

        public static void EliminarLogo()
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.EliminarLogo());
        }

        /* Configuration */

        public static void ConfigurarRetardoAlEnviarComando(int milisegundos)
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.ConfigurarRetardoAlEnviarComando(milisegundos));
        }

        public static void EnviarComando(string comando)
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.EnviarComando(comando));
        }

        /* Generic (low level extended protocol) */

        public static int ObtenerRespuesta(StringBuilder buffer_salida, int largo_buffer_salida, out int largo_final_buffer_salida)
        {
            return EpsonFiscalInterfaceImport.ObtenerRespuesta(buffer_salida, largo_buffer_salida, out largo_final_buffer_salida);
        }

        public static int ObtenerCodigoRetorno()
        {
            return EpsonFiscalInterfaceImport.ObtenerCodigoRetorno();
        }

        public static int ObtenerEstadoFiscal()
        {
            return EpsonFiscalInterfaceImport.ObtenerEstadoFiscal();
        }

        public static int ObtenerEstadoImpresora()
        {
            return EpsonFiscalInterfaceImport.ObtenerEstadoImpresora();
        }

        public static int ObtenerCantidadCamposRespuestaExtendida()
        {
            return EpsonFiscalInterfaceImport.ObtenerCantidadCamposRespuestaExtendida();
        }

        public static int ObtenerRespuestaExtendida(int numero_campo, StringBuilder buffer_salida, int largo_buffer_salida, out int largo_final_buffer_salida)
        {
            return EpsonFiscalInterfaceImport.ObtenerRespuestaExtendida(numero_campo, buffer_salida, largo_buffer_salida, out largo_final_buffer_salida);
        }

        /* Test --- for future implementation */

        public static int IsEInvoiceSupported()
        {
            return EpsonFiscalInterfaceImport.IsEInvoiceSupported();
        }

        public static int IstEscPosSupported()
        {
            return EpsonFiscalInterfaceImport.IstEscPosSupported();
        }

        /* Backward compatibility (Obsolete, and undocumented) */

        public static int ConfimarDescarga(string hasta)
        {
            return EpsonFiscalInterfaceImport.ConfimarDescarga(hasta);
        }

        public static int ImprimirSubtotal()
        {
            return EpsonFiscalInterfaceImport.ImprimirSubtotal();
        }

        /* Private */

        private static void CallWithCheck(Func<int> p)
        {
            int result = 0;
            try
            {
                result = p();
            }
            catch (Exception ex)
            {
                string message = string.Format("EpsonFiscalInterface.{0} call failed", p.Method.Name) + Environment.NewLine + ex.ToString();

                throw new EpsonFiscalInterfaceException(message, ex);
            }

            if (result != 0)
            {
                string description = ConsultarDescripcionDeError(result);

                throw new EpsonFiscalInterfaceException(description, result);
            }
        }
    }
}
