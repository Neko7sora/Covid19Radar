﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19Radar.Services
{
    public interface INotificationService
    {
        DateTime LastNotificationTime { get; }
    }
}
