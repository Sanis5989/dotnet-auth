using System.ComponentModel.DataAnnotations;


namespace User.Managament.API.Models.Authentication.SignUp;

public class RegisterUser {

    [Required(ErrorMessage = "User Name is required.")]
    public String? UserName {get; set;}

    [Required(ErrorMessage = "Email is also Required.")]
    public String? Email {get; set;}

    [Required(ErrorMessage = "Password is requied.")]
    public String? Password {get; set;}

}