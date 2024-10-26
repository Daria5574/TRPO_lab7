using System;
using System.Collections.Generic;

namespace TRPO_lab7.Models;

public partial class Artist
{
    public int ArtistId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? Biography { get; set; }

    public string? Telegram { get; set; }

    public string? Vk { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public virtual ICollection<ArtOrder> ArtOrders { get; set; } = new List<ArtOrder>();

    public virtual ICollection<Artwork> Artworks { get; set; } = new List<Artwork>();

    public virtual ICollection<PortfolioArtwork> PortfolioArtworks { get; set; } = new List<PortfolioArtwork>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
}
