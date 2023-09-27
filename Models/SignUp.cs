namespace stunt.Models;

public class SignUp
{
	public string Name { get; set; }
	public string Surname { get; set; }
	public string Email { get; set; }
	public string CPF { get; set; }  // Brazilian Social Security Number
	public string Password { get; set; }
	public string ConfirmPassword { get; set; }
	public string CellphoneNumber { get; set; }
	public string Address { get; set; }
	public bool ResideInNovaTrento { get; set; }
	public bool WishCardDelivery { get; set; }
}