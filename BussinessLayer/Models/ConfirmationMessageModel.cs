﻿using System;

namespace BussinessLayer.Models
{
    public class ConfirmationMessageModel
    {
        public Guid UserId { get; set; }
        public string ConfirmationMessage { get; set; }
    }
}
