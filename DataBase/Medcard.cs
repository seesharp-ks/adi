//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vet.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Medcard
    {
        public int IDMedcard { get; set; }
        public int IDPatient { get; set; }
        public string CurrentState { get; set; }
        public string History { get; set; }
    
        public virtual Patient Patient { get; set; }
    }
}
