using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDesign;

public class Product
{
    public required string Name { get; init; }
    public required int Quantity { get; init; }
    public required decimal Price { get; init; }

    public decimal TotalPrice => Price * Quantity;
    

    // Todo#1: create computed property "TotalPrice" as decimal
    public override string ToString()
    {
        return $"Name={Name},Price={Price},Quantity={Quantity}, Total={TotalPrice}";
    }
    // Todo#2: override ToString() method
}