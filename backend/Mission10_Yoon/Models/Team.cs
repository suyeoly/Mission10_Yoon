﻿using System;
using System.Collections.Generic;

namespace Mission10_Yoon.Models;

public partial class Team
{
    public int TeamId { get; set; }

    public string TeamName { get; set; } = null!;

    public int? CaptainId { get; set; }

    public virtual ICollection<Bowler> Bowlers { get; set; } = new List<Bowler>();
}
