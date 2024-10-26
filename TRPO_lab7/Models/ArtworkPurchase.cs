using System;
using System.Collections.Generic;

namespace TRPO_lab7.Models;

public partial class ArtworkPurchase
{
    public int AtworkPurchaseId { get; set; }

    public int ArtworkId { get; set; }

    public string DeliveryAddress { get; set; } = null!;

    public string CustomerFullName { get; set; } = null!;

    public string CustomerPhone { get; set; } = null!;

    public DateOnly OrderDate { get; set; }

    public virtual Artwork Artwork { get; set; } = null!;
}
