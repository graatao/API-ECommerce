using System;
using System.Collections.Generic;

namespace API_ECommerce.Models;

public partial class Cliente
{
    public Cliente(object nome)
    {
        Nome = nome;
    }

    public int IdCliente { get; set; }

    public string? NomeCompleto { get; set; }

    public string? Email { get; set; }

    public string? Telefone { get; set; }

    public string? Endereco { get; set; }

    public DateOnly? DataCadastro { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
    public object Nome { get; internal set; }
    public string Senha { get; internal set; }
}
