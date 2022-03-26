using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.Machines = new HashSet<EngineerMachine>();
      
    }
    public int EngineerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get { return this.LastName + ", " + this.FirstName; } }
    public ICollection<EngineerMachine> Machines { get; }
  }
}