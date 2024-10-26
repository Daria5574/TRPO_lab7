using System;
using System.Collections.Generic;

namespace TRPO_lab7.Models;

public partial class PortfolioArtwork
{
    public int PortfolioArtworkId { get; set; }

    public int ArtistId { get; set; }

    public string ArtworkUrl { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string? CanvasSize { get; set; }

    public string? Description { get; set; }

    public virtual Artist Artist { get; set; } = null!;
}
