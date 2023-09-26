using System;

namespace DB_Autoparts_NVA.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class UserMagnat
    {
        public int Id { get; set; }
      
        public string Surname { get; set; }
       
        public string Name { get; set; }
        public string Gender { get; set; }
      
        public decimal Summa { get; set; }
    }
    public class ProductCount
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }
        public int Counts { get; set; }
        public int CountsAll { get; set; }
        
    }
}
