namespace stunt.Models;

public enum RequestStatus
{
	Incoming,
	Processing,
	Processed
}

public class Request
{
	public int Id { get; set; }
	public string Name { get; set; }  // Name of the requester
	public RequestStatus Status { get; set; }
	public string ImageUrl { get; set; }
	public string University { get; set; }
	public string CityOfDestination { get; set; }
	// ... Other properties ...
}