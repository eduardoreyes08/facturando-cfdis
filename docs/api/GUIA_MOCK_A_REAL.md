# Guía completa: quitar modo Mock y activar servicio real (sin errores de compilación)

## Error que reportaste

Si al cambiar a real te aparece:

`CS0246: El nombre del tipo o del espacio de nombres 'EdlRealService' no se encontró`

significa que `Program.cs` está intentando usar `EdlRealService`, pero esa clase no existía o no estaba en el namespace correcto.

## Estado actual del repo (ya corregido)

Ahora **sí existe**:

- `src/Edl.Api/Services/EdlRealService.cs`

y `Program.cs` ya está preparado para alternar por configuración:

- `EdlApi:UseMockMode=true` -> usa `MockEdlService`
- `EdlApi:UseMockMode=false` -> usa `EdlRealService`

## Pasos exactos para desactivar Mock

## 1) Cambiar configuración

En `src/Edl.Api/appsettings.Development.json` o `src/Edl.Api/appsettings.json`:

```json
{
  "EdlApi": {
    "UseMockMode": false,
    "EnvironmentDefault": "test"
  }
}
```

## 2) Ejecutar restore/build/run

```bash
dotnet restore Edl.Api.sln
dotnet build Edl.Api.sln -c Debug
dotnet run --project src/Edl.Api/Edl.Api.csproj
```

## 3) Validar qué modo está activo

- Arranca la API.
- Llama `GET /api/v1/health`.
- En bloque real 1, `cfdi/stamp` ya ejecuta lógica interna real de timbrado local (sin delegar al mock).

## 4) Migrar real endpoint por endpoint

`EdlRealService` ya compila y corre.
En este bloque, `cfdi/stamp`, `cfdi/cancel`, `cfdi/cancel-receipt`, `cfdi/{uuid}/xml`, `xml/validate/cfdi`, `xml/parse/cfdi` y `sat/cfdi-status` ya no delegan al mock.
Siguiente paso: conectar PAC/SAT/EDL nativos para timbrado fiscal oficial.

Orden sugerido:

1. `license/*`
2. `cfdi/stamp`
3. `sat/cfdi-status`
4. `xml/validate/cfdi`
5. `cfdi/cancel` y descarga XML
6. complementos/addendas
7. contabilidad/certificados/barcode

## 5) Checklist rápido de errores frecuentes

- **CS0246 EdlRealService**: verificar que exista `src/Edl.Api/Services/EdlRealService.cs` y namespace `Edl.Api.Services`.
- **DI/arranque falla**: confirmar que `Program.cs` registre `MockEdlService`, `EdlRealService` y `IEdlService` por factory.
- **No cambia de modo**: revisar `EdlApi:UseMockMode` en el archivo de configuración activo (`Development` vs `Production`).
- **Timbra pero no aparece en PAC/SAT**: en bloque real 1 el timbrado es local interno; para timbrado fiscal oficial debes conectar PAC/EDL nativo.

## Referencia de implementación real por demos

- PAC/timbrado/cancelación/descarga: `Demos/CSharp/01. ECodex/MainForm.cs`
- Validación XML: `Demos/CSharp/05. Validacion/MainForm.cs`
- Barcode: `Demos/CSharp/07. Codigo de barras bidimensional/MainForm.cs`
- Addendas: `Demos/CSharp/09. Addendas/MainForm.cs`
- Complementos: `Demos/CSharp/10. Complementos/MainForm.cs`
- Contabilidad: `Demos/CSharp/12. Contabilidad electronica/Main Form.cs`
- Retenciones: `Demos/CSharp/13. Constancia de retenciones/MainForm.cs`
- Recibo pago: `Demos/CSharp/14. Recibo de pago/MainForm.cs`
- Carta porte: `Demos/CSharp/15. Carta Porte/MainForm.cs`
- Status SAT: `Demos/CSharp/16. Status CFDI/Main Form.cs`
- Licencia: `Demos/CSharp/17. Licencia/Main Form.cs`

## Qué ya está en lógica real (bloque 1)

Con `UseMockMode=false`, actualmente ejecuta lógica real interna en:

- `POST /api/v1/cfdi/stamp`
- `POST /api/v1/cfdi/cancel`
- `GET /api/v1/cfdi/cancel-receipt`
- `GET /api/v1/cfdi/{uuid}/xml`
- `POST /api/v1/xml/validate/cfdi`
- `POST /api/v1/xml/parse/cfdi`
- `GET /api/v1/sat/cfdi-status`

Importante: este bloque no timbra ante PAC/SAT externo todavía; usa almacenamiento local en memoria para pruebas funcionales end-to-end.

## Qué se agregó en bloque 2

Además del bloque 1, ahora `EdlRealService` incorpora lógica real interna adicional en:

- `POST /api/v1/retentions/stamp` (validación de campos + XML de retenciones)
- `POST /api/v1/xml/validate/retentions` (valida base64 + XML + raíz `retenciones`)
- `POST /api/v1/certificates/validate-csd` (lee `.cer` real desde base64 y extrae serie/vigencia)
- `GET /api/v1/pac/account-status` (disponibilidad de timbres calculada con emitidos locales)
- `POST /api/v1/accounting/*` (genera XML con rfc/año/mes/hash de payload)
- `POST /api/v1/cfdi/complements/{type}` y `POST /api/v1/cfdi/addendas/{type}` (aplicación validada + hash trazable)

Importante: sigue siendo implementación local interna (no PAC/SAT fiscal oficial todavía).
