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

    // Orders
    [Table("Orders", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class Order /* Column Count = 14 */
    {
        // Number of columns for table Order = 14
        public static int ColumnCount = 14;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"OrderID", Order = 1, TypeName = "int")]
        [Index(@"PK_Orders", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Order ID")]
        public int OrderId { get; set; } // OrderID (Primary key)

        [Column(@"CustomerID", Order = 2, TypeName = "nchar")]
        [Index(@"CustomerID", 1, IsUnique = false, IsClustered = false)]
        [Index(@"CustomersOrders", 1, IsUnique = false, IsClustered = false)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Customer ID")]
        public string CustomerId { get; set; } // CustomerID (length: 5)

        [Column(@"EmployeeID", Order = 3, TypeName = "int")]
        [Index(@"EmployeeID", 1, IsUnique = false, IsClustered = false)]
        [Index(@"EmployeesOrders", 1, IsUnique = false, IsClustered = false)]
        [Display(Name = "Employee ID")]
        public int? EmployeeId { get; set; } // EmployeeID

        [Column(@"OrderDate", Order = 4, TypeName = "datetime")]
        [Index(@"OrderDate", 1, IsUnique = false, IsClustered = false)]
        [Display(Name = "Order date")]
        public System.DateTime? OrderDate { get; set; } // OrderDate

        [Column(@"RequiredDate", Order = 5, TypeName = "datetime")]
        [Display(Name = "Required date")]
        public System.DateTime? RequiredDate { get; set; } // RequiredDate

        [Column(@"ShippedDate", Order = 6, TypeName = "datetime")]
        [Index(@"ShippedDate", 1, IsUnique = false, IsClustered = false)]
        [Display(Name = "Shipped date")]
        public System.DateTime? ShippedDate { get; set; } // ShippedDate

        [Column(@"ShipVia", Order = 7, TypeName = "int")]
        [Index(@"ShippersOrders", 1, IsUnique = false, IsClustered = false)]
        [Display(Name = "Ship via")]
        public int? ShipVia { get; set; } // ShipVia

        [Column(@"Freight", Order = 8, TypeName = "money")]
        [Display(Name = "Freight")]
        public decimal? Freight { get; set; } // Freight

        [Column(@"ShipName", Order = 9, TypeName = "nvarchar")]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Ship name")]
        public string ShipName { get; set; } // ShipName (length: 40)

        [Column(@"ShipAddress", Order = 10, TypeName = "nvarchar")]
        [MaxLength(60)]
        [StringLength(60)]
        [Display(Name = "Ship address")]
        public string ShipAddress { get; set; } // ShipAddress (length: 60)

        [Column(@"ShipCity", Order = 11, TypeName = "nvarchar")]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Ship city")]
        public string ShipCity { get; set; } // ShipCity (length: 15)

        [Column(@"ShipRegion", Order = 12, TypeName = "nvarchar")]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Ship region")]
        public string ShipRegion { get; set; } // ShipRegion (length: 15)

        [Column(@"ShipPostalCode", Order = 13, TypeName = "nvarchar")]
        [Index(@"ShipPostalCode", 1, IsUnique = false, IsClustered = false)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Ship postal code")]
        public string ShipPostalCode { get; set; } // ShipPostalCode (length: 10)

        [Column(@"ShipCountry", Order = 14, TypeName = "nvarchar")]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Ship country")]
        public string ShipCountry { get; set; } // ShipCountry (length: 15)

        // Reverse navigation

        /// <summary>
        /// Child OrderDetails where [Order Details].[OrderID] point to this entity (FK_Order_Details_Orders)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<OrderDetail> OrderDetails { get; set; } // Order Details.FK_Order_Details_Orders

        // Foreign keys

        /// <summary>
        /// Parent Customer pointed by [Orders].([CustomerId]) (FK_Orders_Customers)
        /// </summary>
        [ForeignKey("CustomerId")] public virtual Customer Customer { get; set; } // FK_Orders_Customers

        /// <summary>
        /// Parent Employee pointed by [Orders].([EmployeeId]) (FK_Orders_Employees)
        /// </summary>
        [ForeignKey("EmployeeId")] public virtual Employee Employee { get; set; } // FK_Orders_Employees

        /// <summary>
        /// Parent Shipper pointed by [Orders].([ShipVia]) (FK_Orders_Shippers)
        /// </summary>
        [ForeignKey("ShipVia")] public virtual Shipper Shipper { get; set; } // FK_Orders_Shippers

        public Order()
        {
            Freight = 0m;
            OrderDetails = new System.Collections.Generic.List<OrderDetail>();
        }
    }

}
// </auto-generated>
