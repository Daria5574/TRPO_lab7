using System;
using System.Collections.Generic;

namespace TRPO_lab7.Models;

public partial class ArtOrder
{
    public int ArtOrderId { get; set; }

    public int ArtistId { get; set; }

    public string CustomerFullName { get; set; } = null!;

    public string CustomerPhone { get; set; } = null!;

    public string CustomerEmail { get; set; } = null!;

    public string? SocialMediaLink { get; set; }

    public string ArtworkDescription { get; set; } = null!;

    public string CanvasSize { get; set; } = null!;

    public string? AdditionalRequests { get; set; }

    public DateOnly? Deadline { get; set; }

    public virtual Artist Artist { get; set; } = null!;
}
