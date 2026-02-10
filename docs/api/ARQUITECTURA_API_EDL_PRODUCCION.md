# Arquitectura API EDL para producción

## 1. Respuesta corta a tu duda técnica

Sí, **puedes usar este mismo código base** y convertirlo a API productiva.

No es recomendable exponer los WinForms de `Demos/` en producción. Lo correcto es:

1. Crear un proyecto API nuevo dentro del mismo repositorio (por ejemplo `src/Edl.Api`).
2. Reutilizar la lógica funcional de los demos (timbrado, validación, status SAT, etc.) en servicios de aplicación.
3. Dejar `Demos/` solo como referencia de comportamiento mientras migras.
4. Excluir `Demos/` del despliegue productivo.

> En otras palabras: **sí reutilizas el código**, pero **no la forma de ejecución de demo**.

---

## 2. Qué sí sirve del repo actual y qué se elimina del runtime productivo

## 2.1 Se conserva y reutiliza

- `Assembly/HyperSoft.ElectronicDocumentLibrary.dll` y dependencias (`HyperSoft.Base.dll`, `Newtonsoft.Json.dll`, etc.).
- `Assembly/Adenda/*.dll` para addendas específicas.
- Estructuras de armado de datos que hoy están en `Demos/Data/*` (migrándolas a DTOs + mappers).

## 2.2 No se usa en runtime productivo

- Interfaces WinForms de `Demos/CSharp/*`.
- Datos hardcodeados de prueba (`RFC`, `UUID`, rutas de `.cer/.key`, contraseñas, etc.).
- Configuraciones de pruebas explícitas (`UseForTest`, desactivar validaciones de timbre en producción, etc.).

---

## 3. Diseño propuesto de solución API

Estructura recomendada:

- `src/Edl.Api` → Controllers HTTP.
- `src/Edl.Application` → Casos de uso (timbrar, validar, cancelar, etc.).
- `src/Edl.Infrastructure` → Integración EDL/PAC/SAT, filesystem, certificados.
- `src/Edl.Contracts` → Request/Response DTOs.
- `src/Edl.Domain` → Modelos internos y reglas.

Flujo típico:

`Controller -> ApplicationService -> EDL Adapter -> PAC/SAT -> Response DTO`

---

## 4. Catálogo de endpoints (alto nivel)

Base URL sugerida: `/api/v1`

1. Salud/diagnóstico
   - `GET /health`

2. Licencia
   - `POST /license/load`
   - `GET /license/status`
   - `GET /license/data`

3. CFDI
   - `POST /cfdi/stamp`
   - `POST /cfdi/cancel`
   - `GET /cfdi/cancel-receipt`
   - `GET /cfdi/{uuid}/xml`

4. Constancias de retenciones
   - `POST /retentions/stamp`

5. Complementos
   - `GET /complements`
   - `POST /cfdi/complements/{complementType}`

6. Addendas
   - `GET /addendas`
   - `POST /cfdi/addendas/{addendaType}`

7. Validación y lectura
   - `POST /xml/validate/cfdi`
   - `POST /xml/validate/retentions`
   - `POST /xml/parse/cfdi`

8. SAT status
   - `GET /sat/cfdi-status`

9. Código de barras
   - `POST /barcode/cfdi`
   - `POST /barcode/retentions`
   - `POST /barcode/carta-porte`

> Definición detallada en `openapi/edl-api.yaml`.

---

## 5. Mapeo endpoint -> referencia en código actual

- Timbrado/cancelación/descarga XML PAC:
  - `Demos/CSharp/01. ECodex/MainForm.cs`
- CFDI base / carga de datos:
  - `Demos/Data/Cfdi40.cs`
- Complementos:
  - `Demos/CSharp/10. Complementos/MainForm.cs`
  - `Demos/Data/Complemento/*.cs`
- Addendas:
  - `Demos/CSharp/09. Addendas/MainForm.cs`
- Retenciones:
  - `Demos/CSharp/13. Constancia de retenciones/MainForm.cs`
  - `Demos/Data/Constancia de retenciones/*.cs`
- Validación y lectura XML:
  - `Demos/CSharp/05. Validacion/MainForm.cs`
  - `Demos/Information/Cfdi/*.cs`
- Status SAT:
  - `Demos/CSharp/16. Status CFDI/Main Form.cs`
- Código de barras:
  - `Demos/CSharp/07. Codigo de barras bidimensional/MainForm.cs`
- Licencia:
  - `Demos/CSharp/17. Licencia/Main Form.cs`

---

## 6. Parámetros mínimos obligatorios por funcionalidad

## 6.1 Timbrar CFDI (`POST /cfdi/stamp`)

- `environment`: `test|production`
- `useHttps`: `true|false`
- `pac`: configuración de PAC (según proveedor)
- `certificate`: `cerBase64`, `keyBase64`, `keyPassword`
- `cfdi`: datos fiscales completos (comprobante, emisor, receptor, conceptos, impuestos)

Resultado:

- `uuid`
- `xmlStampedBase64`
- `pac` metadata (fecha timbrado, número certificado SAT, etc.)
- `errors[]` si aplica

## 6.2 Validar XML CFDI (`POST /xml/validate/cfdi`)

- `xmlBase64`
- `validateStamp`: `true|false`
- `validateSchemaMode`: `lite|full`

Resultado:

- `isValid`
- `validations[]`
- `summary`

## 6.3 Status SAT (`GET /sat/cfdi-status`)

- `rfcEmisor`
- `rfcReceptor`
- `uuid`
- `total`

Resultado:

- `status`: `Vigente|Cancelado|Desconocido`
- `cancelationType`
- `cancelationStatus`

---

## 7. Qué se “quita” realmente para producción

Para evitar riesgo operativo, se recomienda **no borrar `Demos/` inmediatamente**.

Hazlo en 2 fases:

1. **Fase migración**: mantener `Demos/` para comparación funcional.
2. **Fase hardening**: excluir `Demos/`, `Documentos/` no críticos y archivos de prueba del artefacto final.

Se incluye script de empaquetado productivo en `scripts/package-production.sh` para generar una carpeta de distribución sin demos.

---

## 8. Seguridad y operación

- Guardar certificados/contraseñas en vault (no en JSON plano en repositorio).
- Registrar `IdTransaccion` por operación.
- Trazabilidad de request/response (sin exponer datos sensibles).
- Reintentos controlados para errores de red con PAC/SAT.
- Normalizar catálogo de errores HTTP + errores PAC/SAT.

---

## 9. Plan de implementación sugerido (orden)

1. Endpoint `health` y `license/*`.
2. `cfdi/stamp`.
3. `xml/validate/cfdi` y `xml/parse/cfdi`.
4. `sat/cfdi-status`.
5. `cfdi/cancel`, `cfdi/cancel-receipt`, `cfdi/{uuid}/xml`.
6. `retentions/stamp`.
7. complementos/addendas.
8. barcode.

Con este orden puedes tener valor productivo rápido y después ampliar.

---

## 10. Implementación base ya creada en este repositorio

Se creó un proyecto funcional base en:

- `Edl.Api.sln`
- `src/Edl.Api/*`

Incluye:

- Controllers por dominio (`Health`, `License`, `Cfdi`, `Retentions`, `Complements`, `Addendas`, `Xml`, `Sat`, `Barcode`).
- DTOs de request/response en `Models/`.
- Servicio `IEdlService` + `MockEdlService` para pruebas locales inmediatas.
- Configuración `appsettings` y `launchSettings`.

Siguiente paso para producción real:

- Sustituir `MockEdlService` por implementación real EDL/PAC reutilizando la lógica de `Demos/`.

---

## 11. Cobertura contra demos (17 carpetas)

Cobertura API respecto a `Demos/CSharp`:

1. ECodex -> `cfdi/*`, `retentions/stamp`, `pac/*`
2. Pax -> `cfdi/*` (mismo contrato, cambiando provider)
3. CFDI 4.0 -> `cfdi/stamp`
4. CFDI 3.3 -> `cfdi/stamp` (payload versión 3.3)
5. Validación -> `xml/validate/*`, `xml/parse/cfdi`
6. Certificado -> `certificates/validate-csd`
7. Código de barras -> `barcode/*`
8. (demo interno no distribuido en este paquete)
9. Addendas -> `addendas`, `cfdi/addendas/{type}`
10. Complementos -> `complements`, `cfdi/complements/{type}`
11. Recibo nómina -> `cfdi/complements/nomina12`
12. Contabilidad electrónica -> `accounting/*`
13. Constancia retenciones -> `retentions/stamp`
14. Recibo de pago -> `cfdi/complements/reciboPago20`
15. Carta porte -> `cfdi/complements/cartaPorte31`, `barcode/carta-porte`
16. Status CFDI SAT -> `sat/cfdi-status`
17. Licencia -> `license/*`

Con esto queda documentado y expuesto el catálogo completo de funcionalidades del paquete demo.
