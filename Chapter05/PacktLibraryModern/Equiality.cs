using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.Shared;

public class AnimalClass
{
    public string? Name { get; set; }
}

public record AnimalRecord
{
    public string? Name { get; set; }
}