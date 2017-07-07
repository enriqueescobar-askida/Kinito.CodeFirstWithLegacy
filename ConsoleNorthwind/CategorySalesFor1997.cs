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

    // Category Sales for 1997
    [Table("Category Sales for 1997", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class CategorySalesFor1997
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"CategoryName", Order = 1, TypeName = "nvarchar")]
        [Required]
        [MaxLength(15)]
        [StringLength(15)]
        [Key]
        [Display(Name = "Category name")]
        public string CategoryName { get; set; } // CategoryName (Primary key) (length: 15)

        [Column(@"CategorySales", Order = 2, TypeName = "money")]
        [Display(Name = "Category sales")]
        public decimal? CategorySales { get; set; } // CategorySales
    }

}
// </auto-generated>