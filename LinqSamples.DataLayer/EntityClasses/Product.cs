using System.Text;

namespace LinqSamples.DataLayer.EntityClasses
{
    public partial class Product
    {
        public required int ProductID { get; set; }
        public required string Name { get; set; }
        public required string Color { get; set; }
        public required decimal StandardCost { get; set; }
        public required decimal ListPrice { get; set; }
        public string? Size { get; set; }

        // Calculated Properties
        public int? NameLength { get; set; }
        public decimal? TotalSales { get; set; }

        #region ToString Override 
        public override string ToString()
        {
            StringBuilder sb = new(1024);

            sb.AppendLine($"{Name}   ");
            sb.AppendLine($"ID: {ProductID}   ");
            sb.AppendLine($"Color: {Color}   ");
            sb.AppendLine($"Size: {Size ?? "n/a"}   ");
            sb.AppendLine($"Cost: {StandardCost:c}   ");
            sb.AppendLine($"Price: {ListPrice:c}");
            if (NameLength.HasValue)
            {
                sb.AppendLine($"   Name Length: {NameLength}");
            }
            if (TotalSales.HasValue)
            {
                sb.AppendLine($"   Total Sales: {TotalSales:c}");
            }
            return sb.ToString();
        }
        #endregion
    }
}
