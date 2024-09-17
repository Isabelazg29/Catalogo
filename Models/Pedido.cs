using System;
using System.Collections.Generic;

namespace Addventure.Models;

public partial class Pedido
{
    public int PedidoId { get; set; }

    public int? ClienteId { get; set; }

    public int? ProductoId { get; set; }

    public int Cantidad { get; set; }

    public DateOnly FechaPedido { get; set; }

    public virtual Cliente? Cliente { get; set; }

    public virtual Producto? Producto { get; set; }
}
