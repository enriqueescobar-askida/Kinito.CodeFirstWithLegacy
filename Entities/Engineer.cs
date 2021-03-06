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

    // engineer
    [Table("engineer", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class Engineer /* Column Count = 4 */
    {
        // Number of columns for table engineer = 4
        public static int ColumnCount = 4;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"engineer_id", Order = 1, TypeName = "int")]
        [Index(@"PK__engineer__6CB60D30E26872D6", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Engineer ID")]
        public int EngineerId { get; set; } // engineer_id (Primary key)

        [Column(@"added", Order = 2, TypeName = "datetime")]
        [Required]
        [Display(Name = "Added")]
        public System.DateTime Added { get; set; } // added

        [Column(@"forename", Order = 3, TypeName = "varchar")]
        [Required]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Forename")]
        public string Forename { get; set; } // forename (length: 100)

        [Column(@"surname", Order = 4, TypeName = "varchar")]
        [Required]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Surname")]
        public string Surname { get; set; } // surname (length: 100)

        // Reverse navigation

        /// <summary>
        /// Child EngineerOrders where [engineer_order].[engineer_id] point to this entity (EO_FK)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<EngineerOrder> EngineerOrders { get; set; } // engineer_order.EO_FK

        public Engineer()
        {
            Added = System.DateTime.Now;
            EngineerOrders = new System.Collections.Generic.List<EngineerOrder>();
        }
    }

}
// </auto-generated>
