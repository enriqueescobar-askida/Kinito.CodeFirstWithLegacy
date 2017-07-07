// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.7
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleNorthwind
{

    // Shippers
    [Table("Shippers", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class Shipper
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ShipperID", Order = 1, TypeName = "int")]
        [Index(@"PK_Shippers", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Shipper ID")]
        public int ShipperId { get; set; } // ShipperID (Primary key)

        [Column(@"CompanyName", Order = 2, TypeName = "nvarchar")]
        [Required]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Company name")]
        public string CompanyName { get; set; } // CompanyName (length: 40)

        [Column(@"Phone", Order = 3, TypeName = "nvarchar")]
        [MaxLength(24)]
        [StringLength(24)]
        [Phone]
        [Display(Name = "Phone")]
        public string Phone { get; set; } // Phone (length: 24)

        // Reverse navigation

        /// <summary>
        /// Child Orders where [Orders].[ShipVia] point to this entity (FK_Orders_Shippers)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Order> Orders { get; set; } // Orders.FK_Orders_Shippers

        public Shipper()
        {
            Orders = new System.Collections.Generic.List<Order>();
        }
    }

}
// </auto-generated>