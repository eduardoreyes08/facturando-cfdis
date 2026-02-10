# Catálogo completo de endpoints (descripción + ejemplo)

Este catálogo cubre **todas las funcionalidades de los demos**:
- PAC/timbrado/cancelación/descarga/fecha/estado de cuenta (ECodex/Pax)
- CFDI 3.3/4.0
- Validación/lectura XML
- Certificados
- Código de barras
- Addendas
- Complementos
- Nómina/Recibo de pago/Carta Porte (vía complementos)
- Contabilidad electrónica
- Constancia de retenciones
- Status SAT
- Licencia

Base URL: `http://localhost:5071/api/v1`

## 1) Salud y licencia

### GET `/health`
**Para qué sirve:** verificar que la API está viva.
```bash
curl -s http://localhost:5071/api/v1/health
```

### POST `/license/load`
**Para qué sirve:** cargar licencia EDL en memoria.
```bash
curl -s -X POST http://localhost:5071/api/v1/license/load -H 'Content-Type: application/json' -d @tests/http/endpoints/license-load.json
```

### GET `/license/status`
**Para qué sirve:** consultar estatus de licencia.
```bash
curl -s http://localhost:5071/api/v1/license/status
```

### GET `/license/data`
**Para qué sirve:** obtener metadatos de la licencia cargada.
```bash
curl -s http://localhost:5071/api/v1/license/data
```

## 2) CFDI y PAC

### POST `/cfdi/stamp`
**Para qué sirve:** generar y timbrar CFDI (4.0/3.3 según payload).
```bash
curl -s -X POST http://localhost:5071/api/v1/cfdi/stamp -H 'Content-Type: application/json' -d @tests/http/endpoints/cfdi-stamp.json
```

### POST `/cfdi/cancel`
**Para qué sirve:** solicitar cancelación CFDI.
```bash
curl -s -X POST http://localhost:5071/api/v1/cfdi/cancel -H 'Content-Type: application/json' -d @tests/http/endpoints/cfdi-cancel.json
```

### GET `/cfdi/cancel-receipt`
**Para qué sirve:** recuperar acuse de cancelación.
```bash
curl -s "http://localhost:5071/api/v1/cfdi/cancel-receipt?rfcEmisor=EKU9003173C9&uuid=123E4567-E89B-12D3-A456-426614174000"
```

### GET `/cfdi/{uuid}/xml`
**Para qué sirve:** descargar XML timbrado desde PAC.
```bash
curl -s "http://localhost:5071/api/v1/cfdi/123E4567-E89B-12D3-A456-426614174000/xml?rfcEmisor=EKU9003173C9"
```

### GET `/pac/time`
**Para qué sirve:** consultar hora del PAC.
```bash
curl -s "http://localhost:5071/api/v1/pac/time?provider=ecodex"
```

### GET `/pac/account-status`
**Para qué sirve:** consultar estado de cuenta/timbres con el PAC.
```bash
curl -s "http://localhost:5071/api/v1/pac/account-status?provider=ecodex&rfc=EKU9003173C9"
```

## 3) Retenciones

### POST `/retentions/stamp`
**Para qué sirve:** generar y timbrar constancia de retenciones.
```bash
curl -s -X POST http://localhost:5071/api/v1/retentions/stamp -H 'Content-Type: application/json' -d @tests/http/endpoints/retentions-stamp.json
```

## 4) Complementos y addendas

### GET `/complements`
**Para qué sirve:** listar complementos soportados.
```bash
curl -s http://localhost:5071/api/v1/complements
```

### POST `/cfdi/complements/{complementType}`
**Para qué sirve:** aplicar complemento (nómina, pago, carta porte, comercio exterior, etc.).
```bash
curl -s -X POST http://localhost:5071/api/v1/cfdi/complements/nomina12 -H 'Content-Type: application/json' -d @tests/http/endpoints/complement-apply.json
```

### GET `/addendas`
**Para qué sirve:** listar addendas soportadas.
```bash
curl -s http://localhost:5071/api/v1/addendas
```

### POST `/cfdi/addendas/{addendaType}`
**Para qué sirve:** aplicar addenda comercial al CFDI.
```bash
curl -s -X POST http://localhost:5071/api/v1/cfdi/addendas/walmart -H 'Content-Type: application/json' -d @tests/http/endpoints/addenda-apply.json
```

## 5) XML validación/lectura

### POST `/xml/validate/cfdi`
**Para qué sirve:** validar XML CFDI (estructura/timbre según opciones).
```bash
curl -s -X POST http://localhost:5071/api/v1/xml/validate/cfdi -H 'Content-Type: application/json' -d @tests/http/endpoints/xml-validate-cfdi.json
```

### POST `/xml/validate/retentions`
**Para qué sirve:** validar XML de retenciones.
```bash
curl -s -X POST http://localhost:5071/api/v1/xml/validate/retentions -H 'Content-Type: application/json' -d @tests/http/endpoints/xml-validate-retentions.json
```

### POST `/xml/parse/cfdi`
**Para qué sirve:** extraer información del CFDI XML.
```bash
curl -s -X POST http://localhost:5071/api/v1/xml/parse/cfdi -H 'Content-Type: application/json' -d @tests/http/endpoints/xml-parse-cfdi.json
```

## 6) SAT

### GET `/sat/cfdi-status`
**Para qué sirve:** consultar vigencia/cancelación del UUID ante SAT.
```bash
curl -s "http://localhost:5071/api/v1/sat/cfdi-status?rfcEmisor=EKU9003173C9&rfcReceptor=AAAD770905441&uuid=123E4567-E89B-12D3-A456-426614174000&total=100.00"
```

## 7) Código de barras

### POST `/barcode/cfdi`
**Para qué sirve:** generar QR/cadena para representación impresa CFDI.
```bash
curl -s -X POST http://localhost:5071/api/v1/barcode/cfdi -H 'Content-Type: application/json' -d @tests/http/endpoints/barcode-cfdi.json
```

### POST `/barcode/retentions`
**Para qué sirve:** generar QR/cadena para retenciones.
```bash
curl -s -X POST http://localhost:5071/api/v1/barcode/retentions -H 'Content-Type: application/json' -d @tests/http/endpoints/barcode-retentions.json
```

### POST `/barcode/carta-porte`
**Para qué sirve:** generar QR/cadena de Carta Porte.
```bash
curl -s -X POST http://localhost:5071/api/v1/barcode/carta-porte -H 'Content-Type: application/json' -d @tests/http/endpoints/barcode-carta-porte.json
```

## 8) Certificados

### POST `/certificates/validate-csd`
**Para qué sirve:** validar CSD y mostrar metadatos (RFC, vigencia, serie).
```bash
curl -s -X POST http://localhost:5071/api/v1/certificates/validate-csd -H 'Content-Type: application/json' -d @tests/http/endpoints/certificate-validate.json
```

## 9) Contabilidad electrónica

### POST `/accounting/catalog`
**Para qué sirve:** generar XML catálogo de cuentas.
```bash
curl -s -X POST http://localhost:5071/api/v1/accounting/catalog -H 'Content-Type: application/json' -d @tests/http/endpoints/accounting-base.json
```

### POST `/accounting/trial-balance`
**Para qué sirve:** generar XML balanza.
```bash
curl -s -X POST http://localhost:5071/api/v1/accounting/trial-balance -H 'Content-Type: application/json' -d @tests/http/endpoints/accounting-base.json
```

### POST `/accounting/policy`
**Para qué sirve:** generar XML póliza.
```bash
curl -s -X POST http://localhost:5071/api/v1/accounting/policy -H 'Content-Type: application/json' -d @tests/http/endpoints/accounting-base.json
```

### POST `/accounting/aux-accounts`
**Para qué sirve:** generar XML auxiliar de cuentas.
```bash
curl -s -X POST http://localhost:5071/api/v1/accounting/aux-accounts -H 'Content-Type: application/json' -d @tests/http/endpoints/accounting-base.json
```

### POST `/accounting/aux-folios`
**Para qué sirve:** generar XML auxiliar de folios.
```bash
curl -s -X POST http://localhost:5071/api/v1/accounting/aux-folios -H 'Content-Type: application/json' -d @tests/http/endpoints/accounting-base.json
```
