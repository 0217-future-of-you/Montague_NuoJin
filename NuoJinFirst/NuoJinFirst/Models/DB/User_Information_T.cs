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
    
    public partial class User_Information_T
    {
        public User_Information_T()
        {
            this.News_T = new HashSet<News_T>();
        }
    
        public int User_ID { get; set; }
        public string User_Bieming { get; set; }
        public string User_Name { get; set; }
        public string User_PassWord { get; set; }
        public string User_Phone { get; set; }
        public string User_Image { get; set; }
        public string User_Address { get; set; }
        public string User_Number { get; set; }
        public Nullable<int> User_TyID { get; set; }
        public Nullable<int> User_Certification { get; set; }
        public Nullable<int> User_Vip_ID { get; set; }
    
        public virtual ICollection<News_T> News_T { get; set; }
        public virtual User_Type_T User_Type_T { get; set; }
        public virtual User_Vip_T User_Vip_T { get; set; }
    }
}