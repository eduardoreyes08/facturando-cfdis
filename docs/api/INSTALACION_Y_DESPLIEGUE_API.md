# Instalación y despliegue paso a paso (API EDL)

## 1) Prerrequisitos

1. Windows Server o Linux compatible con tu runtime .NET elegido.
2. Runtime SDK de .NET (recomendado .NET 8 para API nueva).
3. Certificados CSD válidos (`.cer`, `.key`) y contraseña.
4. Licencia EDL activa.
5. Acceso de red a PAC/SAT y puertos permitidos.
6. DLLs de `Assembly/` incluidas en publicación.

---

## 2) Estructura mínima esperada para producción

- `app/Edl.Api` (binarios de la API)
- `app/Assembly` (DLL EDL y dependencias)
- `app/config` (`appsettings.Production.json`, secretos por variable/vault)
- `app/logs`

---

## 3) Variables de configuración recomendadas

- `EDL_ENVIRONMENT=test|production`
- `EDL_USE_HTTPS=true`
- `EDL_PAC_PROVIDER=ecodex|pax|otro`
- `EDL_PAC_BASE_URL=...`
- `EDL_PAC_USER=...` (si aplica)
- `EDL_PAC_PASSWORD=...` (si aplica)
- `EDL_STORAGE_XML_PATH=...`
- `EDL_LICENSE_PATH=...` o `EDL_LICENSE_BASE64`
- `EDL_CERT_PROVIDER=vault|filesystem`

---

## 4) Arranque inicial

1. Cargar licencia con `POST /api/v1/license/load`.
2. Verificar con `GET /api/v1/license/status`.
3. Ejecutar timbrado de prueba `POST /api/v1/cfdi/stamp` en entorno `test`.
4. Validar XML resultante con `POST /api/v1/xml/validate/cfdi`.
5. Consultar SAT con `GET /api/v1/sat/cfdi-status`.

---

## 5) Checklist de salida a producción

- [ ] Sin datos de prueba hardcodeados.
- [ ] Sin llamadas `UseForTest` en runtime productivo.
- [ ] Manejo de secretos en vault.
- [ ] HTTPS forzado.
- [ ] Logs con trazabilidad (`IdTransaccion`, `uuid`) y enmascarado de datos sensibles.
- [ ] Monitoreo de disponibilidad y latencia (`/health`).
- [ ] Respaldos de XML timbrados/cancelados/acuse.

---

## 6) Estrategia para retirar demos

1. Migrar funcionalidad endpoint por endpoint.
2. Validar equivalencia de salida (demo vs API).
3. Generar artefacto productivo con `scripts/package-production.sh`.
4. Solo después de validar, archivar o remover `Demos/` del proceso de build/deploy.


---

## 7) Comandos para correr local

```bash
dotnet --info
dotnet restore Edl.Api.sln
dotnet build Edl.Api.sln -c Debug
dotnet run --project src/Edl.Api/Edl.Api.csproj
```

Para pruebas rápidas de endpoints:

- `docs/api/PROBAR_ENDPOINTS_LOCAL.md`
- `tests/http/stamp-cfdi.json`

Documentación clave adicional:

- `docs/api/ENDPOINTS_DESCRIPCION_Y_EJEMPLOS.md`
- `docs/api/GUIA_MOCK_A_REAL.md`

---

## 8) Qué necesitas para pasar de bloque real local a timbrado fiscal oficial

Además de activar `UseMockMode=false`, para timbrado oficial PAC/SAT debes tener:

1. Credenciales PAC reales (usuario/password/token, URL y ambiente).
2. CSD del emisor real (`.cer`, `.key`, password).
3. Licencia EDL vigente.
4. Conectividad de red al PAC/SAT (TLS/puertos permitidos).
5. Integración de EDL nativa dentro de `EdlRealService` (reemplazar bloque local interno).

Ubicación recomendada de archivos sensibles en servidor:

- `app/config/secrets/` (si usas filesystem)
  - `license.bin`
  - `csd/<RFC>.cer`
  - `csd/<RFC>.key`
- o usar vault/KMS y no almacenar en disco.
