using System;
using System.Collections.Generic;

namespace TRPO_lab7.Models;

public partial class Review
{
    public int ReviewId { get; set; }

    public int ArtistId { get; set; }

    public string ReviewText { get; set; } = null!;

    public string ReviewerName { get; set; } = null!;

    public DateOnly SubmissionDate { get; set; }

    public virtual Artist Artist { get; set; } = null!;
}
