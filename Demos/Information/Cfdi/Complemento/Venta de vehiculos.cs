using HyperSoft.Base;


namespace HyperSoft.Ejemplo.Information.Complemento
{
  internal static class VentaVehiculos
  {
    internal static void Show(int concepto, ObjectBase value)
    {
      HyperSoft.ElectronicDocumentLibrary.Complemento.VentaVehiculos.Data data =
        (HyperSoft.ElectronicDocumentLibrary.Complemento.VentaVehiculos.Data) value;

      Utils.ShowTitle($"CONCEPTO {concepto} / COMPLEMENTO VENTA DE VEHICULOS");
      Utils.ShowField("Versión        ", data.Version);
      Utils.ShowField("Clave vehicular", data.ClaveVehicular);
      Utils.ShowField("Niv            ", data.Niv);

      for (int i = 0; i < data.InformacionAduanera.Count; i++)
      {
        Utils.ShowTitle($"CONCEPTO {concepto} / VENTA DE VEHICULOS / INFORMACION ADUANERA {i + 1}");
        Utils.ShowField("Número", data.InformacionAduanera[i].Numero);
        Utils.ShowField("Fecha ", data.InformacionAduanera[i].Fecha);
        Utils.ShowField("Aduana", data.InformacionAduanera[i].Aduana);
      }

      for (int i = 0; i < data.Partes.Count; i++)
      {
        string title = $"CONCEPTO {concepto} / VENTA DE VEHICULOS / PARTE {i + 1}";
        Utils.ShowTitle(title);

        HyperSoft.ElectronicDocumentLibrary.Complemento.VentaVehiculos.Partida partida = data.Partes[i];
        
        Utils.ShowField("Cantidad                ", partida.Cantidad);
        Utils.ShowField("Unidad                  ", partida.Unidad);
        Utils.ShowField("Descripción             ", partida.Descripcion);
        Utils.ShowField("Número de identificación", partida.NumeroIdentificacion);
        Utils.ShowField("Valor unitario          ", partida.ValorUnitario);
        Utils.ShowField("Importe                 ", partida.Importe);

        for (int j = 0; j < partida.InformacionAduanera.Count; j++)
        {
          Utils.ShowTitle($"{title} / INFORMACION ADUANERA {j + 1}");
          Utils.ShowField("Número", partida.InformacionAduanera[j].Numero);
          Utils.ShowField("Fecha ", partida.InformacionAduanera[j].Fecha);
          Utils.ShowField("Aduana", partida.InformacionAduanera[j].Aduana);
        }
      }
    }
  }
}
