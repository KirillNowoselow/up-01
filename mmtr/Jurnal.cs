//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mmtr
{
    using System;
    using System.Collections.Generic;
    
    public partial class Jurnal
    {
        public int ID { get; set; }
        public int Group { get; set; }
        public int Teacher { get; set; }
        public int Discipline { get; set; }
    
        public virtual Discipline Discipline1 { get; set; }
        public virtual Group Group1 { get; set; }
        public virtual User User { get; set; }
    }
}