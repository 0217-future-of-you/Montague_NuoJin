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
    
    public partial class wenzhang_T
    {
        public long wenzhang_ID { get; set; }
        public string wenzhang_title { get; set; }
        public string wenzhang_Content { get; set; }
        public string wenzhang_image { get; set; }
        public Nullable<System.DateTime> wenzhang_time { get; set; }
        public Nullable<System.DateTime> wenzhang_backtime { get; set; }
        public Nullable<int> wenzhang_isor { get; set; }
        public Nullable<int> wenzhang_number { get; set; }
        public Nullable<long> User_ID { get; set; }
        public string wenzhang_Describe { get; set; }
    
        public virtual User_Information_T User_Information_T { get; set; }
    }
}