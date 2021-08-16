﻿using Microsoft.WindowsAzure.Storage.Table;
using System;

namespace TodoSanty.Functions.Entities
{
    public class TodoEntity : TableEntity
    {
        public DateTime CreatedTime { get; set; }
        public string TaskDescription { get; set; }
        public bool IsCompleted { get; set; }
    }
}
