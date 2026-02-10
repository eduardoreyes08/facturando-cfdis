# Guía rápida: pasar de modo Mock a servicio real EDL/PAC

## Estado actual

- La API funciona con `MockEdlService` para validar contrato y flujo local rápido.
- Registro actual en DI:
  - `builder.Services.AddSingleton<IEdlService, MockEdlService>();`

## Paso a paso para activar servicio real

1. Crear `src/Edl.Api/Services/EdlRealService.cs` implementando `IEdlService`.
2. Migrar lógica desde demos:
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
3. Inyectar configuración PAC/CSD/licencia en `appsettings.*` o variables de entorno.
4. Cambiar DI en `Program.cs`:
   - de `MockEdlService` a `EdlRealService`.
5. Probar endpoint por endpoint con los JSON de `tests/http/endpoints/`.

## Cambio mínimo en Program.cs

```csharp
builder.Services.AddSingleton<IEdlService, EdlRealService>();
```

## Recomendación de transición segura

- Mantener ambos servicios:
  - `MockEdlService`
  - `EdlRealService`
- Elegir implementación por config:
  - `EdlApi:UseMockMode=true|false`

## Riesgos a vigilar al pasar a real

- Certificados y contraseña inválidos.
- Licencia no cargada o vencida.
- Diferencias de hora local vs PAC/SAT.
- Configuración de entorno (test/prod) y puertos HTTPS.
