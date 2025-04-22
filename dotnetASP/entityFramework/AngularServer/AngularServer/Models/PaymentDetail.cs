using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace AngularServer.Models
{
    // This class represents the payment details of a user.
    //build into migration file with the command: Add-Migration "MigrationName"
    //update database with the command: Update-Database
    public class PaymentDetail
    {
        [Key]
        public int PaymentDetailId { get; set; }
        
        [Column(TypeName = "nvarchar(100)")]
        public string? CardOwnerName { get; set; }
        
        [Column(TypeName = "nvarchar(16)")]
        public string? CardNumber { get; set; }
        
        [Column(TypeName = "nvarchar(5)")]
        public string? ExpirationDate { get; set; }
        
        [Column(TypeName = "nvarchar(3)")]
        public string? SecurityCode { get; set; }

    }


}
