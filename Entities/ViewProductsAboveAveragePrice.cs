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

namespace Entities
{

    // Products Above Average Price
    [Table("Products Above Average Price", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class ViewProductsAboveAveragePrice /* Column Count = 2 */
    {
        // Number of columns for table ViewProducts Above Average Price = 2
        public static int ColumnCount = 2;

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"ProductName", Order = 1, TypeName = "nvarchar")]
        [Required]
        [MaxLength(40)]
        [StringLength(40)]
        [Key]
        [Display(Name = "Product name")]
        public string ProductName { get; set; } // ProductName (Primary key) (length: 40)

        [Column(@"UnitPrice", Order = 2, TypeName = "money")]
        [Display(Name = "Unit price")]
        public decimal? UnitPrice { get; set; } // UnitPrice
    }

}
// </auto-generated>
