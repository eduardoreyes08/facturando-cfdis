# Probar endpoints en local (rápido)

## 1) Levantar API

```bash
cd src/Edl.Api
dotnet restore
dotnet run
```

Swagger:
- http://localhost:5071/swagger
- https://localhost:7071/swagger

## 2) Pruebas rápidas con curl

### Health
```bash
curl -s http://localhost:5071/api/v1/health
```

### Licencia
```bash
curl -s -X POST http://localhost:5071/api/v1/license/load \
  -H 'Content-Type: application/json' \
  -d '{"licenseBase64":"TElDRU5TRV9NT0NL"}'
```

### Timbrar CFDI
```bash
curl -s -X POST http://localhost:5071/api/v1/cfdi/stamp \
  -H 'Content-Type: application/json' \
  -d @../../tests/http/stamp-cfdi.json
```

### Status SAT
```bash
curl -s "http://localhost:5071/api/v1/sat/cfdi-status?rfcEmisor=EKU9003173C9&rfcReceptor=AAAD770905441&uuid=123e4567-e89b-12d3-a456-426614174000&total=100.00"
```

## 3) Nota

Actualmente el servicio está en **modo mock** (`UseMockMode=true`) para que puedas validar todos los endpoints inmediatamente.
Luego puedes reemplazar `MockEdlService` por implementación real EDL/PAC en `Services`.
