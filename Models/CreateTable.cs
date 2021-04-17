using System;
using System.Collections.Generic;

namespace RMS.Models
{
    public class CreateTable
    {
        
        public string tableName { get; set; }
        public List<string> columnName { get; set; }
        public List<string> columnType { get; set; }
        
    }
}
