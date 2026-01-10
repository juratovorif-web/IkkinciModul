namespace Trening1;

internal class Phone
{
    public int Id { get; set; } 
    public string Name { get; set; }
    public double Price { get; set; }

    public override string ToString()
    {
        return $"Id : {Id}, Name : {Name}, Price {Price}";
    }

   
}
