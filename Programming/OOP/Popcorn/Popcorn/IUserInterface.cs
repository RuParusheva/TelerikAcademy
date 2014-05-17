﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Popcorn
{
    public interface IUserInterface
    {
        event EventHandler OnLeftPressed;

        event EventHandler OnRightPressed;

        event EventHandler OnActionPressed;

        void ProcessInput();
    }
}
