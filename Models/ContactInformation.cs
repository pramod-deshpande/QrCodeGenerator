using System.ComponentModel.DataAnnotations;

namespace QrCodeGenerator.Models;

public class ContactInformation
{
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    public string? NickName { get; set; }
    public string? Organization { get; set; }
    public string? OrgTitle { get; set; }
    [Phone]
    public string? Phone { get; set; }
    [Phone]
    public string? MobilePhone { get; set; }
    [Phone]
    public string? WorkPhone { get; set; }
    [EmailAddress]
    public string? Email { get; set; }
    public string? Website { get; set; }
    public string? Street { get; set; }
    public string? HouseNumber { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Zipcode { get; set; }
    public string? Country { get; set; }

}
