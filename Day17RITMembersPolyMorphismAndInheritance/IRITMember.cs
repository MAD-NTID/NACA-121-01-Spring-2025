// This is the interface for the Base class to implement
public interface IRITMember
{
    public string Name { get; set; }
    public string Role { get; set; }
    public string UID { get; set; }

    public void Work();
}