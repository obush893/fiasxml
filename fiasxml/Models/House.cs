//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fiasxml.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    public partial class House
    {
        public string POSTALCODE { get; set; }
        public string IFNSFL { get; set; }
        public string TERRIFNSFL { get; set; }
        public string IFNSUL { get; set; }
        public string TERRIFNSUL { get; set; }
        public string OKATO { get; set; }
        public string OKTMO { get; set; }
        public Nullable<System.DateTime> UPDATEDATE { get; set; }
        public string HOUSENUM { get; set; }
        public int ESTSTATUS { get; set; }
        public string BUILDNUM { get; set; }
        public string STRUCNUM { get; set; }
        public Nullable<int> STRSTATUS { get; set; }
        public System.Guid HOUSEID { get; set; }
        public System.Guid HOUSEGUID { get; set; }
        public Nullable<System.Guid> AOGUID { get; set; }
        public System.DateTime STARTDATE { get; set; }
        public System.DateTime ENDDATE { get; set; }
        public Nullable<int> STATSTATUS { get; set; }
        public Nullable<System.Guid> NORMDOC { get; set; }
        public Nullable<int> COUNTER { get; set; }
        public string CADNUM { get; set; }
        public Nullable<int> DIVTYPE { get; set; }

        public static explicit operator House(DataTable v)
        {
            throw new NotImplementedException();
        }
    }
}