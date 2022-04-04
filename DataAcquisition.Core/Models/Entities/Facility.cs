namespace DataAcquisition.Core.Models.Entities;

public class Facility
{
    public int FacilityId { get; set; }
    public string FacilityName { get; set; }
    public string Address { get; set; }
    public int Employees { get; set; }
    public string CompanyName { get; set; }
    public virtual Company Company { get; set; }
    public virtual ICollection<Workstation> WorkStations { get; set; }
}