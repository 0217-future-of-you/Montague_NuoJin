//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuoJinFirst.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shop_T
    {
        public Shop_T()
        {
            this.Shop_Information_T = new HashSet<Shop_Information_T>();
        }
    
        public int Shop_Id { get; set; }
        public string ShopName { get; set; }
    
        public virtual ICollection<Shop_Information_T> Shop_Information_T { get; set; }
    }
}
