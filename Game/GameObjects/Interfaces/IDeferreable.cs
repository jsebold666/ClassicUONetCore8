﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassicUO.Game.GameObjects.Interfaces
{
    public interface IDeferreable
    {
        DeferredEntity DeferredObject { get; set; }
    }
}
