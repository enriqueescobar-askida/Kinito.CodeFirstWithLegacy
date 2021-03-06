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

    // Current Product List
    [Table("Current Product List", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class ViewCurrentProductList /* Column Count = 2 */
    {
        // Number of columns for table ViewCurrent Product List = 2
        public static int ColumnCount = 2;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ProductID", Order = 1, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Product ID")]
        public int ProductId { get; set; } // ProductID (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"ProductName", Order = 2, TypeName = "nvarchar")]
        [Required]
        [MaxLength(40)]
        [StringLength(40)]
        [Key]
        [Display(Name = "Product name")]
        public string ProductName { get; set; } // ProductName (Primary key) (length: 40)
    }

}
// </auto-generated>
