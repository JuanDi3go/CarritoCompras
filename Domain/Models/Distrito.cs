namespace Domain.Models;

public partial class Distrito
{
    public string Id { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string IdDepartamento { get; set; } = null!;

    public string IdProvincia { get; set; } = null!;
}
