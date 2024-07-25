using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClearArchitecture.Domain.Abstractions;
using ClearArchitecture.Domain.Shared;

namespace ClearArchitecture.Domain.Vehiculos;

//Modelo enriquecido
public sealed class Vehiculo : Entity
{
  public Vehiculo(
Guid id,
Modelo modelo,
Vin vin,
Moneda precio,
Moneda mantenimiento,
DateTime? fechaUltimaAlquiler,
List<Accesorio> accesorios,
Direccion? direccion
) : base(id)
  {
    Modelo = modelo;
    Vin = vin;
    Precio = precio;
    Mantenimiento = mantenimiento;
    FechaUltimaAlquiler = fechaUltimaAlquiler;
    Accesorios = accesorios;
    Direccion = direccion;
  }

  public Modelo? Modelo { get; private set; }
  public Vin? Vin { get; private set; }
  public Direccion? Direccion { get; private set; }
  public Moneda? Precio { get; private set; }
  public Moneda? Mantenimiento { get; private set; }
  public DateTime? FechaUltimaAlquiler { get; internal set; }
  public List<Accesorio> Accesorios { get; private set; } = new List<Accesorio>();

}
