using System.ComponentModel.DataAnnotations;

namespace FirstAPI.Data.Dtos;

public class ReadFilmeDto
{
    //DataTransferObject (DTO)

    public string Titulo { get; set; }
    public string Genero { get; set; }
    public int Duracao { get; set; }

    public DateTime HoraDaConsulta { get; set; } = DateTime.Now;
}
