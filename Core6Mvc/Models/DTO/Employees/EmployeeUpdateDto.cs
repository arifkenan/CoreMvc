using System.ComponentModel.DataAnnotations;

namespace Core6Mvc.Models.DTO.Employees
{
    public class EmployeeUpdateDto
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "soyad Alani boş geçilemez")]
        [StringLength(maximumLength: 50, ErrorMessage = "soyad alani 50 karakterden büyük olamaz")]
        [MinLength(2, ErrorMessage = "soyad alani 2 karakterden az olamaz")]
        public string LastName { get; set; } = null!;
        [Required(ErrorMessage = "Ad Alani boş geçilemez")]
        [StringLength(maximumLength: 50, ErrorMessage = "Ad alani 50 karakterden büyük olamaz")]
        [MinLength(2, ErrorMessage = "Ad alani 2 karakterden az olamaz")]
        public string FirstName { get; set; } = null!;
        public string? Title { get; set; }
        public string? TitleOfCourtesy { get; set; }
        [Required(ErrorMessage = "doğum tarihi boş geçilemez")]
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? HomePhone { get; set; }
        public string? Extension { get; set; }
        public byte[]? Photo { get; set; }
        public string? Notes { get; set; }
        public int? ReportsTo { get; set; }
        public string? PhotoPath { get; set; }
    }
}
