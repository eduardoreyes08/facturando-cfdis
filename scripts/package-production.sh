#!/usr/bin/env bash
set -euo pipefail

ROOT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
OUT_DIR="${1:-$ROOT_DIR/dist/production}"

rm -rf "$OUT_DIR"
mkdir -p "$OUT_DIR"

# Binarios requeridos de EDL
mkdir -p "$OUT_DIR/Assembly"
cp -R "$ROOT_DIR/Assembly"/* "$OUT_DIR/Assembly/"

# Documentación operativa mínima
mkdir -p "$OUT_DIR/docs"
cp "$ROOT_DIR/docs/api/ARQUITECTURA_API_EDL_PRODUCCION.md" "$OUT_DIR/docs/"
cp "$ROOT_DIR/docs/api/INSTALACION_Y_DESPLIEGUE_API.md" "$OUT_DIR/docs/"
cp "$ROOT_DIR/openapi/edl-api.yaml" "$OUT_DIR/docs/"

echo "Empaquetado productivo generado en: $OUT_DIR"
echo "Nota: Demos y archivos de ejemplo quedan excluidos de este artefacto."
