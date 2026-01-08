using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2hmwrk.Models;

internal class School
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Address   { get; set; }
    public int StudetsCount { get; set; }
    public int TeachersCount { get; set; }
    public string DirectorName  { get; set; }

}
