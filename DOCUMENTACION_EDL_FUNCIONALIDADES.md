# Guía de viabilidad e implementación de funcionalidades EDL (Facturando)

## 1) Resumen ejecutivo

Sí, **con este código sí puedes implementar** las funcionalidades que listaste, porque el repositorio ya trae demos y clases de datos para cada caso (CFDI/timbrado, complementos, retenciones, addendas, código de barras, validación, status SAT y lectura de XML). El trabajo principal es:

1. Parametrizar credenciales/licencia y ambiente (pruebas/producción).
2. Reemplazar datos de ejemplo por datos reales de negocio.
3. Convertir los ejemplos WinForms en servicios/procesos de tu solución.

## 2) ¿Qué se necesita para ejecutar EDL?

## 2.1 Requisitos técnicos mínimos

- .NET Framework 4.8 en demos C#. (`supportedRuntime` en todos los `app.config`).
- DLL de EDL y proyectos `Demos/*` como referencia de integración.
- Certificado CSD (`.cer`), llave privada (`.key`) y contraseña para firmado.
- Licencia de EDL cargada y con estado válido.

## 2.2 Insumos funcionales/fiscales

- Datos de emisor: RFC, régimen, nombre, CSD.
- Datos de receptor: RFC, uso CFDI, domicilio fiscal, régimen (según versión/tipo).
- Datos del comprobante: serie, folio, fecha, moneda, subtotal/total, impuestos, exportación, etc.
- Datos PAC: entorno (`Test`/`Production`), HTTPS, token/parámetros del proveedor.
- Catálogos SAT vigentes (claves producto, unidad, impuestos, método, forma de pago, etc.).

## 2.3 Parámetros de ejecución más importantes (timbrado)

En el flujo de timbrado del demo ECodex se cargan explícitamente estos parámetros:

- `ElectronicDocument` o `ConstanciaRetenciones`.
- `Informacion` (respuesta del PAC).
- `Rfc` (del emisor).
- `IdTransaccion`.
- `TestMode`.
- `Enviroment`.
- `UseHttps`.

Además, se usa certificado + `ElectronicManage` para firmado y validaciones.

## 3) Mapa de funcionalidades solicitadas → archivos clave

## 3.1 Generar y timbrar CFDI (factura, pago, nómina, etc.)

**Sí se puede.**

- Flujo de timbrado PAC (ECodex): `Demos/CSharp/01. ECodex/MainForm.cs`.
- Timbrado de CFDI y ejemplos de tipo de comprobante/complemento en el mismo flujo (factura, recibo de pago, nómina, carta porte/comercio exterior en comentarios listos para activar): `Demos/CSharp/01. ECodex/MainForm.cs`.
- Carga de datos CFDI 4.0: `Demos/Data/Cfdi40.cs`.
- Demo específico CFDI 4.0: `Demos/CSharp/03. CFDI 4.0/MainForm.cs`.
- Demo específico CFDI 3.3: `Demos/CSharp/04. CFDI 3.3/MainForm.cs`.
- Recibo de nómina 1.2: `Demos/CSharp/11. Recibo de nomina/MainForm.cs` + `Demos/Data/Complemento/Nomina12.cs`.
- Recibo de pago 2.0: `Demos/CSharp/14. Recibo de pago/MainForm.cs` + `Demos/Data/Complemento/ReciboPago20.cs`.

### Parámetros/datos requeridos para esta actividad

- Certificado (`.cer`), llave (`.key`) y contraseña.
- RFC emisor (para timbrado y PAC).
- Estructura fiscal completa del CFDI (comprobante, emisor/receptor, conceptos, impuestos, complementos).
- Ambiente de timbrado y transporte HTTPS.
- Licencia activa.

## 3.2 Generar cualquier tipo de complemento

**Sí se puede** (el demo incluye múltiples complementos y clases de datos especializadas).

- Selector y ejecución de complementos: `Demos/CSharp/10. Complementos/MainForm.cs`.
- Clases de datos por complemento: `Demos/Data/Complemento/*.cs`.
- Incluye ejemplos de Comercio Exterior, INE, Impuestos Locales, Donatarias, Hidrocarburos, Carta Porte, etc.

### Parámetros/datos requeridos

- Base CFDI válida.
- Datos propios del complemento elegido (cada archivo en `Demos/Data/Complemento/` indica los nodos/atributos requeridos).
- Catálogos SAT de ese complemento.

## 3.3 Emitir constancias de retenciones

**Sí se puede.**

- Timbrado de constancia en PAC: `Demos/CSharp/01. ECodex/MainForm.cs` (`TimbrarConstanciaRetenciones`).
- Demo dedicado: `Demos/CSharp/13. Constancia de retenciones/MainForm.cs`.
- Datos de retenciones 2.0: `Demos/Data/Constancia de retenciones/ConstanciaRetenciones20.cs`.
- Complementos de retenciones: `Demos/Data/Constancia de retenciones/Complemento/*.cs`.

### Parámetros/datos requeridos

- Datos de emisor/receptor (nacional o extranjero), periodo, montos gravados/exentos/retenidos.
- Clave/descrición del concepto de retención.
- UUID relacionado si aplica.

## 3.4 Integrar más de 60 addendas

**Sí se puede** y en este repositorio el demo ya trae **63 addendas** en diccionario.

- Demo de addendas + listado: `Demos/CSharp/09. Addendas/MainForm.cs`.
- Ejemplo de agregar addenda a XML existente: mismo archivo (`btnXmlAddenda_Click`).

### Parámetros/datos requeridos

- CFDI base correctamente generado.
- Datos comerciales específicos de la addenda destino (cada cliente/cadena define su estructura).

## 3.5 Generar código de barras para PDF

**Sí se puede.**

- Demo de código de barras 2D: `Demos/CSharp/07. Codigo de barras bidimensional/MainForm.cs`.
- Métodos disponibles:
  - `GenerateCfdi(...)`
  - `GenerateConstancia(...)`
  - `GenerateCartaPorte(...)`
  - `Calculate...(...)` para la cadena codificada

### Parámetros/datos requeridos

- CFDI: RFC emisor, RFC receptor, total, UUID, sello (según versión).
- Constancia: emisor, receptor, total, UUID, sello (según versión).
- Carta porte: UUID, fecha origen y fecha timbrado.

## 3.6 Validar archivos XML (CFDI)

**Sí se puede.**

- Demo de validación/carga: `Demos/CSharp/05. Validacion/MainForm.cs`.
- Carga de CFDI desde archivo y despliegue de contenido/validación: `ValidarComprobante(...)`.
- También valida contabilidad electrónica y constancias.

### Parámetros/datos requeridos

- Ruta de XML.
- Configuración de `LoadOptions`/`SaveOptions` en `ElectronicManage` según entorno.
- En producción, activar validaciones completas y certificados reales.

## 3.7 Verificar UUID en SAT y conocer estatus

**Sí se puede.**

- Consulta directa SAT: `Demos/CSharp/16. Status CFDI/Main Form.cs`.
- Datos requeridos por parámetro:
  - `RfcEmisor`
  - `RfcReceptor`
  - `Uuid`
  - `Total`
- Respuesta modela: vigente/cancelado + forma de cancelación + status de cancelación.

## 3.8 Leer y extraer información de CFDI XML

**Sí se puede.**

- Carga XML CFDI: `Demos/CSharp/05. Validacion/MainForm.cs` (`LoadFromFile`).
- Extracción y despliegue de campos CFDI/complementos: `Demos/Information/Cfdi/Cfdi.cs` y `Demos/Information/Cfdi/Complemento/*.cs`.
- Utilidades de presentación: `Demos/Information/Utils.cs`.

### Parámetros/datos requeridos

- Ruta del XML.
- Objeto `ElectronicDocument` inicializado y asociado a `ElectronicManage`.
- Opciones de carga/validación según si es test o producción.

## 4) Flujo recomendado para llevarlo a producción

1. **Licencia**: implementar carga y validación de estado antes de cualquier operación fiscal.
2. **Inicialización de librería**: centralizar `Configuration.Library()` + creación de `ElectronicManage`.
3. **Firma**: cargar CSD desde vault/secret manager (no hardcodear ruta/contraseña).
4. **Construcción de XML**: mover lógica de `Demos/Data/*` a servicios de dominio propios.
5. **Timbrado/cancelación/status**: encapsular llamadas PAC/SAT en capa de integración.
6. **Validación y auditoría**: guardar request/response, UUID, folio fiscal, acuses, errores de PAC/SAT.
7. **Observabilidad**: bitácoras técnicas y de negocio por transacción (`IdTransaccion`).

## 5) Riesgos y consideraciones importantes

- En demos hay líneas “solo pruebas” (`UseForTest`, desactivar validación de timbre, etc.) que **deben retirarse en producción**.
- Los datos de ejemplo (RFC, CSD, montos) no son datos productivos.
- La estructura exacta de cada complemento/addenda depende de su versión y lineamientos SAT/cliente.
- Para `Status CFDI`, el valor `Total` debe coincidir con precisión fiscal para evitar falsos “no encontrado”.

## 6) Archivos que debes revisar primero (shortlist)

1. `Leeme.txt` (visión general de EDL).
2. `Demos/CSharp/01. ECodex/MainForm.cs` (timbrado/cancelación/descarga con PAC).
3. `Demos/CSharp/03. CFDI 4.0/MainForm.cs` y `Demos/Data/Cfdi40.cs` (estructura CFDI).
4. `Demos/CSharp/10. Complementos/MainForm.cs` + `Demos/Data/Complemento/*`.
5. `Demos/CSharp/13. Constancia de retenciones/MainForm.cs` + `Demos/Data/Constancia de retenciones/*`.
6. `Demos/CSharp/09. Addendas/MainForm.cs`.
7. `Demos/CSharp/07. Codigo de barras bidimensional/MainForm.cs`.
8. `Demos/CSharp/05. Validacion/MainForm.cs` + `Demos/Information/*`.
9. `Demos/CSharp/16. Status CFDI/Main Form.cs`.
10. `Demos/CSharp/17. Licencia/Main Form.cs`.

## 7) Referencias externas que mencionaste

- Blog activación Facturando: https://www.facturando.mx/blog/index.php/category/activacion/
- Portal desarrolladores: https://facturando.mx/factura-electronica-desarrolladores.php

Usa esas ligas para alinear la configuración final del PAC, activación/licencia y cambios regulatorios vigentes.
