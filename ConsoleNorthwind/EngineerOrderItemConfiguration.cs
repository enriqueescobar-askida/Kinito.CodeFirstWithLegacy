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


namespace ConsoleNorthwind
{
    using Entities;
    using Interfaces;

    // engineer_order_item
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class EngineerOrderItemConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EngineerOrderItem>
    {
        public EngineerOrderItemConfiguration()
            : this("dbo")
        {
        }

        public EngineerOrderItemConfiguration(string schema)
        {
            Property(x => x.EngineerOrderId).IsOptional();
            Property(x => x.Sku).IsUnicode(false);

        }
    }

}
// </auto-generated>
