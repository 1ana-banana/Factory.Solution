using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<MachineEngineer>();
    }

    public int EngineerId { get; set; }
    public string EngineerName { get; set; }
    public string EngineerStatus { get; set; }
    public virtual ICollection<MachineEngineer> JoinEntities { get; set; }
  }
}