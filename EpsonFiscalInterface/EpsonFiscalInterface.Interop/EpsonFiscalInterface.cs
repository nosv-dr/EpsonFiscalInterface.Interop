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

        public static string ConsultarNumeroComprobanteUltimo(AFIP_TIPO_COMPROBANTE tipo_de_comprobante)
        {
            StringBuilder buffer = new StringBuilder(BufferSize);

            CallWithCheck(() => EpsonFiscalInterfaceImport.ConsultarNumeroComprobanteUltimo(((int)tipo_de_comprobante).ToString(), buffer, buffer.Capacity));

            return buffer.ToString();
        }

        public static string ConsultarNumeroComprobanteActual()
        {
            StringBuilder buffer = new StringBuilder(BufferSize);

            CallWithCheck(() => EpsonFiscalInterfaceImport.ConsultarNumeroComprobanteActual(buffer, buffer.Capacity));

            return buffer.ToString();
        }

        public static AFIP_TIPO_COMPROBANTE ConsultarTipoComprobanteActual()
        {
            StringBuilder buffer = new StringBuilder(BufferSize);

            CallWithCheck(() => EpsonFiscalInterfaceImport.ConsultarTipoComprobanteActual(buffer, buffer.Capacity));

            if (Enum.TryParse<AFIP_TIPO_COMPROBANTE>(buffer.ToString(), out AFIP_TIPO_COMPROBANTE value))
            {
                return value;
            }

            return default(AFIP_TIPO_COMPROBANTE);
        }

        public static decimal ConsultarSubTotalBrutoComprobanteActual()
        {
            StringBuilder buffer = new StringBuilder(BufferSize);

            CallWithCheck(() => EpsonFiscalInterfaceImport.ConsultarSubTotalBrutoComprobanteActual(buffer, buffer.Capacity));

            return StringToDecimal(buffer.ToString());
        }

        public static decimal ConsultarSubTotalNetoComprobanteActual()
        {
            StringBuilder buffer = new StringBuilder(BufferSize);

            CallWithCheck(() => EpsonFiscalInterfaceImport.ConsultarSubTotalNetoComprobanteActual(buffer, buffer.Capacity));

            return StringToDecimal(buffer.ToString());
        }

        public static int ConsultarEstado(ESTADO id_consulta, out int respuesta)
        {
            return EpsonFiscalInterfaceImport.ConsultarEstado((int)id_consulta, out respuesta);
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

        public static void ImprimirAuditoria(ID_MODIFICADOR id_modificador, string desde, string hasta)
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.ImprimirAuditoria((int)id_modificador, desde, hasta));
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

        public static void CargarDatosCliente(string nombre_o_razon_social1, string nombre_o_razon_social2, string domicilio1, string domicilio2, string domicilio3, ID_TIPO_DOCUMENTO id_tipo_documento, string numero_documento, ID_RESPONSABILIDAD_IVA id_responsabilidad_iva)
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.CargarDatosCliente(nombre_o_razon_social1, nombre_o_razon_social2, domicilio1, domicilio2, domicilio3, (int)id_tipo_documento, numero_documento, (int)id_responsabilidad_iva));
        }

        public static void CargarComprobanteAsociado(string descripcion)
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.CargarComprobanteAsociado(descripcion));
        }

        public static void AbrirComprobante(ID_TIPO_COMPROBANTE id_tipo_documento)
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.AbrirComprobante((int)id_tipo_documento));
        }

        public static void CargarTextoExtra(string descripcion)
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.CargarTextoExtra(descripcion));
        }

        public static void ImprimirItem(ID_MODIFICADOR id_modificador, string descripcion, decimal cantidad, decimal precio, ID_TASA_IVA id_tasa_iva, ID_IMPUESTO ii_id, decimal ii_valor, ID_CODIGO id_codigo, string codigo, string codigo_unidad_matrix, AFIP_CODIGO_UNIDAD_MEDIDA codigo_unidad_medida)
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.ImprimirItem((int)id_modificador, descripcion, DecimalToString(cantidad), DecimalToString(precio), (int)id_tasa_iva, (int)ii_id, DecimalToString(ii_valor), (int)id_codigo, codigo, codigo_unidad_matrix, (int)codigo_unidad_medida));
        }

        public static void ImprimirTextoLibre(string descripcion)
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.ImprimirTextoLibre(descripcion));
        }

        public static void CargarAjuste(ID_MODIFICADOR id_modificador, string descripcion, decimal monto, ID_TASA_IVA id_tasa_iva, string codigo_interno)
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.CargarAjuste((int)id_modificador, descripcion, DecimalToString(monto), (int)id_tasa_iva, codigo_interno));
        }

        public static void CargarOtrosTributos(AFIP_CODIGO_OTROS_TRIBUTOS codigo_otros_tributos, string descripcion, decimal monto, ID_TASA_IVA id_tasa_iva)
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.CargarOtrosTributos((int)codigo_otros_tributos, descripcion, DecimalToString(monto), (int)id_tasa_iva));
        }

        public static void CargarPago(ID_MODIFICADOR id_modificador, AFIP_CODIGO_FORMA_DE_PAGO codigo_forma_pago, int cantidad_cuotas, decimal monto, string descripcion_de_cupones, string descripcion, string descripcion_extra1, string descripcion_extra2)
        {
            CallWithCheck(() => EpsonFiscalInterfaceImport.CargarPago((int)id_modificador, (int)codigo_forma_pago, cantidad_cuotas, DecimalToString(monto), descripcion_de_cupones, descripcion, descripcion_extra1, descripcion_extra2));
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

        [Obsolete]
        public static int ConfimarDescarga(string hasta)
        {
            return EpsonFiscalInterfaceImport.ConfimarDescarga(hasta);
        }

        [Obsolete]
        public static int ImprimirSubtotal()
        {
            return EpsonFiscalInterfaceImport.ImprimirSubtotal();
        }

        [Obsolete]
        public static void AbrirDocumento(AFIP_TIPO_COMPROBANTE id_tipo_documento)
        {
            AbrirComprobante(AFIPTOID(id_tipo_documento));
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

        private static string DecimalToString(decimal value)
        {
            var format = new System.Globalization.NumberFormatInfo();
            format.NumberDecimalDigits = 4;
            format.NumberGroupSeparator = string.Empty;
            format.NumberGroupSizes = new int[0];
            return value.ToString("N", format);
        }

        private static decimal StringToDecimal(string value)
        {
            return decimal.Parse(value);
        }

        private static ID_TIPO_COMPROBANTE AFIPTOID(AFIP_TIPO_COMPROBANTE id)
        {
            switch (id)
            {
                case AFIP_TIPO_COMPROBANTE.TIQUE:  // - Tique
                    return ID_TIPO_COMPROBANTE.TIQUET;

                case AFIP_TIPO_COMPROBANTE.TIQUE_FACTURA_A:  // - Tique Factura A
                case AFIP_TIPO_COMPROBANTE.TIQUE_FACTURA_B:  // - Tique Factura B
                case AFIP_TIPO_COMPROBANTE.TIQUE_FACTURA_C:  // - Tique Factura C
                case AFIP_TIPO_COMPROBANTE.TIQUE_FACTURA_M:  // - Tique Factura M
                    return ID_TIPO_COMPROBANTE.TIQUE_FACTURA;

                case AFIP_TIPO_COMPROBANTE.DNFH_REMITO_R:  // - DNFH Remito 'R'
                    return ID_TIPO_COMPROBANTE.DNFH_VALORIZADO_REMITO_R;

                case AFIP_TIPO_COMPROBANTE.TIQUE_NOTA_DE_CREDITO:  // - Tique Nota de Crédito
                case AFIP_TIPO_COMPROBANTE.TIQUE_NOTA_DE_CREDITO_A:  // - Tique Nota de Crédito A
                case AFIP_TIPO_COMPROBANTE.TIQUE_NOTA_DE_CREDITO_B:  // - Tique Nota de Crédito B
                case AFIP_TIPO_COMPROBANTE.TIQUE_NOTA_DE_CREDITO_C:  // - Tique Nota de Crédito C
                case AFIP_TIPO_COMPROBANTE.TIQUE_NOTA_DE_CREDITO_M:  // - Tique Nota de Crédito M
                    return ID_TIPO_COMPROBANTE.TIQUE_NOTA_DE_CREDITO;

                case AFIP_TIPO_COMPROBANTE.TIQUE_NOTA_DE_DEBITO_A: // - Tique Nota de Débito A
                case AFIP_TIPO_COMPROBANTE.TIQUE_NOTA_DE_DEBITO_B: // - Tique Nota de Débito B
                case AFIP_TIPO_COMPROBANTE.TIQUE_NOTA_DE_DEBITO_C: // - Tique Nota de Débito C
                case AFIP_TIPO_COMPROBANTE.TIQUE_NOTA_DE_DEBITO_M: // - Tique Nota de Débito M
                    return ID_TIPO_COMPROBANTE.TIQUE_NOTA_DE_DEBITO;

                case AFIP_TIPO_COMPROBANTE.DNFH_REMITO_X: // - DNFH Remito 'X'
                    return ID_TIPO_COMPROBANTE.DNFH_VALORIZADO_REMITO_X;

                case AFIP_TIPO_COMPROBANTE.DNFH_RECIBO_X: // - DNFH Recibo 'X'
                    return ID_TIPO_COMPROBANTE.DNFH_VALORIZADO_RECIBO_X;

                case AFIP_TIPO_COMPROBANTE.DNFH_PRESUPUESTO_X: // - DNFH Presupuesto 'X'
                    return ID_TIPO_COMPROBANTE.DNFH_VALORIZADO_PRESUPUESTO_X;

                case AFIP_TIPO_COMPROBANTE.DNFH_COMPROBANTE_DONACION: // - DNFH Comprobante Donación
                    return ID_TIPO_COMPROBANTE.DNFH_VALORIZADO_DONACION;

                case AFIP_TIPO_COMPROBANTE.DNFH_DOCUMENTO_GENERICO:  // - DNFH Documento Generico 
                    return ID_TIPO_COMPROBANTE.DNFH_GENERIC;

                case AFIP_TIPO_COMPROBANTE.DNFH_DOCUMENTO_DE_USO_INTERNO: // - DNFH Documento de uso interno  
                    return ID_TIPO_COMPROBANTE.DNFH_INTERNAL_USE;

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
