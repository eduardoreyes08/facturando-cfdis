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
- En modo real base, verás logs de advertencia en operaciones como `cfdi/stamp` indicando delegación temporal.

## 4) Migrar real endpoint por endpoint

`EdlRealService` ya compila y corre; el siguiente paso es reemplazar cada delegación al mock por integración real EDL.

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
- **Compila pero no timbra real**: normal por ahora; `EdlRealService` base delega al mock hasta completar integración EDL/PAC.

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
