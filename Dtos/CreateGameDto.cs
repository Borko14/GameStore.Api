using System.ComponentModel.DataAnnotations;
using GameStore.Api.Models;

namespace GameStore.Api.Dtos;

public record CreateGameDto(
    [Required][StringLength(50)] string Name,
    [Range(1, 15)] int GenreId,
    [Range(1, 100)]decimal Price,
    DateOnly ReleaseDate
);